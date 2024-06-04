using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemploHTTP.Models
{
    public class Postagem
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string body { get; set; }
    }
}
