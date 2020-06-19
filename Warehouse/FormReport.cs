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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            //фильтр
            comboBox1.Items.Add(Status.accept);
            comboBox1.Items.Add(Status.storаge);
            comboBox1.Items.Add(Status.sold);
            comboBox1.Items.Add("Все");
            comboBox1.SelectedIndex = 3;
            //ограничение по дате
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    dateTimePicker1.MinDate = db.Storаges.Select(c => c.date).Min().AddDays(-1);
                    dateTimePicker1.MaxDate = db.Storаges.Select(c => c.date).Max();
                    dateTimePicker1.Value = db.Storаges.Select(c => c.date).Min();
                    dateTimePicker2.Value = db.Storаges.Select(c => c.date).Max();
                    dateTimePicker2.MinDate = db.Storаges.Select(c => c.date).Min();
                    dateTimePicker2.MaxDate = db.Storаges.Select(c => c.date).Max().AddDays(1);
                }
                catch
                {
                    Close();
                    MessageBox.Show("Нет Данных");

                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //в зависимости от выбранного фильтра отображаются данные
            if (comboBox1.Text!="Все")
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    dataGridView1.DataSource = db.Storаges
                        .Where(c => c.Stat.Name == comboBox1.Text && c.date>= dateTimePicker1.Value && c.date<= dateTimePicker2.Value)
                        .Select(c => new
                    {
                        id = c.Id,
                        Name = c.Product.Name,
                        Description = c.Product.Description,
                        date = c.date,
                        Stat = c.Stat.Name
                    })
                    .ToList();
                }
            }
            else
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    dataGridView1.DataSource = db.Storаges.Select(c => new
                    {
                        id = c.Id,
                        Name = c.Product.Name,
                        Description = c.Product.Description,
                        date = c.date,
                        Stat = c.Stat.Name
                    }).ToList();
                }
            }
            label2.Text = "Количество:" + dataGridView1.RowCount;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ComboBox1_SelectedIndexChanged(sender, e);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ComboBox1_SelectedIndexChanged(sender, e);
        }
    }
}
