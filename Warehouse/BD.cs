using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Storаge> Storаges { get; set; }
    }

    public class Storаge
    {
        public int? Id { get; set; }
        public DateTime date { get; set; }
        public int? ProductId { get; set; }
        public int? StatId { get; set; }

        public Product Product { get; set; }
        public Stat Stat { get; set; }

    }
    public class Stat
    {
        public int? StatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Storаge> Storаges { get; set; }
    }
}
