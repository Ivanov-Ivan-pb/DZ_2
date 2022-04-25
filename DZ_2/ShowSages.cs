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
    public partial class ShowSages : Form
    {
        public ShowSages()
        {
            InitializeComponent();
            InitializeGridView();
        }

        private void InitializeGridView()
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                dataGridView1.DataSource = cnt.Sages.Select(x => new { id = x.Id, Name = x.Name, Age = x.Age }).ToList();


            }
        }
    }
}
