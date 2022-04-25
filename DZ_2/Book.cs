using System.Collections.Generic;

namespace DZ_2
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sage> Sages { get; set; }
        public Book()
        {
            Sages = new List<Sage>();
        }
    }
}