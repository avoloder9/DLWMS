using DLWMS.WinForms.Studenti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pretraga= new Studenti.frmStudentiPretraga();
            PrikaziFormu(pretraga);
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }


        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ping = new Asinhrono.frmPing();
            ping.MdiParent = this;
            ping.Show();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviStudent = new Studenti.frmStudentNovi();
            PrikaziFormu(noviStudent);
        }

        private void pretragaStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Studenti.frmStudentiPretraga());
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("Da li ste sigurni da zelite zatvoriti glavnu formu","Pitanje",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            
                e.Cancel = true;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPrikaziDatumVrijeme.Text = DateTime.Now.ToString();
        }
    }
}
