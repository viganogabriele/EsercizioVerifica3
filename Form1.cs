using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioVerifica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] classifica =
        {
            "Max Verstappen",
            "Charles Leclerc",
            "Sergio Perez",
            "George Russell",
            "Carlos Sainz Jr.",
            "Lewis Hamilton",
            "Lando Norris",
            "Esteban Ocon",
            "Fernando Alonso",
            "Valtteri Bottas"
        };

        void Aggiorna (string [] classifica)
        {
            lst.Items.Clear();
            for (int i = 0; i < classifica.Length; i++)
            {
                lst.Items.Add(classifica[i]);
            }
        }

        private void btnSorpasso_Click(object sender, EventArgs e)
        {
            int pos = lst.SelectedIndex;
            if(pos != 0)
            {
                string sorpassato = classifica[pos - 1];
                classifica[pos - 1] = classifica[pos];
                classifica[pos] = sorpassato;
                Aggiorna(classifica);
            }  
        }
       
        private void btnStop_Click(object sender, EventArgs e)
        {
            int start = lst.SelectedIndex;
            int end = start+3;
            string temp = classifica[start];
            for(int i = start; i<end; i++)
            {
                classifica[i] = classifica[i+1];
            }
            classifica[end] = temp;
            Aggiorna(classifica);
        }

        private void btnRitiro_Click(object sender, EventArgs e)
        {
            int start = lst.SelectedIndex;
            int end = 9;
            string temp = classifica[start];
            for (int i = start; i < end; i++)
            {
                classifica[i] = classifica[i + 1];
            }
            classifica[end] = "X " +temp;
            Aggiorna(classifica);
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            lblFine.Text = "1: " + classifica[0] + "\n2: " + classifica[1] + "\n3: " + classifica[2];
            Aggiorna(classifica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aggiorna(classifica);
        }
    }
}

