﻿using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinForms.Asinhrono
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();
        }

        private void frmPing_Load(object sender, EventArgs e)
        {
            PostaviPocetneVrijednosti();
        }

        private void PostaviPocetneVrijednosti()
        {
            txtUrl.Text = "www.google.ba";
            cmbBrojPonavljanja.SelectedIndex = 1;
            cmbPauza.SelectedIndex = 1;
        }

        public string Sadrzaj { get; set; }
        private void PingGoogle()
        {
            try
            {
                var ping = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    var odgovor = ping.Send("www.google.ba");
                    Sadrzaj += PingReplyToString(odgovor);
                    Thread.Sleep(200);
                    BeginInvoke(PrikaziSadrzaj);

                }
            }
            catch (Exception ex)
            {
                Sadrzaj = ex.Message;
            }
        }
        private async void PingSite(object obj)
        {
            try
            {
                var ping = new Ping();
                var pingConfig = obj as dtoPing;
                for (int i = 0; i < pingConfig.BrojPonavljanja; i++)
                {
                    var odgovor = await ping.SendPingAsync(pingConfig.Url);
                    Sadrzaj += PingReplyToString(odgovor);
                    Thread.Sleep(pingConfig.Pauza);
                    BeginInvoke(PrikaziSadrzaj);
                }
            }
            catch (Exception ex)
            {
                Sadrzaj = ex.Message;
            }
        }

        private string PingReplyToString(PingReply odgovor)
        {
            return $"{odgovor.Address}\t" + $"{odgovor.RoundtripTime}\t{odgovor.Status}{Environment.NewLine}";
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            var brojPonavljanja = int.Parse(cmbBrojPonavljanja.Text);
            var pauza = int.Parse(cmbPauza.Text);
            var url = txtUrl.Text;
            Thread google = new Thread(() => PingSite(new dtoPing()
            {
                BrojPonavljanja = brojPonavljanja,
                Pauza = pauza,
                Url = url
            }));
            //Thread yahoo = new Thread(() => PingSite(new dtoPing()
            //{
            //    BrojPonavljanja = brojPonavljanja,
            //    Pauza = pauza,
            //    Url = "www.yahoo.com"
            //}));

            //Thread studenti = new Thread(DodajStudente);
            google.Start();
            //yahoo.Start();
            //studenti.Start();


            var poruka = await DodajStudenteUzProvjeru();
            MessageBox.Show(poruka);
            PrikaziSadrzaj();
        }

        private async Task<string> DodajStudenteUzProvjeru()
        {
            await Task.Run(() => PingSite(new dtoPing()
            {
                BrojPonavljanja = 10,
                Pauza = 100,
                Url = "www.yahoo.com"
            }));
            await Task.Run(() => DodajStudente());
            return "Svi SERVISI dostupni i STUDENTI dodati! ";
        }

        private async void DodajStudente()
        {
            try
            {
                DLWMSDbContext db = new DLWMSDbContext();
                var slika = db.Studenti.Find(1)?.Slika;
                var spol = db.Spolovi.Find(1);
                for (int i = 0; i < 30; i++)
                {
                    var noviStudent = new Student()
                    {
                        Aktivan = true,
                        BrojIndeksa = $"IB{220000 + i}",
                        DatumRodjenja = DateTime.Now,
                        Email = $"Ime{i + 1}.Prezime{i + 1}@edu.fit.ba",
                        GodinaStudija = 1,
                        Ime = $"Ime{i + 1}",
                        Prezime = $"Prezime{i + 1}",
                        Lozinka = "TajnaLozinka",
                        Slika = slika,
                        Spol = spol
                    };
                    db.Studenti.Add(noviStudent);
                    Sadrzaj += $"Dodat student=> {noviStudent}{Environment.NewLine}";
                    BeginInvoke(PrikaziSadrzaj);
                }
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Sadrzaj = ex.Message;
            }
        }

        private void PrikaziSadrzaj()
        {
            txtIspis.Text = Sadrzaj;
            PomjeriNaKraj();
        }

        private void PomjeriNaKraj()
        {
            txtIspis.SelectionStart = txtIspis.Text.Length;
            txtIspis.ScrollToCaret();
        }
    }

    public class dtoPing
    {
        public int BrojPonavljanja { get; set; }
        public int Pauza { get; set; }
        public string Url { get; set; }
    }
}
