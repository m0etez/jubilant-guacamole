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

namespace Projet

{
    public partial class FormRecap : Form
    {
        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\budget1.mdb");

        DataSet ds = new DataSet(); // contient les tables "Fixe", "Ponct" et "Revenus"
        DataTable previsionnel = new DataTable(); // DataTable à afficher dans le dgv


        public FormRecap()
        {
            InitializeComponent();
        }

        private void FormRecap_Load(object sender, EventArgs e)
        {
            shapeDt();
            ds.Tables.Add("Fixe");
            ds.Tables.Add("Ponct");
            ds.Tables.Add("Revenus");
            ds.Tables.Add("Echeances");
            ds.Tables.Add("Poste");

            fillDt("SELECT * FROM PostePeriodique", ds.Tables["Fixe"]);
            fillDt("SELECT * FROM PostePonctuel", ds.Tables["Ponct"]);
            fillDt("SELECT * FROM PosteRevenu", ds.Tables["Revenus"]);
            fillDt("SELECT * FROM Echeances", ds.Tables["Echeances"]);
            fillDt("SELECT * FROM Poste", ds.Tables["Poste"]);

            insererRevenus();
            insererFixe();
            totalPerMonth();
            dgvPrevisionnelAnnuel.DataSource = previsionnel;
            dgvPrevisionnelAnnuel.Columns["Poste"].Frozen = true;

            // set le fontstyle de la dernière ligne (Total) en bold
            System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dgvPrevisionnelAnnuel.Rows[dgvPrevisionnelAnnuel.Rows.Count - 2].DefaultCellStyle = boldStyle;
        }

        //Ajoute les différentes colonnes à la dataTable previsionnel
        private void shapeDt()
        {
            previsionnel.Columns.Add("Poste");
            previsionnel.Columns.Add("Janvier");
            previsionnel.Columns.Add("Fevrier");
            previsionnel.Columns.Add("Mars");
            previsionnel.Columns.Add("Avril");
            previsionnel.Columns.Add("Mai");
            previsionnel.Columns.Add("Juin");
            previsionnel.Columns.Add("Juillet");
            previsionnel.Columns.Add("Aout");
            previsionnel.Columns.Add("Septembre");
            previsionnel.Columns.Add("Octobre");
            previsionnel.Columns.Add("Novembre");
            previsionnel.Columns.Add("Decembre");


        }

        // remplie la DataTable saisie en parametre selon la requête
        private void fillDt(string req, DataTable table)
        {
            try
            {
                connec.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(req, connec);
                da.Fill(table);
            }
            catch (Exception) { }
            finally { connec.Close(); }
        }

        // insere les postes fixes dans la DataTable previsionnel
        private void insererFixe()
        {

            DateTime date = new DateTime(DateTime.Today.Year, 1, 1);

            foreach (DataRow dr in ds.Tables["Fixe"].Rows)
            {
                DataRow dtr = previsionnel.NewRow();
                for (int i = 0; i <= 12; i++)
                {
                    if (i == 0)
                        dtr[i] = ds.Tables["Poste"].Select("codePoste = " + dr["codePoste"])[0]["libPoste"].ToString(); // récupération de la description du poste
                    else
                    {
                        switch (Convert.ToInt32(dr["typePer"]))
                        {
                            case 1: // si la periodicité est hebdomadaire
                                {
                                    DayOfWeek dayOfWeek = getDayOfWeek(Convert.ToInt32(dr["jourDuMois"]));
                                    int daysInMonth = countSpecificDaysInMonth(date.AddMonths(i - 1), dayOfWeek);
                                    dtr[i] = (Convert.ToInt32(dr["montant"]) * daysInMonth) - (2 * Convert.ToInt32(dr["montant"]) * daysInMonth);
                                    break;
                                }

                            case 2: // si la periodicité est mensuelle
                                {
                                    dtr[i] = Convert.ToInt32(dr["montant"]) - 2 * Convert.ToInt32(dr["montant"]);
                                    break;
                                }

                            case 3: // si la periodicité est bimestrielle
                                {
                                    if (i % 2 == 1)
                                        dtr[i] = Convert.ToInt32(dr["montant"]) - 2 * Convert.ToInt32(dr["montant"]);
                                    break;
                                }

                            case 4: // si la periodicité est trimestrielle
                                {
                                    if (i % 3 == 1)
                                        dtr[i] = Convert.ToInt32(dr["montant"]) - 2 * Convert.ToInt32(dr["montant"]);
                                    break;
                                }

                            case 5: // si la periodicité est semestrielle
                                {
                                    if (i % 6 == 1)
                                        dtr[i] = Convert.ToInt32(dr["montant"]) - 2 * Convert.ToInt32(dr["montant"]);
                                    break;
                                }

                            default: // si la periodicité est annuelle
                                {
                                    if (i == 1)
                                        dtr[i] = dr["montant"];
                                    break;
                                }
                        }
                    }
                }
                previsionnel.Rows.Add(dtr);
            }
            
        }

        // insere les revenus dans la DataTable previsionnel
        private void insererRevenus()
        {
            foreach (DataRow dr in ds.Tables["Revenus"].Rows)
            {
                DataRow dtr = previsionnel.NewRow();
                for (int i = 0; i <= 12; i++)
                {
                    if (i == 0)
                        dtr[i] = ds.Tables["Poste"].Select("codePoste = " + dr["codePoste"])[0]["libPoste"].ToString(); // récupération de la description du poste
                    else
                        dtr[i] = dr["montant"];
                }
                previsionnel.Rows.Add(dtr);
            }
        }

        // compte le nombre de jour (Lundi, Mardi...) dans le mois actuellement analysé
        private int countSpecificDaysInMonth(DateTime firstDay, DayOfWeek day)
        {
            DateTime lastDay = new DateTime(firstDay.Year, firstDay.Month, DateTime.DaysInMonth(firstDay.Year, firstDay.Month)); // dernier jour du mois actuellement traité
            int res = 0; // compteur de jours du type recherché dans ce mois
            for (DateTime dt = firstDay; dt != lastDay;)
            {
                if (dt.DayOfWeek == day)
                {
                    res++;
                }
                dt = dt.AddDays(1);
            }
            return res;
        }

        // renvoie le nom du jour en fonction de la valeur entrée en paramètre
        private DayOfWeek getDayOfWeek(int dayCode)
        {
            DayOfWeek res = DayOfWeek.Monday;
            switch (dayCode)
            {
                case 1:
                    res = DayOfWeek.Monday;
                    break;
                case 2:
                    res = DayOfWeek.Tuesday;
                    break;
                case 3:
                    res = DayOfWeek.Wednesday;
                    break;
                case 4:
                    res = DayOfWeek.Thursday;
                    break;
                case 5:
                    res = DayOfWeek.Friday;
                    break;
                case 6:
                    res = DayOfWeek.Saturday;
                    break;
                default:
                    res = DayOfWeek.Sunday;
                    break;
            }
            return res;
        }

        // ajoute, pour chaque mois, le total des dépenses et recettes à la dernière ligne de la datatable
        private void totalPerMonth()
        {
            DataRow total = previsionnel.NewRow();
            double somme = 0; // somme par mois
            total["Poste"] = "Total";

            for (int i = 1; i <= 12; i++)
            {
                somme = 0; // on remet la valeur de somme à 0 pour chaque nouveau mois
                foreach (DataRow dr in previsionnel.Rows)
                {
                    if (!DBNull.Value.Equals(dr[i])) // si la cellule visitée n'a pas la valeur DBNull
                    {
                        somme += double.Parse(dr[i].ToString()); // on ajout la valeur de la cellule à la variable "somme"
                    }  
                }
                total[i] = somme; // on attribue la valeur de "somme" à la DataRow "total" pour le mois donné
            }
            previsionnel.Rows.Add(total);

        }
    }
}
