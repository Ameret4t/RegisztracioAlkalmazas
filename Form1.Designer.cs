namespace RegisztracioAlkalmazas
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
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzulDat = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.dateTimePickerSzulDat = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNemF = new System.Windows.Forms.RadioButton();
            this.radioButtonNemN = new System.Windows.Forms.RadioButton();
            this.labelHobbi = new System.Windows.Forms.Label();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.buttonHozzaAd = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(13, 13);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(30, 13);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név:";
            // 
            // labelSzulDat
            // 
            this.labelSzulDat.AutoSize = true;
            this.labelSzulDat.Location = new System.Drawing.Point(12, 51);
            this.labelSzulDat.Name = "labelSzulDat";
            this.labelSzulDat.Size = new System.Drawing.Size(67, 13);
            this.labelSzulDat.TabIndex = 1;
            this.labelSzulDat.Text = "Szül. Dátum:";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(12, 91);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(32, 13);
            this.labelNem.TabIndex = 2;
            this.labelNem.Text = "Nem:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(98, 13);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(166, 20);
            this.textBoxNev.TabIndex = 3;
            // 
            // dateTimePickerSzulDat
            // 
            this.dateTimePickerSzulDat.Location = new System.Drawing.Point(98, 45);
            this.dateTimePickerSzulDat.Name = "dateTimePickerSzulDat";
            this.dateTimePickerSzulDat.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSzulDat.TabIndex = 5;
            // 
            // radioButtonNemF
            // 
            this.radioButtonNemF.AutoSize = true;
            this.radioButtonNemF.Location = new System.Drawing.Point(98, 87);
            this.radioButtonNemF.Name = "radioButtonNemF";
            this.radioButtonNemF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNemF.TabIndex = 6;
            this.radioButtonNemF.TabStop = true;
            this.radioButtonNemF.Text = "Férfi";
            this.radioButtonNemF.UseVisualStyleBackColor = true;
            // 
            // radioButtonNemN
            // 
            this.radioButtonNemN.AutoSize = true;
            this.radioButtonNemN.Location = new System.Drawing.Point(179, 87);
            this.radioButtonNemN.Name = "radioButtonNemN";
            this.radioButtonNemN.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNemN.TabIndex = 7;
            this.radioButtonNemN.TabStop = true;
            this.radioButtonNemN.Text = "Nő";
            this.radioButtonNemN.UseVisualStyleBackColor = true;
            // 
            // labelHobbi
            // 
            this.labelHobbi.AutoSize = true;
            this.labelHobbi.Location = new System.Drawing.Point(384, 13);
            this.labelHobbi.Name = "labelHobbi";
            this.labelHobbi.Size = new System.Drawing.Size(82, 13);
            this.labelHobbi.TabIndex = 8;
            this.labelHobbi.Text = "Kedvenc hobbi:";
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "Úszás",
            "Futball",
            "Kézilabda"});
            this.listBoxHobbik.Location = new System.Drawing.Point(387, 29);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(120, 95);
            this.listBoxHobbik.TabIndex = 9;
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Location = new System.Drawing.Point(319, 147);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(49, 13);
            this.labelUjHobbi.TabIndex = 10;
            this.labelUjHobbi.Text = "Új hobbi:";
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Location = new System.Drawing.Point(387, 144);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(120, 20);
            this.textBoxUjHobbi.TabIndex = 11;
            // 
            // buttonHozzaAd
            // 
            this.buttonHozzaAd.Location = new System.Drawing.Point(387, 170);
            this.buttonHozzaAd.Name = "buttonHozzaAd";
            this.buttonHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaAd.TabIndex = 12;
            this.buttonHozzaAd.Text = "Hozzáad";
            this.buttonHozzaAd.UseVisualStyleBackColor = true;
            this.buttonHozzaAd.Click += new System.EventHandler(this.buttonHozzaAd_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(387, 255);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 13;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(468, 255);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 14;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaAd);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.labelHobbi);
            this.Controls.Add(this.radioButtonNemN);
            this.Controls.Add(this.radioButtonNemF);
            this.Controls.Add(this.dateTimePickerSzulDat);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSzulDat);
            this.Controls.Add(this.labelNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzulDat;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzulDat;
        private System.Windows.Forms.RadioButton radioButtonNemF;
        private System.Windows.Forms.RadioButton radioButtonNemN;
        private System.Windows.Forms.Label labelHobbi;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.Button buttonHozzaAd;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

