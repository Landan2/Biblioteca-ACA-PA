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
    public partial class FrmEditoriales : Form
    {
        public FrmEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();


        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Editoriales";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvEditoriales.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void btnBuscarE_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarE.Text))
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

                    string consulta = "SELECT * FROM Editoriales WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdEditorial", txtBuscarE.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtNombreE.Text = lector["Nombre"].ToString();
                                


                                MessageBox.Show(
                                    "Edotiral encontrada.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró una Editorial con ese Id.",
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
                    "Error al buscar ela Editorial deseada:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }


        private void btnGuardarE_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreE.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la editorial.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "INSERT INTO Editoriales (Nombre) VALUES (@Nombre)";

                using (SqlCommand comando =
                       new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        txtNombreE.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Editorial guardada correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEditoriales();

            txtNombreE.Clear();
            txtBuscarE.Clear();
            txtNombreE.Focus();



        }

        private void btnNuevoE_Click(object sender, EventArgs e)
        {

            txtNombreE.Clear();
            txtBuscarE.Clear();
            txtNombreE.Focus();


        }

        private void dgvEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            txtNombreE.Text = dgvEditoriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();


        }

        private void btnEditarE_Click(object sender, EventArgs e)
        {


            try
            {
                if (dgvEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    dgvEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                if (string.IsNullOrWhiteSpace(txtNombreE.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la editorial.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "UPDATE Editoriales SET Nombre = @Nombre WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            txtNombreE.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial actualizada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                txtNombreE.Clear();
                txtBuscarE.Clear();
                txtNombreE.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    dgvEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar esta editorial?",
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
                        "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial eliminada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                txtNombreE.Clear();
                txtNombreE.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            txtNombreE.Clear();
            txtBuscarE.Clear();
            txtNombreE.Focus();


        }

      



    } //clase partial 



}