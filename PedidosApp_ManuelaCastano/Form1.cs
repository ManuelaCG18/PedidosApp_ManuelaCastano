using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp_ManuelaCastano
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de cliente.");
                    return;
                }

                if(cmbProducto.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un producto.");
                    return;
                }

                if (nudPeso.Value <= 0)
                {
                    MessageBox.Show("El peso debe ser mayor a 0.");
                    return;
                }

                if (nudDistancia.Value <= 0)
                {
                    MessageBox.Show("La distancia debe ser mayor a 0.");
                    return;
                }

                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instance.AgregarPedido(pedido);

                lblResultado.Text = $"Señor/a: {pedido.Cliente}\n" + 
                    $" Su entrega será por : {pedido.MetodoEntrega.TipoEntrega()}\n" + 
                    $" Tiene un costo de: ${pedido.ObtenerCosto():0.00}";
            }
            catch (Exception ex) 
                {
                MessageBox.Show("Error: " + ex.Message);
                }
        }
    }
}
