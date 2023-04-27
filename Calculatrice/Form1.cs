using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int clientWidth = this.ClientSize.Width;
            int clientHeight = this.ClientSize.Height;

            Color backgroundColor = Color.FromArgb(180, 196, 159, 255);
            Color foregroundColor = Color.FromArgb(180, 252, 220, 163);

            int buttonWidth = ButtonStyles.GetButtonWidth(clientWidth);
            int buttonHeight = buttonWidth / 2;

            int positionYLine1 = clientHeight - ((buttonWidth / 2) + 4);
            int positionYLine2 = positionYLine1 - (buttonHeight + 4);

            //set Location x of button
            int LocationXButton1 = 4;
            int LocationXButton2 = LocationXButton1 + buttonWidth + 4;
            int LocationXButton3 = LocationXButton2 + buttonWidth + 4;
            int LocationXButton4 = LocationXButton3 + buttonWidth + 4;


            // 1st lane
            Button button1 = ButtonStyles.Create("1", buttonWidth, buttonHeight, LocationXButton1, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(button1);

            Button button2 = ButtonStyles.Create("2", buttonWidth, buttonHeight, LocationXButton2, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(button2);

            Button button3 = ButtonStyles.Create("3", buttonWidth, buttonHeight, LocationXButton3, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(button3);

            Button buttonEqual = ButtonStyles.Create("=", buttonWidth, buttonHeight, LocationXButton4, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(buttonEqual);

            // 2nd lane
            Button button4 = ButtonStyles.Create("4", buttonWidth, buttonHeight, LocationXButton1, positionYLine2, backgroundColor, foregroundColor);
            this.Controls.Add(button4);

            Button button5 = ButtonStyles.Create("5", buttonWidth, buttonHeight, LocationXButton2, positionYLine2, backgroundColor, foregroundColor);
            this.Controls.Add(button5);

            Button button6 = ButtonStyles.Create("6", buttonWidth, buttonHeight, LocationXButton3, positionYLine2, backgroundColor, foregroundColor);
            this.Controls.Add(button6);

            Button buttonMore = ButtonStyles.Create("+", buttonWidth, buttonHeight, LocationXButton4, positionYLine2, backgroundColor, foregroundColor);
            this.Controls.Add(buttonMore);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}