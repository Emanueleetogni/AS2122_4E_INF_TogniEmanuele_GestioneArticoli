
namespace AS2122_4E_INF_TogniEmanuele_GestioneArticoli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbUnitaDiMisura = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unità di misura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezzo";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(168, 40);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(121, 23);
            this.txtCodice.TabIndex = 4;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(168, 83);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(121, 23);
            this.txtDescrizione.TabIndex = 5;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(168, 169);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(121, 23);
            this.txtPrezzo.TabIndex = 6;
            // 
            // cmbUnitaDiMisura
            // 
            this.cmbUnitaDiMisura.FormattingEnabled = true;
            this.cmbUnitaDiMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnitaDiMisura.Location = new System.Drawing.Point(168, 123);
            this.cmbUnitaDiMisura.Name = "cmbUnitaDiMisura";
            this.cmbUnitaDiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaDiMisura.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUnitaDiMisura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 290);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli articolo";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(91, 215);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(177, 54);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbScelta
            // 
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Items.AddRange(new object[] {
            "Visualizza articoli"});
            this.cmbScelta.Location = new System.Drawing.Point(403, 32);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(251, 23);
            this.cmbScelta.TabIndex = 9;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(686, 32);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 10;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(403, 64);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(358, 274);
            this.lstVisualizza.TabIndex = 11;
            this.lstVisualizza.SelectedIndexChanged += new System.EventHandler(this.lstVisualizza_SelectedIndexChanged_1);
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(65, 323);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(56, 15);
            this.lblArticoli.TabIndex = 12;
            this.lblArticoli.Text = "Articoli ()";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TogniEmanuele; Lab 2.2 4E ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.ComboBox cmbUnitaDiMisura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbScelta;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.ListBox lstVisualizza;
        private System.Windows.Forms.Label lblArticoli;
    }
}

