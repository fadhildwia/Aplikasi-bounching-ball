namespace BouncingBall
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Black;
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(260, 238);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(12, 257);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(75, 23);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "Add Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnexit);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(174, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnreset);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(93, 257);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(75, 23);
            this.btnRect.TabIndex = 4;
            this.btnRect.Text = "Add Rect";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.picCanvas);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bouncing Balls";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRect;
    }
}

