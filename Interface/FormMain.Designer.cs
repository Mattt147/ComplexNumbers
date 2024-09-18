namespace Interface
{
    partial class FormMain
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
            Dekart = new Button();
            Polar = new Button();
            Exp = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Dekart
            // 
            Dekart.BackColor = Color.DarkSalmon;
            Dekart.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Dekart.Location = new Point(457, 157);
            Dekart.Name = "Dekart";
            Dekart.Size = new Size(265, 73);
            Dekart.TabIndex = 0;
            Dekart.Text = "Декартовая ";
            Dekart.UseVisualStyleBackColor = false;
            Dekart.Click += Dekart_Click;
            // 
            // Polar
            // 
            Polar.BackColor = Color.DarkSalmon;
            Polar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Polar.Location = new Point(457, 256);
            Polar.Name = "Polar";
            Polar.Size = new Size(265, 72);
            Polar.TabIndex = 1;
            Polar.Text = "Полярная";
            Polar.UseVisualStyleBackColor = false;
            Polar.Click += Polar_Click;
            // 
            // Exp
            // 
            Exp.BackColor = Color.DarkSalmon;
            Exp.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Exp.Location = new Point(457, 358);
            Exp.Name = "Exp";
            Exp.Size = new Size(265, 77);
            Exp.TabIndex = 2;
            Exp.Text = "Экспоненциальная ";
            Exp.UseVisualStyleBackColor = false;
            Exp.Click += Exp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(66, 200);
            label2.Name = "label2";
            label2.Size = new Size(345, 30);
            label2.TabIndex = 5;
            label2.Text = "Выберите форму представления ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(66, 265);
            label3.Name = "label3";
            label3.Size = new Size(223, 30);
            label3.TabIndex = 6;
            label3.Text = "комплексного числа:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(720, 50);
            label1.TabIndex = 3;
            label1.Text = "Калькулятор комплексных чисел";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 135);
            panel1.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 459);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Exp);
            Controls.Add(Polar);
            Controls.Add(Dekart);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Dekart;
        private Button Polar;
        private Button Exp;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel1;
    }
}