using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Registro1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM JOVEN";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO JOVEN (CODIGO,NOMBRE,APELLIDO,EDAD,TELEFONO,GENERO)VALUES(@CODIGO,@NOMBRE,@APELLIDO,@EDAD,@TELEFONO,@GENERO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txtcodigo.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
            cmd1.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
            cmd1.Parameters.AddWithValue("@EDAD", txtedad.Text);
            cmd1.Parameters.AddWithValue("@TELEFONO", txttelefono.Text);
            cmd1.Parameters.AddWithValue("@GENERO", txtgenero.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron agregados con exito");

            dataGridView1.DataSource = llenar_grid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE JOVEN SET CODIGO=@CODIGO, NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, EDAD=@EDAD, TELEFONO=@TELEFONO, GENERO=@GENERO WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@CODIGO", txtcodigo.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
            cmd2.Parameters.AddWithValue("@EDAD", txtedad.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", txttelefono.Text);
            cmd2.Parameters.AddWithValue("@GENERO", txtgenero.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron actualizados correctamente");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM JOVEN WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@CODIGO", txtcodigo.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron eliminados correctamente");

            dataGridView1.DataSource = llenar_grid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txttelefono.Clear();
            txtgenero.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtedad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txttelefono.Text = dataGridView1.CurrentRow.Cells[4].ToString();
                txtgenero.Text = dataGridView1.CurrentRow.Cells[5].ToString();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
