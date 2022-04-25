using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(MyDbContext cnt=new MyDbContext())
            {
               

                var s1 = cnt.Sages.Where(x => x.Name == "Sage1").FirstOrDefault();
                var b1 = new Book();
                b1.Name = "Book3";
                b1.Sages.Add(s1);
                cnt.Books.Add(b1);
                cnt.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                cnt.Sages.Add(new Sage() { Name = "Sage1", Age = DateTime.Now });
                cnt.SaveChanges();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowBooks showBooks = new ShowBooks();
            showBooks.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowSages showSages = new ShowSages();
            showSages.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteBook deleteBook = new DeleteBook();
            DialogResult dialogResult = deleteBook.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                using (MyDbContext cnt = new MyDbContext())
                {
                    var book = cnt.Books.Where(x => x.Id == deleteBook.idBook).FirstOrDefault();
                    cnt.Books.Remove(book);
                    cnt.SaveChanges();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Book bookAdd = new Add_Book();
            DialogResult dialogResult = bookAdd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                string NameBook = bookAdd.NameBook;
                using (MyDbContext cnt = new MyDbContext())
                {
                    cnt.Books.Add(new Book() { Name = NameBook });
                    cnt.SaveChanges();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteSage deleteSage = new DeleteSage();
            DialogResult dialogResult = deleteSage.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                using (MyDbContext cnt = new MyDbContext())
                {
                    var category = cnt.Sages.Where(x => x.Id == deleteSage.idSage).FirstOrDefault();
                    cnt.Sages.Remove(category);
                    cnt.SaveChanges();
                }
            }
        }
    }
}
