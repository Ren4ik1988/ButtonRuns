namespace ButtonRuns
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.first_btn = new ButtonCompare();
            this.second_btn = new ButtonCompare();
            this.third_btn = new ButtonCompare();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stop_btn);
            this.panel1.Controls.Add(this.pause_btn);
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 65);
            this.panel1.TabIndex = 0;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(239, 26);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(129, 26);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 1;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(19, 26);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(31, 25);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(75, 23);
            this.first_btn.TabIndex = 1;
            this.first_btn.Text = "button1";
            this.first_btn.UseVisualStyleBackColor = true;
            // 
            // second_btn
            // 
            this.second_btn.Location = new System.Drawing.Point(31, 54);
            this.second_btn.Name = "second_btn";
            this.second_btn.Size = new System.Drawing.Size(75, 23);
            this.second_btn.TabIndex = 1;
            this.second_btn.Text = "button1";
            this.second_btn.UseVisualStyleBackColor = true;
            // 
            // third_btn
            // 
            this.third_btn.Location = new System.Drawing.Point(31, 83);
            this.third_btn.Name = "third_btn";
            this.third_btn.Size = new System.Drawing.Size(75, 23);
            this.third_btn.TabIndex = 1;
            this.third_btn.Text = "button1";
            this.third_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ButtonRuns.Properties.Resources.Finish;
            this.pictureBox1.Location = new System.Drawing.Point(842, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.third_btn);
            this.Controls.Add(this.second_btn);
            this.Controls.Add(this.first_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Гонки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ButtonCompare first_btn;
        private ButtonCompare second_btn;
        private ButtonCompare third_btn;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

