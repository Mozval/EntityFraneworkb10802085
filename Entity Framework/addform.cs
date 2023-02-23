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
    public partial class addform : Form
    {
        public addform()
        {
            InitializeComponent();
        }

        private void addform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table data = new Table()
            {
                Product_Id =  textBox1.Text.Trim(),

                Product_Name = textBox2.Text.Trim(),
                Product_Quantity = Convert.ToInt32(textBox3.Text.Trim()),
                Product_Price = Convert.ToInt32(textBox4.Text.Trim()),
                Product_Class = textBox5.Text.Trim(),
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.Table.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");

            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
