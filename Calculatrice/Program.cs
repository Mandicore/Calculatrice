using System.Configuration.Internal;

namespace Calculatrice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public static class ButtonStyles
    {

        public static Button Create(string text, int xSize, int ySize, int xLocation, int yLocation, Color backColor, Color foreColor)
        {
            Button button = new Button();
            button.Text = text;
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.Size = new Size(xSize, ySize);
            button.Location = new Point(xLocation, yLocation);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(120, 255, 156, 182); ;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 255, 156, 182);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 255, 156, 182);
            return button;
        }
        public static int GetButtonWidth(int widthForm)
        {
            int marges = 4;
            int ndButtonByLine = 4;
            int width = widthForm - (marges * 5);
            return width / ndButtonByLine;
        }
        public static TextBox textDisplay(int positionX, int positionY, int sizeX, int SizeY, Color backColor, Color foreColor)
        {
            TextBox textDisplay = new TextBox();
            textDisplay.Location = new System.Drawing.Point(positionX, positionY);
            textDisplay.Size = new System.Drawing.Size(sizeX, SizeY);
            textDisplay.BackColor = backColor;
            textDisplay.ForeColor = foreColor;
            textDisplay.MinimumSize = new Size(sizeX, SizeY);
            textDisplay.Font = new Font("Arial", 30, FontStyle.Bold);
            textDisplay.RightToLeft = RightToLeft.Yes;
            return textDisplay;
        }
        public static Label CalculLabel(int LocationX, int LocationY, int sizeX, int SizeY, Color backColor)
        {
            Label Label = new Label();
            Label.Location = new Point(LocationX, LocationY);
            Label.Size = new Size(sizeX, SizeY);
            Label.BackColor = backColor;
            Label.ForeColor = Color.White;
            Label.Font = new Font("Arial", 18, FontStyle.Regular);
            Label.RightToLeft = RightToLeft.Yes;
            return Label;


        }
    }
    public static class Calculs
    {
        public static double calculMore(string display, double calculField)
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return calculField + doubleDisplay;
        }
        public static double calculLess(string display, double calculField)
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return calculField - doubleDisplay;
        }
        public static double emptyF(string display, double calculField) 
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return doubleDisplay;
        }
        public static double Multiplication(string display, double calculField)
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return calculField * doubleDisplay;
        }
        public static double Division(string display, double calculField)
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return calculField / doubleDisplay;
        }
        public static double Pourcent(string display, double calculField)
        {
            double doubleDisplay = 0;
            try
            {
                doubleDisplay = double.Parse(display);
            }
            catch
            {
                return 0;
            }
            return doubleDisplay / 100;
        }
    }
}