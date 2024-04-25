using clase_negocio.clases.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_negocio.clases.procesos;
using System.Reflection.Emit;

namespace clase_negocio.clases.modelos
{
    internal class modelo_productos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();
        public string operacion_a_hacer(string operacion)
        {
            
            //proceso_que_se_ara§informacion_que_se_utilisara|informacion_que_se_utilisara
            procesos_productos proc_produc = new procesos_productos();

            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);
            
            if (a_donde_enviara_la_informacion[0] == "agregar")
            {
                string temp = "";
                temp = (string)proc_produc.agregar_producto(temp,a_donde_enviara_la_informacion[0]);

                info_a_retornar = temp;
            }

            return info_a_retornar;
        }


    }
}
