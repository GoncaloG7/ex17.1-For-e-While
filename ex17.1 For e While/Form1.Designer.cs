﻿namespace ex17._1_For_e_While
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
            btnCiclo = new Button();
            btnForm2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCiclo
            // 
            btnCiclo.Location = new Point(85, 205);
            btnCiclo.Name = "btnCiclo";
            btnCiclo.Size = new Size(100, 23);
            btnCiclo.TabIndex = 1;
            btnCiclo.Text = "Ver";
            btnCiclo.Click += btnCiclo_Click;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(213, 12);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(50, 23);
            btnForm2.TabIndex = 0;
            btnForm2.Text = "---▶";
            btnForm2.Click += btnForm2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 89);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "nº1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 139);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "nº2";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
            button1.TabIndex = 12;
            button1.Text = "fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image_removebg_preview__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(275, 257);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnForm2);
            Controls.Add(btnCiclo);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCiclo;
        private Button btnForm2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
