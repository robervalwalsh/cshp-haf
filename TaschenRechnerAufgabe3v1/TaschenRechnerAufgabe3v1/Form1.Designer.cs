namespace TaschenRechnerAufgabe3v1
{
    partial class Taschenrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBerechen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.comboBoxRechnenoperation = new System.Windows.Forms.ComboBox();
            this.labelRechnenoperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBerechen
            // 
            this.buttonBerechen.Location = new System.Drawing.Point(13, 125);
            this.buttonBerechen.Name = "buttonBerechen";
            this.buttonBerechen.Size = new System.Drawing.Size(100, 23);
            this.buttonBerechen.TabIndex = 3;
            this.buttonBerechen.Text = "Berechen";
            this.buttonBerechen.UseVisualStyleBackColor = true;
            this.buttonBerechen.Click += new System.EventHandler(this.buttonBerechen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(250, 125);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(100, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.Location = new System.Drawing.Point(13, 106);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(51, 13);
            this.labelBeschreibung.TabIndex = 3;
            this.labelBeschreibung.Text = "Ergebnis:";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(70, 106);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 3;
            this.labelAnzeige.Text = "0";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(12, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.Text = "0";
            this.textBoxZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(12, 38);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.Text = "0";
            this.textBoxZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxRechnenoperation
            // 
            this.comboBoxRechnenoperation.FormattingEnabled = true;
            this.comboBoxRechnenoperation.Items.AddRange(new object[] {
            "Addition",
            "Subtraktion",
            "Division",
            "Multiplikation"});
            this.comboBoxRechnenoperation.Location = new System.Drawing.Point(250, 25);
            this.comboBoxRechnenoperation.Name = "comboBoxRechnenoperation";
            this.comboBoxRechnenoperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRechnenoperation.TabIndex = 5;
            this.comboBoxRechnenoperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxRechnenoperation_SelectedIndexChanged);
            // 
            // labelRechnenoperation
            // 
            this.labelRechnenoperation.AutoSize = true;
            this.labelRechnenoperation.Location = new System.Drawing.Point(248, 9);
            this.labelRechnenoperation.Name = "labelRechnenoperation";
            this.labelRechnenoperation.Size = new System.Drawing.Size(95, 13);
            this.labelRechnenoperation.TabIndex = 6;
            this.labelRechnenoperation.Text = "Rechnenoperation";
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 160);
            this.Controls.Add(this.labelRechnenoperation);
            this.Controls.Add(this.comboBoxRechnenoperation);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Taschenrechner";
            this.Text = "Ein einfacher Taschenrechner";
            this.Load += new System.EventHandler(this.Taschenrechner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerechen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.ComboBox comboBoxRechnenoperation;
        private System.Windows.Forms.Label labelRechnenoperation;
    }
}

