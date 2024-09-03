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
using System.Data;
using System.Data.SqlClient;

namespace GestionTareas.View
{
    /// <summary>
    /// Lógica de interacción para Gestion.xaml
    /// </summary>
    public partial class Gestion : Window
    {
        private string cData = "Server=REUDYS; Database=Tareas; User ID=sa; Password=reyballoon";
        public Gestion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        //Botones
        private void Cerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //Metodos
        private void MoverVentana(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public void CargarDatos()
        {
            using (SqlConnection cnn = new SqlConnection(cData))
            {
                string query = "select TITULO, DESCRIPCION from TAREA_LIST";
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
                DataTable tb = new DataTable();

                try
                {
                    cnn.Open();
                    adapter.Fill(tb);
                    dgv.ItemsSource = tb.DefaultView;

                    if (dgv.Columns.Count > 0)
                    {
                        dgv.Columns[0].Width = new DataGridLength(1, DataGridLengthUnitType.Auto); // Ancho automático para TITULO
                        dgv.Columns[1].Width = new DataGridLength(1, DataGridLengthUnitType.Star);  // Ocupa el espacio restante para DESCRIPCION
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAñadir(object sender, RoutedEventArgs e)
        {
            Añadir form = new Añadir();
            form.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
