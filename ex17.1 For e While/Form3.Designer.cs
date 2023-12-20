namespace ex17._1_For_e_While
{
    partial class Form3
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
            btnForm2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCiclo = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(12, 12);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(50, 23);
            btnForm2.TabIndex = 1;
            btnForm2.Text = "◀---";
            btnForm2.Click += btnForm2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 136);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 10;
            label2.Text = "nº2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 86);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 9;
            label1.Text = "nº1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // btnCiclo
            // 
            btnCiclo.Location = new Point(92, 202);
            btnCiclo.Name = "btnCiclo";
            btnCiclo.Size = new Size(100, 23);
            btnCiclo.TabIndex = 6;
            btnCiclo.Text = "Ver";
            btnCiclo.Click += btnCiclo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(223, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
            button1.TabIndex = 11;
            button1.Text = "fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.eren;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(284, 310);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCiclo);
            Controls.Add(btnForm2);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForm2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnCiclo;
        private Button button1;
    }
}