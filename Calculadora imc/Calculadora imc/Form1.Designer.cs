namespace Calculadora_IMC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtIMC = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtIMC);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 244);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(260, 98);
            label7.Name = "label7";
            label7.Size = new Size(24, 18);
            label7.TabIndex = 14;
            label7.Text = "m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(260, 56);
            label6.Name = "label6";
            label6.Size = new Size(29, 18);
            label6.TabIndex = 13;
            label6.Text = "Kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(22, 216);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 12;
            label4.Text = "Situação";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(154, 137);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(100, 23);
            txtIMC.TabIndex = 9;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(154, 98);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 8;
            txtAltura.Enter += txtAltura_Enter;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(154, 54);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 7;
            txtPeso.Enter += txtPeso_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(87, 142);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 6;
            label5.Text = "IMC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(83, 98);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 4;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(86, 54);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 3;
            label2.Text = "Peso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 6);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 2;
            label1.Text = "Cálculo de IMC";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 264);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(12, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 264);
            panel3.TabIndex = 1;
            // 
            // button13
            // 
            button13.BackColor = Color.Gold;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(38, 232);
            button13.Name = "button13";
            button13.Size = new Size(234, 29);
            button13.TabIndex = 12;
            button13.Text = "Calcular Índice de Massa Corporal";
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Gold;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(200, 178);
            button12.Name = "button12";
            button12.Size = new Size(72, 50);
            button12.TabIndex = 11;
            button12.Text = "Del";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(119, 178);
            button11.Name = "button11";
            button11.Size = new Size(72, 50);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += AddNumber;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(38, 178);
            button10.Name = "button10";
            button10.Size = new Size(72, 50);
            button10.TabIndex = 9;
            button10.Text = ";";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(200, 122);
            button9.Name = "button9";
            button9.Size = new Size(72, 50);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += AddNumber;
            // 
            // button8
            // 
            button8.BackColor = Color.Gold;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(119, 122);
            button8.Name = "button8";
            button8.Size = new Size(72, 50);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += AddNumber;
            // 
            // button7
            // 
            button7.BackColor = Color.Gold;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(38, 122);
            button7.Name = "button7";
            button7.Size = new Size(72, 50);
            button7.TabIndex = 6;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AddNumber;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(200, 66);
            button6.Name = "button6";
            button6.Size = new Size(72, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += AddNumber;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(119, 66);
            button5.Name = "button5";
            button5.Size = new Size(72, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AddNumber;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(38, 66);
            button4.Name = "button4";
            button4.Size = new Size(72, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AddNumber;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(200, 10);
            button3.Name = "button3";
            button3.Size = new Size(72, 50);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AddNumber;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(119, 10);
            button2.Name = "button2";
            button2.Size = new Size(72, 50);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddNumber;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(38, 10);
            button1.Name = "button1";
            button1.Size = new Size(72, 50);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddNumber;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(344, 521);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtIMC;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label label4;
        private Panel panel3;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button13;
        private Label label7;
        private Label label6;
    }
}
