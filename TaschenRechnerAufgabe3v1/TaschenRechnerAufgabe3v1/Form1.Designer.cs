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
            this.boxGroupRechenoperation = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplikation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraktion = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.boxGroupRechenoperation.SuspendLayout();
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
            this.buttonBeenden.Location = new System.Drawing.Point(260, 125);
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
            // boxGroupRechenoperation
            // 
            this.boxGroupRechenoperation.Controls.Add(this.radioButtonMultiplikation);
            this.boxGroupRechenoperation.Controls.Add(this.radioButtonDivision);
            this.boxGroupRechenoperation.Controls.Add(this.radioButtonSubtraktion);
            this.boxGroupRechenoperation.Controls.Add(this.radioButtonAddition);
            this.boxGroupRechenoperation.Location = new System.Drawing.Point(249, 12);
            this.boxGroupRechenoperation.Name = "boxGroupRechenoperation";
            this.boxGroupRechenoperation.Size = new System.Drawing.Size(123, 107);
            this.boxGroupRechenoperation.TabIndex = 2;
            this.boxGroupRechenoperation.TabStop = false;
            this.boxGroupRechenoperation.Text = "Rechenoperation";
            // 
            // radioButtonMultiplikation
            // 
            this.radioButtonMultiplikation.AutoSize = true;
            this.radioButtonMultiplikation.Location = new System.Drawing.Point(7, 88);
            this.radioButtonMultiplikation.Name = "radioButtonMultiplikation";
            this.radioButtonMultiplikation.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMultiplikation.TabIndex = 3;
            this.radioButtonMultiplikation.TabStop = true;
            this.radioButtonMultiplikation.Text = "Multiplikation";
            this.radioButtonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(7, 65);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDivision.TabIndex = 2;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraktion
            // 
            this.radioButtonSubtraktion.AutoSize = true;
            this.radioButtonSubtraktion.Location = new System.Drawing.Point(7, 42);
            this.radioButtonSubtraktion.Name = "radioButtonSubtraktion";
            this.radioButtonSubtraktion.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSubtraktion.TabIndex = 1;
            this.radioButtonSubtraktion.TabStop = true;
            this.radioButtonSubtraktion.Text = "Subtraktion";
            this.radioButtonSubtraktion.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Checked = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(7, 19);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Addition";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 160);
            this.Controls.Add(this.boxGroupRechenoperation);
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
            this.boxGroupRechenoperation.ResumeLayout(false);
            this.boxGroupRechenoperation.PerformLayout();
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
        private System.Windows.Forms.GroupBox boxGroupRechenoperation;
        private System.Windows.Forms.RadioButton radioButtonMultiplikation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonSubtraktion;
        private System.Windows.Forms.RadioButton radioButtonAddition;
    }
}

