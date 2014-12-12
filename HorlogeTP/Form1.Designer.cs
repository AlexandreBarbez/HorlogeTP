namespace HorlogeTP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(397, 188);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(65, 20);
            this.lblDateHeure.TabIndex = 0;
            this.lblDateHeure.Text = "Horloge";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHeure);
            this.groupBox1.Controls.Add(this.rbtnDate);
            this.groupBox1.Controls.Add(this.rbtnDateHeure);
            this.groupBox1.Location = new System.Drawing.Point(209, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(54, 46);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(113, 24);
            this.rbtnDateHeure.TabIndex = 0;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "DateHeure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            this.rbtnDateHeure.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(258, 45);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(69, 24);
            this.rbtnDate.TabIndex = 1;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDate_CheckedChanged);
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(404, 45);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(78, 24);
            this.rbtnHeure.TabIndex = 2;
            this.rbtnHeure.TabStop = true;
            this.rbtnHeure.Text = "Heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            this.rbtnHeure.CheckedChanged += new System.EventHandler(this.rbtnHeure_CheckedChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1037, 339);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(115, 41);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 410);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDateHeure);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.Button btnQuitter;
    }
}

