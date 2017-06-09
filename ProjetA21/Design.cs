using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetA21
{
    class Design
    {



        //Declaration du form principal 
        static FormBudgestion form = new FormBudgestion();


        /*/TO DO: Changer la couleurs de plus de controls 
        //change la couleur de tous les controls appartenants au control avec lequel la fonction est appelée
        public static void setAppColor(Control control, Color color)
        { 
            foreach (Control c in control.Controls)
            {
                if (!(c is Button))
                {
                    setControlColor(c, color);
                    foreach (Control c1 in c.Controls)
                    {
                        setControlColor(c1, color);
                    }
                }
            }
        }
        
        public static void setControlColor(Control control, Color color)
        {
            control.BackColor = color;
        }
        */

        /*
        public static void tabpage_paint_background(object sender, PaintEventArgs e)
        {
            SolidBrush fillBrush = new SolidBrush(Color.Black);

            e.Graphics.FillRectangle(fillBrush, e.ClipRectangle);
        }
        */


    }
}
