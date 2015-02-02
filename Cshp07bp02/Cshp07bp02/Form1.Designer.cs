namespace Cshp07bp02
{
    partial class Form1
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
            this.buttonKopieren = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelQuelle = new System.Windows.Forms.Label();
            this.labelZiel = new System.Windows.Forms.Label();
            this.quelleCombo = new System.Windows.Forms.ComboBox();
            this.zielList = new System.Windows.Forms.ListBox();
            this.einblendenBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonKopieren
            // 
            this.buttonKopieren.Location = new System.Drawing.Point(12, 145);
            this.buttonKopieren.Name = "buttonKopieren";
            this.buttonKopieren.Size = new System.Drawing.Size(113, 23);
            this.buttonKopieren.TabIndex = 0;
            this.buttonKopieren.Text = "Kopieren";
            this.buttonKopieren.UseVisualStyleBackColor = true;
            this.buttonKopieren.Click += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(159, 145);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(113, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // labelQuelle
            // 
            this.labelQuelle.AutoSize = true;
            this.labelQuelle.Location = new System.Drawing.Point(12, 9);
            this.labelQuelle.Name = "labelQuelle";
            this.labelQuelle.Size = new System.Drawing.Size(37, 13);
            this.labelQuelle.TabIndex = 2;
            this.labelQuelle.Text = "Quelle";
            this.labelQuelle.DoubleClick += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // labelZiel
            // 
            this.labelZiel.AutoSize = true;
            this.labelZiel.Location = new System.Drawing.Point(172, 9);
            this.labelZiel.Name = "labelZiel";
            this.labelZiel.Size = new System.Drawing.Size(24, 13);
            this.labelZiel.TabIndex = 3;
            this.labelZiel.Text = "Ziel";
            this.labelZiel.DoubleClick += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // quelleCombo
            // 
            this.quelleCombo.FormattingEnabled = true;
            this.quelleCombo.Items.AddRange(new object[] {
            "Quelle 1",
            "Quelle 2",
            "Quelle 3",
            "Quelle 4",
            "Quelle 5"});
            this.quelleCombo.Location = new System.Drawing.Point(15, 34);
            this.quelleCombo.Name = "quelleCombo";
            this.quelleCombo.Size = new System.Drawing.Size(113, 21);
            this.quelleCombo.TabIndex = 4;
            this.quelleCombo.SelectedValueChanged += new System.EventHandler(this.quelleCombo_SelectedValueChanged);
            // 
            // zielList
            // 
            this.zielList.FormattingEnabled = true;
            this.zielList.Items.AddRange(new object[] {
            "Ziel 1",
            "Ziel 2",
            "Ziel 3",
            "Ziel 4",
            "Ziel 5",
            "Ziel 6"});
            this.zielList.Location = new System.Drawing.Point(159, 33);
            this.zielList.Name = "zielList";
            this.zielList.Size = new System.Drawing.Size(113, 95);
            this.zielList.TabIndex = 5;
            this.zielList.SelectedValueChanged += new System.EventHandler(this.zielList_SelectedValueChanged);
            // 
            // einblendenBox
            // 
            this.einblendenBox.AutoSize = true;
            this.einblendenBox.Checked = true;
            this.einblendenBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.einblendenBox.Location = new System.Drawing.Point(15, 111);
            this.einblendenBox.Name = "einblendenBox";
            this.einblendenBox.Size = new System.Drawing.Size(79, 17);
            this.einblendenBox.TabIndex = 6;
            this.einblendenBox.Text = "Einblenden";
            this.einblendenBox.UseVisualStyleBackColor = true;
            this.einblendenBox.CheckedChanged += new System.EventHandler(this.einblendenBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.einblendenBox);
            this.Controls.Add(this.zielList);
            this.Controls.Add(this.quelleCombo);
            this.Controls.Add(this.labelZiel);
            this.Controls.Add(this.labelQuelle);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonKopieren);
            this.Name = "Form1";
            this.Text = "Spielereien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKopieren;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label labelQuelle;
        private System.Windows.Forms.Label labelZiel;
        private System.Windows.Forms.ComboBox quelleCombo;
        private System.Windows.Forms.ListBox zielList;
        private System.Windows.Forms.CheckBox einblendenBox;
    }
}

