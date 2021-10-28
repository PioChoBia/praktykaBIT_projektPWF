
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
            this.groupBoxNaglowek = new System.Windows.Forms.GroupBox();
            this.labelNaglowek = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDrukuj = new System.Windows.Forms.Button();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.groupBoxSzukaj = new System.Windows.Forms.GroupBox();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.groupBoxNaglowek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSzukaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNaglowek
            // 
            this.groupBoxNaglowek.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxNaglowek.Controls.Add(this.labelNaglowek);
            this.groupBoxNaglowek.Location = new System.Drawing.Point(27, 27);
            this.groupBoxNaglowek.Name = "groupBoxNaglowek";
            this.groupBoxNaglowek.Size = new System.Drawing.Size(781, 78);
            this.groupBoxNaglowek.TabIndex = 0;
            this.groupBoxNaglowek.TabStop = false;
            this.groupBoxNaglowek.Text = " ";
            // 
            // labelNaglowek
            // 
            this.labelNaglowek.AutoSize = true;
            this.labelNaglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaglowek.Location = new System.Drawing.Point(72, 16);
            this.labelNaglowek.Name = "labelNaglowek";
            this.labelNaglowek.Size = new System.Drawing.Size(616, 25);
            this.labelNaglowek.TabIndex = 0;
            this.labelNaglowek.Text = "Polecenie Wystawienia Faktury Sprzedaży/PWF BIT S. A.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonDrukuj
            // 
            this.buttonDrukuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDrukuj.Location = new System.Drawing.Point(1064, 36);
            this.buttonDrukuj.Name = "buttonDrukuj";
            this.buttonDrukuj.Size = new System.Drawing.Size(104, 32);
            this.buttonDrukuj.TabIndex = 3;
            this.buttonDrukuj.Text = "drukuj";
            this.buttonDrukuj.UseVisualStyleBackColor = true;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzukaj.Location = new System.Drawing.Point(226, 17);
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
            this.groupBoxSzukaj.Location = new System.Drawing.Point(838, 74);
            this.groupBoxSzukaj.Name = "groupBoxSzukaj";
            this.groupBoxSzukaj.Size = new System.Drawing.Size(339, 71);
            this.groupBoxSzukaj.TabIndex = 5;
            this.groupBoxSzukaj.TabStop = false;
            this.groupBoxSzukaj.Text = "szukaj po polach";
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukaj.Location = new System.Drawing.Point(18, 22);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(172, 22);
            this.textBoxSzukaj.TabIndex = 5;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 686);
            this.Controls.Add(this.groupBoxSzukaj);
            this.Controls.Add(this.buttonDrukuj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxNaglowek);
            this.Name = "StartWindow";
            this.Text = "StartWindow zmienione";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            this.groupBoxNaglowek.ResumeLayout(false);
            this.groupBoxNaglowek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSzukaj.ResumeLayout(false);
            this.groupBoxSzukaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNaglowek;
        private System.Windows.Forms.Label labelNaglowek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDrukuj;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.GroupBox groupBoxSzukaj;
        private System.Windows.Forms.TextBox textBoxSzukaj;
    }
}

