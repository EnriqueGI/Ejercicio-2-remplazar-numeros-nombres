using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Escribe una frase e incluye muchos caracteres numéricos (0-9), pero decide que para los números 10 y menos prefiere escribir la palabra. ¿Puedes ingresar y editar tu frase para escribir el nombre de cada número en lugar de usar el número?
No
Tarea:
Tome una frase y reemplace cualquier instancia de un número entero del 0 al 10 y reemplácela con la palabra en inglés que corresponda a ese número entero.

Formato de entrada:
Una cadena de la frase en su forma original (minúscula).

Formato de salida:
Una cadena de la frase actualizada que ha cambiado los números a palabras.

Entrada de muestra:
necesito 2 calabazas y 3 manzanas

Salida de muestra:
necesito dos calabazas y tres manzanas

 
 */
namespace Ejercicio_2_remplazar_numeros_nombres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string frase = txMensaje.Text;
            string fraseNueva="";
            for(int i =0; i< frase.Length; i++)
            {
              char caracter= frase.ElementAt(i);
                switch (caracter)
                {
                    case '1':
                        fraseNueva = fraseNueva + " uno ";
                        break;
                    case '2':
                        fraseNueva = fraseNueva + " dos ";
                        break;
                    case '3':
                        fraseNueva = fraseNueva + " tres ";
                        break;
                    case '4':
                        fraseNueva = fraseNueva + " cuatro ";
                        break;
                    case '5':
                        fraseNueva = fraseNueva + " cinco ";
                        break;
                    case '6':
                        fraseNueva = fraseNueva + " seis ";
                        break;
                    case '7':
                        fraseNueva = fraseNueva + " siete ";
                        break;
                    case '8':
                        fraseNueva = fraseNueva + " ocho ";
                        break;
                    case '9':
                        fraseNueva = fraseNueva + " nueve ";
                        break;
                  

                    case ' ':
                        fraseNueva = fraseNueva + " ";
                        break;

                    default:
                        fraseNueva = fraseNueva + caracter;
                        break;
                }
                



            }

            labeMensaje.Text = fraseNueva;
        }
    }
}
