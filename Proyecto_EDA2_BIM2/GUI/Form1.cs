using Proyecto_EDA2_BIM2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EDA2_BIM2
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();

            // string plainText = "Hola mundo!";
            //string plainText = "El objetivo del proyecto se enfoca en desarrollar su propio algoritmo para encriptar y desencriptar información leída de archivos" +
                         //      " con los conceptos aprendidos en clases. y mediante una opción realizar la encriptación y guardado de datos de este archivo. " +
                          //     "Igualmente debe existir la opción para desencriptar el archivo y guardar el archivo desencriptado. ";
            //string key = "clave123";

            //string cipherText = GedaEncryption.Encrypt(plainText, key);
            //encryptedTextRTB.Text += "Texto encriptado: " + cipherText + "\n\n";

            //string decryptedText = GedaEncryption.Decrypt(cipherText, key);
            //plainTextRTB.Text +=  "\n\nTexto desencriptado: " + decryptedText;

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    plainTextRTB.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (plainTextRTB.Text != string.Empty & encryptPageKeyTB.Text != string.Empty)
            {
                string plainText = plainTextRTB.Text;
                string key = encryptPageKeyTB.Text;
                string cipherText = GedaEncryption.Encrypt(plainText, key);

                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "Archivos de texto|*.txt";
                    saveFileDialog1.Title = "Guardar archivo de texto";
                    saveFileDialog1.ShowDialog();

                    if (saveFileDialog1.FileName != "")
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                        {
                            writer.Write(cipherText);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar el texto y la clave para encriptar");
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (encryptedTextRTB.Text != string.Empty & decryptPageKeyTB.Text != string.Empty)
            {
                string cipherText = encryptedTextRTB.Text;
                string key = decryptPageKeyTB.Text;
                string decryptedText = GedaEncryption.Decrypt(cipherText, key);
                decryptedTextRTB.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("Debe ingresar el texto y la clave para desencriptar");
            }
        }

        private void OpenEncryptedFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    encryptedTextRTB.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void SaveFileDecryptedButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "Archivos de texto|*.txt";
                saveFileDialog1.Title = "Guardar archivo de texto";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.Write(decryptedTextRTB.Text);
                    }
                }
            }
        }
    }
}
