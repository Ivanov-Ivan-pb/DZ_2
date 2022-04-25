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
    public partial class DeleteSage : Form
    {
        public int idSage { get; set; }
        public DeleteSage()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                dataGridView1.DataSource = cnt.Sages.Select(x => new { Id = x.Id, Name = x.Name, Age = x.Age }).ToList();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                idSage = (int)dataGridView1[0, index].Value;
            }
            catch
            {

            }

        }
    }
}
