using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class frmAñadirUsuario : Form
    {
        private int? UsuarioID;

        public frmAñadirUsuario(int? usuarioId = null)
        {
            InitializeComponent();
            CargarPaises();
            UsuarioID = usuarioId;

            if (UsuarioID.HasValue)
            {
                this.Text = "Editar Usuario";
                CargarDatosUsuario(UsuarioID.Value);
            }
            else
            {
                this.Text = "Añadir Usuario";
            }
        }
        private void CargarPaises()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=ControlAsistencias;Trusted_Connection=True;"))
            {
                string query = "SELECT ID, Nombre FROM Paises";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbPais.DataSource = dt;
                    cmbPais.DisplayMember = "Nombre";
                    cmbPais.ValueMember = "ID";
                }
            }
        }

        private void CargarDatosUsuario(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=ControlAsistencias;Trusted_Connection=True;"))
            {
                string query = "SELECT Nombre, Email, PaisID, Cedula, Celular, Apellido FROM Usuarios WHERE ID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            cmbPais.SelectedValue = reader["PaisID"];
                            textBoxCedula.Text = reader["Cedula"].ToString();
                            textBoxCelular.Text = reader["Celular"].ToString();
                            textBoxApellido.Text = reader["Apellido"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=ControlAsistencias;Trusted_Connection=True;"))
            {
                string query = UsuarioID.HasValue
                    ? "UPDATE Usuarios SET Nombre = @Nombre, Email = @Email, PaisID = @PaisID, Cedula = @Cedula, Celular = @Celular, Apellido = @Apellido WHERE ID = @UsuarioID"
                    : "INSERT INTO Usuarios (Nombre, Email, PaisID, Cedula, Celular, Apellido) VALUES (@Nombre, @Email, @PaisID, @Cedula, @Celular, @Apellido)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    string nombreLimpio = txtNombre.Text.Contains("(ID:")
                        ? txtNombre.Text.Split(new string[] { "(ID:" }, StringSplitOptions.None)[0].Trim()
                        : txtNombre.Text;
                    cmd.Parameters.AddWithValue("@Nombre", nombreLimpio);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PaisID", cmbPais.SelectedValue);
                    cmd.Parameters.AddWithValue("@Cedula", textBoxCedula.Text);
                    cmd.Parameters.AddWithValue("@Celular", textBoxCelular.Text);
                    cmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);

                    if (UsuarioID.HasValue)
                        cmd.Parameters.AddWithValue("@UsuarioID", UsuarioID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario guardado con éxito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) //deprecado, meh, se puede cerrar con la X pero no lo quito o crashea
        {
            this.Close();
        }
    }
}
