using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Propiedades_de_los_sistemas
{
    
    public partial class Form1 : Form
    {
        //string ruta = "..\\..\\..\\..\\Propiedades_de_los_sistemas\\leader.txt";
        ArrayList myAl;
        string ruta = "..\\leader.txt";

        public Form1()
        {
            
            InitializeComponent();
            lblNombre.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            btnCuestionario.Visible = false;
            mostrarTabla();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = lblNombre.Text + " " + txtNombre.Text;
            lblNombre.Visible = true;
            txtNombre.Enabled = false;
            btnIniciar.Enabled = false;
            pictureBox5.Visible = false;
            panel2.Visible = true;
            btnCuestionario.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCuestionario_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            btnCuestionario.Visible = false;
            btnTerminar.Visible = true;
        }
        
        //=======================================================================
        //logica para agregar y mostrar posiciones
        //=======================================================================
        Int32 aux;
        void addText(int points)
        {
            StreamWriter sw = File.AppendText(ruta);
            try
            {
                //Write a line of text
                sw.WriteLine(points);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        
        //Metodo obtener  tamaño datos del archivo
        ArrayList SizeFile()
        {
            myAl = new ArrayList();
            TextReader read = new StreamReader(ruta);
            string contend;
            while ((contend = read.ReadLine()) != null)
            {
                myAl.Add(contend);
            }

            read.Close();
            return myAl;
        }


        int[] GetOrdenados()
        {
            //declaracion vetor que vamos a ordenar
            int[] datos = new Int32[SizeFile().Count];

//LLENAMOS EL VECTOR QUE VAMOS A ORDENAR
            for (int i = 0; i < SizeFile().Count; i++)
            {
                datos[i] = Int32.Parse(myAl[i].ToString());
            }

            //metodo borbuja -- ordenamiento
            for (int i = 0; i < (SizeFile().Count) - 1; i++)
            {
                for (int j = 0; j < (SizeFile().Count) - 1; j++)
                {
                    if (datos[j] > datos[j + 1])
                    {
                        //si numero actual e mayor(>) a numero siguiente
                        aux = datos[j];
                        datos[j] = datos[j + 1];
                        datos[j + 1] = aux;
                    }
                }
            } //fin for anidados

            return datos;
        }
        
        
        int GetPosicion(int points)
        {
            for (int i = ((SizeFile().Count)-1); i >= 0; i--) {
                if (points == GetOrdenados()[i])
                {
                    return (SizeFile().Count - i);
                }
            }
            return 0;
        }
        //==================================================================
        //Fin logica
        //==================================================================


        void mostrarTabla()
        {
            for (int i = ((SizeFile().Count)-1); i >= 0; i--) {
                if (i == SizeFile().Count-1)
                {
                    lblPrimero.Text = GetOrdenados()[i].ToString();
                }
                if (i == SizeFile().Count-2)
                {
                    lblSegundo.Text = GetOrdenados()[i].ToString();
                }
                if (i == SizeFile().Count-3)
                {
                    lblTercero.Text = GetOrdenados()[i].ToString();
                }
            }
        }

        private int puntos;
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            //Inicializacion variable puntos
             puntos = 0;
            panel2.Visible = false;
            panel3.Visible = false;
            txtNombre.Text = "";
            txtNombre.Enabled = true;
            btnIniciar.Enabled = true;
            pictureBox5.Visible = true;
            lblNombre.Visible = false;
            lblNombre.Text = "¡Hola!, ";
            //================================================
            //sistema para calcular los puntos:
            
            if (combo1.SelectedIndex == 0)
            {
                puntos += 2;
            }

            if (combo2.SelectedIndex == 2)
            {
                puntos += 2;
            }

            if (combo3.SelectedIndex == 0)
            {
                puntos += 2;
            }

            if (combo4.SelectedIndex == 1)
            {
                puntos += 2;
            }
            if (combo5.SelectedIndex == 2)
            {
                puntos += 2;
            }
            if (combo6.SelectedIndex == 2)
            {
                puntos += 2;
            }
            if (combo7.SelectedIndex == 1)
            {
                puntos += 2;
            }
            if (combo8.SelectedIndex == 3)
            {
                puntos += 2;
            }
            if (combo9.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo10.SelectedIndex == 1)
            {
                puntos += 2;
            }
            if (combo11.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo12.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo13.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo14.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo15.SelectedIndex == 1)
            {
                puntos += 2;
            }
            if (combo16.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo17.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo18.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo19.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo20.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo21.SelectedIndex == 3)
            {
                puntos += 2;
            }
            if (combo22.SelectedIndex == 0)
            {
                puntos += 2;
            }
            if (combo23.SelectedIndex == 1)
            {
                puntos += 2;
            }
            if (combo24.SelectedIndex == 2)
            {
                puntos += 2;
            }
            if (combo25.SelectedIndex == 0)
            {
                puntos += 2;
            }
            //==========================================
            
            
            //LLAMAMOS EL METODO PARA AGREGAR EN EL ARCHIVO PLANO
            addText(puntos);
            // metodo para saber la posicion en la que quedo
            MessageBox.Show("F  : "+txtNombre.Text+" su puntuacion fue de: "+puntos+"\nSu posicion es de: "+GetPosicion(puntos)+" segun nuestro rainking");
            mostrarTabla();
            puntos = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}