using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_ManuelaCastano
{
    public static class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string TipoProducto, bool urgente, double peso)
        {

            if (TipoProducto == "accesorio" && peso < 2 && !urgente)
                return new EntregaBicicleta();
                else if (TipoProducto == "tecnología" && urgente)
                        return new EntregaDron();
                        else if (TipoProducto == "accesorio")
                            return new EntregaMoto();
                            else if (TipoProducto == "componente" || peso > 10)
                                return new EntregaCamion();
            else
            {
                return new EntregaMoto(); // es un valor por defecto
            }
            
        }
    }
}
