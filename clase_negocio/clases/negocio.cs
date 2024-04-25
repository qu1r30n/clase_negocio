using clase_negocio.clases.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_negocio.clases.modelos;


namespace clase_negocio.clases
{
    internal class negocio
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;
        public void a_que_clase_enviar(string informacion_a_enviar)
        {
            string[] a_donde_enviara_la_informacion = informacion_a_enviar.Split(G_caracter_separacion_funciones_espesificas[0][0]);

            if (a_donde_enviara_la_informacion[0] =="producto")
            {
                modelo_productos mod_produc = new modelo_productos();
                mod_produc.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
            }
        }
    }
}
