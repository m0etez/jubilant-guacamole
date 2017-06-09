using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA21
{
    class Interaction_BDD
    {

        static FormBudgestion form = new FormBudgestion();

        public static void ajouter_personne(string nom, string pn, string num, object sender, EventArgs e)
        {
            //TO DO: Insérer une personne 
            /*
            try
            { 
            connec.Open();

            OleDbCommand cd = new OleDbCommand();
            string requete = @"INSERT INTO Commandes (N° commande, Code client, N° employé, Date commande, Destinataire) 
                                    VALUES ( " + int.Parse(txtBoxNumCom.Text.ToString()) + ", '" + cbboxClient.SelectedValue + "', " + int.Parse(cbboxEmp.SelectedValue.ToString()) + ", '" + monthCal.SelectionRange.Start.ToShortDateString() + "', '" + txtBoxDest.Text.ToString() + "' )";
            cd.Connection = connec;
            cd.CommandType = CommandType.Text;
            cd.CommandText = requete;

            //MessageBox.Show(requete);
            //cd.ExecuteNonQuery();
            DialogResult result = MessageBox.Show("Exécute request? \n" + requete, "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == form.DialogResult.Yes)
                {
                    cd.ExecuteNonQuery();
                }
            }
            catch (Exception erreur)
            {
                form.MessageBox.Show(erreur.StackTrace.ToString());
                form.MessageBox.Show(erreur.GetType().ToString());
            }
            finally
            {
                form.connec.Close();
            }
            */
            form.tabPageOptions_Enter(sender, e);
        }

    }
}
