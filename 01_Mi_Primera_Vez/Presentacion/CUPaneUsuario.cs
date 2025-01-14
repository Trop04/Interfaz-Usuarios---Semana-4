using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUPaneUsuario : UserControl
    {
        private DataTable ObtenerUsuarios()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=ControlAsistencias;Trusted_Connection=True;"))
            {
                string query = @"
SELECT 
    U.ID AS UsuarioID,
    U.Nombre,
    U.Apellido,
    U.Email,
    U.Celular,
    U.Cedula,
    P.Nombre AS Pais
FROM 
    Usuarios U
INNER JOIN 
    Paises P
ON 
    U.PaisID = P.ID;
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }



        public CUPaneUsuario()
        {
            InitializeComponent();
            CargarUsuariosEnDataGridView();
            dataGridViewLista.CellClick += dataGridViewLista_CellClick;
        }
        private void CargarUsuariosEnDataGridView()
        {
            var fuenteDatos = ObtenerUsuarios();
            dataGridViewLista.DataSource = fuenteDatos;
            if (dataGridViewLista.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    Name = "btnEditar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewLista.Columns.Add(btnEditar);
            }

            if (dataGridViewLista.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    Name = "btnEliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewLista.Columns.Add(btnEliminar);
            }
        }

        private void dataGridViewLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewLista.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int usuarioId = Convert.ToInt32(dataGridViewLista.Rows[e.RowIndex].Cells["UsuarioID"].Value);
                    frmAñadirUsuario frmEditar = new frmAñadirUsuario(usuarioId);
                    frmEditar.ShowDialog();
                    CargarUsuariosEnDataGridView();
                }
                else if (dataGridViewLista.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    int usuarioId = Convert.ToInt32(dataGridViewLista.Rows[e.RowIndex].Cells["UsuarioID"].Value);
                    var resultado = MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        EliminarUsuario(usuarioId);
                        CargarUsuariosEnDataGridView();
                    }
                }
            }
        }
        private void EliminarUsuario(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost;Database=ControlAsistencias;Trusted_Connection=True;"))
            {
                string query = "DELETE FROM Usuarios WHERE ID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private int? UsuarioID;

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmAñadirUsuario frmUsuario = new frmAñadirUsuario();
            frmUsuario.ShowDialog();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGridView();
        }
    }
}
