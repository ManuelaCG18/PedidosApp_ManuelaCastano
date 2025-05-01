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
    public partial class HistorialPedidosForm: Form
    {
        public HistorialPedidosForm()
        {
            InitializeComponent();
            CargarTiposEntrega();
            MostrarPedidos(RegistroPedidos.Instance.ObtenerPedidos());
        }

        private void CargarTiposEntrega()
        {
            comboBoxFiltro.Items.Add("Todos");
            comboBoxFiltro.Items.Add("Moto");
            comboBoxFiltro.Items.Add("Camion");
            comboBoxFiltro.Items.Add("Dron");
            comboBoxFiltro.Items.Add("Bicicleta");
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
        }
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filtro = comboBoxFiltro.SelectedItem.ToString();
            var pedidos = RegistroPedidos.Instance.ObtenerPedidos();
            if (filtro == "Todos")
                MostrarPedidos(pedidos);
            else
                MostrarPedidos(pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList());
        }

        private void MostrarPedidos(List<Pedido> pedidos)
        {
            dataGridViewPedidos.Rows.Clear();
            foreach (var p in pedidos)
            {
                dataGridViewPedidos.Rows.Add(
                    p.Cliente,
                    p.Producto,
                    p.Peso,
                    p.Distancia,
                    p.Urgente,
                    p.MetodoEntrega.TipoEntrega(), // Método de entrega (ej: "Bicicleta")
                    p.ObtenerCosto()              // Costo calculado
                );
            }
        }

        
    }
}
