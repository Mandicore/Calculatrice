using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        //Displays init
        private TextBox textDisplay;
        private int calculField = 0;
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

        public Form1()
        {
            InitializeComponent();

            int clientWidth = this.ClientSize.Width;
            int clientHeight = this.ClientSize.Height;

            Color backgroundColor = Color.FromArgb(180, 196, 159, 255);
            Color foregroundColor = Color.White;
            Color backgroundDisplay = Color.FromArgb(255, 125, 79, 254);
            Color foregroundDisplay = Color.White;

            int buttonWidth = ButtonStyles.GetButtonWidth(clientWidth);
            int buttonHeight = buttonWidth / 2;

            int positionYLine1 = clientHeight - ((buttonWidth / 2) + 4);
            int positionYLine2 = positionYLine1 - (buttonHeight + 4);
            int positionYLine3 = positionYLine2 - (buttonHeight + 4);
            int positionYLine4 = positionYLine3 - (buttonHeight + 4);
            int positionYLine5 = positionYLine4 - (buttonHeight + 4);
            int positionYDisplay = 70;
            int positionYLabel = 40;

            //set Location x of button
            int LocationXButton1 = 4;
            int LocationXButton2 = LocationXButton1 + buttonWidth + 4;
            int LocationXButton3 = LocationXButton2 + buttonWidth + 4;
            int LocationXButton4 = LocationXButton3 + buttonWidth + 4;

            Label CalculLabel = ButtonStyles.CalculLabel(LocationXButton1, positionYLabel, clientHeight - 10, 20, backgroundDisplay);
            CalculLabel.Text = calculField.ToString();
            textDisplay = ButtonStyles.textDisplay(5, positionYDisplay, clientHeight - 10, 20, backgroundDisplay, foregroundDisplay);
            this.Controls.Add(textDisplay);

            // 1st lane
            buttonchangepositive = ButtonStyles.Create("+/-", buttonWidth, buttonHeight, LocationXButton1, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(buttonchangepositive);

            button0 = ButtonStyles.Create("0", buttonWidth, buttonHeight, LocationXButton2, positionYLine1, backgroundColor, foregroundColor);
            button0.Click += new EventHandler(button0_Click);
            this.Controls.Add(button0);

            buttonComma = ButtonStyles.Create(",", buttonWidth, buttonHeight, LocationXButton3, positionYLine1, backgroundColor, foregroundColor);
            buttonComma.Click += new EventHandler(buttonComma_Click);
            this.Controls.Add(buttonComma);

            buttonEqual = ButtonStyles.Create("=", buttonWidth, buttonHeight, LocationXButton4, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(buttonEqual);

            // 2nd lane
            button1 = ButtonStyles.Create("1", buttonWidth, buttonHeight, LocationXButton1, positionYLine2, backgroundColor, foregroundColor);
            button1.Click += button1_Click;
            button1.KeyDown += button1_KeyDown;
            this.Controls.Add(button1);

            button2 = ButtonStyles.Create("2", buttonWidth, buttonHeight, LocationXButton2, positionYLine2, backgroundColor, foregroundColor);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            button3 = ButtonStyles.Create("3", buttonWidth, buttonHeight, LocationXButton3, positionYLine2, backgroundColor, foregroundColor);
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            buttonMore = ButtonStyles.Create("+", buttonWidth, buttonHeight, LocationXButton4, positionYLine2, backgroundColor, foregroundColor);
            buttonMore.Click += new EventHandler(buttonMore_Click);
            this.Controls.Add(buttonMore);

            //3th lane
            button4 = ButtonStyles.Create("4", buttonWidth, buttonHeight, LocationXButton1, positionYLine3, backgroundColor, foregroundColor);
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);

            button5 = ButtonStyles.Create("5", buttonWidth, buttonHeight, LocationXButton2, positionYLine3, backgroundColor, foregroundColor);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            button6 = ButtonStyles.Create("6", buttonWidth, buttonHeight, LocationXButton3, positionYLine3, backgroundColor, foregroundColor);
            button6.Click += new EventHandler(button6_Click);
            this.Controls.Add(button6);

            buttonLess = ButtonStyles.Create("-", buttonWidth, buttonHeight, LocationXButton4, positionYLine3, backgroundColor, foregroundColor);
            this.Controls.Add(buttonLess);

            //4th lane
            button7 = ButtonStyles.Create("7", buttonWidth, buttonHeight, LocationXButton1, positionYLine4, backgroundColor, foregroundColor);
            button7.Click += new EventHandler(button7_Click);
            this.Controls.Add(button7);

            button8 = ButtonStyles.Create("8", buttonWidth, buttonHeight, LocationXButton2, positionYLine4, backgroundColor, foregroundColor);
            button8.Click += new EventHandler(button8_Click);
            this.Controls.Add(button8);

            button9 = ButtonStyles.Create("9", buttonWidth, buttonHeight, LocationXButton3, positionYLine4, backgroundColor, foregroundColor);
            button9.Click += new EventHandler(button9_Click);
            this.Controls.Add(button9);

            buttonMultiplication = ButtonStyles.Create("×", buttonWidth, buttonHeight, LocationXButton4, positionYLine4, backgroundColor, foregroundColor);
            this.Controls.Add(buttonMultiplication);

            //5th lane
            buttonCE = ButtonStyles.Create("CE", buttonWidth, buttonHeight, LocationXButton1, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonCE);

            buttonC = ButtonStyles.Create("C", buttonWidth, buttonHeight, LocationXButton2, positionYLine5, backgroundColor, foregroundColor);
            buttonC.Click += new EventHandler(buttonC_Click);
            this.Controls.Add(buttonC);

            buttonPourcent = ButtonStyles.Create("%", buttonWidth, buttonHeight, LocationXButton3, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonPourcent);

            buttonDivision = ButtonStyles.Create("÷", buttonWidth, buttonHeight, LocationXButton4, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonDivision);

            //KeyPass
            this.KeyDown += Form1_KeyDown;

            
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + 9;
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ",";
        }
        private void buttonMore_Click(object sender, EventArgs e)
        {
            calculField = Calculs.calculMore(textDisplay.Text, calculField);
            textDisplay.Text = null;
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}