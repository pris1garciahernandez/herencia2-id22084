using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    static class Program
    {
        //clase principal o clse papa que guardara metodos de lectura de vaslores y almacenando de valores en variables*/
        class operacion 
        {
            // declaracion de variables que usa la clase
            //tipo de acceso   tipo de dato   nombre de dato
            protected             int              valor1;
            protected             int              valor2;
            protected             int              Resultado;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
