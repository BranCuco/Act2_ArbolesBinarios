using Refaccionaria.DataAccess;
using System;
using System.Windows.Forms;
using Refaccionaria.BusinessLogic;

namespace Refaccionaria
{
    public partial class Form1 : Form
    {
        
        private CamionService _service = new CamionService(new CamionDAO());


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Add("Clave", "Clave");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Tonelaje", "Tonelaje");
            dataGridView1.Columns.Add("Placas", "Placas");
            dataGridView1.Columns.Add("Marca", "Marca");

            

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clave_textBox.Text = dataGridView1.SelectedCells[0].Value.ToString();   
            name_textBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            storageTonnage_textBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            licensePlates_textBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
            cardBrand_textBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        

        

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_service == null)
            { 
                MessageBox.Show("El servicio no se ha inicializado correctamente.");
                return;
            }

            int id = string.IsNullOrEmpty(clave_textBox.Text) ? 0 : Convert.ToInt32(clave_textBox.Text);
            string nombre = name_textBox.Text;
            decimal tonelaje = string.IsNullOrEmpty(storageTonnage_textBox.Text) ? 0 : Convert.ToDecimal(storageTonnage_textBox.Text);
            string marca = cardBrand_textBox.Text;
            string placas = licensePlates_textBox.Text;

            Camion[] camiones = _service.BuscarCamiones(id, nombre, tonelaje, marca, placas);

            showResults(camiones);
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            Camion[] results = _service.TodosLosCamiones();
            showResults(results);
        }

        public void showResults(Camion[] resultados)
        {
            dataGridView1.Rows.Clear();

            foreach (Camion camion in resultados)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1, camion.Clave, camion.Nombre, camion.Tonelaje, camion.Placas, camion.Marca);
                dataGridView1.Rows.Add(fila);
            }
        }

        
    }
}
