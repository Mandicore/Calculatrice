using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private TextBox textDisplay;
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

            //set Location x of button
            int LocationXButton1 = 4;
            int LocationXButton2 = LocationXButton1 + buttonWidth + 4;
            int LocationXButton3 = LocationXButton2 + buttonWidth + 4;
            int LocationXButton4 = LocationXButton3 + buttonWidth + 4;



            // 1st lane
            Button buttonchangepositive = ButtonStyles.Create("+/-", buttonWidth, buttonHeight, LocationXButton1, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(buttonchangepositive);

            Button button0 = ButtonStyles.Create("0", buttonWidth, buttonHeight, LocationXButton2, positionYLine1, backgroundColor, foregroundColor);
            button0.Click += new EventHandler(button0_Click);
            this.Controls.Add(button0);

            Button buttoncomma = ButtonStyles.Create(",", buttonWidth, buttonHeight, LocationXButton3, positionYLine1, backgroundColor, foregroundColor);
            buttoncomma.Click += new EventHandler(buttoncomma_Click);
            this.Controls.Add(buttoncomma);

            Button buttonEqual = ButtonStyles.Create("=", buttonWidth, buttonHeight, LocationXButton4, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(buttonEqual);

            // 2nd lane
            Button button1 = ButtonStyles.Create("1", buttonWidth, buttonHeight, LocationXButton1, positionYLine2, backgroundColor, foregroundColor);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = ButtonStyles.Create("2", buttonWidth, buttonHeight, LocationXButton2, positionYLine2, backgroundColor, foregroundColor);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Button button3 = ButtonStyles.Create("3", buttonWidth, buttonHeight, LocationXButton3, positionYLine2, backgroundColor, foregroundColor);
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            Button buttonMore = ButtonStyles.Create("+", buttonWidth, buttonHeight, LocationXButton4, positionYLine2, backgroundColor, foregroundColor);
            this.Controls.Add(buttonMore);

            //3th lane
            Button button4 = ButtonStyles.Create("4", buttonWidth, buttonHeight, LocationXButton1, positionYLine3, backgroundColor, foregroundColor);
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);

            Button button5 = ButtonStyles.Create("5", buttonWidth, buttonHeight, LocationXButton2, positionYLine3, backgroundColor, foregroundColor);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            Button button6 = ButtonStyles.Create("6", buttonWidth, buttonHeight, LocationXButton3, positionYLine3, backgroundColor, foregroundColor);
            button6.Click += new EventHandler(button6_Click);
            this.Controls.Add(button6);

            Button buttonLess = ButtonStyles.Create("-", buttonWidth, buttonHeight, LocationXButton4, positionYLine3, backgroundColor, foregroundColor);
            this.Controls.Add(buttonLess);

            //4th lane
            Button button7 = ButtonStyles.Create("7", buttonWidth, buttonHeight, LocationXButton1, positionYLine4, backgroundColor, foregroundColor);
            button7.Click += new EventHandler(button7_Click);
            this.Controls.Add(button7);

            Button button8 = ButtonStyles.Create("8", buttonWidth, buttonHeight, LocationXButton2, positionYLine4, backgroundColor, foregroundColor);
            button8.Click += new EventHandler(button8_Click);
            this.Controls.Add(button8);

            Button button9 = ButtonStyles.Create("9", buttonWidth, buttonHeight, LocationXButton3, positionYLine4, backgroundColor, foregroundColor);
            button9.Click += new EventHandler(button9_Click);
            this.Controls.Add(button9);

            Button buttonMultiplication = ButtonStyles.Create("×", buttonWidth, buttonHeight, LocationXButton4, positionYLine4, backgroundColor, foregroundColor);
            this.Controls.Add(buttonMultiplication);

            //5th lane
            Button buttonCE = ButtonStyles.Create("CE", buttonWidth, buttonHeight, LocationXButton1, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonCE);

            Button buttonC = ButtonStyles.Create("C", buttonWidth, buttonHeight, LocationXButton2, positionYLine5, backgroundColor, foregroundColor);
            buttonC.Click += new EventHandler(buttonC_Click);
            this.Controls.Add(buttonC);

            Button buttonPourcent = ButtonStyles.Create("%", buttonWidth, buttonHeight, LocationXButton3, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonPourcent);

            Button buttonDivision = ButtonStyles.Create("÷", buttonWidth, buttonHeight, LocationXButton4, positionYLine5, backgroundColor, foregroundColor);
            this.Controls.Add(buttonDivision);

            //Result display
            textDisplay = ButtonStyles.textDisplay(5, positionYDisplay, clientHeight - 10, 20, backgroundDisplay, foregroundDisplay);
            this.Controls.Add(textDisplay);
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
        private void buttoncomma_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ",";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}