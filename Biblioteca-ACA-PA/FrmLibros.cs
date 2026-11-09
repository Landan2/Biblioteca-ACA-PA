using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Biblioteca_ACA_PA.ConexionDatos;

namespace Biblioteca_ACA_PA
{
    public partial class FrmLibros : Form
    {
        private bool ModoEdicion = false;



        public FrmLibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();

        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarAutores()
        {

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        cmbAutor.DataSource = tabla;   //nombre del boton de autores
                        cmbAutor.DisplayMember = "NombreCompleto";
                        cmbAutor.ValueMember = "IdAutor";
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




        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbEditorial.DataSource = tabla;
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "IdEditorial";
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtBuscar.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtISBN.Text = lector["ISBN"].ToString();
                                txtTitulo.Text = lector["Titulo"].ToString();
                                cmbAutor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                cmbEditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);
                                txtCategoria.Text = lector["Categoria"].ToString();
                                txtAño.Text = lector["Año"].ToString();
                                txtExistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
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
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtISBN.Clear();
            txtTitulo.Clear();
            cmbAutor.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;
            txtAño.Clear();
            txtCategoria.Clear();
            txtExistencias.Clear();
            txtISBN.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    cmbAutor.SelectedIndex == -1 ||
                    cmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtAño.Text) ||
                    string.IsNullOrWhiteSpace(txtExistencias.Text))


                {
                    MessageBox.Show(
                        "Por favor, debe completar todos los campos antes de guardar el registro.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;


                }

                int año;
                int existencias;

                if (!int.TryParse(txtAño.Text, out año))
                {
                    MessageBox.Show(
                        "El año no debe contener comas ni puntos.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(txtExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Por favor ingrese el número de las existencias sin comas ni puntos.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Libros
                                (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Año, Existencias)

                                VALUES

                                (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Año, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(cmbAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(cmbEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", txtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Año", año);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                btnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro, por favot vuelva a intentarlo:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            txtISBN.Text = dgvLibros.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();

            cmbAutor.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdAutor"].Value
            );

            cmbEditorial.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdEditorial"].Value
            );

            txtCategoria.Text = dgvLibros.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtAño.Text = dgvLibros.Rows[e.RowIndex].Cells["Año"].Value.ToString();
            txtExistencias.Text = dgvLibros.Rows[e.RowIndex].Cells["Existencias"].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    cmbAutor.SelectedIndex == -1 ||
                    cmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtAño.Text) ||
                    string.IsNullOrWhiteSpace(txtExistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int año;
                int existencias;

                if (!int.TryParse(txtAño.Text, out año))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(txtExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Libros
                                SET Titulo = @Titulo,
                                    IdAutor = @IdAutor,
                                    IdEditorial = @IdEditorial,
                                    Categoria = @Categoria,
                                    Año = @Año,
                                    Existencias = @Existencias
                                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(cmbAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(cmbEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", txtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Año", año);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {


            txtISBN.Clear();
            txtTitulo.Clear();
            txtCategoria.Clear();
            txtAño.Clear();
            txtExistencias.Clear();

            cmbAutor.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;

            ModoEdicion = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvLibros.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un libro para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string isbn = dgvLibros.CurrentRow.Cells["ISBN"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este libro?",
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

                    string consulta = "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ModoEdicion = false;
                txtISBN.Enabled = true;

                CargarLibros();

                btnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }











        //cierre de clase partial

    }






}

