using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class EinstellungenDialog : Form
    {
        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return rueckgabe;
        }

        public EinstellungenDialog()
        {
            InitializeComponent();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
