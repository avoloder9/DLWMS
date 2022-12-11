using System.Reflection.PortableExecutable;

namespace DLWMS.Data
{

    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<Student> Studenti = GenerisiStudente();
        public static List<GodinaStudija> GodineStudija = GenerisiGodineStudija();
        public static List<Spol> Spolovi = GenerisiSpolove();
        public static List<Predmet> Predmeti = GenerisiPredmete();

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>() {
                    new Predmet()  { Id = 1, Naziv="Programiranje III"},
                    new Predmet()  { Id = 2, Naziv="Matematika III" },
                    new Predmet()  { Id = 3, Naziv="Marketing" }
            };
        }

        private static List<Spol> GenerisiSpolove()
        {
            return new List<Spol>() {
                    new Spol()  { Id = 1, Naziv="*******"},
                    new Spol()  { Id = 2, Naziv="Zenski" },
                    new Spol()  { Id = 3, Naziv="Muski" }                   
            };
        }

        private static List<GodinaStudija> GenerisiGodineStudija()
        {
            return new List<GodinaStudija>() {
                    new GodinaStudija()  { Id = 1, Aktivna = true, Oznaka= "1 - GODINA", Opis = "Prva godina studija"  },
                    new GodinaStudija()  { Id = 2, Aktivna = true, Oznaka= "2 - GODINA", Opis = "Druga godina studija"  },
                    new GodinaStudija()  { Id = 3, Aktivna = true, Oznaka= "3 - GODINA", Opis = "Treca godina studija"  },
                    new GodinaStudija()  { Id = 4, Aktivna = true, Oznaka= "4 - GODINA", Opis = "Cetvrta godina studija"  }

            };            
        }
        private static List<Student> GenerisiStudente()
        {
            return new List<Student>() {
                    new Student()  {
                        Id = 1,
                        Aktivan = true,
                        Email = "adnan@edu.fit.ba",
                        Ime = "Adnan",
                        Prezime = "Voloder",
                        BrojIndeksa = "IB210012",
                        Lozinka = "adnan",
                        DatumRodjenja = new DateTime(2000,2,2),
                        GodinaStudija = 1,
                        Slika = null           
                    },
                    new Student()  {
                        Id = 2,
                        Aktivan = true,
                        Email = "faris@edu.fit.ba",
                        Ime = "Faris",
                        Prezime = "Dizdarevic",
                        BrojIndeksa = "IB210022",
                        Lozinka = "faris",
                        DatumRodjenja = new DateTime(2000,3,3),
                        GodinaStudija = 1,
                        Slika = null
                    }
            };
        }
        private static List<Korisnik> GenerisiKorisnike()
        {

            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Aktivan = true,
            //    Email = "admin@edu.fit.ba",
            //    Ime = "Administrator",
            //    Prezime = "FIT",
            //    KorisnickoIme = "admin",
            //    Lozinka = "admin"
            //};
            //var lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;

            return new List<Korisnik>() {
                    new Korisnik()  {
                        Id = 1,
                        Aktivan = true,
                        Email = "admin@edu.fit.ba",
                        Ime = "Administrator",
                        Prezime = "FIT",
                        KorisnickoIme = "admin",
                        Lozinka = "admin"
                    }
            };
        }
    }
}