using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
  public  class Sage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public Sage()
        {
            Books = new List<Book>();
        }
    }
}
