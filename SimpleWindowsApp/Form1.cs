using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWindowsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SimpleWindowsApp
{
    public partial class Calculator : Form
    {
        private int openParenthesesCount = 0;
        private bool mouseDown;
        private bool isDisabled = false;
        private bool isOperationPerformed = false;
        private bool isScientificNotation = false;
        private double result = 0;
        private double lastOperand = 0;
        private string operation = "";
        private string lastOperator = "";
        private string currentExpression = "";
        private Point lastLocation;
        private List<string> historyList = new List<string>();




        public Calculator()
        {
            InitializeComponent();
            this.Panel_Title.MouseDown += new MouseEventHandler(this.Calculator_MouseDown);
            this.Panel_Title.MouseMove += new MouseEventHandler(this.Calculator_MouseMove);
            this.Panel_Title.MouseUp += new MouseEventHandler(this.Calculator_MouseUp);
            panel_CalStandard.Height = 340;     panel_CalStandard.Visible = true;
            panel_CalSci.Height = 0;            panel_CalSci.Visible = false;
            panel_ShowHistory.Height = 0;       panel_ShowHistory.Visible = false;
            roundedPanel_Trigo.Height = 0;      roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Functions.Height = 0;  roundedPanel_Functions.Visible = false;
            roundedPanel_Functions.Width = 0;
            panel_Menu1.Width = 0;
            panel_Menu2.Width = 0;
            textBox_Display1.Text = "0";
            EnableButtons(this);
            UpdateFontSize();
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
            if (isDisabled)
            {
                roundedButton_Clear_Click(sender, e);
                return;
            }

            textBox_Display1.Text = "0";
            EnableButtons(this);
            UpdateFontSize();
            UpdateParenthesisButton();
        }

        private void roundedButton_Clear_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "0";
            textBox_Display2.Text = "";
            result = 0;
            operation = "";
            EnableButtons(this);
            UpdateFontSize();
            UpdateParenthesisButton();
        }

        private void roundedButton_Delete_Click(object sender, EventArgs e)
        {
            if (isDisabled)
            {
                roundedButton_Clear_Click(sender, e);
                return;
            }

            if (textBox_Display1.Text.Length > 1)
                textBox_Display1.Text = textBox_Display1.Text.Remove(textBox_Display1.Text.Length - 1);
            else
                textBox_Display1.Text = "0";
            EnableButtons(this);
            UpdateFontSize();
            UpdateParenthesisButton();
        }






        private void roundedButton_Num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int maxDigits = (textBox_CalcType.Text == "Standard") ? 15 : 15;

            // new inputs
            if (textBox_Display1.Text == "0" || isOperationPerformed)
            {
                textBox_Display1.Clear();
            }

            if (textBox_Display1.Text == "0" && button.Text != ".")
            {
                textBox_Display1.Clear();
            }

            // input limit
            if (textBox_Display1.Text.Replace(",", "").Length >= maxDigits)
            {
                return;
            }

            // decimal input
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

            // format for readability
            if (double.TryParse(textBox_Display1.Text, out double formattedValue))
            {
                if (!textBox_Display1.Text.Contains("."))
                {
                    textBox_Display1.Text = formattedValue.ToString("N0");
                }
            }

            roundedButton_ClearCE.Text = (textBox_Display1.Text != "0") ? "CE" : "C";

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
                double input = Convert.ToDouble(textBox_Display1.Text);
                result = -input;
                textBox_Display1.Text = result.ToString("N0");
            }
            catch
            {
                textBox_Display1.Text = "Invalid Input" ;
                DisableButtons(this);
            }
        }

        private void roundedButton_Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0 && !isOperationPerformed) // compute first ongoing operation, 
            {
                roundedButton_Equals_Click(sender, e);
            }

            operation = button.Text;
            if (operation == "x^y")
                operation = "^";
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

                while (openParenthesesCount > 0)
                {
                    textBox_Display2.Text += ")";
                    openParenthesesCount--;
                }

                if (isDisabled)
                {
                    roundedButton_Clear_Click(sender, e);
                    return;
                }

                if (string.IsNullOrEmpty(operation) && string.IsNullOrEmpty(textBox_Display2.Text) && textBox_Display1.Text == "0")
                {
                    textBox_Display1.Text = "0";
                    textBox_Display2.Text = "0 =";
                    return;
                }

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
                        case "mod":
                            if (inputValue == 0)
                            {
                                textBox_Display1.Text = "Error";
                                DisableButtons(this);
                                return;
                            }
                            result = (int)result % (int)inputValue; 
                            operation = "Mod";
                            break;

                        case "x^y":
                            result = Math.Pow(result, inputValue);
                            operation = "^";
                            break;
                        case "exp":
                            result = result * Math.Pow(10, inputValue);
                            operation = "Exp";
                            break;
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
                AddToHistory(Convert.ToString(expression), Convert.ToString(result));
                expression += " =";
                textBox_Display2.Text = expression;
                
                operation = "";
                isOperationPerformed = true;
            }
            catch (Exception)
            {
                CheckOverflow();
                textBox_Display1.Text = "Invalid Input";
                textBox_Display1.Text = "0";
                result = 0;
                DisableButtons(this);
            }
        }

        private void roundedButton_Square_Click(object sender, EventArgs e)
        {

            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                //double result = Math.Pow(input, 2);
                textBox_Display1.Text = FormatResult(Math.Pow(input, 2));
                textBox_Display2.Text = $"sqr( {input} )";
                AddToHistory($"sqr( {input} )", FormatResult(Math.Pow(input, 2)));
            }
            catch
            {
                CheckOverflow();
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
            }

            operation = "";
            isOperationPerformed = false;
        }

        private void roundedButton_SquareRoot_Click(object sender, EventArgs e)
        {

            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                if (input >= 0)
                {
                    //double result = Math.Sqrt(input);
                    textBox_Display1.Text = FormatResult(Math.Sqrt(input));
                    textBox_Display2.Text = $"√( {input} )";
                    AddToHistory($"√( {input} )", FormatResult(Math.Sqrt(input)));
                }
                else
                {
                    textBox_Display2.Text = $"√( {input} )";
                    textBox_Display1.Text = "Invalid Input";
                    DisableButtons(this);
                }
            }
            catch
            {
                CheckOverflow();
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
            }

            operation = "";
            isOperationPerformed = true;
        }

        private void roundedButton_DivBy1_Click(object sender, EventArgs e)
        {

            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                if (input != 0)
                {
                    //double result = 1 / input;
                    textBox_Display1.Text = FormatResult(1 / input);
                    textBox_Display2.Text = $"1/( {input} )";
                    AddToHistory($"1/( {input} )", FormatResult(1 / input));
                }
                else
                {
                    textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily, 20, textBox_Display1.Font.Style);
                    textBox_Display2.Text = $"1/( {input} )";
                    textBox_Display1.Text = "Cannot Divide by Zero";
                    DisableButtons(this);
                }
            }
            catch
            {
                //CheckOverflow();
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
            }

            operation = "";
            isOperationPerformed = true;
        }


        private void roundedButton_Percent_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                double temp = (result != 0 && !string.IsNullOrEmpty(operation)) ? (input /= 100) * result : input /= 100;
                textBox_Display2.Text = (result == 0) ? $"{operation} {input}" : $"{result} {operation} {input}";
                textBox_Display1.Text = FormatResult(input);
                //AddToHistory(Convert.ToString(input), Convert.ToString(result));
                isOperationPerformed = true;
            }
            catch (Exception)
            {
                CheckOverflow();
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
            }
        }










        private void button_History_Click(object sender, EventArgs e)
        {
            panel_ShowHistory.Visible = (panel_ShowHistory.Visible == false) ? true : false;
            panel_CalStandard.Visible = (panel_ShowHistory.Visible == false) ? true : false;
            panel_CalSci.Visible =  (panel_ShowHistory.Visible == false) ? true : false;

            if (textBox_CalcType.Text == "Standard")
            {
                panel_CalStandard.Height = (panel_ShowHistory.Visible == true) ? 0 : 340;
                panel_CalStandard.BringToFront();
            }
            else
            {
                panel_CalSci.Height = (panel_ShowHistory.Visible == true) ? 0 : 360;
                panel_CalSci.BringToFront();
            }

                panel_ShowHistory.Height = (panel_ShowHistory.Height == 0) ? 300 : 0;
                panel_ShowHistory.BringToFront();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            panel_Menu1.Width = (panel_Menu1.Width == 0) ? 255 : 0; panel_Menu1.BringToFront(); panel_Menu1.Visible = true;
            panel_Menu2.Width = (panel_Menu2.Width == 0) ? 255 : 0; panel_Menu2.BringToFront(); panel_Menu2.Visible = true;
            button_Menu.BackColor = (panel_Menu2.Width == 0) ? Color.FromArgb(32, 32, 32) : Color.FromArgb(47, 47, 47);

            if (panel_Menu1.Width == 255 && panel_Menu2.Width == 255)
            {
                panel_CalStandard.SendToBack();     panel_CalStandard.Visible = false;
                panel_CalSci.SendToBack();          panel_CalSci.Visible = false;
                textBox_Display1.Visible = false;   textBox_Display1.SendToBack();
            }
            else
            {
                panel_CalStandard.BringToFront();   panel_CalStandard.Visible = true;
                panel_CalSci.BringToFront();        panel_CalSci.Visible = true;
                textBox_Display1.Visible = true;    textBox_Display1.BringToFront();
            }

                button_Menu.BringToFront();
        }

        private void roundedButton_CalcStandard_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "0";        textBox_Display2.Clear();
            textBox_CalcType.Text = "Standard";
            panel_CalSci.Height = 0;            panel_CalSci.Visible = false;
            panel_CalStandard.Height = 340;     panel_CalStandard.Visible = true;
            panel_Menu1.Width = 0;              panel_Menu2.Width = 0;
            textBox_Display1.BringToFront();    textBox_Display1.Visible = true;

            button_Menu.BackColor = Color.FromArgb(32, 32, 32);

            operation = "";
            result = 0;

            UpdateFontSize();
        }

        private void roundedButton_CalcScientific_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "0";        textBox_Display2.Clear();
            textBox_CalcType.Text = "Scientific";
            roundedButton_ClearCE.Text = "C";
            panel_CalStandard.Height = 0;       panel_CalStandard.Visible = false;
            panel_CalSci.Height = 360;          panel_CalSci.Visible = true; 
            panel_Menu1.Width = 0;              panel_Menu2.Width = 0;
            textBox_Display1.BringToFront();    textBox_Display1.Visible = true;

            button_Menu.BackColor = Color.FromArgb(32, 32, 32);

            operation = "";
            result = 0;

            button_DegRadGrad.BringToFront();
            button_FENotation.BringToFront();
            textBox_Display1.SendToBack();
            UpdateFontSize();
        }










        // SCIENTIFIC FUNCTIONS
        private void roundedButton_ClearCE_Click(object sender, EventArgs e)
        {
            if (textBox_Display1.Text != "0")
            {
                roundedButton_ClearEntry_Click(sender, e);
            }
            else
            {
                roundedButton_Clear_Click(sender, e);
            }
            roundedButton_ClearCE.Text = "C";
            EnableButtons(this);
        }

        private void button_FENotation_Click(object sender, EventArgs e)
        {
            // TODO: WHEN NOTATION IS TOGGLED, IT REFLECTS TO DISPLAY 2 AND RESULT IS ALSO IN THE DESIRED NOTATION 
            //
            //try
            //{
            //    double value = Convert.ToDouble(textBox_Display1.Text);

            //    if (!isScientificNotation)
            //    {
            //        string sciNotation = value.ToString("0.e+0", CultureInfo.InvariantCulture); // Format like "9.e-1"
            //        sciNotation = sciNotation.Replace("+", ""); // Remove unnecessary '+'

            //        textBox_Display1.Text = sciNotation;
            //    }
            //    else
            //    {
            //        textBox_Display1.Text = FormatResult(value); // Convert back to standard
            //    }

            //    isScientificNotation = !isScientificNotation;
            //}
            //catch
            //{
            //    textBox_Display1.Text = "Invalid Input";
            //}
        }


        private void button_DegRadGrad_Click(object sender, EventArgs e)
        {
            //TODO: IMPLEMENT DEGREES, RADIANS, GRADIANS
            button_DegRadGrad.Text = (button_DegRadGrad.Text == "DEG")
                ? "RAD"
                : (button_DegRadGrad.Text == "RAD")
                    ? "GRAD"
                    : "DEG";
        }

        private void roundedButton_log_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBox_Display1.Text);

            if (input <= 0)
            {
                textBox_Display2.Text = $"log( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = Math.Log10(input);
            textBox_Display2.Text = $"log( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Height = 0;
            roundedPanel_Trigo.Width = 0;
        }

        private void roundedButton_ln_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBox_Display1.Text);

            if (input <= 0)
            {
                textBox_Display2.Text = $"ln( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = Math.Log(input);
            textBox_Display2.Text = $"ln( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Height = 0;
            roundedPanel_Trigo.Width = 0;
        }

        private void roundedButton_Pi_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "3.14159265358979";
            isOperationPerformed = true; // Ensures next input replaces π
            roundedButton_ClearCE.Text = "CE";
        }

        private void roundedButton_e_Click(object sender, EventArgs e)
        {
            textBox_Display1.Text = "2.71828182845905";
            isOperationPerformed = true; // Ensures next input replaces e
            roundedButton_ClearCE.Text = "CE";
        }


        private void roundedButton_AbsoluteValue_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                double result = Math.Abs(input);

                textBox_Display1.Text = FormatResult(result);
                textBox_Display2.Text = $"Abs( {input} )";
            }
            catch
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
            }
        }

        private void roundedButton_Factorial_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(textBox_Display1.Text);
                if (input < 0)
                {
                    textBox_Display1.Text = "Invalid Input";
                    DisableButtons(this);
                    return;
                }

                long result = 1;
                for (int i = 2; i <= input; i++)
                    result *= i;

                textBox_Display1.Text = FormatResult(result);
                textBox_Display2.Text = $"fact( {input} )";
            }
            catch
            {
                CheckOverflow();
                DisableButtons(this);
            }

            roundedButton_ClearCE.Text = (textBox_Display1.Text != "0") ? "CE" : "C";
        }

        private void roundedButton_TenRaisedToN_Click(object sender, EventArgs e)
        {
            CheckOverflow();

            try
            {
                double input = Convert.ToDouble(textBox_Display1.Text);
                textBox_Display1.Text = FormatResult(Math.Pow(10, input));
                textBox_Display2.Text = $"10^( {input} )";
            }
            catch
            {
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
            }

            roundedButton_ClearCE.Text = (textBox_Display1.Text != "0") ? "CE" : "C";
        }

        private void roundedButton_ParenthesisOpen_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox_Display1.Clear();
                isOperationPerformed = false;
            }

            textBox_Display2.Text += "( ";
            openParenthesesCount++;

            UpdateParenthesisButton();
        }

        private void roundedButton_ParenthesisClose_Click(object sender, EventArgs e)
        {
            if (openParenthesesCount > 0)
            {
                if ((string.IsNullOrEmpty(textBox_Display1.Text) || textBox_Display2.Text == "0")
                    && (!string.IsNullOrEmpty(textBox_Display2.Text) && textBox_Display2.Text[textBox_Display2.Text.Length - 1] == '('))
                {
                    textBox_Display2.Text += $"0 )";
                }
                else
                {
                    textBox_Display2.Text += $"{textBox_Display1.Text} )";
                }
                    
                openParenthesesCount--;
            }


                UpdateParenthesisButton();
        }




        private void roundedButton_ShowTrigo_Click(object sender, EventArgs e)
        {
            bool isVisible = roundedPanel_Trigo.Visible;

            roundedPanel_Trigo.Visible = !isVisible;
            roundedPanel_Trigo.Height = isVisible ? 0 : 100;
            roundedPanel_Trigo.Width = isVisible ? 0 : 260;

            roundedPanel_Functions.Visible = false;
            roundedPanel_Functions.Height = 0;
            roundedPanel_Functions.Width = 0;

            if (!isVisible)
            {
                roundedPanel_Trigo.BringToFront();
                panel_CalSci.SendToBack();
            }
            else
            {
                roundedPanel_Trigo.SendToBack();
                panel_CalSci.BringToFront();
            }
        }

        private void roundedButton_2nd_2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton_Hyp_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton_Sin_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            double result = Math.Sin(DegreeToRadian(input));

            textBox_Display2.Text = $"sin( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }

        private void roundedButton_Cos_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            double result = Math.Cos(DegreeToRadian(input));

            textBox_Display2.Text = $"cos( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }

        private void roundedButton_Tan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            if (input % 90 == 0 && (input / 90) % 2 != 0)
            {
                textBox_Display2.Text = $"tan( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = Math.Tan(DegreeToRadian(input));
            textBox_Display2.Text = $"tan( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }

        private void roundedButton_Sec_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            if (Math.Cos(DegreeToRadian(input)) == 0)
            {
                textBox_Display2.Text = $"sec( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = 1 / Math.Cos(DegreeToRadian(input));
            textBox_Display2.Text = $"sec( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }

        private void roundedButton_Csc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            if (Math.Sin(DegreeToRadian(input)) == 0)
            {
                textBox_Display2.Text = $"csc( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = 1 / Math.Sin(DegreeToRadian(input));
            textBox_Display2.Text = $"csc( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }

        private void roundedButton_Cot_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_Display1.Text, out double input))
            {
                textBox_Display1.Text = "Error";
                DisableButtons(this);
                return;
            }

            if (Math.Tan(DegreeToRadian(input)) == 0)
            {
                textBox_Display2.Text = $"cot( {input} )";
                textBox_Display1.Text = "Invalid Input";
                DisableButtons(this);
                return;
            }

            double result = 1 / Math.Tan(DegreeToRadian(input));
            textBox_Display2.Text = $"cot( {input} )";
            textBox_Display1.Text = FormatResult(result);

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Width = 0;
            roundedPanel_Trigo.Height = 0;
        }





        private void roundedButton_ShowFunctions_Click(object sender, EventArgs e)
        {
            bool isVisible = roundedPanel_Functions.Visible;

            roundedPanel_Functions.Visible = !isVisible;
            roundedPanel_Functions.Height = isVisible ? 0 : 100;
            roundedPanel_Functions.Width = isVisible ? 0 : 196;

            roundedPanel_Trigo.Visible = false;
            roundedPanel_Trigo.Height = 0;
            roundedPanel_Trigo.Width = 0;

            if (!isVisible)
            {
                roundedPanel_Functions.BringToFront();
                panel_CalSci.SendToBack();
            }
            else
            {
                roundedPanel_Functions.SendToBack();
                panel_CalSci.BringToFront();
            }
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
            if (Math.Abs(value) >= 1e15 || Math.Abs(value) < 1e-6)
            {
                return value.ToString("0.###############e+0"); // Scientific notation with up to 8 decimal places
            }
            else if (value % 1 == 0)
                return value.ToString("N0"); // Whole number (e.g., 1,234)
            else
                return value.ToString("N16").TrimEnd('0').TrimEnd('.'); // Show up to 16 decimal places
        }

        private double DegreeToRadian(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public void AddToHistory(string expression, string result)
        {
            string formattedHistory = $"{expression} = {result}";

            if (historyList.Count == 0 || historyList[0] == "There's no history yet")
            {
                historyList.Clear();
            }

            historyList.Insert(0, formattedHistory);
            UpdateHistoryDisplay();
        }










        private void UpdateFontSize()
        {
            int length = textBox_Display1.Text.Replace(",", "").Length;

            // Standard
            if (panel_CalStandard.Visible && !panel_CalSci.Visible)
            {
                textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily,
                    length <= 9 
                    ? 34 
                    : length <= 10 
                        ? 32 
                        : length <= 11
                            ? 30
                            : length <= 12
                                ? 28
                                : length <= 13
                                    ? 24
                                    : 22
                    , FontStyle.Bold);
            }
            // Scientific
            else if (!panel_CalStandard.Visible && panel_CalSci.Visible)
            {
                textBox_Display1.Font = new Font(textBox_Display1.Font.FontFamily,
                    length <= 18 
                    ? 20 
                    : length <= 19 
                        ? 19 
                        : length <= 20
                            ? 18
                            : length <= 21
                                ? 17
                                : length <= 22
                                    ? 16
                                    : length <= 23
                                        ? 15
                                        : length <= 24
                                            ? 14
                                            : length <= 25
                                                ? 13
                                                : length <= 27
                                                    ? 12
                                                    : length <= 28
                                                        ? 11
                                                        : length <= 30
                                                            ? 10
                                                            : length <= 32
                                                                ? 9
                                                                : 8
                    , FontStyle.Bold);
            }
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

        private void UpdateParenthesisButton()
        {
            roundedButton_ParenthesisOpen.Text = (openParenthesesCount == 0) ? "(" : $"(  {openParenthesesCount}";
        }

        private void CheckOverflow()
        {
            if (textBox_Display2.Text.Length > 25)
            {
                textBox_Display1.Text = "Overflow";
                DisableButtons(this);
            }
        }









        // stored variables for enabling and disabling buttons
        string[] exemptedMenuButtons =
            {
                "roundedButton_Settings",
                "roundedButton_Clear",
                "roundedButton_ClearCE",
                "roundedButton_ClearEntry",
                "roundedButton_2nd_2",              //"roundedButton_2nd",
                "roundedButton_Equals",             "roundedButton_Equals2",
                //"roundedButton_ShowTrigo",        //"roundedButton_ShowFunctions",
                "roundedButton_CalcStandard",       "roundedButton_CalcScientific",
                "roundedButton_Delete",             "roundedButton_Delete2",
                "button_Minimize",                  "button_Maximize",
                "button_ClearHistory",
                "button_History",
                "button_Menu",
                "button_Exit"
            };

        string[] exemptedMemoryButtons =
            {
                "button_DegRadGrad",                "button_FENotation",
                "button_Memory",                    "button_Memory2",
                "button_MemoryStore",               "button_MemoryStore2",
                "button_MemorySubtract",            "button_MemorySubtract2",
                "button_MemoryAdd",                 "button_MemoryAdd2",
                "button_MemoryRecall",              "button_MemoryRecall2",
                "button_MemoryClear",               "button_MemoryClear2",
            };

        string[] exemptedTrigoButtons =
            {
                "roundedButton_2nd_2",              "roundedButton_Hyp",
                "roundedButton_Sin",                "roundedButton_Sec",
                "roundedButton_Cos",                "roundedButton_Csc",
                "roundedButton_Tan",                "roundedButton_Cot",
            };

        string[] exemptedFuncButtons =
            {
                "roundedButton_AbsoluteValue2",     "roundedButton_Random",
                "roundedButton_FloorFunction",      "roundedButton_CeilingFunction",
                "roundedButton_DecToDMS",           "roundedButton_DMSToDec"
            };

        string[] exemptedNumButtons =
            {
                "roundedButton_Num",                "roundedButton_Num_2",
                "roundedButton_Num1",               "roundedButton_Num1_2",
                "roundedButton_Num2",               "roundedButton_Num2_2",
                "roundedButton_Num3",               "roundedButton_Num3_2",
                "roundedButton_Num4",               "roundedButton_Num4_2",
                "roundedButton_Num5",               "roundedButton_Num5_2",
                "roundedButton_Num6",               "roundedButton_Num6_2",
                "roundedButton_Num7",               "roundedButton_Num7_2",
                "roundedButton_Num8",               "roundedButton_Num8_2",
                "roundedButton_Num9",               "roundedButton_Num9_2"
            };

        string[] exemptedButtonWithOwnColors =
            {
                "roundedButton_PositiveNegative",   "roundedButton_PositiveNegative2",
                "roundedButton_Decimal",            "roundedButton_Decimal2",
            };

        private void DisableButtons(Control parent)
        {
            isDisabled = true;
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    if (!exemptedMenuButtons.Contains(button.Name) 
                        && !exemptedNumButtons.Contains(button.Name)
                        && !exemptedFuncButtons.Contains(button.Name)
                        && !exemptedTrigoButtons.Contains(button.Name)
                        && !exemptedMemoryButtons.Contains(button.Name))
                    {
                        button.Enabled = false;

                        if (button.Name != "roundedButton_ShowTrigo" 
                            && button.Name != "roundedButton_ShowFunctions")
                        {
                            button.BackColor = Color.FromArgb(40, 40, 40);
                        }

                        roundedPanel_Functions.Width = (roundedPanel_Functions.Width == 0) ? 196 : 0;
                        roundedPanel_Functions.Height = (roundedPanel_Functions.Height == 0) ? 100 : 0;
                    }
                }
                else if (control is Panel || control is GroupBox)
                {
                    DisableButtons(control); // Recursively disable inside panels
                }
            }
        }

        private void EnableButtons(Control parent)
        {
            isDisabled = false;
            foreach (Control control in parent.Controls) 
            {
                if (control is Button button) 
                {
                    button.Enabled = true;
                    if (!exemptedMenuButtons.Contains(button.Name)
                        && !exemptedNumButtons.Contains(button.Name)
                        && !exemptedFuncButtons.Contains(button.Name)
                        && !exemptedTrigoButtons.Contains(button.Name)
                        && !exemptedMemoryButtons.Contains(button.Name)
                        && button.Name != "roundedButton_ShowTrigo" 
                        && button.Name != "roundedButton_ShowFunctions")
                    {
                        if (exemptedButtonWithOwnColors.Contains(button.Name))
                        {
                            button.BackColor = Color.FromArgb(59, 59, 59);
                        }
                        else
                        { 
                            button.BackColor = Color.FromArgb(50, 50, 50);
                        }
                    }
                }
                else if (control is Panel || control is GroupBox)
                {
                    EnableButtons(control); // Recursively enable inside panels
                }
            }
        }

    }
}
