using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace Fernandez_Robin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }
        #region Def objetos
        private Socket conexion;
        private Thread lecturathread;
        private NetworkStream socketstream;
        private BinaryWriter escritor;
        private BinaryReader lector;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            lecturathread = new Thread(new ThreadStart(EjecutarServidor));
            lecturathread.Start();
        }

        private void EjecutarServidor()
        {

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("No se pudo conectar", "ERROR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("El error se resolvió");
                }
                else
                {
                    MessageBox.Show("El problema no se resolvio");
                }
            }
        } 
        //Cierra todos los subprocesos asociadas con esta aplicacion . 
       
        
        private void ServidorChatForm_FormClosing(object sender,
                FormClosingEventArgs e)
        {
            int a = 5;
            int b = 10;
            int c = a + b;
            if(c==15)
            { MessageBox.Show(c.ToString()); }





            System.Environment.Exit(System.Environment.ExitCode);

        } // Fin del metodo CharServerForm_FormClosing

       

    }


}
