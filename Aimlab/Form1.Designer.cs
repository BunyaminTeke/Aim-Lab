namespace Aimlab
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
            karpuz = new Button();
            SuspendLayout();
            // 
            // karpuz
            // 
            karpuz.BackColor = SystemColors.Control;
            karpuz.FlatAppearance.BorderSize = 0;
            karpuz.FlatAppearance.MouseOverBackColor = Color.Transparent;
            karpuz.FlatStyle = FlatStyle.Flat;
            karpuz.Location = new Point(343, 244);
            karpuz.Name = "karpuz";
            karpuz.Size = new Size(45, 45);
            karpuz.TabIndex = 0;
            karpuz.UseVisualStyleBackColor = false;
            karpuz.Click += karpuz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(karpuz);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button karpuz;
    }
}
