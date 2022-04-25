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
    public partial class Add_Book : Form
    {
        public string NameBook { get { return textBox1.Text; } }
        public Add_Book()
        {
            InitializeComponent();
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }
    }
}
