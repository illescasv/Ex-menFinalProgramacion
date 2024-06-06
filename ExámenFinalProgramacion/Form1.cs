using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ExámenFinalProgramacion
{
    public partial class Form1 : Form
    {
        // Declarar la lista de dispositivos
        List<object> dispositivos = new List<object>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Laptop", "Smartphone", "Tablet" });

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // Inicialmente ocultar todos los paneles específicos
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            // Manejar eventos de los botones
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tipoDispositivo = comboBox1.SelectedItem.ToString();

            switch (tipoDispositivo)
            {
                case "Laptop":
                    Laptop laptop = new Laptop(
                        textBox1.Text,
                        textBox4.Text,
                        textBox5.Text,
                        (int)numericUpDown1.Value,
                        (int)numericUpDown4.Value
                    );
                    dispositivos.Add(laptop);
                    break;

                case "Smartphone":
                    Smartphone smartphone = new Smartphone(
                        textBox2.Text,
                        textBox7.Text,
                        textBox6.Text,
                        textBox8.Text,
                        (int)numericUpDown2.Value
                    );
                    dispositivos.Add(smartphone);
                    break;

                case "Tablet":
                    Tablet tablet = new Tablet(
                        textBox3.Text,
                        textBox9.Text,
                        textBox10.Text,
                        (float)numericUpDown3.Value,
                        checkBox1.Checked
                    );
                    dispositivos.Add(tablet);
                    break;
            }

            label20.Text = $"Cantidad de dispositivos: {dispositivos.Count}";
            MessageBox.Show("Dispositivo guardado exitosamente");
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGridView();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoDispositivo = comboBox1.SelectedItem.ToString();

            panel1.Visible = tipoDispositivo == "Laptop";
            panel2.Visible = tipoDispositivo == "Smartphone";
            panel3.Visible = tipoDispositivo == "Tablet";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void MostrarDatosEnGridView()
        {
            // Limpiar las filas existentes en el DataGridView
            dataGridView1.Rows.Clear();

            // Definir las columnas en el DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NumeroDeSerie", "NumeroDeSerie");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Modelo", "Modelo");
            dataGridView1.Columns.Add("RAM", "RAM");
            dataGridView1.Columns.Add("Almacenamiento", "Almacenamiento");

            // Recorrer la lista de dispositivos y agregar cada uno a una fila en el DataGridView
            foreach (var dispositivo in dispositivos)
            {
                if (dispositivo is Laptop)
                {
                    Laptop laptop = (Laptop)dispositivo;
                    dataGridView1.Rows.Add(laptop.NumeroDeSerie, laptop.Marca, laptop.Modelo, laptop.MemoriaRAM, laptop.Almacenamiento);
                }
                else if (dispositivo is Smartphone)
                {
                    Smartphone smartphone = (Smartphone)dispositivo;
                    dataGridView1.Rows.Add(smartphone.NumeroDeSerie, smartphone.Marca, smartphone.Modelo, smartphone.SistemaOperativo, smartphone.NumeroDeCamaras);
                }
                else if (dispositivo is Tablet)
                {
                    Tablet tablet = (Tablet)dispositivo;
                    dataGridView1.Rows.Add(tablet.NumeroDeSerie, tablet.Marca, tablet.Modelo, tablet.TamanoDePantalla, tablet.SoporteParaStylus);
                }
            }
        }




    }
}