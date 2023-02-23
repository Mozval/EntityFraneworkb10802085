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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.Table.Where(x => x.Product_Id == textBox1.Text).ToList();
            foreach ( var item in list )
            {
                context.Table.Remove(item);
            }
            context.SaveChanges();
            MessageBox.Show("存檔完成");
        }
    }
}
