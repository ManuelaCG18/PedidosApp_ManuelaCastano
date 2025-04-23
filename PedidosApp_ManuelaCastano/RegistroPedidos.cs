using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_ManuelaCastano
{
    public sealed class RegistroPedidos
    {
        private static RegistroPedidos _instance;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }

        private RegistroPedidos() => Pedidos = new List<Pedido>();

        public static RegistroPedidos Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RegistroPedidos();
                    }
                    return _instance;
                }
            }
        }

        public void AgregarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
            
