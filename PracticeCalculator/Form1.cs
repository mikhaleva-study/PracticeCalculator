using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace PracticeCalculator
{
    public partial class Form1 : Form
    {
        // Используем запятую для дробных чисел.
        private readonly CultureInfo numberCulture =
            CultureInfo.GetCultureInfo("ru-RU");

        private decimal storedValue = 0;
        private string pendingOperation = "";
        private bool startNewNumber = true;

        public Form1()
        {
            InitializeComponent();

            btnSave.Click += SaveResult_Click;
            btnLoad.Click += LoadResult_Click;
            btnFontSize.Click += ChangeFontSize_Click;

            txtDisplay.ReadOnly = true;
            txtDisplay.Text = "0";

            // Все цифровые кнопки используют общий обработчик.
            Button[] digitButtons =
            {
                btn0, btn1, btn2, btn3, btn4,
                btn5, btn6, btn7, btn8, btn9
            };

            foreach (Button button in digitButtons)
            {
                button.Click += Digit_Click;
            }

            btnDecimal.Click += Decimal_Click;
            btnEquals.Click += Equals_Click;
            btnClear.Click += Clear_Click;

            btnAdd.Click += (sender, e) => SelectOperation("+");
            btnSubtract.Click += (sender, e) => SelectOperation("-");
            btnMultiply.Click += (sender, e) => SelectOperation("*");
            btnDivide.Click += (sender, e) => SelectOperation("/");
        }

        // Ввод цифр.
        private void Digit_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            if (startNewNumber)
            {
                txtDisplay.Text = "0";
                startNewNumber = false;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = button.Text;
            }
            else if (txtDisplay.Text.Length < 28)
            {
                txtDisplay.Text += button.Text;
            }
        }

        // Ввод дробной части: вторую запятую добавить нельзя.
        private void Decimal_Click(object? sender, EventArgs e)
        {
            if (startNewNumber)
            {
                txtDisplay.Text = "0";
                startNewNumber = false;
            }

            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }
        }

        // Чтение числа с дисплея с проверкой корректности.
        private bool TryReadDisplay(out decimal value)
        {
            bool valid = decimal.TryParse(
                txtDisplay.Text,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                numberCulture,
                out value);

            if (!valid)
            {
                ShowError("Некорректное или слишком большое число.");
            }

            return valid;
        }

        // Выбор операции и выполнение предыдущей в цепочке.
        private void SelectOperation(string operation)
        {
            if (!TryReadDisplay(out decimal currentValue))
                return;

            if (pendingOperation != "" && !startNewNumber)
            {
                if (!Calculate(currentValue))
                    return;
            }
            else
            {
                storedValue = currentValue;
            }

            pendingOperation = operation;
            startNewNumber = true;
        }

        // Нажатие кнопки "=".
        private void Equals_Click(object? sender, EventArgs e)
        {
            // Ждём второе число, если оно ещё не введено.
            if (pendingOperation == "" || startNewNumber)
                return;

            if (!TryReadDisplay(out decimal currentValue))
                return;

            if (!Calculate(currentValue))
                return;

            pendingOperation = "";
            startNewNumber = true;
        }

        // Выполнение арифметической операции.
        private bool Calculate(decimal secondValue)
        {
            try
            {
                decimal result;

                switch (pendingOperation)
                {
                    case "+":
                        result = storedValue + secondValue;
                        break;

                    case "-":
                        result = storedValue - secondValue;
                        break;

                    case "*":
                        result = storedValue * secondValue;
                        break;

                    case "/":
                        if (secondValue == 0)
                        {
                            ShowError("Делить на ноль нельзя.");
                            return false;
                        }

                        result = storedValue / secondValue;
                        break;

                    default:
                        return false;
                }

                storedValue = result;

                // Убираем лишние нули после запятой.
                txtDisplay.Text = result.ToString(
                    "0.############################",
                    numberCulture);

                return true;
            }
            catch (OverflowException)
            {
                ShowError("Результат слишком большой для вычисления.");
                return false;
            }
        }

        // Полная очистка калькулятора.
        private void Clear_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void ResetCalculator()
        {
            storedValue = 0;
            pendingOperation = "";
            startNewNumber = true;
            txtDisplay.Text = "0";
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                this,
                message,
                "Ошибка вычисления",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            ResetCalculator();
        }

        // Сохранены, поскольку на них может ссылаться конструктор.

        // Сохранение текущего числа в текстовый файл.
        private void SaveResult_Click(object? sender, EventArgs e)
        {
            if (!TryReadDisplay(out decimal value))
                return;

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Сохранить результат",
                Filter = "Текстовые файлы (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true,
                FileName = "result.txt",
                OverwritePrompt = true
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                File.WriteAllText(
                    dialog.FileName,
                    value.ToString(numberCulture));

                MessageBox.Show(
                    this,
                    "Результат сохранён.",
                    "Сохранение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex) when (
                ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show(
                    this,
                    "Не удалось сохранить файл.\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Загрузка числа из ранее сохранённого файла.
        private void LoadResult_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Загрузить результат",
                Filter = "Текстовые файлы (*.txt)|*.txt",
                CheckFileExists = true,
                Multiselect = false
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string text = File.ReadAllText(dialog.FileName).Trim();

                bool valid = decimal.TryParse(
                    text,
                    NumberStyles.AllowLeadingSign |
                    NumberStyles.AllowDecimalPoint,
                    numberCulture,
                    out decimal value);

                if (!valid)
                {
                    MessageBox.Show(
                        this,
                        "В файле должно быть одно число, например 12,5.",
                        "Некорректный файл",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Загруженное число можно использовать в новых вычислениях.
                storedValue = value;
                pendingOperation = "";
                startNewNumber = true;

                txtDisplay.Text = value.ToString(
                    "0.############################",
                    numberCulture);
            }
            catch (Exception ex) when (
                ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show(
                    this,
                    "Не удалось открыть файл.\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Переключение размера цифр: 16 → 20 → 24 → 16.
        private void ChangeFontSize_Click(object? sender, EventArgs e)
        {
            float currentSize = txtDisplay.Font.SizeInPoints;

            float newSize = currentSize < 20f
                ? 20f
                : currentSize < 24f
                    ? 24f
                    : 16f;

            txtDisplay.Font = new Font(
                txtDisplay.Font.FontFamily,
                newSize,
                txtDisplay.Font.Style,
                GraphicsUnit.Point);

            btnFontSize.Text = $"Размер шрифта: {newSize:0}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btnFontSize_Click(object sender, EventArgs e)
        {

        }
    }
}