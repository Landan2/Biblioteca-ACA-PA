using Biblioteca_ACA_PA.ConexionDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca_ACA_PA
{
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
            CargarAutores();

        }


        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Autores";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvAutores.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarA.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ID para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Autores WHERE IdAutor = @IdAutor";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdAutor", txtBuscarA.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtNombreA.Text = lector["Nombre"].ToString();
                                txtApellidoA.Text = lector["Apellido"].ToString();


                                MessageBox.Show(
                                    "Autor encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un autor con ese Id.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el Autor deseado:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void btnGuardarA_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreA.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoA.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Autores
                                (Nombre, Apellido)
                                VALUES
                                (@Nombre, @Apellido)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            txtNombreA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Apellido",
                            txtApellidoA.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                txtNombreA.Clear();
                txtApellidoA.Clear();

                txtNombreA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void btnNuevoA_Click(object sender, EventArgs e)
        {


            txtNombreA.Clear();
            txtApellidoA.Clear();
            txtBuscarA.Clear();

            txtNombreA.Focus();


        }

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0)
                return;

            txtNombreA.Text = dgvAutores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            txtApellidoA.Text = dgvAutores.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

        }

        private void btnEditarA_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreA.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoA.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (dgvAutores.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un autor para editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idAutor = Convert.ToInt32(
                    dgvAutores.CurrentRow.Cells["IdAutor"].Value);

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Autores
                                SET Nombre = @Nombre,
                                    Apellido = @Apellido
                                WHERE IdAutor = @IdAutor";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            txtNombreA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Apellido",
                            txtApellidoA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@IdAutor",
                            idAutor);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                txtNombreA.Clear();
                txtApellidoA.Clear();

                txtNombreA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void btnEliminarA_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvAutores.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un autor para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idAutor = Convert.ToInt32(
                    dgvAutores.CurrentRow.Cells["IdAutor"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este autor?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "DELETE FROM Autores WHERE IdAutor = @IdAutor";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdAutor",
                            idAutor);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                txtNombreA.Clear();
                txtApellidoA.Clear();

                txtNombreA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnCancelarA_Click(object sender, EventArgs e)
        {


            txtNombreA.Clear();
            txtApellidoA.Clear();

            txtNombreA.Focus();


        }





    } //clase partial
}
