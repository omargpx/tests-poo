using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //generado por equivocacion
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //generado por equivocacion
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigoProducto = int.Parse(txtCodigo.Text);
            string nombreProducto = txtNombre.Text;
            double precioProducto = double.Parse(txtPrecio.Text);

            string query = "INSERT INTO tbl_productos (no_producto,precio,nu_codigo) VALUES('"
                +nombreProducto+"','"+precioProducto+"','"+codigoProducto+"');";

            MySqlConnection conn = conexionDB.conexionBD();
            conn.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query,conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registrado con exito");
                txtArea.Text = "";
                txtBuscar.Text = "";
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se pudo Guardar"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigoProducto = int.Parse(txtBuscar.Text);
            MySqlDataReader reader = null;

            string query = "SELECT *  FROM tbl_productos WHERE id_producto LIKE '"+codigoProducto+"' OR nu_codigo LIKE'"+codigoProducto+"';";

            MySqlConnection conn = conexionDB.conexionBD();
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand(query,conn);
                reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtArea.Text += "Id: "+reader.GetString(0) +"; \nNombre:"
                            +reader.GetString(1)+"; \nPrecio:"+reader.GetString(2)+"; \nCodigo:"+reader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("no se encontro el registro");
                }
            }catch(Exception ecs)
            {
                MessageBox.Show("Error al buscar producto");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int codigoProducto = int.Parse(txtBuscar.Text);


            MySqlDataReader reader = null;

            string query = "SELECT *  FROM tbl_productos WHERE id_producto LIKE '" + codigoProducto + "' OR nu_codigo LIKE'" + codigoProducto + "';";

            MySqlConnection conn = conexionDB.conexionBD();
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand(query, conn);
                reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtArea.Text += "Id: " + reader.GetString(0) + "; \nNombre:"
                            + reader.GetString(1) + "; \nPrecio:" + reader.GetString(2) + "; \nCodigo:" + reader.GetString(3);
                        Console.WriteLine("Id: " + reader.GetString(0) + " \nNombre:"
                            + reader.GetString(1) + " \nPrecio:" + reader.GetString(2) + " \nCodigo:" + reader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("no se encontro el registro");
                }
            }
            catch (Exception ecs)
            {
                MessageBox.Show("Error al buscar producto");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
//            DirectoryInfo curry = new DirectoryInfo(@"C:\Usuarios\lober\Escritorio");
            findAll();

           

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Reporte.txt";
            save.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(save.FileName);
                w.WriteLine(rows);
                w.Close();
                txtArea.Text += "\r\nReporte generado";
            }

        }

        string rows;

        public void findAll()
        {
            txtArea.Text = "Genrando reporte. . .\r\n";
            MySqlDataReader reader = null;

            string query = "SELECT id_producto,no_producto,precio  FROM tbl_productos;";

            MySqlConnection conn = conexionDB.conexionBD();
            conn.Open();

            try
            {
                MySqlCommand comand = new MySqlCommand(query, conn);
                reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                        rows += "\n"+"ID:"+reader.GetString(0)+"  Nombre:"+reader.GetString(1)+"  Precio: $ "+reader.GetString(2);
                        Console.WriteLine(rows);
                    }
                }
                else
                {
                    MessageBox.Show("no hay registros");
                }
            }
            catch (Exception ecs)
            {
                MessageBox.Show("Error : "+ecs.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
