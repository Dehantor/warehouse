using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Warehouse
{
    public partial class FormAccept : Form
    {
        public FormAccept()
        {
            InitializeComponent();

        }

        private void АссеptButton_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //ищем продукт
                Product product = db.Products
                    .Where(c => c.Name == NameTextBox.Text)
                    .FirstOrDefault();
               //если есть,  принимаем
                if(product!=null)
                {
                    Storаge storаge = new Storаge
                    {
                        date = DateTime.Now,
                        StatId = 1,
                        ProductId = product.Id
                    };
                    db.Storаges.Add(storаge);
                    db.SaveChanges();
                }
                else
                {//нету, создаём в базе и принимаем
                    product = new Product
                    {
                        Name = NameTextBox.Text,
                        Description = textBoxDescription.Text.ToLower(),
                        Storаges = new List<Storаge>
                        {
                            new Storаge
                            {
                                date = DateTime.Now,
                                StatId = 1
                            }
                        }
                    };
                    db.Products.Add(product);
                    db.SaveChanges();
                }

            }
        }

        private void FormAccept_Load(object sender, EventArgs e)
        {
            //подсказка для ввденных текущих продуктов 
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            using (ApplicationContext db = new ApplicationContext())
            {
               
                foreach (Product pr in db.Products) {
                    source.Add(pr.Name);
                }

            }
            NameTextBox.AutoCompleteCustomSource = source;
            NameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
