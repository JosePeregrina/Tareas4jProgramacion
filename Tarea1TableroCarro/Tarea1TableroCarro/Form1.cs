using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1TableroCarro
{
    public partial class Form1 : Form
    {
        short contadorProceso;   
        
        public Form1()
        {   
            InitializeComponent();
        }

       int Recorrer(int variable, int recorrer, int comparacion)
        {
           
            variable >>= recorrer;
             
            contadorProceso++;
            return variable & comparacion;
        }

        void Mostrar(short c, int informacion)
        {
            switch (c)
            {
                case 1:
                    switch (informacion)
                    {
                        case 1:
                            pbBrujula.Image = Properties.Resources.Norte;
                            break;
                        case 2:
                            pbBrujula.Image = Properties.Resources.NorEste;
                            break;
                        case 3:
                            pbBrujula.Image = Properties.Resources.Este;
                            break;
                        case 4:
                            pbBrujula.Image = Properties.Resources.SurEste;
                            break;
                        case 5:
                            pbBrujula.Image = Properties.Resources.Sur;
                            break;
                        case 6:
                            pbBrujula.Image = Properties.Resources.SurOeste;
                            break;
                        case 7:
                            pbBrujula.Image = Properties.Resources.Oeste;
                            break;
                        case 8:
                            pbBrujula.Image = Properties.Resources.NorOeste;
                            break;
                    }
                    break;
                case 2:
                    switch (informacion)
                    {
                        case 0:
                            pbTanque.Image = Properties.Resources.TanqueGasolina;
                            break;
                        case 1:
                            pbTanque.Image = Properties.Resources.TanqueMedio;
                            break;
                        case 2:
                            pbTanque.Image = Properties.Resources.TanqueFull;
                            break;
                        case 3:
                            pbTanque.Image = Properties.Resources.TanqueLlenandose;
                            break;
                    }
                    break;
                case 3:
                    if (informacion == 0)
                    {
                        pbSensor2.Image = Properties.Resources.Alerta_de_temperatura;
                    }
                    else
                    {
                        pbSensor2.Image = Properties.Resources.noAgua;
                    }
                    break;
                case 4:
                    if(informacion == 0)
                    {
                        pbSensor1.Image = Properties.Resources.tablero_luces_cinturon;
                    }
                    else
                    {
                        pbSensor1.Image = Properties.Resources.Mal_funcionamiento_del_motor;
                    }
                    break;
            }
        }

        private void cmdAccion_Click(object sender, EventArgs e)
        {
            int dia = 0;
            int mes = 0;
            int año = 0;
            Int32 dato = Convert.ToInt32(txtdato.Text);
            int info;
           info = Recorrer(dato, 1, 7); //Recorrer el primer bit y compara con 7
           Mostrar(contadorProceso, info);//Mostrar la direccion
           info = Recorrer(dato, 3, 3);//Recorrer 3 bits y comparar con 3
           Mostrar(contadorProceso, info);//Muestra el estado del tanque
           info = Recorrer(dato, 2, 3);//Recorrer  2 bits y comparar con 3
           Mostrar(contadorProceso, info);//Mostrar el estado del sensor 1
           info = Recorrer(dato, 1, 1);//Recorrer 1 bit y comparar con 1
           Mostrar(contadorProceso, info);//Mostrar el estado del sensor 2
                                          // textBox1.Text = Convert.ToString(info);

            // dateTimePicker1.Value.Year();
            //info = Recorrer(dato, )
            dia = Recorrer(dato, 1, 31); //Empezamos con los dias
            mes = Recorrer(dato, 5, 15);
            año = Recorrer(dato, 4, 255) + 1900;
            lblFecha.Text += dia + "/" + mes + "/" + año;
            
            //dtpFecha.Value.Year(info);

           contadorProceso = 0;

        }

        private void cmdCambiarFecha_Click(object sender, EventArgs e)
        {
            int fechaTemp = dtpFecha.Value.Year;

            fechaTemp -= 1900;
            fechaTemp <<= 4;
            fechaTemp += dtpFecha.Value.Month;
            
            fechaTemp <<= 5;
            fechaTemp += dtpFecha.Value.Day;
           
            //fecha -= 1900;
            //fecha += fechaTemp;
            txtNuevaFecha.Text = Convert.ToString(fechaTemp);


        }
    }
}
