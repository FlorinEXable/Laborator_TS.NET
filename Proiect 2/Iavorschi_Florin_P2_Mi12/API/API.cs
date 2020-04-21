using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7
{
    public class API
    {
        public int PhotoExist(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                return context.Photos.Where(p => p.Cale == caleGUI).Count();
            }
        }

        public void AddPhoto(string caleGUI, DateTime dataCrearii, string eveniment, string loc, string persoane)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                Photo p = new Photo()
                {
                    Cale = caleGUI,
                    DataCreare = dataCrearii,
                    Eveniment = eveniment,
                    Loc = loc,
                    Persoane = persoane
                };
                if (PhotoExist(caleGUI) == 0)
                {
                    context.Photos.Add(p);
                    context.SaveChanges();
                }
                else
                {
                    var foto = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                    foto.DataCreare = dataCrearii;
                    foto.Eveniment = eveniment;
                    foto.Loc = loc;
                    foto.Persoane = persoane;
                    context.SaveChanges();
                }
            }
        }

        public string GetNume(string caleGUI)
        {
            return caleGUI.Split('\\').Last();
        }

        public string GetEveniment(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                return p.Eveniment;
            }
        }
        public string GetLoc(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                return p.Loc;
            }
        }
        public DateTime GetDataCrearii(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                return p.DataCreare.Value;
            }
        }
        public List<String> GetNames()
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                List<string> lista = new List<string>();
                var p = context.Photos.OrderByDescending(photo => photo.DataCreare);
                foreach (var x in p)
                {
                    lista.Add(x.Cale);
                }
                return lista;
            }
        }
        public string GetPersoane(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                if (p.Persoane is null || p.Persoane == "")
                {
                    return p.Persoane;
                }
                else
                {
                    return p.Persoane.Remove(p.Persoane.Length - 1);
                }
            }
        }
        public List<string> GetEvenimentList(string cautare)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Eveniment == cautare).OrderByDescending(photo => photo.DataCreare);
                List<string> lista = new List<string>();
                foreach (var x in p)
                {
                    lista.Add(x.Cale);
                }
                return lista;
            }
        }
        public List<string> GetLocList(string cautare)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Loc == cautare).OrderByDescending(photo => photo.DataCreare);
                List<string> lista = new List<string>();
                foreach (var x in p)
                {
                    lista.Add(x.Cale);
                }
                return lista;
            }
        }
        public List<string> GetPersoanaList(string cautare)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Persoane.Contains(cautare)).OrderByDescending(photo => photo.DataCreare);
                List<string> lista = new List<string>();
                foreach (var x in p)
                {
                    lista.Add(x.Cale);
                }
                return lista;
            }
        }
        public List<string> GetDataCreariiList(string cautare)
        {
            DateTime dataCrearii;
            if (DateTime.TryParse(cautare, out dataCrearii))
            {
                using (PhotoContainer context = new PhotoContainer())
                {
                    DateTime dataCreariiTaiat = dataCrearii.Date;
                    var p = context.Photos.Where(photo => photo.DataCreare == dataCreariiTaiat).OrderByDescending(photo => photo.DataCreare);
                    List<string> lista = new List<string>();
                    foreach (var x in p)
                    {
                        lista.Add(x.Cale);
                    }
                    return lista;
                }
            }
            else
            {
                using (PhotoContainer context = new PhotoContainer())
                {
                    dataCrearii = DateTime.Parse("1970-01-01");
                    var p = context.Photos.Where(photo => photo.DataCreare == dataCrearii).OrderByDescending(photo => photo.DataCreare);
                    List<string> lista = new List<string>();
                    foreach (var x in p)
                    {
                        lista.Add(x.Cale);
                    }
                    return lista;
                }
            }
        }
        public void DeletePhoto(string caleGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                context.Photos.Remove(p);
                context.SaveChanges();
            }
        }
        public void SchimbareCale(string caleGUI, string caleNouaGUI)
        {
            using (PhotoContainer context = new PhotoContainer())
            {
                var p = context.Photos.Where(photo => photo.Cale == caleGUI).FirstOrDefault();
                p.Cale = caleNouaGUI;
                context.SaveChanges();
            }
        }
    }
}
