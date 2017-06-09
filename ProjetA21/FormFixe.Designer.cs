namespace ProjetA21
{
    partial class FormFixe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFixe));
            this.dtg_AperçuFixe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AperçuFixe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_AperçuFixe
            // 
            this.dtg_AperçuFixe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AperçuFixe.Location = new System.Drawing.Point(24, 12);
            this.dtg_AperçuFixe.Name = "dtg_AperçuFixe";
            this.dtg_AperçuFixe.Size = new System.Drawing.Size(625, 248);
            this.dtg_AperçuFixe.TabIndex = 0;
            
            // 
            // FormFixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 261);
            this.Controls.Add(this.dtg_AperçuFixe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFixe";
            this.Text = "FormFixe";
            this.Load += new System.EventHandler(this.FormFixe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AperçuFixe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_AperçuFixe;
    }
}