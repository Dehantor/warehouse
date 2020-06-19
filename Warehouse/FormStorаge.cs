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
    public partial class FormStorаge : Form
    {
        public FormStorаge()
        {
            InitializeComponent();

        }
        int rowIndex = 0;
        private void FormStorаge_Load(object sender, EventArgs e)
        {
            //показ всех записей
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Storаges.Where(c => c.StatId == 2).Select(c => new
                {
                    id = c.Id,
                    Name = c.Product.Name,
                    Description = c.Product.Description,
                    date = c.date,
                    Stat = c.Stat.Name
                }).ToList();
            }
        }

        private void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //управление контекстным меню
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    this.dataGridView1.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    contextMenuStrip1.Show(this.dataGridView1, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
                catch { }
            }
        }

        private void ПродатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //действие при выборе действия продажи
            Console.WriteLine(dataGridView1.Rows[rowIndex].Cells[0].Value);
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Storаge> storаges = db.Storаges
                 .Where(c => c.Id ==(int)dataGridView1.Rows[rowIndex].Cells[0].Value)
                 .AsEnumerable()
                 .Select(c =>
                 {
                     c.StatId = 3;
                     c.date = DateTime.Now;
                     return c;
                 });
                foreach (Storаge st in storаges)
                {
                    // Указать, что запись изменилась
                    db.Entry(st).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                db.SaveChanges();


                dataGridView1.DataSource = db.Storаges.Where(c => c.StatId == 2).Select(c => new
                {
                    id = c.Id,
                    Name = c.Product.Name,
                    date = c.date,
                    Description = c.Product.Description,
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