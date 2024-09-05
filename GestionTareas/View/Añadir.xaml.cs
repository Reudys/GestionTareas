using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace GestionTareas.View
{
    /// <summary>
    /// Lógica de interacción para Añadir.xaml
    /// </summary>
    public partial class Añadir : Window
    {
        private string cData = "Server=REUDYS; Database=Tareas; User ID=sa; Password=reyballoon";
        public Añadir()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAgregar(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO TAREA_LIST (TITULO, DESCRIPCION) VALUES (@A1, @A2)";
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;

            Gestion viewGestion = new Gestion();

            using (SqlConnection cnn = new SqlConnection(cData))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@A1", titulo);
                    cmd.Parameters.AddWithValue("@A2", descripcion);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    viewGestion.CargarDatos();
                }
            }
        }
    }
}
