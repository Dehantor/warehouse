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
    public partial class ViewAccept : Form
    {
        public ViewAccept()
        {
            InitializeComponent();
        }



        private void View_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Form accept = new FormAccept();
            Visible = false;
            accept.ShowDialog();
            Visible = true;
            //показ всех записей
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Storаges.Where(c => c.StatId == 1).Select(c => new
                {
                    id = c.Id,
                    Name = c.Product.Name,
                    Description = c.Product.Description,
                    Stat = c.Stat.Name
                }).ToList();
            }
        }

        private void ViewAccept_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Перевод на склад
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Storаge> storаges= db.Storаges
                     .Where(c => c.StatId == 1)
                     .AsEnumerable()
                     .Select(c =>
                     {
                         c.StatId = 2;
                         return c;
                     });
                foreach (Storаge st in storаges)
                {
                    // Указать, что запись изменилась
                    db.Entry(st).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                db.SaveChanges();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
