using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinForms.Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db=new DLWMSDbContext();
        public frmStudentiPredmeti(Student odabraniStudent)
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPolozenePredmete();
            UcitajPodatkeOStudentu();
            UcitajPredmete();
            cmbOcjene.SelectedIndex = 0;
        }

        private void UcitajPredmete()
        {
            //cmbPredmeti.DataSource = InMemoryDB.Predmeti;
            DataLoader.ToComboBox(cmbPredmeti, db.Predmeti.ToList());
        }

        private void UcitajPodatkeOStudentu()
        {
            pbSlika.Image =ImageHelper.FromByteToImage(odabraniStudent.Slika);
            lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
            lblIndeks.Text = $"{odabraniStudent.BrojIndeksa}";
        }

        private void UcitajPolozenePredmete()
        {
            var binding = new BindingSource();
            binding.DataSource = db.StudentiPredmeti.Where
               (polozeni => polozeni.StudentId == odabraniStudent.Id).ToList(); ;
            //dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = binding;
            //dgvPolozeniPredmeti.DataSource = odabraniStudent.PolozeniPredmeti;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;

                if (PredmetVecDodat())
                {
                    var poruka = Resursi.Get(Kljucevi.PodatakVecPostoji);
                    var ispis = string.Format(poruka, predmet.Naziv);
                    MessageBox.Show(ispis, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);//<<<<<
                    return;
                }
                var polozeni = new StudentPredmet()
                {
                    //Id = odabraniStudent.PolozeniPredmeti.Count() + 1,
                    Datum = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    PredmetId = predmet.Id,
                    StudentId=odabraniStudent.Id
                };
               db.StudentiPredmeti.Add(polozeni);
                db.SaveChanges();
                UcitajPolozenePredmete();
            }
        }

        private bool PredmetVecDodat()
        {
            
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmet;
            return db.StudentiPredmeti.Where
                ( polozeni => polozeni.PredmetId == odabraniPredmet.Id && 
                polozeni.StudentId==odabraniStudent.Id).Count() > 0;
            
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, Kljucevi.ObaveznaVrijednost)  
                && Validator.ValidirajKontrolu(cmbOcjene, err, Kljucevi.ObaveznaVrijednost);

        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (dgvPolozeniPredmeti.CurrentCell is DataGridViewButtonCell)
            {
                int indeksReda=dgvPolozeniPredmeti.CurrentCell.RowIndex;
                dgvPolozeniPredmeti.Rows.RemoveAt(indeksReda);
            }
        }
    }
}
