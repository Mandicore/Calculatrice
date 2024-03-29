using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        //actions
        private delegate double FonctionDelegate(string argument1, double argument2);
        FonctionDelegate monDelegate = Calculs.emptyF;
        //Displays init
        private TextBox textDisplay;
        private double calculField = 0;
        private System.Windows.Forms.Label CalculLabel;
        //button init
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonchangepositive;
        private Button buttonComma;
        private Button buttonEqual;
        private Button buttonMore;
        private Button buttonLess;
        private Button buttonMultiplication;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonPourcent;
        private Button buttonDivision;
        //items lists
        private List<Button> buttonList = new List<Button>();

        private List<Button> buttonListX1 = new List<Button>();
        private List<Button> buttonListX2 = new List<Button>();
        private List<Button> buttonListX3 = new List<Button>();
        private List<Button> buttonListX4 = new List<Button>();

        private List<Button> buttonListY1 = new List<Button>();
        private List<Button> buttonListY2 = new List<Button>();
        private List<Button> buttonListY3 = new List<Button>();
        private List<Button> buttonListY4 = new List<Button>();
        private List<Button> buttonListY5 = new List<Button>();

        //screen size
        private int clientWidth = 0;
        private int clientHeight = 0;

        //
        private int positionYLine1 = 0;
        private int positionYLine2 = 0;
        private int positionYLine3 = 0;
        private int positionYLine4 = 0;
        private int positionYLine5 = 0;

        private int buttonWidth = 0;
        private int buttonHeight = 0;

        private int LocationXButton1 = 0;
        private int LocationXButton2 = 0;
        private int LocationXButton3 = 0;
        private int LocationXButton4 = 0;
        public Form1()
        {
            InitializeComponent();

            clientWidth = this.ClientSize.Width;
            clientHeight = this.ClientSize.Height;

            Color backgroundColor = Color.FromArgb(180, 196, 159, 255);
            Color foregroundColor = Color.White;
            Color backgroundDisplay = Color.FromArgb(255, 125, 79, 254);
            Color foregroundDisplay = Color.White;

            buttonWidth = ScreenSize.GetButtonWidth(clientWidth);
            buttonHeight = buttonWidth / 2;

            positionYLine1 = clientHeight - ((buttonWidth / 2) + 4);
            positionYLine2 = positionYLine1 - (buttonHeight + 4);
            positionYLine3 = positionYLine2 - (buttonHeight + 4);
            positionYLine4 = positionYLine3 - (buttonHeight + 4);
            positionYLine5 = positionYLine4 - (buttonHeight + 4);
            int positionYDisplay = 70;
            int positionYLabel = 25;

            //set Location x of button
            LocationXButton1 = 4;
            LocationXButton2 = LocationXButton1 + buttonWidth + 4;
            LocationXButton3 = LocationXButton2 + buttonWidth + 4;
            LocationXButton4 = LocationXButton3 + buttonWidth + 4;

            CalculLabel = ButtonStyles.CalculLabel(LocationXButton1, positionYLabel, clientHeight - 10, 40, backgroundDisplay);

            this.Controls.Add(CalculLabel);
            textDisplay = ButtonStyles.textDisplay(5, positionYDisplay, clientHeight - 10, 20, backgroundDisplay, foregroundDisplay);
            this.Controls.Add(textDisplay);

            // 1st lane
            buttonchangepositive = ButtonStyles.Create("+/-", buttonWidth, buttonHeight, LocationXButton1, positionYLine1, backgroundColor, foregroundColor);
            buttonchangepositive.Click += new EventHandler(buttonchangepositive_Click);
            this.Controls.Add(buttonchangepositive);
            buttonList.Add(buttonchangepositive);
            buttonListY1.Add(buttonchangepositive);
            buttonListX1.Add(buttonchangepositive);

            button0 = ButtonStyles.Create("0", buttonWidth, buttonHeight, LocationXButton2, positionYLine1, backgroundColor, foregroundColor);
            button0.Click += new EventHandler(button0_Click);
            this.Controls.Add(button0);
            buttonList.Add(button0);
            buttonListY1.Add(button0);
            buttonListX2.Add(button0);

            buttonComma = ButtonStyles.Create(",", buttonWidth, buttonHeight, LocationXButton3, positionYLine1, backgroundColor, foregroundColor);
            buttonComma.Click += new EventHandler(buttonComma_Click);
            this.Controls.Add(buttonComma);
            buttonList.Add(buttonComma);
            buttonListY1.Add(buttonComma);
            buttonListX3.Add(buttonComma);

            buttonEqual = ButtonStyles.Create("=", buttonWidth, buttonHeight, LocationXButton4, positionYLine1, backgroundColor, foregroundColor);
            buttonEqual.Click += new EventHandler(buttonEqual_Click);
            this.Controls.Add(buttonEqual);
            buttonList.Add(buttonEqual);
            buttonListY1.Add(buttonEqual);
            buttonListX4.Add(buttonEqual);

            // 2nd lane
            button1 = ButtonStyles.Create("1", buttonWidth, buttonHeight, LocationXButton1, positionYLine2, backgroundColor, foregroundColor);
            button1.Click += button1_Click;
            this.Controls.Add(button1);
            buttonList.Add(button1);
            buttonListY2.Add(button1);
            buttonListX1.Add(button1);

            button2 = ButtonStyles.Create("2", buttonWidth, buttonHeight, LocationXButton2, positionYLine2, backgroundColor, foregroundColor);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);
            buttonList.Add(button2);
            buttonListY2.Add(button2);
            buttonListX2.Add(button2);

            button3 = ButtonStyles.Create("3", buttonWidth, buttonHeight, LocationXButton3, positionYLine2, backgroundColor, foregroundColor);
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);
            buttonList.Add(button3);
            buttonListY2.Add(button3);
            buttonListX3.Add(button3);

            buttonMore = ButtonStyles.Create("+", buttonWidth, buttonHeight, LocationXButton4, positionYLine2, backgroundColor, foregroundColor);
            buttonMore.Click += new EventHandler(buttonMore_Click);
            this.Controls.Add(buttonMore);
            buttonList.Add(buttonMore);
            buttonListY2.Add(buttonMore);
            buttonListX4.Add(buttonMore);

            //3th lane
            button4 = ButtonStyles.Create("4", buttonWidth, buttonHeight, LocationXButton1, positionYLine3, backgroundColor, foregroundColor);
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);
            buttonList.Add(button4);
            buttonListY3.Add(button4);
            buttonListX1.Add(button4);

            button5 = ButtonStyles.Create("5", buttonWidth, buttonHeight, LocationXButton2, positionYLine3, backgroundColor, foregroundColor);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);
            buttonList.Add(button5);
            buttonListY3.Add(button5);
            buttonListX2.Add(button5);

            button6 = ButtonStyles.Create("6", buttonWidth, buttonHeight, LocationXButton3, positionYLine3, backgroundColor, foregroundColor);
            button6.Click += new EventHandler(button6_Click);
            this.Controls.Add(button6);
            buttonList.Add(button6);
            buttonListY3.Add(button6);
            buttonListX3.Add(button6);

            buttonLess = ButtonStyles.Create("-", buttonWidth, buttonHeight, LocationXButton4, positionYLine3, backgroundColor, foregroundColor);
            buttonLess.Click += new EventHandler(buttonLess_Click);
            this.Controls.Add(buttonLess);
            buttonList.Add(buttonLess);
            buttonListY3.Add(buttonLess);
            buttonListX4.Add(buttonLess);

            //4th lane
            button7 = ButtonStyles.Create("7", buttonWidth, buttonHeight, LocationXButton1, positionYLine4, backgroundColor, foregroundColor);
            button7.Click += new EventHandler(button7_Click);
            this.Controls.Add(button7);
            buttonList.Add(button7);
            buttonListY4.Add(button7);
            buttonListX1.Add(button7);

            button8 = ButtonStyles.Create("8", buttonWidth, buttonHeight, LocationXButton2, positionYLine4, backgroundColor, foregroundColor);
            button8.Click += new EventHandler(button8_Click);
            this.Controls.Add(button8);
            buttonList.Add(button8);
            buttonListY4.Add(button8);
            buttonListX2.Add(button8);

            button9 = ButtonStyles.Create("9", buttonWidth, buttonHeight, LocationXButton3, positionYLine4, backgroundColor, foregroundColor);
            button9.Click += new EventHandler(button9_Click);
            this.Controls.Add(button9);
            buttonList.Add(button9);
            buttonListY4.Add(button9);
            buttonListX3.Add(button9);

            buttonMultiplication = ButtonStyles.Create("�", buttonWidth, buttonHeight, LocationXButton4, positionYLine4, backgroundColor, foregroundColor);
            buttonMultiplication.Click += new EventHandler(buttonMultiplication_Click);
            this.Controls.Add(buttonMultiplication);
            buttonList.Add(buttonMultiplication);
            buttonListY4.Add(buttonMultiplication);
            buttonListX4.Add(buttonMultiplication);

            //5th lane
            buttonCE = ButtonStyles.Create("CE", buttonWidth, buttonHeight, LocationXButton1, positionYLine5, backgroundColor, foregroundColor);
            buttonCE.Click += new EventHandler(buttonCE_Click);
            this.Controls.Add(buttonCE);
            buttonList.Add(buttonCE);
            buttonListY5.Add(buttonCE);
            buttonListX1.Add(buttonCE);

            buttonC = ButtonStyles.Create("C", buttonWidth, buttonHeight, LocationXButton2, positionYLine5, backgroundColor, foregroundColor);
            buttonC.Click += new EventHandler(buttonC_Click);
            this.Controls.Add(buttonC);
            buttonList.Add(buttonC);
            buttonListY5.Add(buttonC);
            buttonListX2.Add(buttonC);

            buttonPourcent = ButtonStyles.Create("%", buttonWidth, buttonHeight, LocationXButton3, positionYLine5, backgroundColor, foregroundColor);
            buttonPourcent.Click += new EventHandler(buttonPourcent_Click);
            this.Controls.Add(buttonPourcent);
            buttonList.Add(buttonPourcent);
            buttonListY5.Add(buttonPourcent);
            buttonListX3.Add(buttonPourcent);

            buttonDivision = ButtonStyles.Create("�", buttonWidth, buttonHeight, LocationXButton4, positionYLine5, backgroundColor, foregroundColor);
            buttonDivision.Click += new EventHandler(buttonDivision_Click);
            this.Controls.Add(buttonDivision);
            buttonList.Add(buttonDivision);
            buttonListY5.Add(buttonDivision);
            buttonListX4.Add(buttonDivision);

            //KeyPass
            this.KeyDown += Form1_KeyDown;


        }
        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "0";
            buttonEqual.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "1";
            buttonEqual.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "2";
            buttonEqual.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "3";
            buttonEqual.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "4";
            buttonEqual.Focus();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "5";
            buttonEqual.Focus();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "6";
            buttonEqual.Focus();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "7";
            buttonEqual.Focus();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "8";
            buttonEqual.Focus();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "9";
            buttonEqual.Focus();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            buttonEqual.Focus();
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ",";
            buttonEqual.Focus();
        }
        private void buttonMore_Click(object sender, EventArgs e)
        {
            calculField = monDelegate(textDisplay.Text, calculField);
            monDelegate = Calculs.calculMore;
            CalculLabel.Text = calculField.ToString();
            textDisplay.Text = null;
            buttonEqual.Focus();
        }
        private void buttonLess_Click(object sender, EventArgs e)
        {
            calculField = monDelegate(textDisplay.Text, calculField);
            monDelegate = Calculs.calculLess;
            CalculLabel.Text = calculField.ToString();
            textDisplay.Text = null;
            buttonEqual.Focus();
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculField = monDelegate(textDisplay.Text, calculField);
            monDelegate = Calculs.emptyF;
            CalculLabel.Text = null;
            textDisplay.Text = calculField.ToString();
            buttonEqual.Focus();
        }
        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            calculField = monDelegate(textDisplay.Text, calculField);
            monDelegate = Calculs.Multiplication;
            CalculLabel.Text = calculField.ToString();
            textDisplay.Text = null;
            buttonEqual.Focus();
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            calculField = monDelegate(textDisplay.Text, calculField);
            monDelegate = Calculs.Division;
            CalculLabel.Text = calculField.ToString();
            textDisplay.Text = null;
            buttonEqual.Focus();
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            calculField = 0;
            textDisplay.Text = null;
            CalculLabel.Text = null;
            buttonEqual.Focus();
        }
        private void buttonPourcent_Click(object sender, EventArgs e)
        {
            textDisplay.Text = Calculs.Pourcent(textDisplay.Text).ToString();

        }
        private void buttonchangepositive_Click(object sender, EventArgs e)
        {
            textDisplay.Text = Calculs.numberSign(textDisplay.Text).ToString();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                buttonDivision.Select();
                buttonDivision.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Multiply)
            {
                buttonMultiplication.Select();
                buttonMultiplication.PerformClick();
                e.Handled = true;
            }
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                buttonEqual.Select();
                buttonEqual.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                button0.Select();
                button0.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                button1.Select();
                button1.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                button2.Select();
                button2.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                button3.Select();
                button3.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                button4.Select();
                button4.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                button5.Select();
                button5.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                button6.Select();
                button6.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                button7.Select();
                button7.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                button8.Select();
                button8.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                button9.Select();
                button9.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Decimal)
            {
                buttonComma.Select();
                buttonComma.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Add)
            {
                buttonMore.Select();
                buttonMore.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Back)
            {
                if (textDisplay.Text.Length > 0)
                {
                    textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
                    e.Handled = true;
                }

            }
            if (e.KeyCode == Keys.Subtract)
            {
                buttonLess.Select();
                buttonLess.PerformClick();
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            textDisplay.ReadOnly = true;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}