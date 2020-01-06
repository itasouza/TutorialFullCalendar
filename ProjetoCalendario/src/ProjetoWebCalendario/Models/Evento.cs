using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebCalendario.Models
{
    public class Evento
    {

        public Evento() { }

        public int id { get; set; }
        public string title { get; set; }
        public string color { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public Evento(int id, string title, string color, string url, DateTime start, DateTime end)
        {
            this.id = id;
            this.title = title;
            this.color = color;
            this.url = url;
            this.start = start;
            this.end = end;
        }

    }
}
