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
    public partial class FormFixe : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Lorsque qu'on reste cliqué sur le menuStrip (mettre dans l'evenement mousedown du control qui autorise le deplacement
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //Déplace le form
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        string adress = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\budget1.mdb";
        OleDbConnection co;
        DataTable dt = new DataTable();
        DataTable dtPer = new DataTable();
        private DataRow dar;

        public FormFixe(DataTable dtPPer, DataTable dtP, DataTable dtPer)
        {
            InitializeComponent();
            this.dtPer = dtPer;
            this.dt.Columns.Add("Code", typeof(int));
            this.dt.Columns.Add("Description", typeof(string));
            this.dt.Columns.Add("Montant", typeof(int));
            this.dt.Columns.Add("Periodicite", typeof(string));

            foreach (DataRow r in dtPPer.Rows)
            {
                DataRow rFinal = dt.NewRow();
                int i = 0;
                int y = 0;

                while ((int)dtP.Rows[i][0] != (int)r[0])
                    i++;

                while ((int)dtPer.Rows[y][0] != (int)r[2])
                    y++;

                rFinal["Code"] = r[0];
                rFinal["Description"] = dtP.Rows[i][1];
                rFinal["Montant"] = r[1];
                rFinal["Periodicite"] = dtPer.Rows[y][1];
                this.dt.Rows.Add(rFinal);
            }
        }
        public FormFixe()
        {
            InitializeComponent();
        }

        public FormFixe(DataRow dar, DataTable dtPer)
        {
            this.dar = dar;
            this.dtPer = dtPer;
        }

        public DataRow donner
        {
            get
            {
                return dar;
            }
        }

        private void FormFixe_Load(object sender, EventArgs e)
        {
            dtg_AperçuFixe.DataSource = this.dt;
        }

        private void ctm_Event_Modifier_Click(object sender, EventArgs e)
        {

            if (dtg_AperçuFixe.CurrentCell.ColumnIndex != 0)
            {
                int row = dtg_AperçuFixe.CurrentCell.RowIndex;
                DataRow dar = dt.Rows[row];

                FormFixe frm = new FormFixe(dar, dtPer);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    co = new OleDbConnection(adress);
                    OleDbCommand rd = new OleDbCommand();
                    co.Open();
                    OleDbTransaction trans = co.BeginTransaction();
                    rd.Connection = co;
                    rd.Transaction = trans;
                    try
                    {


                        rd.CommandText = "Update [poste] set [libPoste]  = '" + frm.donner[1] + "' where [codePoste] =" + frm.donner[0];
                        rd.ExecuteNonQuery();
                        rd.CommandText = "Update [postePeriodique] set [typePer] =" + frm.donner[3] + ",[montant] =" + frm.donner[2] + " where [codePoste] =" + frm.donner[0];
                        rd.ExecuteNonQuery();
                        trans.Commit();
                        MessageBox.Show("La modification a bien était pris en compte");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); trans.Rollback(); }
                    co.Close();
                    dtg_AperçuFixe.Rows[row].Cells["Description"].Value = frm.donner[1];
                    int i = 0;
                    while (int.Parse("" + frm.donner[3]) != int.Parse("" + dtPer.Rows[i]["CodePer"]))
                        i++;
                    dtg_AperçuFixe.Rows[row].Cells["Periodicite"].Value = "" + dtPer.Rows[i]["libPer"];
                    dtg_AperçuFixe.Rows[row].Cells["Montant"].Value = frm.donner[2];
                }


            }
            else { MessageBox.Show("Vous ne pouvais pas modifier cette case"); }


        }


        private void dtg_AperçuFixe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.RowIndex <= (dtg_AperçuFixe.Rows.Count - 2) && e.ColumnIndex >= 0)
            {
                dtg_AperçuFixe.CurrentCell = dtg_AperçuFixe.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void ctm_Event_Supprimer_Click(object sender, EventArgs e)
        {
            int row = dtg_AperçuFixe.SelectedCells[0].RowIndex;
            DialogResult supr = MessageBox.Show("Etez-vous sûre de vouloir supprimer la ligne: " + (row + 1), "Verification de suppression", MessageBoxButtons.YesNo);
            if (supr == DialogResult.Yes)
            {
                co = new OleDbConnection(adress);
                co.Open();
                try
                {
                    OleDbCommand rd = new OleDbCommand("Delete from [PostePeriodique] where [codePoste] =" + (int)dtg_AperçuFixe.Rows[row].Cells[0].Value, co);
                    rd.ExecuteNonQuery();
                    dtg_AperçuFixe.Rows.Remove(dtg_AperçuFixe.Rows[row]);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }



        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btn_reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    }
