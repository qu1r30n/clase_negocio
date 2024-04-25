using clase_negocio.clases.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_negocio.clases.procesos;

namespace clase_negocio.clases.modelos
{
    internal class modelo_productos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;


        public void operacion_a_hacer(string operacion)
        {
            procesos_productos proc_produc = new procesos_productos();
            
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);
            
            if (a_donde_enviara_la_informacion[0] == "agregar")
            {
                proc_produc.agregar_producto(a_donde_enviara_la_informacion[0]);
                
            }
        }


    }
}
