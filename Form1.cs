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
            string temp;
            int posStoppato = lst.SelectedIndex;
            string nomeStoppato = classifica[posStoppato];
            for(int i = posStoppato; i < posStoppato+3; i++)
            {
                for(int j = posStoppato; j < posStoppato+3; j++)
                {
                    
                }
            }
            classifica[posStoppato + 3] = nomeStoppato;
            Aggiorna(classifica);
        }

        private void btnRitiro_Click(object sender, EventArgs e)
        {
            Aggiorna(classifica);
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            Aggiorna(classifica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aggiorna(classifica);
        }
    }
}

