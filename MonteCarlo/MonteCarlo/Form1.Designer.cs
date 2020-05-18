namespace MonteCarlo
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
            this.textBoxCntThr = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxRad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSqr = new System.Windows.Forms.TextBox();
            this.textBoxSqr2 = new System.Windows.Forms.TextBox();
            this.bthStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCntThr
            // 
            this.textBoxCntThr.Location = new System.Drawing.Point(870, 107);
            this.textBoxCntThr.Name = "textBoxCntThr";
            this.textBoxCntThr.Size = new System.Drawing.Size(100, 22);
            this.textBoxCntThr.TabIndex = 0;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(870, 161);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 2;
            // 
            // textBoxRad
            // 
            this.textBoxRad.Location = new System.Drawing.Point(870, 58);
            this.textBoxRad.Name = "textBoxRad";
            this.textBoxRad.Size = new System.Drawing.Size(100, 22);
            this.textBoxRad.TabIndex = 3;
            this.textBoxRad.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Радиус круга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество потоков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Площадь квадрата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Площадь круга";
            // 
            // textBoxSqr
            // 
            this.textBoxSqr.Location = new System.Drawing.Point(870, 319);
            this.textBoxSqr.Name = "textBoxSqr";
            this.textBoxSqr.Size = new System.Drawing.Size(100, 22);
            this.textBoxSqr.TabIndex = 12;
            // 
            // textBoxSqr2
            // 
            this.textBoxSqr2.Location = new System.Drawing.Point(870, 359);
            this.textBoxSqr2.Name = "textBoxSqr2";
            this.textBoxSqr2.Size = new System.Drawing.Size(100, 22);
            this.textBoxSqr2.TabIndex = 13;
            // 
            // bthStart
            // 
            this.bthStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthStart.Location = new System.Drawing.Point(700, 230);
            this.bthStart.Name = "bthStart";
            this.bthStart.Size = new System.Drawing.Size(95, 33);
            this.bthStart.TabIndex = 14;
            this.bthStart.Text = "Начать";
            this.bthStart.UseVisualStyleBackColor = true;
            this.bthStart.Click += new System.EventHandler(this.bthStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 414);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(875, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Число PI ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bthStart);
            this.Controls.Add(this.textBoxSqr2);
            this.Controls.Add(this.textBoxSqr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRad);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxCntThr);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Монте-Карло";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxCntThr;
        public System.Windows.Forms.TextBox textBoxSpeed;
        public System.Windows.Forms.TextBox textBoxRad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxSqr;
        public System.Windows.Forms.TextBox textBoxSqr2;
        public System.Windows.Forms.Button bthStart;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

