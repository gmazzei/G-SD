using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Mensajes
{
    class Mensaje
    {
        private static Mensaje instance = null;
        private string titulo;

        public static Mensaje Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Mensaje();
                }

                return instance;
            }
        }

        private Mensaje()
        {
            titulo = "FRBA Bus";
        }

        public void mostrarNormal(String mensaje)
        {
            MessageBox.Show(mensaje, titulo);
        }

        public DialogResult mostrarPreguntaSiNo(String mensaje)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void mostrarErrorYSalir(String mensaje)
        {
            Mensaje.Instance.mostrarNormal(mensaje);
            //Environment.Exit(0);
        }
    }
}
