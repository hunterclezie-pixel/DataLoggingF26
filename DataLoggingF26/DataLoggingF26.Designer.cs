namespace DataLoggingF26
{
    partial class DataLoggingF26
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            ClearButton = new Button();
            DrawButton = new Button();
            ButtonGroupBox = new GroupBox();
            DisplayPictureBox = new PictureBox();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            BottomStatusStrip = new StatusStrip();
            SampleTimer = new System.Windows.Forms.Timer(components);
            ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(200, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(91, 46);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(103, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(91, 46);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(6, 26);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(91, 46);
            DrawButton.TabIndex = 2;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(DrawButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Location = new Point(488, 333);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(300, 84);
            ButtonGroupBox.TabIndex = 3;
            ButtonGroupBox.TabStop = false;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = Color.Black;
            DisplayPictureBox.Location = new Point(12, 31);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(776, 296);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 28);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(46, 24);
            FileTopMenuItem.Text = "File";
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.ImageScalingSize = new Size(20, 20);
            BottomStatusStrip.Location = new Point(0, 428);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Size = new Size(800, 22);
            BottomStatusStrip.TabIndex = 6;
            BottomStatusStrip.Text = "statusStrip1";
            // 
            // SampleTimer
            // 
            SampleTimer.Interval = 250;
            SampleTimer.Tick += SampleTimer_Tick;
            // 
            // DataLoggingF26
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BottomStatusStrip);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "DataLoggingF26";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Logging";
            ButtonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button DrawButton;
        private GroupBox ButtonGroupBox;
        private PictureBox DisplayPictureBox;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private StatusStrip BottomStatusStrip;
        private System.Windows.Forms.Timer SampleTimer;
    }
}
