namespace _241209_jz_form
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
            label1 = new Label();
            lbnev = new Label();
            label3 = new Label();
            label4 = new Label();
            btKeres = new Button();
            btSave = new Button();
            tbAzon = new TextBox();
            tbHossz = new TextBox();
            tbMelyseg = new TextBox();
            Nevlb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Azonosító:";
            // 
            // lbnev
            // 
            lbnev.AutoSize = true;
            lbnev.Location = new Point(12, 60);
            lbnev.Name = "lbnev";
            lbnev.Size = new Size(81, 15);
            lbnev.TabIndex = 1;
            lbnev.Text = "Barlang neve: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 106);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Hosszúság:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Mélység:";
            // 
            // btKeres
            // 
            btKeres.Location = new Point(217, 18);
            btKeres.Name = "btKeres";
            btKeres.Size = new Size(106, 22);
            btKeres.TabIndex = 4;
            btKeres.Text = "Barlang keresése";
            btKeres.UseVisualStyleBackColor = true;
            btKeres.Click += btkeres_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(217, 129);
            btSave.Name = "btSave";
            btSave.Size = new Size(106, 25);
            btSave.TabIndex = 5;
            btSave.Text = "Adatok mentése";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbAzon
            // 
            tbAzon.Location = new Point(81, 15);
            tbAzon.Name = "tbAzon";
            tbAzon.Size = new Size(100, 23);
            tbAzon.TabIndex = 6;
            // 
            // tbHossz
            // 
            tbHossz.Location = new Point(85, 106);
            tbHossz.Name = "tbHossz";
            tbHossz.Size = new Size(100, 23);
            tbHossz.TabIndex = 7;
            tbHossz.TextChanged += tbHossz_TextChanged;
            // 
            // tbMelyseg
            // 
            tbMelyseg.Location = new Point(85, 155);
            tbMelyseg.Name = "tbMelyseg";
            tbMelyseg.Size = new Size(100, 23);
            tbMelyseg.TabIndex = 8;
            // 
            // Nevlb
            // 
            Nevlb.AutoSize = true;
            Nevlb.Location = new Point(99, 60);
            Nevlb.Name = "Nevlb";
            Nevlb.Size = new Size(21, 15);
            Nevlb.TabIndex = 9;
            Nevlb.Text = "ph";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 224);
            Controls.Add(Nevlb);
            Controls.Add(tbMelyseg);
            Controls.Add(tbHossz);
            Controls.Add(tbAzon);
            Controls.Add(btSave);
            Controls.Add(btKeres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbnev);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Barlangok";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbnev;
        private Label label3;
        private Label label4;
        private Button btKeres;
        private Button btSave;
        private TextBox tbAzon;
        private TextBox tbHossz;
        private TextBox tbMelyseg;
        private Label Nevlb;
    }
}
