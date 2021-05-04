using EjercicioGrupo1.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGrupo1
{
    public partial class Form1 : Form
    {
        List<ClsNombre> ListaNombre = new List<ClsNombre>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            ClsNombre nombres = new ClsNombre();
            nombres.Nombre = txtNombre.Text;

            ListaNombre.Add(nombres);
            dtgEjercicio1.DataSource = null;
            dtgEjercicio1.DataSource = ListaNombre;
            Limpiar();
 

            MessageBox.Show("Nombre agregado");
            
            }
        private void Limpiar() {
            txtNombre.Clear();
        
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
            
        }
        
    }
}