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
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo especificado
                    filePath = openFileDialog.FileName;

                    using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        // Procesa el contenido del archivo
                        string content = reader.ReadToEnd();
                        plainTextRTB.Text = content;
                    }
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

                encryptPageKeyTB.Text = string.Empty;
                plainTextRTB.Text = string.Empty;
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
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo especificado
                    filePath = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        // Procesa el contenido del archivo
                        string content = reader.ReadToEnd();
                        encryptedTextRTB.Text = content;
                    }
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
            decryptPageKeyTB.Text = string.Empty;
            encryptedTextRTB.Text = string.Empty;
            decryptedTextRTB.Text = string.Empty;
        }
    }
}
