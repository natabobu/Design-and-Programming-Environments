using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void motiveExmatriculareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgentMotiveExmatriculare agent_motiv = new AgentMotiveExmatriculare();
            agent_motiv.ShowDialog();
        }

        private void tipuriInscriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgentTipuriInscrieri agent_tip = new AgentTipuriInscrieri();
            agent_tip.ShowDialog();
        }

        private void inscriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvenimentInscriere evenimentInscriere = new EvenimentInscriere();
            evenimentInscriere.ShowDialog();
        }

        private void exmatriculareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvenimentExmatriculare evenimentExmatriculare = new EvenimentExmatriculare();
            evenimentExmatriculare.ShowDialog();

        }

        private void claseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResursaClase resursaClasa = new ResursaClase();
            resursaClasa.ShowDialog();
        }

        private void eleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResursaElevi resursaElevi = new ResursaElevi();
            resursaElevi.ShowDialog();
        }
    }
}
