using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Editorial ed1 = new Editorial();
            Editorial ed2 = new Editorial();

            ed1.Id = Guid.NewGuid().ToString();
            ed2.Id = Guid.NewGuid().ToString();

            ed1.Nombre = "Planeta";
            ed2.Nombre = "Antartida";

            cmbEditorial.Items.Add(ed1);
            cmbEditorial.Items.Add(ed2);
        }

        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editorial edit = (Editorial)cmbEditorial.SelectedItem;
            MessageBox.Show(edit.Id);
        }
    }
}
