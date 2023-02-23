using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.Table.Where(x => x.Product_Id == textBox1.Text).ToList();
            foreach (var item in list)
            {
                context.Table.Remove(item);
            }
            Table data = new Table()
            {
                Product_Id = textBox1.Text.Trim(),

                Product_Name = textBox2.Text.Trim(),
                Product_Quantity = Convert.ToInt32(textBox3.Text.Trim()),
                Product_Price = Convert.ToInt32(textBox4.Text.Trim()),
                Product_Class = textBox5.Text.Trim(),
            };
            try
            {
           
                context.Table.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");

            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }


        }
    }
}
