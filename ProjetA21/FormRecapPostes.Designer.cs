namespace ProjetA21
{
    partial class FormRecapPostes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecapPostes));
            this.tabControlRecapPostes = new System.Windows.Forms.TabControl();
            this.tabPageRecapFixes = new System.Windows.Forms.TabPage();
            this.dataGridViewRecapFixes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRecapPonctuel = new System.Windows.Forms.TabPage();
            this.dataGridViewRecapPonctuel = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRecapRevenu = new System.Windows.Forms.TabPage();
            this.dataGridViewRecapRevenu = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlRecapPostes.SuspendLayout();
            this.tabPageRecapFixes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapFixes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageRecapPonctuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapPonctuel)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPageRecapRevenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapRevenu)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRecapPostes
            // 
            this.tabControlRecapPostes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlRecapPostes.Controls.Add(this.tabPageRecapFixes);
            this.tabControlRecapPostes.Controls.Add(this.tabPageRecapPonctuel);
            this.tabControlRecapPostes.Controls.Add(this.tabPageRecapRevenu);
            this.tabControlRecapPostes.Location = new System.Drawing.Point(12, 12);
            this.tabControlRecapPostes.Name = "tabControlRecapPostes";
            this.tabControlRecapPostes.SelectedIndex = 0;
            this.tabControlRecapPostes.Size = new System.Drawing.Size(833, 608);
            this.tabControlRecapPostes.TabIndex = 0;
            // 
            // tabPageRecapFixes
            // 
            this.tabPageRecapFixes.Controls.Add(this.dataGridViewRecapFixes);
            this.tabPageRecapFixes.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecapFixes.Name = "tabPageRecapFixes";
            this.tabPageRecapFixes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecapFixes.Size = new System.Drawing.Size(825, 579);
            this.tabPageRecapFixes.TabIndex = 0;
            this.tabPageRecapFixes.Text = "Postes fixes";
            this.tabPageRecapFixes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecapFixes
            // 
            this.dataGridViewRecapFixes.AllowUserToResizeColumns = false;
            this.dataGridViewRecapFixes.AllowUserToResizeRows = false;
            this.dataGridViewRecapFixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecapFixes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecapFixes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecapFixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecapFixes.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewRecapFixes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRecapFixes.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewRecapFixes.Name = "dataGridViewRecapFixes";
            this.dataGridViewRecapFixes.ReadOnly = true;
            this.dataGridViewRecapFixes.RowTemplate.Height = 24;
            this.dataGridViewRecapFixes.Size = new System.Drawing.Size(812, 566);
            this.dataGridViewRecapFixes.TabIndex = 0;
            this.dataGridViewRecapFixes.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecapFixes_CellMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 52);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // tabPageRecapPonctuel
            // 
            this.tabPageRecapPonctuel.Controls.Add(this.dataGridViewRecapPonctuel);
            this.tabPageRecapPonctuel.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecapPonctuel.Name = "tabPageRecapPonctuel";
            this.tabPageRecapPonctuel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecapPonctuel.Size = new System.Drawing.Size(825, 579);
            this.tabPageRecapPonctuel.TabIndex = 1;
            this.tabPageRecapPonctuel.Text = "Poste ponctuel";
            this.tabPageRecapPonctuel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecapPonctuel
            // 
            this.dataGridViewRecapPonctuel.AllowUserToResizeColumns = false;
            this.dataGridViewRecapPonctuel.AllowUserToResizeRows = false;
            this.dataGridViewRecapPonctuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecapPonctuel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecapPonctuel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecapPonctuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecapPonctuel.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridViewRecapPonctuel.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewRecapPonctuel.Name = "dataGridViewRecapPonctuel";
            this.dataGridViewRecapPonctuel.ReadOnly = true;
            this.dataGridViewRecapPonctuel.RowTemplate.Height = 24;
            this.dataGridViewRecapPonctuel.Size = new System.Drawing.Size(812, 569);
            this.dataGridViewRecapPonctuel.TabIndex = 0;
            this.dataGridViewRecapPonctuel.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecapFixes_CellMouseEnter);
            this.dataGridViewRecapPonctuel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRecapPonctuel_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 52);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // tabPageRecapRevenu
            // 
            this.tabPageRecapRevenu.Controls.Add(this.dataGridViewRecapRevenu);
            this.tabPageRecapRevenu.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecapRevenu.Name = "tabPageRecapRevenu";
            this.tabPageRecapRevenu.Size = new System.Drawing.Size(825, 579);
            this.tabPageRecapRevenu.TabIndex = 2;
            this.tabPageRecapRevenu.Text = "Revenu";
            this.tabPageRecapRevenu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecapRevenu
            // 
            this.dataGridViewRecapRevenu.AllowUserToResizeColumns = false;
            this.dataGridViewRecapRevenu.AllowUserToResizeRows = false;
            this.dataGridViewRecapRevenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecapRevenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecapRevenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecapRevenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecapRevenu.ContextMenuStrip = this.contextMenuStrip3;
            this.dataGridViewRecapRevenu.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewRecapRevenu.Name = "dataGridViewRecapRevenu";
            this.dataGridViewRecapRevenu.ReadOnly = true;
            this.dataGridViewRecapRevenu.RowTemplate.Height = 24;
            this.dataGridViewRecapRevenu.Size = new System.Drawing.Size(818, 572);
            this.dataGridViewRecapRevenu.TabIndex = 0;
            this.dataGridViewRecapRevenu.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecapFixes_CellMouseEnter);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem2,
            this.supprimerToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(148, 52);
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            this.modifierToolStripMenuItem2.Click += new System.EventHandler(this.modifierToolStripMenuItem2_Click);
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            this.supprimerToolStripMenuItem2.Click += new System.EventHandler(this.supprimerToolStripMenuItem2_Click);
            // 
            // FormRecapPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 632);
            this.Controls.Add(this.tabControlRecapPostes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRecapPostes";
            this.Text = "Tableau de bord des postes";
            this.Load += new System.EventHandler(this.FormRecapPostes_Load);
            this.tabControlRecapPostes.ResumeLayout(false);
            this.tabPageRecapFixes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapFixes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageRecapPonctuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapPonctuel)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPageRecapRevenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecapRevenu)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRecapPostes;
        private System.Windows.Forms.TabPage tabPageRecapFixes;
        private System.Windows.Forms.TabPage tabPageRecapPonctuel;
        private System.Windows.Forms.TabPage tabPageRecapRevenu;
        private System.Windows.Forms.DataGridView dataGridViewRecapFixes;
        private System.Windows.Forms.DataGridView dataGridViewRecapPonctuel;
        private System.Windows.Forms.DataGridView dataGridViewRecapRevenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
    }
}