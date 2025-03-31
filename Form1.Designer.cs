namespace Exercise02
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
            lb01 = new Label();
            label1 = new Label();
            txtAungKaungHtet = new TextBox();
            SuspendLayout();
            // 
            // lb01
            // 
            lb01.AutoSize = true;
            lb01.Location = new Point(183, 26);
            lb01.Margin = new Padding(2, 0, 2, 0);
            lb01.Name = "lb01";
            lb01.Size = new Size(151, 15);
            lb01.TabIndex = 0;
            lb01.Text = "This is Me Doing Exercise02";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 87);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 1;
            label1.Text = "Aung Kaung Htet is doing now";
            // 
            // txtAungKaungHtet
            // 
            txtAungKaungHtet.Location = new Point(140, 136);
            txtAungKaungHtet.Name = "txtAungKaungHtet";
            txtAungKaungHtet.Size = new Size(100, 23);
            txtAungKaungHtet.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 270);
            Controls.Add(txtAungKaungHtet);
            Controls.Add(label1);
            Controls.Add(lb01);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb01;
        private Label label1;
        private TextBox txtAungKaungHtet;
    }
}
