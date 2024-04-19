namespace WinFormsAppAlgoritmo
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 13F);
            groupBox1.Location = new Point(34, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 54);
            label1.Name = "label1";
            label1.Size = new Size(221, 36);
            label1.TabIndex = 0;
            label1.Text = "Numero da conta";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 128);
            textBox1.Location = new Point(23, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 44);
            textBox1.TabIndex = 1;
            textBox1.Text = "123456";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 44);
            textBox2.TabIndex = 3;
            textBox2.Text = "Rafael Vieira Suarez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 54);
            label2.Name = "label2";
            label2.Size = new Size(209, 36);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 44);
            textBox3.TabIndex = 7;
            textBox3.Text = "Corrente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 142);
            label3.Name = "label3";
            label3.Size = new Size(181, 36);
            label3.TabIndex = 6;
            label3.Text = "Tipo da Conta";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(0, 192, 0);
            textBox4.Location = new Point(23, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 44);
            textBox4.TabIndex = 5;
            textBox4.Text = "1000";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 142);
            label4.Name = "label4";
            label4.Size = new Size(192, 36);
            label4.TabIndex = 4;
            label4.Text = "Saldo da conta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
