using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionMysql
{

    public partial class Form1: Form
    {
        private MySqlConnection conexion; 
           
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(host.Text))
            {
                MessageBox.Show("El HOST es campo requerido");
                return;
            }
            if (string.IsNullOrEmpty(usuario.Text))
            {
                MessageBox.Show("El USUARIO es campo requerido");
                return;
            }
            if (string.IsNullOrEmpty(contrasena.Text))
            {
                MessageBox.Show("La CONTRASEÑA es campo requerido");
                return;
            }
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = "server=" + host.Text + ";"
                    + "user id=" + usuario.Text + ";"
                    + "password=" + contrasena.Text + ";";
                conexion.Open();
                MessageBox.Show("La conexión se realizó exitosamente");
                }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al conectar:" + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();         
            }
        
        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
