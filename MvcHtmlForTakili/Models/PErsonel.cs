using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHtmlForTakili.Models
{
    public class PErsonel
    {
        private readonly List<Cinsiyet> Cinsiyetler = new List<Cinsiyet>
        {
            new Cinsiyet{Id=1,Ad="Erkek"},
            new Cinsiyet{Id=2,Ad="Kadın"}
        };
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Cinsiyet { get; set; }
        public string MedeniDurum { get; set; }
        public bool Ehliyet { get; set; }
        public string Parola { get; set; }
        public string Mesaj { get; set; }

        public IEnumerable<SelectListItem> CinsiyetSecim
        {
            get
            {
                return new SelectList(Cinsiyetler, "Id", "Ad");
            }
        }
    }
}