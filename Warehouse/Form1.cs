using Microsoft.Win32;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form view = new ViewAccept();
            Visible = false;
            view.ShowDialog();
            Visible = true;

        }

        private void ButtonHouse_Click(object sender, EventArgs e)
        {
            Form view = new FormStorаge();
            Visible = false;
            view.ShowDialog();
            Visible = true;
        }

        private void ButtonSold_Click(object sender, EventArgs e)
        {
            Form view = new ViewSold();
            Visible = false;
            view.ShowDialog();
            Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //работа с реестром
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey storage = currentUserKey.OpenSubKey("storage");
            //при первом запуске программы, создаются ключи вреестре
            if (storage == null)
            {
                RegistryKey testSearch = currentUserKey.CreateSubKey("storage");

                //добавление первичных значений в базу при первом запуске программы
                using (ApplicationContextNew db = new ApplicationContextNew())
                {
                    Stat st1 = new Stat { Name = Status.accept };
                    Stat st2 = new Stat { Name = Status.storаge };
                    Stat st3 = new Stat { Name = Status.sold };
                    Product pr = new Product { Name = "виски" };
                    db.Stats.Add(st1);
                    db.Stats.Add(st2);
                    db.Stats.Add(st3);
                    db.Products.Add(pr);
                    db.SaveChanges();

                }

            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            Form view = new FormReport();
            Visible = false;
            view.ShowDialog();
            Visible = true;
        }
    }
}
