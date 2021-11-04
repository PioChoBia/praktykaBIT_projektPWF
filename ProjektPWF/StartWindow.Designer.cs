
namespace ProjektPWF
{
    partial class StartWindow
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
            this.labelNaglowek = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDrukuj = new System.Windows.Forms.Button();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.groupBoxSzukaj = new System.Windows.Forms.GroupBox();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.buttonDopisz = new System.Windows.Forms.Button();
            this.groupBoxDopisz = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDopiszDataSprzedazy = new System.Windows.Forms.DateTimePicker();
            this.labelDopiszDataSprzedazy = new System.Windows.Forms.Label();
            this.dateTimePickerDopiszDataWystawienia = new System.Windows.Forms.DateTimePicker();
            this.labelDopiszDataWystawienia = new System.Windows.Forms.Label();
            this.buttonDopiszZatwierdz = new System.Windows.Forms.Button();
            this.labelDopiszNrZlecenia = new System.Windows.Forms.Label();
            this.textBoxDopiszNrZlecenia = new System.Windows.Forms.TextBox();
            this.textBoxDopiszNrUmowy = new System.Windows.Forms.TextBox();
            this.labelDopiszNrUmowy = new System.Windows.Forms.Label();
            this.labelDopiszTrescUmowy = new System.Windows.Forms.Label();
            this.richTextBoxDopiszTrescUmowy = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSzukaj.SuspendLayout();
            this.groupBoxDopisz.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNaglowek
            // 
            this.labelNaglowek.AutoSize = true;
            this.labelNaglowek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelNaglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaglowek.Location = new System.Drawing.Point(204, 8);
            this.labelNaglowek.Name = "labelNaglowek";
            this.labelNaglowek.Size = new System.Drawing.Size(616, 25);
            this.labelNaglowek.TabIndex = 0;
            this.labelNaglowek.Text = "Polecenie Wystawienia Faktury Sprzedaży/PWF BIT S. A.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonDrukuj
            // 
            this.buttonDrukuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDrukuj.Location = new System.Drawing.Point(1073, 8);
            this.buttonDrukuj.Name = "buttonDrukuj";
            this.buttonDrukuj.Size = new System.Drawing.Size(104, 32);
            this.buttonDrukuj.TabIndex = 3;
            this.buttonDrukuj.Text = "drukuj";
            this.buttonDrukuj.UseVisualStyleBackColor = true;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzukaj.Location = new System.Drawing.Point(805, 17);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(104, 32);
            this.buttonSzukaj.TabIndex = 4;
            this.buttonSzukaj.Text = "szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // groupBoxSzukaj
            // 
            this.groupBoxSzukaj.Controls.Add(this.textBoxSzukaj);
            this.groupBoxSzukaj.Controls.Add(this.buttonSzukaj);
            this.groupBoxSzukaj.Location = new System.Drawing.Point(58, 74);
            this.groupBoxSzukaj.Name = "groupBoxSzukaj";
            this.groupBoxSzukaj.Size = new System.Drawing.Size(1119, 71);
            this.groupBoxSzukaj.TabIndex = 5;
            this.groupBoxSzukaj.TabStop = false;
            this.groupBoxSzukaj.Text = "szukaj po polach i treści";
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukaj.Location = new System.Drawing.Point(563, 19);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(172, 22);
            this.textBoxSzukaj.TabIndex = 5;
            // 
            // buttonDopisz
            // 
            this.buttonDopisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDopisz.Location = new System.Drawing.Point(942, 8);
            this.buttonDopisz.Name = "buttonDopisz";
            this.buttonDopisz.Size = new System.Drawing.Size(104, 32);
            this.buttonDopisz.TabIndex = 6;
            this.buttonDopisz.Text = "dopisz";
            this.buttonDopisz.UseVisualStyleBackColor = true;
            this.buttonDopisz.Click += new System.EventHandler(this.buttonDopisz_Click);
            // 
            // groupBoxDopisz
            // 
            this.groupBoxDopisz.Controls.Add(this.richTextBoxDopiszTrescUmowy);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszTrescUmowy);
            this.groupBoxDopisz.Controls.Add(this.textBoxDopiszNrUmowy);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszNrUmowy);
            this.groupBoxDopisz.Controls.Add(this.textBoxDopiszNrZlecenia);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszNrZlecenia);
            this.groupBoxDopisz.Controls.Add(this.buttonDopiszZatwierdz);
            this.groupBoxDopisz.Controls.Add(this.dateTimePickerDopiszDataWystawienia);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszDataWystawienia);
            this.groupBoxDopisz.Controls.Add(this.dateTimePickerDopiszDataSprzedazy);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszDataSprzedazy);
            this.groupBoxDopisz.Location = new System.Drawing.Point(48, 409);
            this.groupBoxDopisz.Name = "groupBoxDopisz";
            this.groupBoxDopisz.Size = new System.Drawing.Size(1142, 251);
            this.groupBoxDopisz.TabIndex = 7;
            this.groupBoxDopisz.TabStop = false;
            this.groupBoxDopisz.Text = "wpisz poprawne wartości i kliknij zatwierdź";
            // 
            // dateTimePickerDopiszDataSprzedazy
            // 
            this.dateTimePickerDopiszDataSprzedazy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDopiszDataSprzedazy.Location = new System.Drawing.Point(107, 25);
            this.dateTimePickerDopiszDataSprzedazy.Name = "dateTimePickerDopiszDataSprzedazy";
            this.dateTimePickerDopiszDataSprzedazy.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDopiszDataSprzedazy.TabIndex = 1;
            // 
            // labelDopiszDataSprzedazy
            // 
            this.labelDopiszDataSprzedazy.AutoSize = true;
            this.labelDopiszDataSprzedazy.Location = new System.Drawing.Point(12, 25);
            this.labelDopiszDataSprzedazy.Name = "labelDopiszDataSprzedazy";
            this.labelDopiszDataSprzedazy.Size = new System.Drawing.Size(78, 13);
            this.labelDopiszDataSprzedazy.TabIndex = 0;
            this.labelDopiszDataSprzedazy.Text = "data sprzedaży";
            // 
            // dateTimePickerDopiszDataWystawienia
            // 
            this.dateTimePickerDopiszDataWystawienia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDopiszDataWystawienia.Location = new System.Drawing.Point(106, 51);
            this.dateTimePickerDopiszDataWystawienia.Name = "dateTimePickerDopiszDataWystawienia";
            this.dateTimePickerDopiszDataWystawienia.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDopiszDataWystawienia.TabIndex = 3;
            // 
            // labelDopiszDataWystawienia
            // 
            this.labelDopiszDataWystawienia.AutoSize = true;
            this.labelDopiszDataWystawienia.Location = new System.Drawing.Point(12, 51);
            this.labelDopiszDataWystawienia.Name = "labelDopiszDataWystawienia";
            this.labelDopiszDataWystawienia.Size = new System.Drawing.Size(88, 13);
            this.labelDopiszDataWystawienia.TabIndex = 2;
            this.labelDopiszDataWystawienia.Text = "data wystawienia";
            // 
            // buttonDopiszZatwierdz
            // 
            this.buttonDopiszZatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDopiszZatwierdz.Location = new System.Drawing.Point(1016, 200);
            this.buttonDopiszZatwierdz.Name = "buttonDopiszZatwierdz";
            this.buttonDopiszZatwierdz.Size = new System.Drawing.Size(104, 32);
            this.buttonDopiszZatwierdz.TabIndex = 7;
            this.buttonDopiszZatwierdz.Text = "zatwierdź";
            this.buttonDopiszZatwierdz.UseVisualStyleBackColor = true;
            this.buttonDopiszZatwierdz.Click += new System.EventHandler(this.buttonDopiszZatwierdz_Click);
            // 
            // labelDopiszNrZlecenia
            // 
            this.labelDopiszNrZlecenia.AutoSize = true;
            this.labelDopiszNrZlecenia.Location = new System.Drawing.Point(12, 93);
            this.labelDopiszNrZlecenia.Name = "labelDopiszNrZlecenia";
            this.labelDopiszNrZlecenia.Size = new System.Drawing.Size(78, 13);
            this.labelDopiszNrZlecenia.TabIndex = 8;
            this.labelDopiszNrZlecenia.Text = "numer zlecenia";
            // 
            // textBoxDopiszNrZlecenia
            // 
            this.textBoxDopiszNrZlecenia.Location = new System.Drawing.Point(107, 89);
            this.textBoxDopiszNrZlecenia.Name = "textBoxDopiszNrZlecenia";
            this.textBoxDopiszNrZlecenia.Size = new System.Drawing.Size(65, 20);
            this.textBoxDopiszNrZlecenia.TabIndex = 9;
            this.textBoxDopiszNrZlecenia.TextChanged += new System.EventHandler(this.textBoxDopiszNrZlecenia_TextChanged);
            // 
            // textBoxDopiszNrUmowy
            // 
            this.textBoxDopiszNrUmowy.Location = new System.Drawing.Point(107, 115);
            this.textBoxDopiszNrUmowy.Name = "textBoxDopiszNrUmowy";
            this.textBoxDopiszNrUmowy.Size = new System.Drawing.Size(65, 20);
            this.textBoxDopiszNrUmowy.TabIndex = 11;
            this.textBoxDopiszNrUmowy.TextChanged += new System.EventHandler(this.textBoxDopiszNrUmowy_TextChanged);
            // 
            // labelDopiszNrUmowy
            // 
            this.labelDopiszNrUmowy.AutoSize = true;
            this.labelDopiszNrUmowy.Location = new System.Drawing.Point(12, 119);
            this.labelDopiszNrUmowy.Name = "labelDopiszNrUmowy";
            this.labelDopiszNrUmowy.Size = new System.Drawing.Size(72, 13);
            this.labelDopiszNrUmowy.TabIndex = 10;
            this.labelDopiszNrUmowy.Text = "numer umowy";
            // 
            // labelDopiszTrescUmowy
            // 
            this.labelDopiszTrescUmowy.AutoSize = true;
            this.labelDopiszTrescUmowy.Location = new System.Drawing.Point(12, 149);
            this.labelDopiszTrescUmowy.Name = "labelDopiszTrescUmowy";
            this.labelDopiszTrescUmowy.Size = new System.Drawing.Size(66, 13);
            this.labelDopiszTrescUmowy.TabIndex = 12;
            this.labelDopiszTrescUmowy.Text = "treść umowy";
            // 
            // richTextBoxDopiszTrescUmowy
            // 
            this.richTextBoxDopiszTrescUmowy.Location = new System.Drawing.Point(106, 147);
            this.richTextBoxDopiszTrescUmowy.Name = "richTextBoxDopiszTrescUmowy";
            this.richTextBoxDopiszTrescUmowy.Size = new System.Drawing.Size(892, 98);
            this.richTextBoxDopiszTrescUmowy.TabIndex = 13;
            this.richTextBoxDopiszTrescUmowy.Text = "";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 686);
            this.Controls.Add(this.groupBoxDopisz);
            this.Controls.Add(this.buttonDopisz);
            this.Controls.Add(this.labelNaglowek);
            this.Controls.Add(this.groupBoxSzukaj);
            this.Controls.Add(this.buttonDrukuj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StartWindow";
            this.Text = "StartWindow zmienione";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSzukaj.ResumeLayout(false);
            this.groupBoxSzukaj.PerformLayout();
            this.groupBoxDopisz.ResumeLayout(false);
            this.groupBoxDopisz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNaglowek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDrukuj;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.GroupBox groupBoxSzukaj;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.Button buttonDopisz;
        private System.Windows.Forms.GroupBox groupBoxDopisz;
        private System.Windows.Forms.DateTimePicker dateTimePickerDopiszDataSprzedazy;
        private System.Windows.Forms.Label labelDopiszDataSprzedazy;
        private System.Windows.Forms.Button buttonDopiszZatwierdz;
        private System.Windows.Forms.DateTimePicker dateTimePickerDopiszDataWystawienia;
        private System.Windows.Forms.Label labelDopiszDataWystawienia;
        private System.Windows.Forms.TextBox textBoxDopiszNrZlecenia;
        private System.Windows.Forms.Label labelDopiszNrZlecenia;
        private System.Windows.Forms.TextBox textBoxDopiszNrUmowy;
        private System.Windows.Forms.Label labelDopiszNrUmowy;
        private System.Windows.Forms.RichTextBox richTextBoxDopiszTrescUmowy;
        private System.Windows.Forms.Label labelDopiszTrescUmowy;
    }
}

