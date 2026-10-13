namespace DataLoggingF26
{
    public partial class DataLoggingF26 : Form
    {
        public DataLoggingF26()
        {
            InitializeComponent();
        }

        void DrawLine(int x, int y)
        {
            // Constructor for graphics object to draw on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // Constructor for pen
            Pen myPen = new Pen(Color.Green, 3);
            float scaleX = DisplayPictureBox.Width / 100f;
            float scaleY = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(scaleX, -scaleY); // Flip the y-axis and scale the coordinates
            g.TranslateTransform(0, -1023); // Move the origin to the bottom left corner
            g.DrawLine(myPen, 0, 0, x, y);

            // Free up resources
            myPen.Dispose();
            g.Dispose();
        }


        //Event Handlers Below Here ----------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine(90,1000);
        }
    }
}
