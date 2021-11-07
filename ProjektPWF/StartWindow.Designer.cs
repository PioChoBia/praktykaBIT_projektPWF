
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
            this.comboBoxDopiszNabywca = new System.Windows.Forms.ComboBox();
            this.labelDopiszNabywca = new System.Windows.Forms.Label();
            this.comboBoxDopiszKierownik = new System.Windows.Forms.ComboBox();
            this.labelDopiszKierownik = new System.Windows.Forms.Label();
            this.comboBoxDopiszDostarczanie = new System.Windows.Forms.ComboBox();
            this.labelDopiszDostarczanie = new System.Windows.Forms.Label();
            this.richTextBoxDopiszUwagi = new System.Windows.Forms.RichTextBox();
            this.labelDopiszUwagi = new System.Windows.Forms.Label();
            this.comboBoxDopiszVatStawka = new System.Windows.Forms.ComboBox();
            this.labelDopiszVatStawka = new System.Windows.Forms.Label();
            this.textBoxDopiszNetto = new System.Windows.Forms.TextBox();
            this.labelDopiszNetto = new System.Windows.Forms.Label();
            this.richTextBoxDopiszTresc = new System.Windows.Forms.RichTextBox();
            this.labelDopiszTresc = new System.Windows.Forms.Label();
            this.textBoxDopiszNrUmowy = new System.Windows.Forms.TextBox();
            this.labelDopiszNrUmowy = new System.Windows.Forms.Label();
            this.textBoxDopiszNrZlecenia = new System.Windows.Forms.TextBox();
            this.labelDopiszNrZlecenia = new System.Windows.Forms.Label();
            this.buttonDopiszZatwierdz = new System.Windows.Forms.Button();
            this.dateTimePickerDopiszDataWystawienia = new System.Windows.Forms.DateTimePicker();
            this.labelDopiszDataWystawienia = new System.Windows.Forms.Label();
            this.dateTimePickerDopiszDataSprzedazy = new System.Windows.Forms.DateTimePicker();
            this.labelDopiszDataSprzedazy = new System.Windows.Forms.Label();
            this.comboBoxDopiszPlatnosc = new System.Windows.Forms.ComboBox();
            this.labelDopiszPlatnosc = new System.Windows.Forms.Label();
            this.comboBoxDopiszStatus = new System.Windows.Forms.ComboBox();
            this.labelDopiszStatus = new System.Windows.Forms.Label();
            this.comboBoxDopiszTermin = new System.Windows.Forms.ComboBox();
            this.labelDopiszTermin = new System.Windows.Forms.Label();
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
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszTermin);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszTermin);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszStatus);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszStatus);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszPlatnosc);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszPlatnosc);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszNabywca);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszNabywca);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszKierownik);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszKierownik);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszDostarczanie);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszDostarczanie);
            this.groupBoxDopisz.Controls.Add(this.richTextBoxDopiszUwagi);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszUwagi);
            this.groupBoxDopisz.Controls.Add(this.comboBoxDopiszVatStawka);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszVatStawka);
            this.groupBoxDopisz.Controls.Add(this.textBoxDopiszNetto);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszNetto);
            this.groupBoxDopisz.Controls.Add(this.richTextBoxDopiszTresc);
            this.groupBoxDopisz.Controls.Add(this.labelDopiszTresc);
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
            this.groupBoxDopisz.Size = new System.Drawing.Size(1142, 253);
            this.groupBoxDopisz.TabIndex = 7;
            this.groupBoxDopisz.TabStop = false;
            this.groupBoxDopisz.Text = "wpisz poprawne wartości i kliknij zatwierdź";
            // 
            // comboBoxDopiszNabywca
            // 
            this.comboBoxDopiszNabywca.FormattingEnabled = true;
            this.comboBoxDopiszNabywca.Location = new System.Drawing.Point(278, 88);
            this.comboBoxDopiszNabywca.Name = "comboBoxDopiszNabywca";
            this.comboBoxDopiszNabywca.Size = new System.Drawing.Size(201, 21);
            this.comboBoxDopiszNabywca.TabIndex = 25;
            // 
            // labelDopiszNabywca
            // 
            this.labelDopiszNabywca.AutoSize = true;
            this.labelDopiszNabywca.Location = new System.Drawing.Point(205, 92);
            this.labelDopiszNabywca.Name = "labelDopiszNabywca";
            this.labelDopiszNabywca.Size = new System.Drawing.Size(50, 13);
            this.labelDopiszNabywca.TabIndex = 24;
            this.labelDopiszNabywca.Text = "nabywca";
            // 
            // comboBoxDopiszKierownik
            // 
            this.comboBoxDopiszKierownik.FormattingEnabled = true;
            this.comboBoxDopiszKierownik.Location = new System.Drawing.Point(278, 116);
            this.comboBoxDopiszKierownik.Name = "comboBoxDopiszKierownik";
            this.comboBoxDopiszKierownik.Size = new System.Drawing.Size(201, 21);
            this.comboBoxDopiszKierownik.TabIndex = 23;
            // 
            // labelDopiszKierownik
            // 
            this.labelDopiszKierownik.AutoSize = true;
            this.labelDopiszKierownik.Location = new System.Drawing.Point(204, 120);
            this.labelDopiszKierownik.Name = "labelDopiszKierownik";
            this.labelDopiszKierownik.Size = new System.Drawing.Size(52, 13);
            this.labelDopiszKierownik.TabIndex = 22;
            this.labelDopiszKierownik.Text = "kierownik";
            // 
            // comboBoxDopiszDostarczanie
            // 
            this.comboBoxDopiszDostarczanie.FormattingEnabled = true;
            this.comboBoxDopiszDostarczanie.Location = new System.Drawing.Point(683, 17);
            this.comboBoxDopiszDostarczanie.Name = "comboBoxDopiszDostarczanie";
            this.comboBoxDopiszDostarczanie.Size = new System.Drawing.Size(102, 21);
            this.comboBoxDopiszDostarczanie.TabIndex = 21;
            // 
            // labelDopiszDostarczanie
            // 
            this.labelDopiszDostarczanie.AutoSize = true;
            this.labelDopiszDostarczanie.Location = new System.Drawing.Point(564, 21);
            this.labelDopiszDostarczanie.Name = "labelDopiszDostarczanie";
            this.labelDopiszDostarczanie.Size = new System.Drawing.Size(104, 13);
            this.labelDopiszDostarczanie.TabIndex = 20;
            this.labelDopiszDostarczanie.Text = "sposób dostarczania";
            // 
            // richTextBoxDopiszUwagi
            // 
            this.richTextBoxDopiszUwagi.Location = new System.Drawing.Point(562, 85);
            this.richTextBoxDopiszUwagi.Name = "richTextBoxDopiszUwagi";
            this.richTextBoxDopiszUwagi.Size = new System.Drawing.Size(558, 47);
            this.richTextBoxDopiszUwagi.TabIndex = 19;
            this.richTextBoxDopiszUwagi.Text = "";
            // 
            // labelDopiszUwagi
            // 
            this.labelDopiszUwagi.AutoSize = true;
            this.labelDopiszUwagi.Location = new System.Drawing.Point(521, 96);
            this.labelDopiszUwagi.Name = "labelDopiszUwagi";
            this.labelDopiszUwagi.Size = new System.Drawing.Size(35, 13);
            this.labelDopiszUwagi.TabIndex = 18;
            this.labelDopiszUwagi.Text = "uwagi";
            // 
            // comboBoxDopiszVatStawka
            // 
            this.comboBoxDopiszVatStawka.FormattingEnabled = true;
            this.comboBoxDopiszVatStawka.Location = new System.Drawing.Point(374, 58);
            this.comboBoxDopiszVatStawka.Name = "comboBoxDopiszVatStawka";
            this.comboBoxDopiszVatStawka.Size = new System.Drawing.Size(65, 21);
            this.comboBoxDopiszVatStawka.TabIndex = 17;
            // 
            // labelDopiszVatStawka
            // 
            this.labelDopiszVatStawka.AutoSize = true;
            this.labelDopiszVatStawka.Location = new System.Drawing.Point(291, 61);
            this.labelDopiszVatStawka.Name = "labelDopiszVatStawka";
            this.labelDopiszVatStawka.Size = new System.Drawing.Size(60, 13);
            this.labelDopiszVatStawka.TabIndex = 16;
            this.labelDopiszVatStawka.Text = "stawka Vat";
            // 
            // textBoxDopiszNetto
            // 
            this.textBoxDopiszNetto.Location = new System.Drawing.Point(374, 25);
            this.textBoxDopiszNetto.Name = "textBoxDopiszNetto";
            this.textBoxDopiszNetto.Size = new System.Drawing.Size(65, 20);
            this.textBoxDopiszNetto.TabIndex = 15;
            this.textBoxDopiszNetto.TextChanged += new System.EventHandler(this.textBoxDopiszNetto_TextChanged);
            // 
            // labelDopiszNetto
            // 
            this.labelDopiszNetto.AutoSize = true;
            this.labelDopiszNetto.Location = new System.Drawing.Point(291, 32);
            this.labelDopiszNetto.Name = "labelDopiszNetto";
            this.labelDopiszNetto.Size = new System.Drawing.Size(71, 13);
            this.labelDopiszNetto.TabIndex = 14;
            this.labelDopiszNetto.Text = "wartość netto";
            // 
            // richTextBoxDopiszTresc
            // 
            this.richTextBoxDopiszTresc.Location = new System.Drawing.Point(106, 147);
            this.richTextBoxDopiszTresc.Name = "richTextBoxDopiszTresc";
            this.richTextBoxDopiszTresc.Size = new System.Drawing.Size(892, 98);
            this.richTextBoxDopiszTresc.TabIndex = 13;
            this.richTextBoxDopiszTresc.Text = "";
            // 
            // labelDopiszTresc
            // 
            this.labelDopiszTresc.AutoSize = true;
            this.labelDopiszTresc.Location = new System.Drawing.Point(12, 149);
            this.labelDopiszTresc.Name = "labelDopiszTresc";
            this.labelDopiszTresc.Size = new System.Drawing.Size(66, 13);
            this.labelDopiszTresc.TabIndex = 12;
            this.labelDopiszTresc.Text = "treść umowy";
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
            // textBoxDopiszNrZlecenia
            // 
            this.textBoxDopiszNrZlecenia.Location = new System.Drawing.Point(107, 89);
            this.textBoxDopiszNrZlecenia.Name = "textBoxDopiszNrZlecenia";
            this.textBoxDopiszNrZlecenia.Size = new System.Drawing.Size(65, 20);
            this.textBoxDopiszNrZlecenia.TabIndex = 9;
            this.textBoxDopiszNrZlecenia.TextChanged += new System.EventHandler(this.textBoxDopiszNrZlecenia_TextChanged);
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
            // comboBoxDopiszPlatnosc
            // 
            this.comboBoxDopiszPlatnosc.FormattingEnabled = true;
            this.comboBoxDopiszPlatnosc.Location = new System.Drawing.Point(966, 58);
            this.comboBoxDopiszPlatnosc.Name = "comboBoxDopiszPlatnosc";
            this.comboBoxDopiszPlatnosc.Size = new System.Drawing.Size(124, 21);
            this.comboBoxDopiszPlatnosc.TabIndex = 27;
            // 
            // labelDopiszPlatnosc
            // 
            this.labelDopiszPlatnosc.AutoSize = true;
            this.labelDopiszPlatnosc.Location = new System.Drawing.Point(825, 58);
            this.labelDopiszPlatnosc.Name = "labelDopiszPlatnosc";
            this.labelDopiszPlatnosc.Size = new System.Drawing.Size(121, 13);
            this.labelDopiszPlatnosc.TabIndex = 26;
            this.labelDopiszPlatnosc.Text = "płatność opłacona jako";
            // 
            // comboBoxDopiszStatus
            // 
            this.comboBoxDopiszStatus.FormattingEnabled = true;
            this.comboBoxDopiszStatus.Location = new System.Drawing.Point(966, 17);
            this.comboBoxDopiszStatus.Name = "comboBoxDopiszStatus";
            this.comboBoxDopiszStatus.Size = new System.Drawing.Size(124, 21);
            this.comboBoxDopiszStatus.TabIndex = 29;
            // 
            // labelDopiszStatus
            // 
            this.labelDopiszStatus.AutoSize = true;
            this.labelDopiszStatus.Location = new System.Drawing.Point(825, 21);
            this.labelDopiszStatus.Name = "labelDopiszStatus";
            this.labelDopiszStatus.Size = new System.Drawing.Size(82, 13);
            this.labelDopiszStatus.TabIndex = 28;
            this.labelDopiszStatus.Text = "status płatności";
            // 
            // comboBoxDopiszTermin
            // 
            this.comboBoxDopiszTermin.FormattingEnabled = true;
            this.comboBoxDopiszTermin.Location = new System.Drawing.Point(684, 51);
            this.comboBoxDopiszTermin.Name = "comboBoxDopiszTermin";
            this.comboBoxDopiszTermin.Size = new System.Drawing.Size(102, 21);
            this.comboBoxDopiszTermin.TabIndex = 31;
            // 
            // labelDopiszTermin
            // 
            this.labelDopiszTermin.AutoSize = true;
            this.labelDopiszTermin.Location = new System.Drawing.Point(564, 54);
            this.labelDopiszTermin.Name = "labelDopiszTermin";
            this.labelDopiszTermin.Size = new System.Drawing.Size(99, 13);
            this.labelDopiszTermin.TabIndex = 30;
            this.labelDopiszTermin.Text = "termin płatności dni";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 746);
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
        private System.Windows.Forms.RichTextBox richTextBoxDopiszTresc;
        private System.Windows.Forms.Label labelDopiszTresc;
        private System.Windows.Forms.ComboBox comboBoxDopiszVatStawka;
        private System.Windows.Forms.Label labelDopiszVatStawka;
        private System.Windows.Forms.TextBox textBoxDopiszNetto;
        private System.Windows.Forms.Label labelDopiszNetto;
        private System.Windows.Forms.ComboBox comboBoxDopiszDostarczanie;
        private System.Windows.Forms.Label labelDopiszDostarczanie;
        private System.Windows.Forms.RichTextBox richTextBoxDopiszUwagi;
        private System.Windows.Forms.Label labelDopiszUwagi;
        private System.Windows.Forms.ComboBox comboBoxDopiszKierownik;
        private System.Windows.Forms.Label labelDopiszKierownik;
        private System.Windows.Forms.ComboBox comboBoxDopiszNabywca;
        private System.Windows.Forms.Label labelDopiszNabywca;
        private System.Windows.Forms.ComboBox comboBoxDopiszPlatnosc;
        private System.Windows.Forms.Label labelDopiszPlatnosc;
        private System.Windows.Forms.ComboBox comboBoxDopiszStatus;
        private System.Windows.Forms.Label labelDopiszStatus;
        private System.Windows.Forms.ComboBox comboBoxDopiszTermin;
        private System.Windows.Forms.Label labelDopiszTermin;
    }
}

