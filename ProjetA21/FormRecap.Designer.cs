using System;
using System.Windows.Forms;

namespace Projet
{
    partial class FormRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecap));
            this.dgvPrevisionnelAnnuel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisionnelAnnuel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrevisionnelAnnuel
            // 
            this.dgvPrevisionnelAnnuel.AllowUserToResizeColumns = false;
            this.dgvPrevisionnelAnnuel.AllowUserToResizeRows = false;
            this.dgvPrevisionnelAnnuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrevisionnelAnnuel.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrevisionnelAnnuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevisionnelAnnuel.Location = new System.Drawing.Point(3, 0);
            this.dgvPrevisionnelAnnuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrevisionnelAnnuel.Name = "dgvPrevisionnelAnnuel";
            this.dgvPrevisionnelAnnuel.Size = new System.Drawing.Size(1396, 549);
            this.dgvPrevisionnelAnnuel.TabIndex = 0;
            this.dgvPrevisionnelAnnuel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevisionnelAnnuel_CellContentClick);
            // 
            // FormRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 564);
            this.Controls.Add(this.dgvPrevisionnelAnnuel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRecap";
            this.Text = "FormRecap";
            this.Load += new System.EventHandler(this.FormRecap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisionnelAnnuel)).EndInit();
            this.ResumeLayout(false);

        }



        private void dgvPrevisionnelAnnuel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrevisionnelAnnuel;
    }
}