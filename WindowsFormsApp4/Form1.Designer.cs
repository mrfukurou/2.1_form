namespace WindowsFormsApp4
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
            this.coord_x = new System.Windows.Forms.TextBox();
            this.coord_y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coord_x
            // 
            this.coord_x.Location = new System.Drawing.Point(203, 214);
            this.coord_x.Name = "coord_x";
            this.coord_x.Size = new System.Drawing.Size(197, 22);
            this.coord_x.TabIndex = 1;
            // 
            // coord_y
            // 
            this.coord_y.Location = new System.Drawing.Point(203, 256);
            this.coord_y.Name = "coord_y";
            this.coord_y.Size = new System.Drawing.Size(197, 22);
            this.coord_y.TabIndex = 2;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(43, 214);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(144, 17);
            this.X.TabIndex = 3;
            this.X.Text = "Введите значение х:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(42, 256);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(145, 17);
            this.Y.TabIndex = 4;
            this.Y.Text = "Введите значение у:";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(45, 298);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(577, 22);
            this.rez.TabIndex = 5;
            this.rez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(577, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Определить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.Безымянный1;
            this.pictureBox1.Location = new System.Drawing.Point(406, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(665, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.coord_y);
            this.Controls.Add(this.coord_x);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox coord_x;
        private System.Windows.Forms.TextBox coord_y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button1;
    }
}

