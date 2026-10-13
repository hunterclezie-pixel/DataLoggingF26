namespace DataLoggingF26
{
    public partial class DataLoggingF26 : Form
    {
        public DataLoggingF26()
        {
            InitializeComponent();
        }

        Queue<int> buffer = new Queue<int>();

        int lastX = 0;
        int lastY = 0;

        void DrawLine(int x, int y)
        {
            // Constructor for graphics object to draw on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // Constructor for pen
            Pen myPen = new Pen(Color.Lime, 3);
            float scaleX = DisplayPictureBox.Width / 100f;
            float scaleY = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(scaleX, -scaleY); // Flip the y-axis and scale the coordinates
            g.TranslateTransform(0, -1023); // Move the origin to the bottom left corner
            DrawVerticalLine(x);
            g.DrawLine(myPen, lastX, lastY, x, y);
            lastX = x;
            lastY = y;

            // Free up resources
            myPen.Dispose();
            g.Dispose();
        }

        void DrawVerticalLine(int x)
        {
            // Constructor for graphics object to draw on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();

            // Constructor for brush
            Brush myBrush = new SolidBrush(Color.Black);
            float scaleX = DisplayPictureBox.Width / 100f;
            float scaleY = DisplayPictureBox.Height / 1023f;

            g.ScaleTransform(scaleX, -scaleY); // Flip the y-axis and scale the coordinates
            g.TranslateTransform(0, -1023); // Move the origin to the bottom left corner
            g.FillRectangle(myBrush, x, 0, x, 1023);

            // Free up resources
            myBrush.Dispose();
            g.Dispose();
        }

        void DrawBuffer()
        {
            //DisplayPictureBox.Refresh(); // Clear the PictureBox before drawing new lines (Too slow, causes flickers)
            lastX = 0; // Reset lastX to 0 for the new drawing
            lastY = 0; // Reset lastY to 0 for the new drawing
            for (int point = 0; point < buffer.Count; point++)
            {
                DrawLine(point, buffer.ElementAt(point)); // Increment x for each new data point
            }
        }

        int GetFakeData()
        {
            Random randy = new Random();
            return randy.Next(1024);
        }

        void GetDataSample()
        {
            if (buffer.Count >= 100)
            {
                buffer.Dequeue(); // Remove the oldest data point
            }
            buffer.Enqueue(GetFakeData());
        }

        //Event Handlers Below Here ----------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh(); // Clear the PictureBox
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawLine(90,512);
            if (SampleTimer.Enabled)
            {
                SampleTimer.Enabled = false;
            }
            else
            { 
                SampleTimer.Enabled = true;
            }
        }

        private void SampleTimer_Tick(object sender, EventArgs e)
        {
            GetDataSample();
            DrawBuffer();
        }
    }
}
