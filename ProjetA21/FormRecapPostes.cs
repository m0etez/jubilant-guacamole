using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetA21
{
    public partial class FormRecapPostes : Form
    {
        public FormRecapPostes()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\budget1.mdb");

        DataSet ds = new DataSet(); // contient les tables "Fixe", "Ponct" et "Revenus"
        DataTable dt = new DataTable(); // DataTable à afficher dans le dgv

        private void FormRecapPostes_Load(object sender, EventArgs e)
        {
            connec.Open();

            DataTable schemaTable = connec.GetOleDbSchemaTable(
                OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            DataSetFill(schemaTable);

            //REMPLIR POSTE FIXE----------------------------------------------
            OleDbCommand cd = new OleDbCommand();
            string requete = "SELECT pp.codePoste as Code, p.libPoste as Descrition, pp.montant as Montant, pd.libPer as Periodicite, pp.jourDuMois as [Jour du Mois] FROM PostePeriodique pp, Periodicite pd, Poste p WHERE pp.codePoste=p.codePoste and pp.typePer=pd.codePer";

            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;
            OleDbDataAdapter da = new OleDbDataAdapter(cd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRecapFixes.DataSource = dt;

            //REMPLIR POSTE PONCTUEL----------------------------------------------
            requete = "SELECT pp.codePoste as Poste, pp.commentaire as Description, COUNT(e.codePoste) as Echeances, SUM(e.montantEcheance) as Montant FROM PostePonctuel pp, Echeances e WHERE e.codePoste=pp.codePoste GROUP BY pp.codePoste, pp.commentaire, e.codePoste";

            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cd);

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridViewRecapPonctuel.DataSource = dt1;


            //REMPLIR POSTE REVENU----------------------------------------------
            requete = "SELECT pr.codePoste as Poste, p.libPoste as Description, pn.pnPersonne + ' ' + pn.nomPersonne as Beneficiaire, pr.montant as Montant FROM PosteRevenu pr, Personne pn, Poste p WHERE pn.codePersonne=pr.codePersonne AND pr.codePoste=p.codePoste";

            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;
            OleDbDataAdapter da2 = new OleDbDataAdapter(cd);

            DataTable dt2 = new DataTable();
            da1.Fill(dt2);
            dataGridViewRecapRevenu.DataSource = dt2;

            connec.Close();
        }

        //Met à jour les DGV
        private void updateDGV() 
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
            finally
            {
                connec.Close();
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

        private DataGridViewCellEventArgs mouseLocation;

        private void dataGridViewRecapFixes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        //Modifier Poste Fixe
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codePoste = 1;
            try
            {
            codePoste = int.Parse(dataGridViewRecapFixes.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception x)
            { }

            double montant = 0;
            int typePeriod = 0;
            int jourMois = 0;
            string description = "";
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
                    string requete = "UPDATE [PostePeriodique] SET montant='"+montant+"', typePer="+typePeriod+", jourDuMois="+jourMois+" WHERE codePoste=" + codePoste;
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
        }

        //Supprimer Poste Fixe
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codePoste = 1;
            try
            {
            codePoste = int.Parse(dataGridViewRecapFixes.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception x)
            { }

            connec.Open();
            string requete = "DELETE FROM [PostePeriodique] WHERE codePoste=" + codePoste;
            OleDbCommand cd = new OleDbCommand();
            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;
            cd.ExecuteNonQuery();
            /*
            requete = "DELETE FROM [Poste] WHERE codePoste=" + codePoste;
            cd.CommandText = requete;
            cd.ExecuteNonQuery();
            */
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

        //modifier poste pontuel
        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //supprimer poste pontuel
        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //modifier poste revenu
        private void modifierToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //supprimer poste revenu
        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRecapPonctuel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                int codePoste = int.Parse(dataGridViewRecapPonctuel.Rows[mouseLocation.RowIndex].Cells[0].Value.ToString());
                }
                catch (Exception x)
                { }
                FormEcheances form = new FormEcheances();
                form.Show();
            }
        }
    }
}
