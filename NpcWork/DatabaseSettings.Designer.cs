namespace NpcWork
{
    partial class DatabaseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettings));
            this.label1 = new System.Windows.Forms.Label();
            this._dbSettingsHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._dbSettingsUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._dbSettingsPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._dbSettingsDBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // _dbSettingsHost
            // 
            this._dbSettingsHost.Location = new System.Drawing.Point(14, 25);
            this._dbSettingsHost.Name = "_dbSettingsHost";
            this._dbSettingsHost.Size = new System.Drawing.Size(206, 20);
            this._dbSettingsHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // _dbSettingsUserName
            // 
            this._dbSettingsUserName.Location = new System.Drawing.Point(14, 64);
            this._dbSettingsUserName.Name = "_dbSettingsUserName";
            this._dbSettingsUserName.Size = new System.Drawing.Size(206, 20);
            this._dbSettingsUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // _dbSettingsPassword
            // 
            this._dbSettingsPassword.Location = new System.Drawing.Point(14, 103);
            this._dbSettingsPassword.Name = "_dbSettingsPassword";
            this._dbSettingsPassword.Size = new System.Drawing.Size(206, 20);
            this._dbSettingsPassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DBSaveSettingsClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // _dbSettingsDBName
            // 
            this._dbSettingsDBName.Location = new System.Drawing.Point(14, 142);
            this._dbSettingsDBName.Name = "_dbSettingsDBName";
            this._dbSettingsDBName.Size = new System.Drawing.Size(206, 20);
            this._dbSettingsDBName.TabIndex = 8;
            // 
            // DatabaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 208);
            this.Controls.Add(this._dbSettingsDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._dbSettingsPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._dbSettingsUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dbSettingsHost);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseSettings";
            this.Text = "DatabaseSettings";
            this.Load += new System.EventHandler(this.DatabaseSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _dbSettingsHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _dbSettingsUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _dbSettingsPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _dbSettingsDBName;
    }
}