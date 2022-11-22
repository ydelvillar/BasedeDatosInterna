using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasedeDatosInterna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_EmpleadosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bD_EmpleadosDataSet.Empleados);
            empleadosBindingSource.DataSource = this.bD_EmpleadosDataSet.Empleados;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try 
            {
                panel1.Enabled = true;
                textNombre.Focus();
                this.bD_EmpleadosDataSet.Empleados.
                    AddEmpleadosRow(this.bD_EmpleadosDataSet.
                    Empleados.NewEmpleadosRow());
                empleadosBindingSource.MoveLast();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                empleadosBindingSource.ResetBindings(false);
            }
        }
    }
}
