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
using System.Xml.Serialization;
using System.Xml;
namespace practica2
{
    public partial class Form1 : Form
    {
        short flag;
        public Form1()
        {
            InitializeComponent();
        }

        //public int firma()
        //{
        //    ofld.ShowDialog();
        //    FileStream archivo = new FileStream(ofld.FileName, FileMode.Open);
        //    BinaryReader leector = new BinaryReader(archivo);

        //    //Int16 firma = leector.ReadInt16();
        //    byte firma = 0;
        //    firma = leector.ReadByte();
        //    firma += leector.ReadByte();
        //    //leector.BaseStream.Seek(3, SeekOrigin.Begin); para posicionarme
        //    leector.Close();
        //    archivo.Close();
        //    return 0;
        //}

        public int recorrer()
        {
            int resultado = 0;
            FileStream archivo = new FileStream(ofld.FileName, FileMode.Open);
            BinaryReader leector = new BinaryReader(archivo);
            switch (flag)
            {
                case 0:
                    leector.BaseStream.Seek(2, SeekOrigin.Begin);
                    resultado = leector.ReadInt32();
                    break;
                case 1:
                    leector.BaseStream.Seek(18, SeekOrigin.Begin);
                    resultado = leector.ReadInt32();
                    break;
                case 2:
                    leector.BaseStream.Seek(22, SeekOrigin.Begin);
                    resultado = leector.ReadInt32();
                    break;
                case 3:
                    leector.BaseStream.Seek(28, SeekOrigin.Begin);
                    resultado = leector.ReadInt32();
                    break;
                default:
                    resultado = 0;
                    break;
            }
            leector.Close(); 
            archivo.Close();
            flag++;
            return resultado;
        }
        public void mostrar()
        {

            txtMostrar.Text += "("+flag+ ".-" + recorrer().ToString()+"\r\n";
        }
        
        private void cmdAbrir_Click(object sender, EventArgs e)
        {
            flag = 0;
            ofld.ShowDialog();
            FileStream archivo = new FileStream(ofld.FileName, FileMode.Open);
            BinaryReader leector = new BinaryReader(archivo);

            byte firma = 0;
            firma = leector.ReadByte();
            firma += leector.ReadByte();
            archivo.Close();
            leector.Close();
            if (firma == 0x8f)
            {
                mostrar();
                mostrar();
                mostrar();
                mostrar();
            }
            else
            {

            }
            

        }

        private void cmdXL3_Click(object sender, EventArgs e)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            archivo.Filter = "xml.|.xml";
            archivo.ShowDialog();

            XmlWriterSettings auto = new XmlWriterSettings();
            auto.Indent = true;
            auto.NewLineOnAttributes = true;

            XmlWriter escritor = XmlWriter.Create(archivo.FileName, auto);

            escritor.WriteStartDocument();
            escritor.WriteStartElement("Auto");

            escritor.WriteStartElement("Id");
            escritor.WriteString("1");

            escritor.WriteStartElement("Marca");
            escritor.WriteString("Toyota");

            escritor.WriteStartElement("Tipo");
            escritor.WriteString("Casual");

            escritor.WriteStartElement("Tamaño");
            escritor.WriteString("Mediano");

            escritor.WriteStartElement("Color");
            escritor.WriteString("Rojo");

        }
    }
}
