using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'incasariDS1.NoteElev' table. You can move, or remove it, as needed.
            this.noteElevTableAdapter.Fill(this.incasariDS1.NoteElev);
            // TODO: This line of code loads data into the 'incasariDS.NoteElev' table. You can move, or remove it, as needed.
            this.noteElevTableAdapter.Fill(this.incasariDS.NoteElev);

        }
    }
}
