using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWindowsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SimpleWindowsApp
{
    public partial class Calculator : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        private double lastOperand = 0;
        private string lastOperator = "";
        private string currentExpression = "";
        private Point lastLocation;
        private bool mouseDown;
        private List<string> historyList = new List<string>();




        public Calculator()
        {
            InitializeComponent();
            this.Panel_Title.MouseDown += new MouseEventHandler(this.Calculator_MouseDown);
            this.Panel_Title.MouseMove += new MouseEventHandler(this.Calculator_MouseMove);
            this.Panel_Title.MouseUp += new MouseEventHandler(this.Calculator_MouseUp);
            panel_ShowHistory.Height = 0;
            panel_Menu1.Width = 0;
            panel_Menu2.Width = 0;
            UpdateHistoryDisplay();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }






        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_ClearHistory_Click(object sender, EventArgs e)
        {
            historyList.Clear();
            listBox_History.Items.Clear();
            UpdateHistoryDisplay();
        }

        private void roundedButton_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "0";
        }

        private void roundedButton_Clear_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "0";
            textBox_Display2.Text = "";
            result = 0;
            operation = "";
        }

        private void roundedButton_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_Display1.Text.Length > 1)
                textBox_Display1.Text = textBox_Display1.Text.Remove(textBox_Display1.Text.Length - 1);
            else
                textBox_Display1.Text = "0";
        }






        private void roundedButton_Num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int maxDigits = 16;

            if (textBox_Display1.Text.Replace(",", "").Length >= maxDigits)
            {
                return;
            }

            if (textBox_Display1.Text == "0" || isOperationPerformed)
            {
                textBox_Display1.Clear();
            }

            if (textBox_Display1.Text == "0" && button.Text != ".")
            {
                textBox_Display1.Clear();
            }

            if (isOperationPerformed)
            {
                textBox_Display1.Text = (button.Text == ".") ? "0." : button.Text;
                isOperationPerformed = false;
            }
            else
            {
                if (textBox_Display1.Text == "0" && button.Text != ".")
                {
                    textBox_Display1.Text = button.Text;
                }
                else
                {
                    textBox_Display1.Text += button.Text;
                }
            }

            if (double.TryParse(textBox_Display1.Text, out double formattedValue))
            {
                if (!textBox_Display1.Text.Contains("."))
                {
                    textBox_Display1.Text = formattedValue.ToString("N0");
                }
            }

            UpdateFontSize();
        }

        private void roundedButton_Decimal_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox_Display1.Text = "0";  // Start fresh with a new number
                isOperationPerformed = false;
            }

            if (!textBox_Display1.Text.Contains("."))
            {
                textBox_Display1.Text += ".";
                isOperationPerformed = false; // Prevents clearing input after decimal is added
            }
        }

        private void roundedButton_PositiveNegative_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox_Display1.Text);
                result = -value;
                textBox_Display1.Text = result.ToString("N0");
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton_Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0 && !isOperationPerformed) // If there's an ongoing operation, compute it first
            {
                roundedButton_Equals_Click(sender, e);
            }

            operation = button.Text;
            result = Convert.ToDouble(textBox_Display1.Text);
            isOperationPerformed = true;

            currentExpression = result + " " + operation;
            textBox_Display2.Text = currentExpression;
        }

        private void roundedButton_Equals_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue;

                if (operation == "")
                {
                    inputValue = lastOperand;
                    operation = lastOperator;
                }
                else
                {
                    inputValue = Convert.ToDouble(textBox_Display1.Text);
                    lastOperand = inputValue;
                }

                if (operation != "")
                {
                    lastOperator = operation;
                }

                if (lastOperator == "")
                {
                    return;
                }

                string expression = result + " " + operation + " " + inputValue;

                switch (operation)
                    {
                        case "+":
                            result += inputValue;
                            break;
                        case "-":
                            result -= inputValue;
                            break;
                        case "×":
                            result *= inputValue;
                            break;
                        case "÷":
                            if (inputValue != 0)
                                result /= inputValue;
                            else
                                throw new DivideByZeroException();
                            break;
                    }

                textBox_Display1.Text = FormatResult(result);
                expression += " =";
                AddToHistory(Convert.ToString(expression), Convert.ToString(result));
                textBox_Display2.Text = expression;
                
                operation = "";
                isOperationPerformed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Display1.Text = "0";
                result = 0; 
            }
        }

        private void roundedButton_Square_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox_Display1.Text);
                textBox_Display1.Text = FormatResult(Math.Pow(value, 2));
                textBox_Display2.Text = $"sqr({value})";
                AddToHistory(Convert.ToString(value), Convert.ToString(result));
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            operation = "";
            isOperationPerformed = true;
        }


        private void roundedButton_SquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox_Display1.Text);
                if (value >= 0)
                {
                    textBox_Display1.Text = FormatResult(Math.Sqrt(value));
                    textBox_Display2.Text = $"√({value})";
                    AddToHistory(Convert.ToString(value), Convert.ToString(result));
                }
                else
                {
                    MessageBox.Show("Cannot calculate square root of a negative number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            operation = "";
            isOperationPerformed = true;
        }


        private void roundedButton_DivBy1_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox_Display1.Text);
                if (value != 0)
                {
                    result = 1 / value;
                    textBox_Display1.Text = FormatResult(1 / value);
                    textBox_Display2.Text = $"1/({value})";
                    AddToHistory(Convert.ToString(value), Convert.ToString(result));
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            operation = "";
            isOperationPerformed = true;
        }

        private void roundedButton_Percent_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox_Display1.Text);
                double temp = (result != 0 && !string.IsNullOrEmpty(operation)) ? (value /= 100) * result: value /= 100;
                textBox_Display2.Text = $"{result} {operation} {value}";
                textBox_Display1.Text = FormatResult(value);
                AddToHistory(Convert.ToString(value), Convert.ToString(result));
                isOperationPerformed = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid percentage operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            panel_ShowHistory.Height = (panel_ShowHistory.Height == 0) ? 300 : 0;

            //panelTargetHeight = 300;
            //if (panel_ShowHistory.Height == 2)
            //{
            //    for (int i = 0; panel_ShowHistory.Height < panelTargetHeight; i++)
            //    {
            //        panel_ShowHistory.Height += 5;
            //    }
            //}
            //else
            //{
            //    for (int i = 0; panel_ShowHistory.Height > 2; i++)
            //    {
            //        panel_ShowHistory.Height -= 5;
            //    }
            //}
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            panel_Menu1.Width = (panel_Menu1.Width == 0) ? 255 : 0;
            panel_Menu2.Width = (panel_Menu2.Width == 0) ? 255 : 0;
            button_Menu.BackColor = (panel_Menu2.Width == 0) ? Color.FromArgb(32, 32, 32) : Color.FromArgb(47, 47, 47);


            button_Menu.BringToFront();
        }






        private void button_Memory_Click(object sender, EventArgs e)
        {

        }

        private void button_MemoryStore_Click(object sender, EventArgs e)
        {

        }

        private void button_MemorySubtract_Click(object sender, EventArgs e)
        {

        }

        private void button_MemoryAdd_Click(object sender, EventArgs e)
        {

        }

        private void button_MemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void button_MemoryClear_Click(object sender, EventArgs e)
        {

        }





        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Calculator_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Calculator_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private string FormatResult(double value)
        {
            if (value % 1 == 0)
                return value.ToString("N0"); // Whole number (e.g., 1,234)
            else
                return value.ToString("N16").TrimEnd('0').TrimEnd('.'); // Show up to 16 decimal places
        }

        private void UpdateFontSize()
        {
            int length = textBox_Display1.Text.Replace(",", "").Length;

            if (length <= 8)
                textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily, 36, FontStyle.Bold);
            else if (length <= 12)
                textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily, 28, FontStyle.Bold);
            else
                textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily, 22, FontStyle.Bold);
        }

        public void AddToHistory(string expression, string result)
        {
            string formattedHistory = $"{expression} {result}";

            if (historyList.Count == 0 || historyList[0] == "There's no history yet")
            {
                historyList.Clear();
            }

            historyList.Insert(0, formattedHistory); 
            UpdateHistoryDisplay();
        }


        private void UpdateHistoryDisplay()
        {
            listBox_History.Items.Clear();

            if (historyList.Count == 0)
            {
                listBox_History.Items.Add("There's no history yet");
                return;
            }

            foreach (string item in historyList)
            {
                listBox_History.Items.Add(item);
            }
        }
    }
}
