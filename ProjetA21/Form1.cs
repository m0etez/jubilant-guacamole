using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using Twilio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;
using Twilio.Types;
using Projet;

namespace ProjetA21
{
    public partial class FormBudgestion : Form
    {
        //---------------------Variables Globales-------------------------------

        //Nécessaire pour redéfinir la zone de déplacement du form dans la zone client
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public static OleDbConnection connec = new OleDbConnection();
        public static DataSet ds = new DataSet();


        public FormBudgestion()
        {
            InitializeComponent();
            labelTitre.Text = "BUDGET DU MOIS";
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // this.transactionTableAdapter.Fill(this.budget1DataSet.Transaction);

            try
            {
                connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget1.mdb";
                connec.Open();

                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                DataSetFill(schemaTable);



            }

            /*
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion !");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL !");
            }
            */
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                connec.Close();
                init1a1(1);
                dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Transaction";

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "Personne";


                ComboBoxFill(cbpTypeTransa, "TypeTransaction", "libType", "codeType");
            }
        }

        //Remplit la DataTable donnee en parametre
        public void DataSetFill(DataTable schemaTable)
        {
            string nomTable;
            string requete;
            foreach (DataRow ligne in schemaTable.Rows)
            {
                nomTable = ligne[2].ToString();
                requete = "SELECT * FROM [" + nomTable + "]";
                OleDbCommand cd = new OleDbCommand(requete, connec);

                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd;

                da.Fill(ds, nomTable);
            }
        }

        //Remplit la ComboBox donnee en paramete avec la table nomTable par la colonne nomColonne
        public static void ComboBoxFill(ComboBox cb, string nomTable, string nomColonne)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = nomColonne;
        }

        //Remplit la ComboBox donnee en paramete avec la table nomTable par la colonne ColonneAffichee, et la colonne cachee colonneCachee
        public static void ComboBoxFill(ComboBox cb, string nomTable, string ColonneAffichee, string colonneCachee)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = ColonneAffichee;
            cb.ValueMember = colonneCachee;
        }

        private void listType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ajout d'une transaction
        private void buttonAjoutTransactionAjouter_Click(object sender, EventArgs e)
        {
            if (txtBox_montant.Text == "")
            {
                MessageBox.Show("Entrer un montant!");
            }
            else if (txtBox_description.Text == "")
            {
                MessageBox.Show("Entrer une description!");
            }
            else if (cbpTypeTransa.SelectedValue == null)
            {
                MessageBox.Show("Selectionner un Type de Transaction!");
            }
            else
            {
                try
                {
                    connec.Open();
                    DateTime date = dateDepense.Value;
                    string desc = txtBox_description.Text;
                    string montant = txtBox_montant.Text;
                    int recette = 0;
                    int percu = 0;
                    if (chBox1.Checked == true) { recette = 1; }
                    if (chBox2.Checked == true) { percu = 1; }
                    int type = (int)cbpTypeTransa.SelectedValue;

                    string requete = @"INSERT INTO [Transaction] (codeTransaction, dateTransaction, description, montant, recetteON, percuON, type) 
                                        SELECT  (MAX(t.codeTransaction) + 1), "
                                                    + "format('" + date.ToShortDateString() + "','DD/MM/YYYY') ,"
                                                    + "'" + desc + "' ,"
                                                    + "'" + montant + "' ,"
                                                    + recette + " ,"
                                                    + percu + " ,"
                                                    + cbpTypeTransa.SelectedValue
                                                    + " FROM [Transaction] t";

                    OleDbCommand cd1 = new OleDbCommand();
                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = requete;

                    try
                    {
                        cd1.ExecuteNonQuery();
                        MessageBox.Show("Transaction ajoutée !");
                    }
                    catch (OleDbException x)
                    {
                        requete = @"INSERT INTO TypeTransaction (codeType, libType) VALUES ("
                                    + cbpTypeTransa.SelectedValue + ", '"
                                    + cbpTypeTransa.Text
                                    + "')";
                        OleDbCommand cd = new OleDbCommand();
                        cd.Connection = connec;
                        cd.CommandType = CommandType.Text;
                        cd.CommandText = requete;

                        cd.ExecuteNonQuery();
                        cd1.ExecuteNonQuery();
                        MessageBox.Show("Transaction ajoutée !");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                    finally
                    {
                        connec.Close();
                    }


                    foreach (CheckBox chk in gbParticipant.Controls)
                    {
                        if (chk.Checked)
                        {
                            try
                            {
                                connec.Open();

                                //recupération codePersonne
                                string[] perso = chk.Text.Split(' ');
                                requete = "SELECT [Personne].[codePersonne] FROM [Personne] WHERE [pnPersonne] = '" + perso[0] + "' AND [nomPersonne] = '" + perso[1] + "'";

                                OleDbCommand cd2 = new OleDbCommand(requete, connec);
                                int codePerso = (int)cd2.ExecuteScalar();
                                //ajout dans table Bénéficiaires

                                requete = @"INSERT INTO Beneficiaires (codeTransaction, codePersonne  )
                                SELECT MAX(t.codeTransaction), "
                                    + codePerso
                                    + " FROM [Transaction] t";

                                OleDbCommand cd3 = new OleDbCommand();
                                cd3.Connection = connec;
                                cd3.CommandType = CommandType.Text;
                                cd3.CommandText = requete;
                                cd3.ExecuteNonQuery();
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.ToString());
                            }
                            finally
                            {
                                connec.Close();
                            }
                        }
                    }



                    MiseAJour();
                    remplirDGV();
                }


                /*
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! ajoutTransa");
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! ajoutTransa");
                }
                */
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    connec.Close();
                }
            }
        }

        private void remplirParticipants()
        {
            try
            {
                //Mise en place de la connection string et on ouvre la connection
                connec.Open();

                //On récupère les données de la table pour travailler en mode déconnecté
                DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                foreach (DataRow ds in tbl1.Rows)
                {
                    if (ds[2].ToString() == "Personne")
                    {
                        //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                        OleDbCommand cd1 = new OleDbCommand();
                        cd1.Connection = connec;
                        cd1.CommandType = CommandType.Text;
                        cd1.CommandText = "Select codePersonne, pnPersonne, nomPersonne from Personne";
                        int nb = cd1.ExecuteNonQuery();

                        OleDbDataReader dr = cd1.ExecuteReader();


                        //création et indentation des checkbox générées dynamiquements
                        if (dr.HasRows)
                        {
                            int top = 25;
                            int left = 15;
                            int i = 0;
                            while (dr.Read())
                            {
                                CheckBox cbPersonne = new CheckBox();
                                cbPersonne.Text = dr[nb + 1].ToString() + " " + dr[nb + 2].ToString();
                                cbPersonne.Top = top + i * 10;
                                cbPersonne.Left = left;
                                cbPersonne.AutoSize = true;

                                i += 2;
                                gbParticipant.Controls.Add(cbPersonne);

                            }
                        }
                    }

                }

            }
            /*
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! : RemplirParticipant");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! : RemplirParticipant");
            }
            */
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                connec.Close();
            }
        }

        //Pour Onglet 1a1
        int ligneTable = 0;
        private void button1a1_7_Click(object sender, EventArgs e)
        {
            try
            {
                init1a1(2);
            }
            catch (Exception x)
            {

            }

        }

        private void button1a1_1_Click(object sender, EventArgs e)
        {
            try
            {
                init1a1(-2);
            }
            catch (Exception x)
            {

            }

        }

        private void button1a1_3_Click(object sender, EventArgs e)
        {

            try
            {
                init1a1(1);
            }
            catch (Exception x)
            {

            }
        }

        private void button1a1_2_Click(object sender, EventArgs e)
        {
            try
            {
                init1a1(-1);
            }
            catch (Exception x)
            {

            }
        }

        private void init1a1(int ligne)
        {
            try
            {
                listBox1.Items.Clear();
                List<int> max = new List<int>();
                string jointure = "";
                int codeTransaction = 0;
                List<int> Personne = new List<int>();
                OleDbCommand cd0 = new OleDbCommand("SELECT [codeTransaction] FROM[Transaction]", connec);
                connec.Open();
                OleDbDataReader dr0 = cd0.ExecuteReader();
                while (dr0.Read())
                {
                    max.Add(dr0.GetInt32(0));
                }

                if (ligne == -2)
                {
                    ligne = 1;
                    ligneTable = 1;
                }
                else if (ligne == -1)
                {
                    if (ligneTable == 1)
                    {
                        ligne = 1;
                    }
                    else
                    {
                        ligneTable--;
                        ligne = ligneTable;
                    }
                }
                else if (ligne == 1)
                {
                    if (ligneTable == max.Count)
                    {
                        ligne = max.Count;
                    }
                    else
                    {
                        ligneTable++;
                        ligne = ligneTable;
                    }
                }
                else
                {
                    ligne = max.Count;
                    ligneTable = max.Count;
                }

                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction] where [codeTransaction] = " + ligne, connec);
                OleDbDataReader dr1 = cd1.ExecuteReader();

                while (dr1.Read())
                {



                    label1a1Num.Text = dr1.GetInt32(0).ToString();
                    codeTransaction = dr1.GetInt32(0); dateTimePicker1a1.Value = dr1.GetDateTime(1);
                    dateTimePicker1a1.Value = dr1.GetDateTime(1);
                    try
                    {
                        label1a1NumDesc.Text = dr1.GetString(2);
                    }
                    catch (Exception x) { }

                    label1a1Montant.Text = dr1.GetValue(3).ToString() + " €";
                    checkBox1a1recette.Checked = dr1.GetBoolean(4);
                    checkBox1a1percu.Checked = dr1.GetBoolean(5);
                    if (dr1[6].ToString() == "")
                    {
                        jointure = "";
                    }
                    else
                    {
                        jointure = dr1.GetInt32(6).ToString();

                    }
                }

                if (jointure != "")
                {
                    //Pour eviter de faire une requette avec une jointure
                    OleDbCommand cd2 = new OleDbCommand("SELECT [TypeTransaction].* FROM [TypeTransaction] where [codeType] = " + jointure, connec);
                    OleDbDataReader dr2 = cd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        label1a1Type.Text = dr2.GetString(1);
                    }
                }
                else
                {
                    label1a1Type.Text = "Type NULL";
                }


                OleDbCommand cd3 = new OleDbCommand("SELECT [CodePersonne] FROM[Beneficiaires] where [codeTransaction] =" + codeTransaction, connec);
                OleDbDataReader dr3 = cd3.ExecuteReader();
                while (dr3.Read())
                {
                    Personne.Add(dr3.GetInt32(0));
                }
                for (int i = 0; i < Personne.Count(); i++)
                {
                    OleDbCommand cd4 = new OleDbCommand("SELECT [nomPersonne],[pnPersonne] FROM[Personne] where [codePersonne] =" + Personne[i].ToString(), connec);
                    OleDbDataReader dr4 = cd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        listBox1.Items.Add(dr4.GetString(0) + dr4.GetString(1));
                    }
                }



            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! 1a1");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! 1a1");
            }
            finally
            {
                connec.Close();
            }
        }

        private void remplirDGV() //Met à jour les DGV
        {
            try
            {
                connec.Open();
                ds.Clear();


                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                DataSetFill(schemaTable);

            }
            /*
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            */
            finally
            {
                connec.Close();
            }
        }

        private void remplirDGV(DateTime du, DateTime au) //Met à jour les DGV
        {
            try
            {
                connec.Open();
                ds.Clear();


                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                //DataSetFill(schemaTable);

                ///////////////////////
                string nomTable;
                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    nomTable = ligne[2].ToString();
                    if (nomTable == "Transaction")
                    {
                        requete = "SELECT * FROM [" + nomTable + "] WHERE [dateTransaction] >= FORMAT('" + du.ToShortDateString() + "','DD/MM/YYYY') AND [dateTransaction] <= FORMAT('" + au.ToShortDateString() + "','DD/MM/YYYY')";
                    }
                    else
                    {
                        requete = "SELECT * FROM [" + nomTable + "]";
                    }

                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter();

                    da.SelectCommand = cd;
                    try
                    {
                        da.Fill(ds, nomTable);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }

                }
                /////////////////////////////
                /*
                string nomTable;
                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    nomTable = ligne[2].ToString();
                    requete = "SELECT * FROM [" + nomTable + "]";
                    OleDbCommand cd = new OleDbCommand(requete, connec);

                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = cd;

                    da.Fill(ds, nomTable);
                }*/
            }

            /*
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            */
            finally
            {
                connec.Close();
            }
        }

        // mettre a jour la bdd
        private void MiseAJour()
        {
            //remplirParticipants();
            //remplirDGV();
            try
            {
                ComboBoxFill(cbpTypeTransa, "TypeTransaction", "libType", "codeType");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        // générer le pdf
        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1

            //Creation de table PDF à partir du dataGridView1
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Export vers PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }


        private void lbl_type_Click(object sender, EventArgs e)
        {

        }

        private void chBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox1.Checked == false) { chBox2.Checked = false; }
        }

        private void chBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox1.Checked == false) { chBox2.Checked = false; }
        }

        private void lbl1_description_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_montant_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_montant_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void dateDepense_ValueChanged(object sender, EventArgs e)
        {

        }

        private void budgetDuMoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlParent.SelectedTab = tabPageBudgetMois;
            labelTitre.Text = "BUDGET DU MOIS";
        }

        private void budgetPrevisionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlParent.SelectedTab = tabPageBudgetPrevisio;
            labelTitre.Text = "BUDGET PREVISIONNEL";
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControlParent.SelectedTab = tabPageOptions;
            }
            catch (Exception x)
            { }
            
            labelTitre.Text = "UTILISATEURS";
        }

        private void buttonOptionAjouter_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////
            int exist = -1;
            try
            {
                connec.Open();

                String requete = "SELECT [Personne].[codePersonne] FROM [Personne] WHERE [pnPersonne] = '" + textBoxUsrPrenom.Text + "' AND [nomPersonne] = '" + textBoxUsrNom.Text + "'";
                OleDbCommand cd2 = new OleDbCommand(requete, connec);
                exist = int.Parse(cd2.ExecuteScalar().ToString());
            }
            catch (Exception x)
            {

            }
            finally
            {
                connec.Close();
            }
            ////////////////////////////////////////////////////////

            //Interaction_BDD.ajouter_personne(textBoxUsrNom.Text, textBoxUsrPrenom.Text, textBoxUsrNumero.Text, sender, e);
            if (exist != -1)
            {
                MessageBox.Show("Un utilisateur avec ce nom et ce prenom existe deja dans la base de donnee!");
            }
            else if (textBoxUsrNom.Text == "")
            {
                MessageBox.Show("Entrer un nom!");
            }
            else if (textBoxUsrPrenom.Text == "")
            {
                MessageBox.Show("Entrer un prénom!");
            }
            else
            {
                try
                {
                    connec.Open();
                    OleDbCommand cd1 = new OleDbCommand();

                    string tel = "null";
                    if (textBoxUsrNumero.Text != "")
                    {
                        tel = "'" + textBoxUsrNumero.Text + "'";
                    }

                    string requete1 = @"INSERT INTO Personne (codePersonne, nomPersonne, pnPersonne, telMobile) 
                                        SELECT  MAX(Personne.codePersonne) + 1, '"
                                        + textBoxUsrNom.Text + "', '"
                                        + textBoxUsrPrenom.Text + "', "
                                        + tel
                                        + " FROM Personne";


                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = requete1;


                    cd1.ExecuteNonQuery();
                    MessageBox.Show("L'utilisateur a été ajouté à la base de donée!");

                    DataTable schemaTable = connec.GetOleDbSchemaTable(
                        OleDbSchemaGuid.Tables,
                        new object[] { null, null, null, "TABLE" });

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    connec.Close();
                }
            }
            remplirDGV();
        }

        private void appColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modification du bouton du menu (Sombre/Clair) et de la couleur de l'appli
            if (appColorToolStripMenuItem.Text == "Clair")
            {
                appColorToolStripMenuItem.Text = "Sombre";
                labelTitre.ForeColor = Color.Black;
                //Design.setAppColor(this, Color.FromArgb(240, 240, 240
                menuStrip1.BackColor = Color.FromArgb(240, 240, 240);
                labelTitre.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                appColorToolStripMenuItem.Text = "Clair";
                labelTitre.ForeColor = Color.White;
                //Design.setAppColor(this, Color.FromArgb(54, 57, 62));
                menuStrip1.BackColor = Color.FromArgb(54, 57, 62);
                labelTitre.BackColor = Color.FromArgb(54, 57, 62);
            }
        }


        //Lorsque qu'on reste cliqué sur le menuStrip
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //Déplace le form
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        //Lorsque qu'on reste cliqué sur le titre
        private void labelTitre_MouseDown(object sender, MouseEventArgs e)
        {
            //Déplace le form
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBudgestion));
        //private readonly object cboTypeTransa;
        //private object grpParticipantsTransa;

        private void gbParticipant_Enter(object sender, EventArgs e)
        {

        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

                this.WindowState = FormWindowState.Maximized;
                // /!\ Uncomment this to hide taskbar
            }
        }


        private void FormBudgestion_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                buttonMax.Image = this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                buttonMax.Image = ((System.Drawing.Image)(new Bitmap("..\\..\\ressource\\shrink_0.png")));
            }
        }

        private void comboBoxPosteFixePoste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget.mdb";
            connec.Open();

            //On récupère les données de la table pour travailler en mode déconnecté
            DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            //on parcours la DataTable et on récupère uniquement la table qui nous intéresse
            foreach (DataRow ds in tbl1.Rows)
            {
                if (ds[2].ToString() == "Poste")
                {
                    //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                    OleDbCommand cd1 = new OleDbCommand();
                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = "Select libPoste from Poste";
                    int nb = cd1.ExecuteNonQuery();

                    OleDbDataReader dr = cd1.ExecuteReader();



                    //création et indentation des checkbox générées dynamiquements
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            comboBoxPosteFixePoste.Items.Add(dr[nb]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                }
            }
            connec.Close();
        }

        private void comboBoxPosteFixePeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget.mdb";
            connec.Open();

            //On récupère les données de la table pour travailler en mode déconnecté
            DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            //on parcours la DataTable et on récupère uniquement la table qui nous intéresse
            foreach (DataRow ds in tbl1.Rows)
            {
                if (ds[2].ToString() == "Periodicite")
                {
                    //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                    OleDbCommand cd2 = new OleDbCommand();
                    cd2.Connection = connec;
                    cd2.CommandType = CommandType.Text;
                    cd2.CommandText = "SELECT libPer FROM Periodicite";
                    int nb = cd2.ExecuteNonQuery();

                    OleDbDataReader dr = cd2.ExecuteReader();


                    //création et indentation des checkbox générées dynamiquements
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            comboBoxPosteFixePeriodicite.Items.Add(dr[nb]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                }
            }
            connec.Close();
        }

        private void textBoxPosteFixeJour_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPosteFixeMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPostePonctuelIntitule_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPostePonctuelCommentaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPostePonctuelNbPrelevements_TextChanged(object sender, EventArgs e)
        {

            int top = 15;
            int left = 15;
            int nb = 0;
            if (textBoxPostePonctuelNbPrelevements.Text != "")
            {
                nb = int.Parse(textBoxPostePonctuelNbPrelevements.Text);
            }
            for (int i = 0; i < nb; i++)
            {
                DateTimePicker dt = new DateTimePicker();
                dt.Top = 30 * i + top;
                dt.Left = left;
                textBoxPostePonctuelNbPrelevements.Controls.Add(dt);
            }

        }

        private void groupBoxPostePonctuel_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxRevenuPoste_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRevenuBeneficiaire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRevenuMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRevenuJour_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        //PDF
        private void button3_Click(object sender, EventArgs e)
        {
            // Info pdf : http://csharp.net-informations.com/file/dbtopdf.htm
            //TO DO: Generer un PDF et demander ou l'enregistrer qui récapitule le mois (comboBoxRecapMois) de l'annee (comboBoxRecapAnnee)
        }

        //Lorsque qu'on selectionne une Transaction dans l'onglet suppression
        private void comboBoxSuppression_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TO DO: Faire apparaitre un résumé de la transaction dans la tabPageSuppression
        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            //TO DO: Générer une fenêtre qui demande la validation de la suppression à l'utilisateur
            //Si oui: Supprime la Transaction du numero de la comboBoxSuppression
        }

        private void comboBoxModification_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TO DO: Faire apparaitre le contenu de la transaction dans la tabPageModification
            //Dans des textboxs afin de pouvoir les modifiés 
        }

        private void buttonModification_Click(object sender, EventArgs e)
        {
            //TO DO: Anule les modifications non-enregistrées (re-remplit les textBoxs avec les infos de la Transaction numero:comboBoxModification)
        }

        private void buttonModificationValider_Click(object sender, EventArgs e)
        {
            //TO DO: enregistrer les modifications de la Transactions (s'il y en a) des textBoxs de la tabPageModification
        }
        */

        //--------------------KEY PRESS-----------------------

        private void comboBoxRecapAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxRecapMois_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxModification_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxSuppression_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void txtBox_montant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Autorise une virgule
            else if (e.KeyChar == ',' && txtBox_montant.Text == "")
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && !txtBox_montant.Text.Contains(','))
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxUsrNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxPosteFixeJour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxPosteFixeMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Autorise une virgule
            else if (e.KeyChar == ',' && txtBox_montant.Text == "")
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && !txtBox_montant.Text.Contains(','))
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxPostePonctuelNbPrelevements_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxRevenuMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Autorise une virgule
            else if (e.KeyChar == ',' && txtBox_montant.Text == "")
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && !txtBox_montant.Text.Contains(','))
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxRevenuJour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        //------------------------TabPage ENTER-----------------------------


        //Lorsqu'on arrive sur la page recap
        private void tabPageRecap_Enter(object sender, EventArgs e)
        {
            remplirDGV(dateTimePicker1.Value, dateTimePicker2.Value);


        }

        //Lorsqu'on arrive sur l'onglet personne
        public void tabPageOptions_Enter(object sender, EventArgs e)
        {
            //TO DO: remplir DataGridView2 avec la table Personne
        }

        private void tabPageModification_Enter_1(object sender, EventArgs e)
        {

        }

        private void tabPage1a1_Enter(object sender, EventArgs e)
        {
            //dateTimePicker1a1_ValueChanged(sender, e);
        }

        private void dateTimePicker1a1_ValueChanged(object sender, EventArgs e)
        {
            //label1a1Num.Text = ds.Tables["codeTransaction"].Columns[0].ToString();
        }

        private void buttonRevenuValider_Click(object sender, EventArgs e)
        {
            if (comboBoxRevenuPoste.SelectedValue == null)
            {
                MessageBox.Show("Selectionner un poste!");
            }
            else if (comboBoxRevenuBeneficiaire.SelectedValue == null)
            {
                MessageBox.Show("Selectionner un Bénéficiaire!");
            }
            else if (textBoxRevenuJour.Text == "")
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (int.Parse(textBoxRevenuJour.Text) > 31 || int.Parse(textBoxRevenuJour.Text) <= 0)
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (textBoxRevenuMontant.Text == null)
            {
                MessageBox.Show("Entrer un montant!");
            }
            else
            {
                try
                {
                    connec.Open();
                    OleDbCommand cd1 = new OleDbCommand();
                    OleDbCommand cd2 = new OleDbCommand();

                    string requete1 = @"INSERT INTO PosteRevenu (codePoste, montant, codePersonne, jourDuMois) 
                                    SELECT  MAX(Poste.codePoste), '"
                                        + float.Parse(textBoxRevenuMontant.Text) + "', "
                                        + comboBoxRevenuBeneficiaire.SelectedValue + ", "
                                        + textBoxRevenuJour.Text
                                        + " FROM Poste";

                    string requete2 = @"INSERT INTO Poste (codePoste, libPoste) 
                                        SELECT  MAX(Poste.codePoste) + 1, '"
                                        + comboBoxRevenuPoste.Text + "' FROM Poste";

                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = requete1;

                    cd2.Connection = connec;
                    cd2.CommandType = CommandType.Text;
                    cd2.CommandText = requete2;

                        cd2.ExecuteNonQuery();
                        cd1.ExecuteNonQuery();


                    DataTable schemaTable = connec.GetOleDbSchemaTable(
                        OleDbSchemaGuid.Tables,
                        new object[] { null, null, null, "TABLE" });

                    ds.Clear();
                    DataSetFill(schemaTable);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    connec.Close();
                }
            }

        }

        private void tabPageRevenu_Enter(object sender, EventArgs e)
        {
            ComboBoxFill(comboBoxRevenuBeneficiaire, "Personne", "pnPersonne", "codePersonne");
            ComboBoxFill(comboBoxRevenuPoste, "Poste", "libPoste", "codePoste");
        }

        private void buttonPostePonctuelValider_Click(object sender, EventArgs e)
        {

            if (textBoxPostePonctuelIntitule.Text == "")
            {
                MessageBox.Show("Entrer un intitulé!");
            }
            else if (textBoxPostePonctuelNbPrelevements.Text == "" || int.Parse(textBoxPostePonctuelNbPrelevements.Text) <= 0)
            {
                MessageBox.Show("Entrer un nombre de prélèvement supérieur à 0!");
            }
            else
            {
                try
                {
                    connec.Open();
                    OleDbCommand cd1 = new OleDbCommand();
                    OleDbCommand cd2 = new OleDbCommand();

                    string requete1 = @"INSERT INTO PostePonctuel (codePoste, commentaire) 
                                    SELECT  MAX(Poste.codePoste), '"
                                        + textBoxPostePonctuelCommentaire.Text
                                        + "' FROM Poste";

                    string requete2 = @"INSERT INTO Poste (codePoste, libPoste) 
                                        SELECT  MAX(Poste.codePoste) + 1, '"
                                        + textBoxPostePonctuelIntitule.Text + "' FROM Poste";

                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = requete1;

                    cd2.Connection = connec;
                    cd2.CommandType = CommandType.Text;
                    cd2.CommandText = requete2;

                    /*
                    DialogResult result = MessageBox.Show("Execute requests? \n" + requete1 + requete2, "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                    */
                    cd2.ExecuteNonQuery();
                    cd1.ExecuteNonQuery();
                    //}

                    //--------------Insert into Echeances / Transaction-----------------
                    DateTime datePrelevt = DateTime.Today;
                    float montantEcheance = 0;
                    foreach (Control c in groupBoxPostePonctuel.Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Text != "")
                            {
                                montantEcheance = float.Parse(c.Text);
                            }
                            else
                            {
                                MessageBox.Show("Chaque échéance doit avoir un montant!");
                                break;
                            }

                            //INSERT INTO Echeances
                            
                            string requete3 = @"INSERT INTO Echeances (codePoste, datePrelevt, montantEcheance) 
                                        SELECT  MAX(Poste.codePoste), "
                                                + "format('" + datePrelevt.ToShortDateString() + "','DD/MM/YYYY') ,"
                                                + "'" + montantEcheance + "'"
                                                + " FROM Poste";
                            OleDbCommand cd3 = new OleDbCommand();
                            cd3.Connection = connec;
                            cd3.CommandType = CommandType.Text;
                            cd3.CommandText = requete3;
                            cd3.ExecuteNonQuery();

                            ////////////////////////////////////////////////////////
                            int exist = -1;
                            try
                            {

                                String requete = "SELECT [codeType] FROM [TypeTransaction] WHERE [libType]='Poste ponctuel'";
                                OleDbCommand cd5 = new OleDbCommand(requete, connec);
                                exist = int.Parse(cd5.ExecuteScalar().ToString());
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.ToString());
                                String requete = "SELECT MAX(codeType) + 1 FROM [TypeTransaction]";
                                OleDbCommand cd6 = new OleDbCommand(requete, connec);
                                exist = int.Parse(cd6.ExecuteScalar().ToString());

                                requete = "INSERT INTO TypeTransaction(codeType, libType) VALUES (" + exist + ",'Poste ponctuel')";
                                OleDbCommand cd7 = new OleDbCommand(requete, connec);
                                cd7.ExecuteNonQuery();
                            }
                            finally
                            {
                                connec.Close();
                            }
                            ////////////////////////////////////////////////////////

                            string requete4 = @"INSERT INTO [Transaction] (codeTransaction, dateTransaction, description, montant, recetteON, percuON, type) 
                                        SELECT  MAX(t.codeTransaction) + 1, "
                                                + "format('" + datePrelevt.ToShortDateString() + "','DD/MM/YYYY'), "
                                                + "'" + textBoxPostePonctuelIntitule.Text + "' ,"
                                                + "'" + montantEcheance + "' ,"
                                                + 0 + " ,"
                                                + 0 + " ,"
                                                + exist
                                                + " FROM [Transaction] t";


                            connec.Open();
                            OleDbCommand cd4 = new OleDbCommand();
                            cd4.Connection = connec;
                            cd4.CommandType = CommandType.Text;
                            cd4.CommandText = requete4;
                            cd4.ExecuteNonQuery();

                        }
                        if (c is DateTimePicker)
                        {
                            var dateTimePicker = c as DateTimePicker;
                            datePrelevt = dateTimePicker.Value;
                        }

                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    connec.Close();
                }
            }
        }


        private void buttonPosteFixeValider_Click(object sender, EventArgs e)
        {
            if (comboBoxPosteFixePoste.SelectedValue == null)
            {
                MessageBox.Show("Selectionner un poste!");
            }
            else if (comboBoxPosteFixePeriodicite.SelectedValue == null)
            {
                MessageBox.Show("Selectionner une périodicitée!");
            }
            else if (textBoxPosteFixeJour.Text == "")
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (int.Parse(textBoxPosteFixeJour.Text) > 31 || int.Parse(textBoxPosteFixeJour.Text) <= 0)
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (textBoxPosteFixeMontant.Text == null)
            {
                MessageBox.Show("Entrer un montant!");
            }
            else
            {
                try
                {
                    connec.Open();
                    OleDbCommand cd1 = new OleDbCommand();
                    OleDbCommand cd2 = new OleDbCommand();


                    string requete1 = @"INSERT INTO PostePeriodique (codePoste, montant, typePer, jourDuMois) 
                                        SELECT  MAX(Poste.codePoste), '"
                                                + float.Parse(textBoxPosteFixeMontant.Text) + "', "
                                                + comboBoxPosteFixePeriodicite.SelectedValue + ", "
                                                + textBoxPosteFixeJour.Text
                                                + " FROM Poste";

                    string requete2 = @"INSERT INTO Poste (codePoste, libPoste) 
                                        SELECT  MAX(Poste.codePoste) + 1, '"
                                        + comboBoxPosteFixePoste.Text + "' FROM Poste";


                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = requete1;

                    cd2.Connection = connec;
                    cd2.CommandType = CommandType.Text;
                    cd2.CommandText = requete2;

                    /*
                    DialogResult result = MessageBox.Show("Execute requests? \n" + requete1 + requete2, "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                    */
                        cd2.ExecuteNonQuery();
                        cd1.ExecuteNonQuery();
                    //}

                    DataTable schemaTable = connec.GetOleDbSchemaTable(
                        OleDbSchemaGuid.Tables,
                        new object[] { null, null, null, "TABLE" });

                    ds.Clear();
                    DataSetFill(schemaTable);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    connec.Close();
                }
            }
        }

        //Bonton autre poste de Revenu
        private void buttonRevenuAutre_Click(object sender, EventArgs e)
        {
            string nomPoste = "";
            using (Form2 form = new Form2())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    nomPoste = form.nomPoste;
                }
            }

            DataTable dt = ds.Tables["Poste"];

            comboBoxRevenuPoste.DisplayMember = "libPoste";
            comboBoxRevenuPoste.ValueMember = "codePoste";
            comboBoxRevenuPoste.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["libPoste"] = nomPoste;
            dr["codePoste"] = 0;

            dt.Rows.InsertAt(dr, 0);
            comboBoxRevenuPoste.SelectedIndex = 0;

        }

        //Bonton autre poste de Poste Fixe
        private void buttonPosteFixeAutre_Click(object sender, EventArgs e)
        {
            string nomPoste = "";
            using (Form2 form = new Form2())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    nomPoste = form.nomPoste;
                }
            }

            DataTable dt = ds.Tables["Poste"];

            comboBoxPosteFixePoste.DisplayMember = "libPoste";
            comboBoxPosteFixePoste.ValueMember = "codePoste";
            comboBoxPosteFixePoste.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["libPoste"] = nomPoste;
            dr["codePoste"] = 0;

            dt.Rows.InsertAt(dr, 0);
            comboBoxPosteFixePoste.SelectedIndex = 0;
        }

        private void tabPagePosteFixe_Enter_1(object sender, EventArgs e)
        {
            ComboBoxFill(comboBoxPosteFixePoste, "Poste", "libPoste", "codePoste");
            ComboBoxFill(comboBoxPosteFixePeriodicite, "Periodicite", "libPer", "codePer");
        }

        private void textBoxPostePonctuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Autorise les virgule
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        //Lorsque l'on ecrit dans textBoxPostePonctuelNbPrelevements (generer dynamiquement les echeances dans groupBoxPostePonctuel)
        private void textBoxPostePonctuelNbPrelevements_TextChanged_1(object sender, EventArgs e)
        {
            groupBoxPostePonctuel.Controls.Clear();
            if (textBoxPostePonctuelNbPrelevements.Text != "")
            {
                for (int i = 1; i <= int.Parse(textBoxPostePonctuelNbPrelevements.Text); i++)
                {
                    if (i == 1)
                    {
                        //Label
                        this.labelPostePonctuel = new System.Windows.Forms.Label();
                        this.labelPostePonctuel.AutoSize = true;
                        this.labelPostePonctuel.Location = new System.Drawing.Point(15, 35 + i * 30);
                        this.labelPostePonctuel.Name = "labelPostePonctuel";
                        this.labelPostePonctuel.Size = new System.Drawing.Size(100, 17);
                        this.labelPostePonctuel.TabIndex = 0;
                        this.labelPostePonctuel.Text = "Echeance n°" + i;
                        this.groupBoxPostePonctuel.Controls.Add(this.labelPostePonctuel);

                        //DateTimePicker
                        this.dateTimePickerPostePonctuel1 = new System.Windows.Forms.DateTimePicker();
                        this.dateTimePickerPostePonctuel1.Location = new System.Drawing.Point(150, 30 + i * 30);
                        this.dateTimePickerPostePonctuel1.Name = "dateTimePickerPostePonctuel1";
                        this.dateTimePickerPostePonctuel1.Size = new System.Drawing.Size(250, 25);
                        this.dateTimePickerPostePonctuel1.TabIndex = 1;
                        this.dateTimePickerPostePonctuel1.ValueChanged += new System.EventHandler(this.dateTimePickerPostePonctuel1_ValueChanged);
                        this.groupBoxPostePonctuel.Controls.Add(this.dateTimePickerPostePonctuel1);


                        //TextBox
                        this.textBoxPostePonctuel1 = new System.Windows.Forms.TextBox();
                        this.textBoxPostePonctuel1.Location = new System.Drawing.Point(410, 30 + i * 30);
                        this.textBoxPostePonctuel1.Name = "textBoxPostePonctuel1";
                        this.textBoxPostePonctuel1.Size = new System.Drawing.Size(100, 25);
                        this.textBoxPostePonctuel1.TabIndex = 2;
                        this.textBoxPostePonctuel1.TextChanged += new System.EventHandler(this.textBoxPostePonctuel1_TextChanged);
                        this.textBoxPostePonctuel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostePonctuel_KeyPress);
                        this.groupBoxPostePonctuel.Controls.Add(this.textBoxPostePonctuel1);

                    }
                    else
                    {
                        //Label
                        this.labelPostePonctuel = new System.Windows.Forms.Label();
                        this.labelPostePonctuel.AutoSize = true;
                        this.labelPostePonctuel.Location = new System.Drawing.Point(15, 35 + i * 30);
                        this.labelPostePonctuel.Name = "labelPostePonctuel";
                        this.labelPostePonctuel.Size = new System.Drawing.Size(100, 17);
                        this.labelPostePonctuel.TabIndex = 0;
                        this.labelPostePonctuel.Text = "Echeance n°" + i;
                        this.groupBoxPostePonctuel.Controls.Add(this.labelPostePonctuel);


                        //DateTimePicker
                        this.dateTimePickerPostePonctuel = new System.Windows.Forms.DateTimePicker();
                        this.dateTimePickerPostePonctuel.Location = new System.Drawing.Point(150, 30 + i * 30);
                        this.dateTimePickerPostePonctuel.Name = "dateTimePickerPostePonctuel";
                        this.dateTimePickerPostePonctuel.Size = new System.Drawing.Size(250, 25);
                        this.dateTimePickerPostePonctuel.TabIndex = 1;
                        this.dateTimePickerPostePonctuel.Value = dateTimePickerPostePonctuel1.Value.AddMonths(i - 1);
                        this.groupBoxPostePonctuel.Controls.Add(this.dateTimePickerPostePonctuel);

                        //TextBox
                        this.textBoxPostePonctuel = new System.Windows.Forms.TextBox();
                        this.textBoxPostePonctuel.Location = new System.Drawing.Point(410, 30 + i * 30);
                        this.textBoxPostePonctuel.Name = "textBoxPostePonctuel";
                        this.textBoxPostePonctuel.Size = new System.Drawing.Size(100, 25);
                        this.textBoxPostePonctuel.TabIndex = 2;
                        this.textBoxPostePonctuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostePonctuel_KeyPress);
                        this.groupBoxPostePonctuel.Controls.Add(this.textBoxPostePonctuel);
                    }
                }
            }

        }

        private void dateTimePickerPostePonctuel1_ValueChanged(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Control c in groupBoxPostePonctuel.Controls)
            {
                if (c.Name == "dateTimePickerPostePonctuel")
                {
                    //Sorte de cast pour acceder au .Value
                    var dateTimePicker = c as DateTimePicker;
                    dateTimePicker.Value = dateTimePickerPostePonctuel1.Value.AddMonths(i);
                    i++;
                }
            }

        }

        private void textBoxPostePonctuel1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxPostePonctuel.Controls)
            {
                if (c.Name == "textBoxPostePonctuel")
                {
                    c.Text = textBoxPostePonctuel1.Text;
                }
            }

        }

        private void tabPageAjout_Enter(object sender, EventArgs e)
        {
            //MiseAJour();
            remplirParticipants();
            remplirDGV();
        }

        private void buttonAjoutAutreType_Click(object sender, EventArgs e)
        {

            string nomPoste = "";
            using (Form2 form = new Form2())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    nomPoste = form.nomPoste;
                }
            }

            DataTable dt = ds.Tables["TypeTransaction"];

            cbpTypeTransa.DisplayMember = "libType";
            cbpTypeTransa.ValueMember = "codeType";
            cbpTypeTransa.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["libType"] = nomPoste;

            string requete = "SELECT MAX(codeType) + 1 FROM TypeTransaction";

            OleDbCommand cd = new OleDbCommand();
            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;

            connec.Open();
            string res = cd.ExecuteScalar().ToString();
            dr["codeType"] = int.Parse(res);
            connec.Close();

            dt.Rows.InsertAt(dr, 0);
            cbpTypeTransa.SelectedIndex = 0;
        }

        private void txtBox_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void textBoxPostePonctuelIntitule_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void textBoxPostePonctuelCommentaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void textBoxUsrNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void textBoxUsrPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void tabPageOptions_Enter_1(object sender, EventArgs e)
        {
            remplirDGV();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            remplirDGV(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            remplirDGV(dateTimePicker1.Value, dateTimePicker2.Value);
        }











        //----------------SMS-----------------


        private void gestionDesSMSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                DateTime mois = DateTime.Now; //mois courant
                int prix = 0; //Prix de l'objet


                //From1.updateFromDatabase("Transaction");
                DataTable dtTransac = ds.Tables["Transaction"];
                int depense = 0; //Total des dépenses du mois

                foreach (DataRow row in dtTransac.Rows)
                {
                    if (row[4].ToString() == "False" && ((DateTime)row[1]).Month == mois.Month) //Si recette est false (donc dépense) et le mois est le mois recherché
                    {
                        depense += int.Parse(row[3].ToString());//Ajoute le montant à dépense
                    }
                }
                MessageBox.Show("TOTAL:" + depense);
                if (prix > (depense / 10))
                {
                    // Initialisation de l'account SID et du Auth Token
                    const string accountSid = "ACdf3b15468a9f55a51ed3c7f46d9207d4";
                    const string authToken = "dff35ffe4b008d0dce2da0ea9fbcd543";

                    // Initialisation du Client Twilio
                    TwilioClient.Init(accountSid, authToken);

                    //Création de l'annuaire
                    foreach (DataRow dr in ds.Tables["Personne"].Rows)
                    {
                        if (dr[3].ToString() != String.Empty) //S'il y a un numéro de téléphone
                        {
                            try
                            {
                                Twilio.Rest.Api.V2010.Account.MessageResource.Create(
                                from: new PhoneNumber("++33756796406"), // Envoie depuis un numéro SMS-enabled Twilio
                                to: new PhoneNumber(dr[3].ToString()),
                                body: $"Bonjour " + dr[2] + " " + dr[1] + ". Vous vous apprêtez à executer une transaction qui dépasse les 10% du revenu totale /!\\ "); // Contenu du message
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                }
            }
        }

        private void calendrierPrevisionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecap frm_new = new FormRecap();
            frm_new.StartPosition = this.StartPosition;
            frm_new.ShowDialog();
        }

        private void recapPostesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecapPostes frm_new = new FormRecapPostes();
            frm_new.StartPosition = this.StartPosition;
            frm_new.ShowDialog();
        }

        private DataGridViewCellEventArgs mouseLocation;

        private void dataGridViewRecapFixes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            int codePoste = int.Parse(dataGridView1.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString());

            DateTime date = DateTime.Today;
            string description = "";
            double montant;
            int recetteON = 0;
            int percuON = 0;
            int type = 0;

            using (FormRecapFixModif form = new FormRecapFixModif())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    montant = form.montant;
                    typePeriod = form.typePeriod;
                    jourMois = form.jourMois;
                    description = form.description;

                    //Update la dataBase
                    connec.Open();
                    string requete = "UPDATE [PostePeriodique] SET montant='" + montant + "', typePer=" + typePeriod + ", jourDuMois=" + jourMois + " WHERE codePoste=" + codePoste;
                    OleDbCommand cd = new OleDbCommand();
                    cd.Connection = connec;
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = requete;
                    cd.ExecuteNonQuery();
                    requete = "UPDATE [Poste] SET libPoste='" + description + "' WHERE codePoste=" + codePoste;
                    cd.CommandText = requete;
                    cd.ExecuteNonQuery();
                    connec.Close();


                    //Update la dgv
                    try
                    {
                        connec.Open();
                        dt.Clear();
                        requete = "SELECT pp.codePoste as Code, p.libPoste as Descrition, pp.montant as Montant, pd.libPer as Periodicite, pp.jourDuMois as [Jour du Mois] FROM PostePeriodique pp, Periodicite pd, Poste p WHERE pp.codePoste=p.codePoste and pp.typePer=pd.codePer";
                        cd.Connection = connec;
                        cd.CommandType = CommandType.Text;
                        cd.CommandText = requete;
                        OleDbDataAdapter da = new OleDbDataAdapter(cd);
                        da.Fill(dt);
                        dataGridViewRecapFixes.DataSource = dt;
                    }
                    finally
                    {
                        connec.Close();
                    }
                }
            }
            */
            
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codeTransaction = 1;
            try
            {
                codeTransaction = int.Parse(dataGridView1.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception x)
            { }

            connec.Open();
            string requete = "DELETE FROM [Beneficiaires] WHERE codeTransaction=" + codeTransaction; 
            OleDbCommand cd = new OleDbCommand();
            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;
            cd.ExecuteNonQuery();


            requete = "DELETE FROM [Transaction] WHERE codeTransaction=" + codeTransaction;
            cd.CommandText = requete;
            cd.ExecuteNonQuery();

            connec.Close();

            //Update la dgv
            remplirDGV();
        }
    }
}
