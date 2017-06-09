using System;
using System.Drawing;

namespace ProjetA21
{
    partial class FormBudgestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBudgestion));
            this.typeTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget1DataSet = new ProjetA21.budget1DataSet();
            this.lbl_type = new System.Windows.Forms.Label();
            this.chBox1 = new System.Windows.Forms.CheckBox();
            this.chBox2 = new System.Windows.Forms.CheckBox();
            this.txtBox_montant = new System.Windows.Forms.TextBox();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.lbl1_description = new System.Windows.Forms.Label();
            this.lbl_montant = new System.Windows.Forms.Label();
            this.dateDepense = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.typeTransactionTableAdapter = new ProjetA21.budget1DataSetTableAdapters.TypeTransactionTableAdapter();
            this.tabControlEnfant = new System.Windows.Forms.TabControl();
            this.tabPage1a1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1a1Montant = new System.Windows.Forms.Label();
            this.label1a1Type = new System.Windows.Forms.Label();
            this.label1a1NumDesc = new System.Windows.Forms.Label();
            this.label1a1Num = new System.Windows.Forms.Label();
            this.button1a1_7 = new System.Windows.Forms.Button();
            this.button1a1_3 = new System.Windows.Forms.Button();
            this.button1a1_2 = new System.Windows.Forms.Button();
            this.button1a1_1 = new System.Windows.Forms.Button();
            this.checkBox1a1percu = new System.Windows.Forms.CheckBox();
            this.checkBox1a1recette = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1a1 = new System.Windows.Forms.DateTimePicker();
            this.tabPageAjout = new System.Windows.Forms.TabPage();
            this.buttonAjoutAutreType = new System.Windows.Forms.Button();
            this.labelEuro = new System.Windows.Forms.Label();
            this.gbParticipant = new System.Windows.Forms.GroupBox();
            this.cbpTypeTransa = new System.Windows.Forms.ComboBox();
            this.buttonAjoutTransactionAjouter = new System.Windows.Forms.Button();
            this.tabPageRecap = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelRecapAu = new System.Windows.Forms.Label();
            this.labelRecapDu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.budget1DataSet1 = new ProjetA21.budget1DataSet();
            this.tabControlParent = new System.Windows.Forms.TabControl();
            this.tabPageBudgetMois = new System.Windows.Forms.TabPage();
            this.tabPageBudgetPrevisio = new System.Windows.Forms.TabPage();
            this.tabControlEnfantPrevisio = new System.Windows.Forms.TabControl();
            this.tabPagePosteFixe = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonPosteFixeValider = new System.Windows.Forms.Button();
            this.buttonPosteFixeAutre = new System.Windows.Forms.Button();
            this.textBoxPosteFixeMontant = new System.Windows.Forms.TextBox();
            this.textBoxPosteFixeJour = new System.Windows.Forms.TextBox();
            this.comboBoxPosteFixePeriodicite = new System.Windows.Forms.ComboBox();
            this.comboBoxPosteFixePoste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePostePonctuel = new System.Windows.Forms.TabPage();
            this.panelPostePonctuel = new System.Windows.Forms.Panel();
            this.groupBoxPostePonctuel = new System.Windows.Forms.GroupBox();
            this.buttonPostePonctuelValider = new System.Windows.Forms.Button();
            this.textBoxPostePonctuelNbPrelevements = new System.Windows.Forms.TextBox();
            this.textBoxPostePonctuelCommentaire = new System.Windows.Forms.TextBox();
            this.textBoxPostePonctuelIntitule = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageRevenu = new System.Windows.Forms.TabPage();
            this.buttonRevenuAutre = new System.Windows.Forms.Button();
            this.comboBoxRevenuPoste = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonRevenuValider = new System.Windows.Forms.Button();
            this.comboBoxRevenuBeneficiaire = new System.Windows.Forms.ComboBox();
            this.textBoxRevenuJour = new System.Windows.Forms.TextBox();
            this.textBoxRevenuMontant = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonOptionAjouter = new System.Windows.Forms.Button();
            this.textBoxUsrPrenom = new System.Windows.Forms.TextBox();
            this.textBoxUsrNom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxUsrNumero = new System.Windows.Forms.TextBox();
            this.labelOptionsNum = new System.Windows.Forms.Label();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetDuMoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetPrevisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierPrevisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recapPostesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficiairesTableAdapter1 = new ProjetA21.budget1DataSetTableAdapters.BeneficiairesTableAdapter();
            this.labelTitre = new System.Windows.Forms.Label();
            this.personneTableAdapter = new ProjetA21.budget1DataSetTableAdapters.PersonneTableAdapter();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.transactionTableAdapter = new ProjetA21.budget1DataSetTableAdapters.TransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet)).BeginInit();
            this.tabControlEnfant.SuspendLayout();
            this.tabPage1a1.SuspendLayout();
            this.tabPageAjout.SuspendLayout();
            this.tabPageRecap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet1)).BeginInit();
            this.tabControlParent.SuspendLayout();
            this.tabPageBudgetMois.SuspendLayout();
            this.tabPageBudgetPrevisio.SuspendLayout();
            this.tabControlEnfantPrevisio.SuspendLayout();
            this.tabPagePosteFixe.SuspendLayout();
            this.tabPagePostePonctuel.SuspendLayout();
            this.panelPostePonctuel.SuspendLayout();
            this.tabPageRevenu.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeTransactionBindingSource
            // 
            this.typeTransactionBindingSource.DataMember = "TypeTransaction";
            this.typeTransactionBindingSource.DataSource = this.budget1DataSet;
            // 
            // budget1DataSet
            // 
            this.budget1DataSet.DataSetName = "budget1DataSet";
            this.budget1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(69, 320);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(51, 17);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "Type : ";
            this.lbl_type.Click += new System.EventHandler(this.lbl_type_Click);
            // 
            // chBox1
            // 
            this.chBox1.AutoSize = true;
            this.chBox1.Location = new System.Drawing.Point(228, 228);
            this.chBox1.Margin = new System.Windows.Forms.Padding(4);
            this.chBox1.Name = "chBox1";
            this.chBox1.Size = new System.Drawing.Size(81, 21);
            this.chBox1.TabIndex = 2;
            this.chBox1.Text = "Recette";
            this.chBox1.UseVisualStyleBackColor = true;
            this.chBox1.CheckedChanged += new System.EventHandler(this.chBox1_CheckedChanged);
            // 
            // chBox2
            // 
            this.chBox2.AutoSize = true;
            this.chBox2.Location = new System.Drawing.Point(228, 257);
            this.chBox2.Margin = new System.Windows.Forms.Padding(4);
            this.chBox2.Name = "chBox2";
            this.chBox2.Size = new System.Drawing.Size(69, 21);
            this.chBox2.TabIndex = 3;
            this.chBox2.Text = "Perçu";
            this.chBox2.UseVisualStyleBackColor = true;
            this.chBox2.CheckedChanged += new System.EventHandler(this.chBox2_CheckedChanged);
            // 
            // txtBox_montant
            // 
            this.txtBox_montant.Location = new System.Drawing.Point(228, 165);
            this.txtBox_montant.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_montant.Name = "txtBox_montant";
            this.txtBox_montant.Size = new System.Drawing.Size(249, 25);
            this.txtBox_montant.TabIndex = 4;
            this.txtBox_montant.TextChanged += new System.EventHandler(this.txtBox_montant_TextChanged);
            this.txtBox_montant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_montant_KeyPress);
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(228, 111);
            this.txtBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(249, 25);
            this.txtBox_description.TabIndex = 5;
            this.txtBox_description.TextChanged += new System.EventHandler(this.txtBox_description_TextChanged);
            this.txtBox_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_description_KeyPress);
            // 
            // lbl1_description
            // 
            this.lbl1_description.AutoSize = true;
            this.lbl1_description.Location = new System.Drawing.Point(69, 114);
            this.lbl1_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1_description.Name = "lbl1_description";
            this.lbl1_description.Size = new System.Drawing.Size(86, 17);
            this.lbl1_description.TabIndex = 6;
            this.lbl1_description.Text = "Description:";
            this.lbl1_description.Click += new System.EventHandler(this.lbl1_description_Click);
            // 
            // lbl_montant
            // 
            this.lbl_montant.AutoSize = true;
            this.lbl_montant.Location = new System.Drawing.Point(69, 165);
            this.lbl_montant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_montant.Name = "lbl_montant";
            this.lbl_montant.Size = new System.Drawing.Size(63, 17);
            this.lbl_montant.TabIndex = 7;
            this.lbl_montant.Text = "Montant:";
            this.lbl_montant.Click += new System.EventHandler(this.lbl_montant_Click);
            // 
            // dateDepense
            // 
            this.dateDepense.Location = new System.Drawing.Point(228, 51);
            this.dateDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dateDepense.Name = "dateDepense";
            this.dateDepense.Size = new System.Drawing.Size(249, 25);
            this.dateDepense.TabIndex = 8;
            this.dateDepense.ValueChanged += new System.EventHandler(this.dateDepense_ValueChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(69, 57);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(142, 17);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "Date de la dépense :";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // typeTransactionTableAdapter
            // 
            this.typeTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tabControlEnfant
            // 
            this.tabControlEnfant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEnfant.Controls.Add(this.tabPage1a1);
            this.tabControlEnfant.Controls.Add(this.tabPageAjout);
            this.tabControlEnfant.Controls.Add(this.tabPageRecap);
            this.tabControlEnfant.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEnfant.Location = new System.Drawing.Point(0, 0);
            this.tabControlEnfant.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlEnfant.Name = "tabControlEnfant";
            this.tabControlEnfant.SelectedIndex = 0;
            this.tabControlEnfant.Size = new System.Drawing.Size(1104, 613);
            this.tabControlEnfant.TabIndex = 10;
            // 
            // tabPage1a1
            // 
            this.tabPage1a1.Controls.Add(this.listBox1);
            this.tabPage1a1.Controls.Add(this.label1a1Montant);
            this.tabPage1a1.Controls.Add(this.label1a1Type);
            this.tabPage1a1.Controls.Add(this.label1a1NumDesc);
            this.tabPage1a1.Controls.Add(this.label1a1Num);
            this.tabPage1a1.Controls.Add(this.button1a1_7);
            this.tabPage1a1.Controls.Add(this.button1a1_3);
            this.tabPage1a1.Controls.Add(this.button1a1_2);
            this.tabPage1a1.Controls.Add(this.button1a1_1);
            this.tabPage1a1.Controls.Add(this.checkBox1a1percu);
            this.tabPage1a1.Controls.Add(this.checkBox1a1recette);
            this.tabPage1a1.Controls.Add(this.dateTimePicker1a1);
            this.tabPage1a1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1a1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1a1.Name = "tabPage1a1";
            this.tabPage1a1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1a1.Size = new System.Drawing.Size(1096, 583);
            this.tabPage1a1.TabIndex = 0;
            this.tabPage1a1.Text = "Affichage 1 à 1";
            this.tabPage1a1.UseVisualStyleBackColor = true;
            this.tabPage1a1.Enter += new System.EventHandler(this.tabPage1a1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(7, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(617, 361);
            this.listBox1.TabIndex = 11;
            // 
            // label1a1Montant
            // 
            this.label1a1Montant.AutoSize = true;
            this.label1a1Montant.Location = new System.Drawing.Point(287, 70);
            this.label1a1Montant.Name = "label1a1Montant";
            this.label1a1Montant.Size = new System.Drawing.Size(54, 17);
            this.label1a1Montant.TabIndex = 10;
            this.label1a1Montant.Text = "label23";
            // 
            // label1a1Type
            // 
            this.label1a1Type.AutoSize = true;
            this.label1a1Type.Location = new System.Drawing.Point(7, 102);
            this.label1a1Type.Name = "label1a1Type";
            this.label1a1Type.Size = new System.Drawing.Size(54, 17);
            this.label1a1Type.TabIndex = 9;
            this.label1a1Type.Text = "label22";
            // 
            // label1a1NumDesc
            // 
            this.label1a1NumDesc.AutoSize = true;
            this.label1a1NumDesc.Location = new System.Drawing.Point(7, 70);
            this.label1a1NumDesc.Name = "label1a1NumDesc";
            this.label1a1NumDesc.Size = new System.Drawing.Size(54, 17);
            this.label1a1NumDesc.TabIndex = 8;
            this.label1a1NumDesc.Text = "label21";
            // 
            // label1a1Num
            // 
            this.label1a1Num.AutoSize = true;
            this.label1a1Num.Location = new System.Drawing.Point(7, 39);
            this.label1a1Num.Name = "label1a1Num";
            this.label1a1Num.Size = new System.Drawing.Size(54, 17);
            this.label1a1Num.TabIndex = 7;
            this.label1a1Num.Text = "label20";
            // 
            // button1a1_7
            // 
            this.button1a1_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1a1_7.Location = new System.Drawing.Point(475, 516);
            this.button1a1_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1a1_7.Name = "button1a1_7";
            this.button1a1_7.Size = new System.Drawing.Size(149, 60);
            this.button1a1_7.TabIndex = 6;
            this.button1a1_7.Text = ">>";
            this.button1a1_7.UseVisualStyleBackColor = true;
            this.button1a1_7.Click += new System.EventHandler(this.button1a1_7_Click);
            // 
            // button1a1_3
            // 
            this.button1a1_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1a1_3.Location = new System.Drawing.Point(319, 516);
            this.button1a1_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1a1_3.Name = "button1a1_3";
            this.button1a1_3.Size = new System.Drawing.Size(149, 60);
            this.button1a1_3.TabIndex = 5;
            this.button1a1_3.Text = ">";
            this.button1a1_3.UseVisualStyleBackColor = true;
            this.button1a1_3.Click += new System.EventHandler(this.button1a1_3_Click);
            // 
            // button1a1_2
            // 
            this.button1a1_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1a1_2.Location = new System.Drawing.Point(163, 516);
            this.button1a1_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1a1_2.Name = "button1a1_2";
            this.button1a1_2.Size = new System.Drawing.Size(149, 60);
            this.button1a1_2.TabIndex = 4;
            this.button1a1_2.Text = "<";
            this.button1a1_2.UseVisualStyleBackColor = true;
            this.button1a1_2.Click += new System.EventHandler(this.button1a1_2_Click);
            // 
            // button1a1_1
            // 
            this.button1a1_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1a1_1.Location = new System.Drawing.Point(7, 516);
            this.button1a1_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1a1_1.Name = "button1a1_1";
            this.button1a1_1.Size = new System.Drawing.Size(149, 60);
            this.button1a1_1.TabIndex = 3;
            this.button1a1_1.Text = "<<";
            this.button1a1_1.UseVisualStyleBackColor = true;
            this.button1a1_1.Click += new System.EventHandler(this.button1a1_1_Click);
            // 
            // checkBox1a1percu
            // 
            this.checkBox1a1percu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1a1percu.AutoCheck = false;
            this.checkBox1a1percu.AutoSize = true;
            this.checkBox1a1percu.Location = new System.Drawing.Point(840, 66);
            this.checkBox1a1percu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1a1percu.Name = "checkBox1a1percu";
            this.checkBox1a1percu.Size = new System.Drawing.Size(69, 21);
            this.checkBox1a1percu.TabIndex = 2;
            this.checkBox1a1percu.Text = "Perçu";
            this.checkBox1a1percu.UseVisualStyleBackColor = true;
            // 
            // checkBox1a1recette
            // 
            this.checkBox1a1recette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1a1recette.AutoCheck = false;
            this.checkBox1a1recette.AutoSize = true;
            this.checkBox1a1recette.Location = new System.Drawing.Point(840, 39);
            this.checkBox1a1recette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1a1recette.Name = "checkBox1a1recette";
            this.checkBox1a1recette.Size = new System.Drawing.Size(81, 21);
            this.checkBox1a1recette.TabIndex = 1;
            this.checkBox1a1recette.Text = "Recette";
            this.checkBox1a1recette.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1a1
            // 
            this.dateTimePicker1a1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1a1.Location = new System.Drawing.Point(840, 7);
            this.dateTimePicker1a1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1a1.Name = "dateTimePicker1a1";
            this.dateTimePicker1a1.Size = new System.Drawing.Size(249, 25);
            this.dateTimePicker1a1.TabIndex = 0;
            this.dateTimePicker1a1.ValueChanged += new System.EventHandler(this.dateTimePicker1a1_ValueChanged);
            // 
            // tabPageAjout
            // 
            this.tabPageAjout.Controls.Add(this.buttonAjoutAutreType);
            this.tabPageAjout.Controls.Add(this.labelEuro);
            this.tabPageAjout.Controls.Add(this.gbParticipant);
            this.tabPageAjout.Controls.Add(this.cbpTypeTransa);
            this.tabPageAjout.Controls.Add(this.buttonAjoutTransactionAjouter);
            this.tabPageAjout.Controls.Add(this.lbl_date);
            this.tabPageAjout.Controls.Add(this.dateDepense);
            this.tabPageAjout.Controls.Add(this.lbl_montant);
            this.tabPageAjout.Controls.Add(this.lbl1_description);
            this.tabPageAjout.Controls.Add(this.txtBox_description);
            this.tabPageAjout.Controls.Add(this.txtBox_montant);
            this.tabPageAjout.Controls.Add(this.chBox2);
            this.tabPageAjout.Controls.Add(this.chBox1);
            this.tabPageAjout.Controls.Add(this.lbl_type);
            this.tabPageAjout.Location = new System.Drawing.Point(4, 26);
            this.tabPageAjout.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAjout.Name = "tabPageAjout";
            this.tabPageAjout.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAjout.Size = new System.Drawing.Size(1096, 583);
            this.tabPageAjout.TabIndex = 1;
            this.tabPageAjout.Text = "Ajout d\'une transaction";
            this.tabPageAjout.UseVisualStyleBackColor = true;
            this.tabPageAjout.Enter += new System.EventHandler(this.tabPageAjout_Enter);
            // 
            // buttonAjoutAutreType
            // 
            this.buttonAjoutAutreType.Location = new System.Drawing.Point(444, 320);
            this.buttonAjoutAutreType.Name = "buttonAjoutAutreType";
            this.buttonAjoutAutreType.Size = new System.Drawing.Size(33, 25);
            this.buttonAjoutAutreType.TabIndex = 14;
            this.buttonAjoutAutreType.Text = "...";
            this.buttonAjoutAutreType.UseVisualStyleBackColor = true;
            this.buttonAjoutAutreType.Click += new System.EventHandler(this.buttonAjoutAutreType_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(484, 168);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(16, 17);
            this.labelEuro.TabIndex = 13;
            this.labelEuro.Text = "€";
            // 
            // gbParticipant
            // 
            this.gbParticipant.Location = new System.Drawing.Point(608, 46);
            this.gbParticipant.Margin = new System.Windows.Forms.Padding(4);
            this.gbParticipant.Name = "gbParticipant";
            this.gbParticipant.Padding = new System.Windows.Forms.Padding(4);
            this.gbParticipant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbParticipant.Size = new System.Drawing.Size(391, 370);
            this.gbParticipant.TabIndex = 12;
            this.gbParticipant.TabStop = false;
            this.gbParticipant.Text = "Participants";
            // 
            // cbpTypeTransa
            // 
            this.cbpTypeTransa.FormattingEnabled = true;
            this.cbpTypeTransa.Location = new System.Drawing.Point(228, 320);
            this.cbpTypeTransa.Margin = new System.Windows.Forms.Padding(4);
            this.cbpTypeTransa.Name = "cbpTypeTransa";
            this.cbpTypeTransa.Size = new System.Drawing.Size(209, 25);
            this.cbpTypeTransa.TabIndex = 11;
            // 
            // buttonAjoutTransactionAjouter
            // 
            this.buttonAjoutTransactionAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjoutTransactionAjouter.Location = new System.Drawing.Point(837, 495);
            this.buttonAjoutTransactionAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjoutTransactionAjouter.Name = "buttonAjoutTransactionAjouter";
            this.buttonAjoutTransactionAjouter.Size = new System.Drawing.Size(251, 80);
            this.buttonAjoutTransactionAjouter.TabIndex = 10;
            this.buttonAjoutTransactionAjouter.Text = "Ajouter";
            this.buttonAjoutTransactionAjouter.UseVisualStyleBackColor = true;
            this.buttonAjoutTransactionAjouter.Click += new System.EventHandler(this.buttonAjoutTransactionAjouter_Click);
            // 
            // tabPageRecap
            // 
            this.tabPageRecap.Controls.Add(this.dateTimePicker2);
            this.tabPageRecap.Controls.Add(this.dateTimePicker1);
            this.tabPageRecap.Controls.Add(this.labelRecapAu);
            this.tabPageRecap.Controls.Add(this.labelRecapDu);
            this.tabPageRecap.Controls.Add(this.button3);
            this.tabPageRecap.Controls.Add(this.dataGridView1);
            this.tabPageRecap.Location = new System.Drawing.Point(4, 26);
            this.tabPageRecap.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRecap.Name = "tabPageRecap";
            this.tabPageRecap.Size = new System.Drawing.Size(1096, 583);
            this.tabPageRecap.TabIndex = 4;
            this.tabPageRecap.Text = "Récapitulatif";
            this.tabPageRecap.UseVisualStyleBackColor = true;
            this.tabPageRecap.Enter += new System.EventHandler(this.tabPageRecap_Enter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Location = new System.Drawing.Point(358, 521);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 521);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelRecapAu
            // 
            this.labelRecapAu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecapAu.AutoSize = true;
            this.labelRecapAu.Location = new System.Drawing.Point(323, 527);
            this.labelRecapAu.Name = "labelRecapAu";
            this.labelRecapAu.Size = new System.Drawing.Size(29, 17);
            this.labelRecapAu.TabIndex = 5;
            this.labelRecapAu.Text = "Au:";
            // 
            // labelRecapDu
            // 
            this.labelRecapDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRecapDu.AutoSize = true;
            this.labelRecapDu.Location = new System.Drawing.Point(4, 527);
            this.labelRecapDu.Name = "labelRecapDu";
            this.labelRecapDu.Size = new System.Drawing.Size(82, 17);
            this.labelRecapDu.TabIndex = 2;
            this.labelRecapDu.Text = "Période du:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(941, 518);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 60);
            this.button3.TabIndex = 1;
            this.button3.Text = "Creer PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 514);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecapFixes_CellMouseEnter);
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
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.budget1DataSetBindingSource;
            // 
            // budget1DataSetBindingSource
            // 
            this.budget1DataSetBindingSource.DataSource = this.budget1DataSet;
            this.budget1DataSetBindingSource.Position = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1079, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 26);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // budget1DataSet1
            // 
            this.budget1DataSet1.DataSetName = "budget1DataSet";
            this.budget1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControlParent
            // 
            this.tabControlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlParent.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlParent.Controls.Add(this.tabPageBudgetMois);
            this.tabControlParent.Controls.Add(this.tabPageBudgetPrevisio);
            this.tabControlParent.Controls.Add(this.tabPageOptions);
            this.tabControlParent.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlParent.Location = new System.Drawing.Point(0, 32);
            this.tabControlParent.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlParent.Name = "tabControlParent";
            this.tabControlParent.SelectedIndex = 0;
            this.tabControlParent.Size = new System.Drawing.Size(1112, 622);
            this.tabControlParent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlParent.TabIndex = 11;
            // 
            // tabPageBudgetMois
            // 
            this.tabPageBudgetMois.Controls.Add(this.tabControlEnfant);
            this.tabPageBudgetMois.Location = new System.Drawing.Point(4, 5);
            this.tabPageBudgetMois.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBudgetMois.Name = "tabPageBudgetMois";
            this.tabPageBudgetMois.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageBudgetMois.Size = new System.Drawing.Size(1104, 613);
            this.tabPageBudgetMois.TabIndex = 0;
            this.tabPageBudgetMois.Text = "Budget du Mois";
            this.tabPageBudgetMois.UseVisualStyleBackColor = true;
            // 
            // tabPageBudgetPrevisio
            // 
            this.tabPageBudgetPrevisio.Controls.Add(this.tabControlEnfantPrevisio);
            this.tabPageBudgetPrevisio.Location = new System.Drawing.Point(4, 5);
            this.tabPageBudgetPrevisio.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBudgetPrevisio.Name = "tabPageBudgetPrevisio";
            this.tabPageBudgetPrevisio.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageBudgetPrevisio.Size = new System.Drawing.Size(1104, 613);
            this.tabPageBudgetPrevisio.TabIndex = 1;
            this.tabPageBudgetPrevisio.Text = "Budget previsionnel";
            this.tabPageBudgetPrevisio.UseVisualStyleBackColor = true;
            // 
            // tabControlEnfantPrevisio
            // 
            this.tabControlEnfantPrevisio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEnfantPrevisio.Controls.Add(this.tabPagePosteFixe);
            this.tabControlEnfantPrevisio.Controls.Add(this.tabPagePostePonctuel);
            this.tabControlEnfantPrevisio.Controls.Add(this.tabPageRevenu);
            this.tabControlEnfantPrevisio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEnfantPrevisio.Location = new System.Drawing.Point(0, 0);
            this.tabControlEnfantPrevisio.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlEnfantPrevisio.Name = "tabControlEnfantPrevisio";
            this.tabControlEnfantPrevisio.SelectedIndex = 0;
            this.tabControlEnfantPrevisio.Size = new System.Drawing.Size(1104, 613);
            this.tabControlEnfantPrevisio.TabIndex = 0;
            // 
            // tabPagePosteFixe
            // 
            this.tabPagePosteFixe.Controls.Add(this.label18);
            this.tabPagePosteFixe.Controls.Add(this.buttonPosteFixeValider);
            this.tabPagePosteFixe.Controls.Add(this.buttonPosteFixeAutre);
            this.tabPagePosteFixe.Controls.Add(this.textBoxPosteFixeMontant);
            this.tabPagePosteFixe.Controls.Add(this.textBoxPosteFixeJour);
            this.tabPagePosteFixe.Controls.Add(this.comboBoxPosteFixePeriodicite);
            this.tabPagePosteFixe.Controls.Add(this.comboBoxPosteFixePoste);
            this.tabPagePosteFixe.Controls.Add(this.label6);
            this.tabPagePosteFixe.Controls.Add(this.label5);
            this.tabPagePosteFixe.Controls.Add(this.label4);
            this.tabPagePosteFixe.Controls.Add(this.label3);
            this.tabPagePosteFixe.Controls.Add(this.label2);
            this.tabPagePosteFixe.Controls.Add(this.label1);
            this.tabPagePosteFixe.Location = new System.Drawing.Point(4, 26);
            this.tabPagePosteFixe.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePosteFixe.Name = "tabPagePosteFixe";
            this.tabPagePosteFixe.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePosteFixe.Size = new System.Drawing.Size(1096, 583);
            this.tabPagePosteFixe.TabIndex = 0;
            this.tabPagePosteFixe.Text = "Poste fixe";
            this.tabPagePosteFixe.UseVisualStyleBackColor = true;
            this.tabPagePosteFixe.Enter += new System.EventHandler(this.tabPagePosteFixe_Enter_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(269, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "€";
            // 
            // buttonPosteFixeValider
            // 
            this.buttonPosteFixeValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPosteFixeValider.Location = new System.Drawing.Point(839, 497);
            this.buttonPosteFixeValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosteFixeValider.Name = "buttonPosteFixeValider";
            this.buttonPosteFixeValider.Size = new System.Drawing.Size(250, 80);
            this.buttonPosteFixeValider.TabIndex = 12;
            this.buttonPosteFixeValider.Text = "Valider";
            this.buttonPosteFixeValider.UseVisualStyleBackColor = true;
            this.buttonPosteFixeValider.Click += new System.EventHandler(this.buttonPosteFixeValider_Click);
            // 
            // buttonPosteFixeAutre
            // 
            this.buttonPosteFixeAutre.Location = new System.Drawing.Point(497, 11);
            this.buttonPosteFixeAutre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosteFixeAutre.Name = "buttonPosteFixeAutre";
            this.buttonPosteFixeAutre.Size = new System.Drawing.Size(37, 25);
            this.buttonPosteFixeAutre.TabIndex = 11;
            this.buttonPosteFixeAutre.Text = "...";
            this.buttonPosteFixeAutre.UseVisualStyleBackColor = true;
            this.buttonPosteFixeAutre.Click += new System.EventHandler(this.buttonPosteFixeAutre_Click);
            // 
            // textBoxPosteFixeMontant
            // 
            this.textBoxPosteFixeMontant.Location = new System.Drawing.Point(163, 209);
            this.textBoxPosteFixeMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosteFixeMontant.Name = "textBoxPosteFixeMontant";
            this.textBoxPosteFixeMontant.Size = new System.Drawing.Size(100, 25);
            this.textBoxPosteFixeMontant.TabIndex = 10;
            this.textBoxPosteFixeMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPosteFixeMontant_KeyPress);
            // 
            // textBoxPosteFixeJour
            // 
            this.textBoxPosteFixeJour.Location = new System.Drawing.Point(163, 114);
            this.textBoxPosteFixeJour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosteFixeJour.Name = "textBoxPosteFixeJour";
            this.textBoxPosteFixeJour.Size = new System.Drawing.Size(100, 25);
            this.textBoxPosteFixeJour.TabIndex = 9;
            this.textBoxPosteFixeJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPosteFixeJour_KeyPress);
            // 
            // comboBoxPosteFixePeriodicite
            // 
            this.comboBoxPosteFixePeriodicite.FormattingEnabled = true;
            this.comboBoxPosteFixePeriodicite.Location = new System.Drawing.Point(163, 63);
            this.comboBoxPosteFixePeriodicite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPosteFixePeriodicite.Name = "comboBoxPosteFixePeriodicite";
            this.comboBoxPosteFixePeriodicite.Size = new System.Drawing.Size(328, 25);
            this.comboBoxPosteFixePeriodicite.TabIndex = 8;
            // 
            // comboBoxPosteFixePoste
            // 
            this.comboBoxPosteFixePoste.FormattingEnabled = true;
            this.comboBoxPosteFixePoste.Location = new System.Drawing.Point(163, 11);
            this.comboBoxPosteFixePoste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPosteFixePoste.Name = "comboBoxPosteFixePoste";
            this.comboBoxPosteFixePoste.Size = new System.Drawing.Size(328, 25);
            this.comboBoxPosteFixePoste.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Montant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "du mois";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "le";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jour du mois:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Périodicité:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poste:";
            // 
            // tabPagePostePonctuel
            // 
            this.tabPagePostePonctuel.Controls.Add(this.panelPostePonctuel);
            this.tabPagePostePonctuel.Controls.Add(this.buttonPostePonctuelValider);
            this.tabPagePostePonctuel.Controls.Add(this.textBoxPostePonctuelNbPrelevements);
            this.tabPagePostePonctuel.Controls.Add(this.textBoxPostePonctuelCommentaire);
            this.tabPagePostePonctuel.Controls.Add(this.textBoxPostePonctuelIntitule);
            this.tabPagePostePonctuel.Controls.Add(this.label9);
            this.tabPagePostePonctuel.Controls.Add(this.label8);
            this.tabPagePostePonctuel.Controls.Add(this.label7);
            this.tabPagePostePonctuel.Location = new System.Drawing.Point(4, 26);
            this.tabPagePostePonctuel.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePostePonctuel.Name = "tabPagePostePonctuel";
            this.tabPagePostePonctuel.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePostePonctuel.Size = new System.Drawing.Size(1096, 583);
            this.tabPagePostePonctuel.TabIndex = 1;
            this.tabPagePostePonctuel.Text = "Poste ponctuel";
            this.tabPagePostePonctuel.UseVisualStyleBackColor = true;
            // 
            // panelPostePonctuel
            // 
            this.panelPostePonctuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPostePonctuel.AutoScroll = true;
            this.panelPostePonctuel.Controls.Add(this.groupBoxPostePonctuel);
            this.panelPostePonctuel.Location = new System.Drawing.Point(16, 152);
            this.panelPostePonctuel.Name = "panelPostePonctuel";
            this.panelPostePonctuel.Size = new System.Drawing.Size(1071, 340);
            this.panelPostePonctuel.TabIndex = 7;
            // 
            // groupBoxPostePonctuel
            // 
            this.groupBoxPostePonctuel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPostePonctuel.AutoSize = true;
            this.groupBoxPostePonctuel.Location = new System.Drawing.Point(3, 2);
            this.groupBoxPostePonctuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPostePonctuel.Name = "groupBoxPostePonctuel";
            this.groupBoxPostePonctuel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPostePonctuel.Size = new System.Drawing.Size(1065, 336);
            this.groupBoxPostePonctuel.TabIndex = 3;
            this.groupBoxPostePonctuel.TabStop = false;
            this.groupBoxPostePonctuel.Text = "Echéances prévues";
            // 
            // buttonPostePonctuelValider
            // 
            this.buttonPostePonctuelValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostePonctuelValider.Location = new System.Drawing.Point(839, 497);
            this.buttonPostePonctuelValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostePonctuelValider.Name = "buttonPostePonctuelValider";
            this.buttonPostePonctuelValider.Size = new System.Drawing.Size(250, 80);
            this.buttonPostePonctuelValider.TabIndex = 6;
            this.buttonPostePonctuelValider.Text = "Valider";
            this.buttonPostePonctuelValider.UseVisualStyleBackColor = true;
            this.buttonPostePonctuelValider.Click += new System.EventHandler(this.buttonPostePonctuelValider_Click);
            // 
            // textBoxPostePonctuelNbPrelevements
            // 
            this.textBoxPostePonctuelNbPrelevements.Location = new System.Drawing.Point(256, 98);
            this.textBoxPostePonctuelNbPrelevements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostePonctuelNbPrelevements.Name = "textBoxPostePonctuelNbPrelevements";
            this.textBoxPostePonctuelNbPrelevements.Size = new System.Drawing.Size(100, 25);
            this.textBoxPostePonctuelNbPrelevements.TabIndex = 5;
            this.textBoxPostePonctuelNbPrelevements.TextChanged += new System.EventHandler(this.textBoxPostePonctuelNbPrelevements_TextChanged_1);
            this.textBoxPostePonctuelNbPrelevements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostePonctuelNbPrelevements_KeyPress);
            // 
            // textBoxPostePonctuelCommentaire
            // 
            this.textBoxPostePonctuelCommentaire.Location = new System.Drawing.Point(256, 46);
            this.textBoxPostePonctuelCommentaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostePonctuelCommentaire.Name = "textBoxPostePonctuelCommentaire";
            this.textBoxPostePonctuelCommentaire.Size = new System.Drawing.Size(359, 25);
            this.textBoxPostePonctuelCommentaire.TabIndex = 4;
            this.textBoxPostePonctuelCommentaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostePonctuelCommentaire_KeyPress);
            // 
            // textBoxPostePonctuelIntitule
            // 
            this.textBoxPostePonctuelIntitule.Location = new System.Drawing.Point(256, 10);
            this.textBoxPostePonctuelIntitule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostePonctuelIntitule.Name = "textBoxPostePonctuelIntitule";
            this.textBoxPostePonctuelIntitule.Size = new System.Drawing.Size(359, 25);
            this.textBoxPostePonctuelIntitule.TabIndex = 0;
            this.textBoxPostePonctuelIntitule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostePonctuelIntitule_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre de prélèvements:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Commentaire:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Intitulé:";
            // 
            // tabPageRevenu
            // 
            this.tabPageRevenu.Controls.Add(this.buttonRevenuAutre);
            this.tabPageRevenu.Controls.Add(this.comboBoxRevenuPoste);
            this.tabPageRevenu.Controls.Add(this.label10);
            this.tabPageRevenu.Controls.Add(this.label19);
            this.tabPageRevenu.Controls.Add(this.buttonRevenuValider);
            this.tabPageRevenu.Controls.Add(this.comboBoxRevenuBeneficiaire);
            this.tabPageRevenu.Controls.Add(this.textBoxRevenuJour);
            this.tabPageRevenu.Controls.Add(this.textBoxRevenuMontant);
            this.tabPageRevenu.Controls.Add(this.label15);
            this.tabPageRevenu.Controls.Add(this.label14);
            this.tabPageRevenu.Controls.Add(this.label13);
            this.tabPageRevenu.Controls.Add(this.label12);
            this.tabPageRevenu.Controls.Add(this.label11);
            this.tabPageRevenu.Location = new System.Drawing.Point(4, 26);
            this.tabPageRevenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRevenu.Name = "tabPageRevenu";
            this.tabPageRevenu.Size = new System.Drawing.Size(1096, 583);
            this.tabPageRevenu.TabIndex = 2;
            this.tabPageRevenu.Text = "Revenu";
            this.tabPageRevenu.UseVisualStyleBackColor = true;
            this.tabPageRevenu.Enter += new System.EventHandler(this.tabPageRevenu_Enter);
            // 
            // buttonRevenuAutre
            // 
            this.buttonRevenuAutre.Location = new System.Drawing.Point(495, 14);
            this.buttonRevenuAutre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevenuAutre.Name = "buttonRevenuAutre";
            this.buttonRevenuAutre.Size = new System.Drawing.Size(38, 25);
            this.buttonRevenuAutre.TabIndex = 17;
            this.buttonRevenuAutre.Text = "...";
            this.buttonRevenuAutre.UseVisualStyleBackColor = true;
            this.buttonRevenuAutre.Click += new System.EventHandler(this.buttonRevenuAutre_Click);
            // 
            // comboBoxRevenuPoste
            // 
            this.comboBoxRevenuPoste.FormattingEnabled = true;
            this.comboBoxRevenuPoste.Location = new System.Drawing.Point(161, 14);
            this.comboBoxRevenuPoste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRevenuPoste.Name = "comboBoxRevenuPoste";
            this.comboBoxRevenuPoste.Size = new System.Drawing.Size(328, 25);
            this.comboBoxRevenuPoste.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Poste:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(269, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "€";
            // 
            // buttonRevenuValider
            // 
            this.buttonRevenuValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRevenuValider.Location = new System.Drawing.Point(839, 497);
            this.buttonRevenuValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevenuValider.Name = "buttonRevenuValider";
            this.buttonRevenuValider.Size = new System.Drawing.Size(250, 80);
            this.buttonRevenuValider.TabIndex = 10;
            this.buttonRevenuValider.Text = "Valider";
            this.buttonRevenuValider.UseVisualStyleBackColor = true;
            this.buttonRevenuValider.Click += new System.EventHandler(this.buttonRevenuValider_Click);
            // 
            // comboBoxRevenuBeneficiaire
            // 
            this.comboBoxRevenuBeneficiaire.FormattingEnabled = true;
            this.comboBoxRevenuBeneficiaire.Location = new System.Drawing.Point(163, 52);
            this.comboBoxRevenuBeneficiaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRevenuBeneficiaire.Name = "comboBoxRevenuBeneficiaire";
            this.comboBoxRevenuBeneficiaire.Size = new System.Drawing.Size(121, 25);
            this.comboBoxRevenuBeneficiaire.TabIndex = 9;
            // 
            // textBoxRevenuJour
            // 
            this.textBoxRevenuJour.Location = new System.Drawing.Point(161, 153);
            this.textBoxRevenuJour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRevenuJour.Name = "textBoxRevenuJour";
            this.textBoxRevenuJour.Size = new System.Drawing.Size(100, 25);
            this.textBoxRevenuJour.TabIndex = 8;
            this.textBoxRevenuJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRevenuJour_KeyPress);
            // 
            // textBoxRevenuMontant
            // 
            this.textBoxRevenuMontant.Location = new System.Drawing.Point(163, 94);
            this.textBoxRevenuMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRevenuMontant.Name = "textBoxRevenuMontant";
            this.textBoxRevenuMontant.Size = new System.Drawing.Size(100, 25);
            this.textBoxRevenuMontant.TabIndex = 7;
            this.textBoxRevenuMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRevenuMontant_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "du mois";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "le";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Jour du mois:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Montant:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bénéficiaire:";
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.BackColor = System.Drawing.Color.White;
            this.tabPageOptions.Controls.Add(this.dataGridView2);
            this.tabPageOptions.Controls.Add(this.buttonOptionAjouter);
            this.tabPageOptions.Controls.Add(this.textBoxUsrPrenom);
            this.tabPageOptions.Controls.Add(this.textBoxUsrNom);
            this.tabPageOptions.Controls.Add(this.label17);
            this.tabPageOptions.Controls.Add(this.label16);
            this.tabPageOptions.Controls.Add(this.textBoxUsrNumero);
            this.tabPageOptions.Controls.Add(this.labelOptionsNum);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 5);
            this.tabPageOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOptions.Size = new System.Drawing.Size(1104, 613);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.Enter += new System.EventHandler(this.tabPageOptions_Enter_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 50);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1085, 555);
            this.dataGridView2.TabIndex = 8;
            // 
            // buttonOptionAjouter
            // 
            this.buttonOptionAjouter.Location = new System.Drawing.Point(499, 5);
            this.buttonOptionAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOptionAjouter.Name = "buttonOptionAjouter";
            this.buttonOptionAjouter.Size = new System.Drawing.Size(99, 27);
            this.buttonOptionAjouter.TabIndex = 0;
            this.buttonOptionAjouter.Text = "Ajouter";
            this.buttonOptionAjouter.UseVisualStyleBackColor = true;
            this.buttonOptionAjouter.Click += new System.EventHandler(this.buttonOptionAjouter_Click);
            // 
            // textBoxUsrPrenom
            // 
            this.textBoxUsrPrenom.Location = new System.Drawing.Point(224, 7);
            this.textBoxUsrPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsrPrenom.Name = "textBoxUsrPrenom";
            this.textBoxUsrPrenom.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsrPrenom.TabIndex = 7;
            this.textBoxUsrPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsrPrenom_KeyPress);
            // 
            // textBoxUsrNom
            // 
            this.textBoxUsrNom.Location = new System.Drawing.Point(51, 7);
            this.textBoxUsrNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsrNom.Name = "textBoxUsrNom";
            this.textBoxUsrNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsrNom.TabIndex = 6;
            this.textBoxUsrNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsrNom_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Prenom:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Nom:";
            // 
            // textBoxUsrNumero
            // 
            this.textBoxUsrNumero.Location = new System.Drawing.Point(393, 7);
            this.textBoxUsrNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsrNumero.Name = "textBoxUsrNumero";
            this.textBoxUsrNumero.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsrNumero.TabIndex = 2;
            this.textBoxUsrNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsrNumero_KeyPress);
            // 
            // labelOptionsNum
            // 
            this.labelOptionsNum.AutoSize = true;
            this.labelOptionsNum.Location = new System.Drawing.Point(331, 11);
            this.labelOptionsNum.Name = "labelOptionsNum";
            this.labelOptionsNum.Size = new System.Drawing.Size(66, 17);
            this.labelOptionsNum.TabIndex = 1;
            this.labelOptionsNum.Text = "Numéro: ";
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "Personne";
            this.personneBindingSource.DataSource = this.budget1DataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1112, 34);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetDuMoisToolStripMenuItem,
            this.budgetPrevisionnelToolStripMenuItem,
            this.calendrierPrevisionnelToolStripMenuItem,
            this.recapPostesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.gestionDesSMSToolStripMenuItem,
            this.appColorToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(36, 24);
            // 
            // budgetDuMoisToolStripMenuItem
            // 
            this.budgetDuMoisToolStripMenuItem.Name = "budgetDuMoisToolStripMenuItem";
            this.budgetDuMoisToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.budgetDuMoisToolStripMenuItem.Text = "Budget du mois";
            this.budgetDuMoisToolStripMenuItem.Click += new System.EventHandler(this.budgetDuMoisToolStripMenuItem_Click);
            // 
            // budgetPrevisionnelToolStripMenuItem
            // 
            this.budgetPrevisionnelToolStripMenuItem.Name = "budgetPrevisionnelToolStripMenuItem";
            this.budgetPrevisionnelToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.budgetPrevisionnelToolStripMenuItem.Text = "Budget previsionnel";
            this.budgetPrevisionnelToolStripMenuItem.Click += new System.EventHandler(this.budgetPrevisionnelToolStripMenuItem_Click);
            // 
            // calendrierPrevisionnelToolStripMenuItem
            // 
            this.calendrierPrevisionnelToolStripMenuItem.Name = "calendrierPrevisionnelToolStripMenuItem";
            this.calendrierPrevisionnelToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.calendrierPrevisionnelToolStripMenuItem.Text = "Calendrier previsionnel";
            this.calendrierPrevisionnelToolStripMenuItem.Click += new System.EventHandler(this.calendrierPrevisionnelToolStripMenuItem_Click);
            // 
            // recapPostesToolStripMenuItem
            // 
            this.recapPostesToolStripMenuItem.Name = "recapPostesToolStripMenuItem";
            this.recapPostesToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.recapPostesToolStripMenuItem.Text = "Recapitulatif des postes";
            this.recapPostesToolStripMenuItem.Click += new System.EventHandler(this.recapPostesToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.optionsToolStripMenuItem.Text = "Utilisateurs";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // gestionDesSMSToolStripMenuItem
            // 
            this.gestionDesSMSToolStripMenuItem.Name = "gestionDesSMSToolStripMenuItem";
            this.gestionDesSMSToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestionDesSMSToolStripMenuItem.Text = "Gestion des SMS";
            this.gestionDesSMSToolStripMenuItem.Click += new System.EventHandler(this.gestionDesSMSToolStripMenuItem_Click_1);
            // 
            // appColorToolStripMenuItem
            // 
            this.appColorToolStripMenuItem.Name = "appColorToolStripMenuItem";
            this.appColorToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.appColorToolStripMenuItem.Text = "Clair";
            this.appColorToolStripMenuItem.Click += new System.EventHandler(this.appColorToolStripMenuItem_Click);
            // 
            // beneficiairesTableAdapter1
            // 
            this.beneficiairesTableAdapter1.ClearBeforeFill = true;
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(260, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(508, 17);
            this.labelTitre.TabIndex = 9;
            this.labelTitre.Text = "labelTitre";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitre_MouseDown);
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            this.buttonMax.Location = new System.Drawing.Point(1044, 4);
            this.buttonMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(29, 26);
            this.buttonMax.TabIndex = 14;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(1009, 4);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(29, 26);
            this.buttonMin.TabIndex = 15;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // FormBudgestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 654);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.tabControlParent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBudgestion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Budgestion";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.SizeChanged += new System.EventHandler(this.FormBudgestion_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.typeTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet)).EndInit();
            this.tabControlEnfant.ResumeLayout(false);
            this.tabPage1a1.ResumeLayout(false);
            this.tabPage1a1.PerformLayout();
            this.tabPageAjout.ResumeLayout(false);
            this.tabPageAjout.PerformLayout();
            this.tabPageRecap.ResumeLayout(false);
            this.tabPageRecap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet1)).EndInit();
            this.tabControlParent.ResumeLayout(false);
            this.tabPageBudgetMois.ResumeLayout(false);
            this.tabPageBudgetPrevisio.ResumeLayout(false);
            this.tabControlEnfantPrevisio.ResumeLayout(false);
            this.tabPagePosteFixe.ResumeLayout(false);
            this.tabPagePosteFixe.PerformLayout();
            this.tabPagePostePonctuel.ResumeLayout(false);
            this.tabPagePostePonctuel.PerformLayout();
            this.panelPostePonctuel.ResumeLayout(false);
            this.panelPostePonctuel.PerformLayout();
            this.tabPageRevenu.ResumeLayout(false);
            this.tabPageRevenu.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */

        /*
        private void cbpTypeTransa_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */

        #endregion
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.CheckBox chBox1;
        private System.Windows.Forms.CheckBox chBox2;
        private System.Windows.Forms.TextBox txtBox_montant;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.Label lbl1_description;
        private System.Windows.Forms.Label lbl_montant;
        private System.Windows.Forms.DateTimePicker dateDepense;
        private System.Windows.Forms.Label lbl_date;
        private budget1DataSet budget1DataSet;
        private System.Windows.Forms.BindingSource typeTransactionBindingSource;
        private budget1DataSetTableAdapters.TypeTransactionTableAdapter typeTransactionTableAdapter;
        private System.Windows.Forms.TabControl tabControlEnfant;
        private System.Windows.Forms.TabPage tabPage1a1;
        private System.Windows.Forms.TabPage tabPageAjout;
        private System.Windows.Forms.TabPage tabPageRecap;
        private budget1DataSet budget1DataSet1;
        private System.Windows.Forms.Button buttonAjoutTransactionAjouter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlParent;
        private System.Windows.Forms.TabPage tabPageBudgetMois;
        private System.Windows.Forms.TabPage tabPageBudgetPrevisio;
        private System.Windows.Forms.TabControl tabControlEnfantPrevisio;
        private System.Windows.Forms.TabPage tabPagePosteFixe;
        private System.Windows.Forms.TabPage tabPagePostePonctuel;
        private System.Windows.Forms.TabPage tabPageRevenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetDuMoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetPrevisionnelToolStripMenuItem;
        private System.Windows.Forms.Button button1a1_7;
        private System.Windows.Forms.Button button1a1_3;
        private System.Windows.Forms.Button button1a1_2;
        private System.Windows.Forms.Button button1a1_1;
        private System.Windows.Forms.CheckBox checkBox1a1percu;
        private System.Windows.Forms.CheckBox checkBox1a1recette;
        private System.Windows.Forms.DateTimePicker dateTimePicker1a1;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxUsrNumero;
        private System.Windows.Forms.Label labelOptionsNum;
        private System.Windows.Forms.Button buttonOptionAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosteFixeMontant;
        private System.Windows.Forms.TextBox textBoxPosteFixeJour;
        private System.Windows.Forms.ComboBox comboBoxPosteFixePeriodicite;
        private System.Windows.Forms.ComboBox comboBoxPosteFixePoste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPosteFixeValider;
        private System.Windows.Forms.Button buttonPosteFixeAutre;
        private System.Windows.Forms.Button buttonPostePonctuelValider;
        private System.Windows.Forms.TextBox textBoxPostePonctuelNbPrelevements;
        private System.Windows.Forms.TextBox textBoxPostePonctuelCommentaire;
        private System.Windows.Forms.TextBox textBoxPostePonctuelIntitule;
        private System.Windows.Forms.GroupBox groupBoxPostePonctuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRevenuBeneficiaire;
        private System.Windows.Forms.TextBox textBoxRevenuJour;
        private System.Windows.Forms.TextBox textBoxRevenuMontant;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRevenuValider;
        private budget1DataSetTableAdapters.BeneficiairesTableAdapter beneficiairesTableAdapter1;
        private System.Windows.Forms.TextBox textBoxUsrPrenom;
        private System.Windows.Forms.TextBox textBoxUsrNom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource budget1DataSetBindingSource;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private budget1DataSetTableAdapters.PersonneTableAdapter personneTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem appColorToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label labelRecapAu;
        private System.Windows.Forms.Label labelRecapDu;
        private System.Windows.Forms.ComboBox cbpTypeTransa;
        private System.Windows.Forms.GroupBox gbParticipant;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private budget1DataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1a1Montant;
        private System.Windows.Forms.Label label1a1Type;
        private System.Windows.Forms.Label label1a1NumDesc;
        private System.Windows.Forms.Label label1a1Num;
        private System.Windows.Forms.Button buttonRevenuAutre;
        private System.Windows.Forms.ComboBox comboBoxRevenuPoste;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAjoutAutreType;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPostePonctuel;
        private System.Windows.Forms.TextBox textBoxPostePonctuel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPostePonctuel;
        private System.Windows.Forms.DateTimePicker dateTimePickerPostePonctuel1;

        private System.Windows.Forms.Label labelPostePonctuel;
        private System.Windows.Forms.Panel panelPostePonctuel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendrierPrevisionnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recapPostesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}