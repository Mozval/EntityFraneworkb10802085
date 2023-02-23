using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var readText = File.ReadAllLines(@"..\..\..\product.csv").Skip(1).ToList();
            var context = new ContactsModel();
            var list = context.Table.ToList();
            foreach (var item in list)
            {
                context.Table.Remove(item);
            }
            foreach (var i in readText)
            {
                string[] a = i.Split(',');
                Table data = new Table()
                {
                    Product_Id = a[0],
                    Product_Name = a[1],
                  Product_Quantity = int.Parse(a[2]),
                    Product_Price = Convert.ToInt32( a[3]),
                    Product_Class= a[4]
                };
                try
                {
                    context.Table.Add(data);
                    context.SaveChanges();


                }
                catch (Exception ex)
                { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }

            }
           
            MessageBox.Show("存檔完成");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new addform();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new remove();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new select();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new change();
            form.ShowDialog();
        }
    }
}
