using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class ViewSold : Form
    {
        public ViewSold()
        {
            InitializeComponent();
        }

        private void ViewSold_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Storаges.Where(c => c.StatId == 3).Select(c => new
                {
                    id = c.Id,
                    Name = c.Product.Name,
                    Description = c.Product.Description,
                    date = c.date,
                    Stat = c.Stat.Name
                }).ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
