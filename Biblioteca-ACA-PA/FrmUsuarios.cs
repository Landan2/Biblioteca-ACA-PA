using Biblioteca_ACA_PA.ConexionDatos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Biblioteca_ACA_PA
{
    public partial class FrmUsuarios : Form
    {





        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();

        }


        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarU_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarU.Text))
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

                    string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", txtBuscarU.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtNombre.Text = lector["Nombre"].ToString();
                                txtApellido.Text = lector["Apellido"].ToString();
                                txtDocumento.Text = lector["Documento"].ToString();
                                txtTelefono.Text = lector["Telefono"].ToString();
                                txtCorreo.Text = lector["Correo"].ToString();

                                MessageBox.Show(
                                    "Usuario encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un usuario con ese Id.",
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
                    "Error al buscar el Usuario:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }



        private void btnGuardarU_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtDocumento.Text) ||
               string.IsNullOrWhiteSpace(txtTelefono.Text) ||
               string.IsNullOrWhiteSpace(txtCorreo.Text))
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

                string consulta =
                    "INSERT INTO Usuarios " +
                    "(Nombre, Apellido, Documento, Telefono, Correo) " +
                    "VALUES " +
                    "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    comando.Parameters.AddWithValue("@Documento", txtDocumento.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario guardado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevoU_Click(null, null);


        }


        private void btnNuevoU_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtBuscarU.Clear();

            txtNombre.Focus();

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

            txtDocumento.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            txtTelefono.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();


        }

        private void btnEditarU_Click(object sender, EventArgs e)
        {


            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
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
                    "UPDATE Usuarios SET " +
                    "Nombre = @Nombre, " +
                    "Apellido = @Apellido, " +
                    "Documento = @Documento, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo " +
                    "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        txtNombre.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        txtApellido.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Documento",
                        txtDocumento.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        txtTelefono.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        txtCorreo.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevoU_Click(null, null);


        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
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
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario eliminado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevoU_Click(null, null);




        }

        private void btnCancelarU_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            dgvUsuarios.ClearSelection();

            txtNombre.Focus();



        }

       
    }  //clase partial





}
