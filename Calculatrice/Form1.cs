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
            Color foregroundColor = Color.White;

            int buttonWidth = ButtonStyles.GetButtonWidth(clientWidth);

            int positionYLine1 = clientHeight - ((buttonWidth / 2) + 5);

            Button button1 = ButtonStyles.Create("test", buttonWidth, buttonWidth / 2, 5, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(button1);

            Button button2 = ButtonStyles.Create("test", buttonWidth, buttonWidth / 2, 5 + buttonWidth + 5, positionYLine1, backgroundColor, foregroundColor);
            this.Controls.Add(button2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}