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
            label1 = new Label();
            SuspendLayout();
            // 
            // Dekart
            // 
            Dekart.Location = new Point(549, 35);
            Dekart.Name = "Dekart";
            Dekart.Size = new Size(209, 94);
            Dekart.TabIndex = 0;
            Dekart.Text = "Декартовая система";
            Dekart.UseVisualStyleBackColor = true;
            // 
            // Polar
            // 
            Polar.Location = new Point(549, 173);
            Polar.Name = "Polar";
            Polar.Size = new Size(209, 94);
            Polar.TabIndex = 1;
            Polar.Text = "Полярная система";
            Polar.UseVisualStyleBackColor = true;
            // 
            // Exp
            // 
            Exp.Location = new Point(549, 319);
            Exp.Name = "Exp";
            Exp.Size = new Size(209, 94);
            Exp.TabIndex = 2;
            Exp.Text = "Экспоненциальная форма";
            Exp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 125);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = " Выбор";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Exp);
            Controls.Add(Polar);
            Controls.Add(Dekart);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Dekart;
        private Button Polar;
        private Button Exp;
        private Label label1;
    }
}