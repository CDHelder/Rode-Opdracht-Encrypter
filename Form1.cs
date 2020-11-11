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
using System.Security.Cryptography;

namespace Rode_Opdracht_Encrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //Selecteer het bestand dat je wilt encrypten of decrypten
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                filepathTextbox.Text = od.FileName;
            }
        }

        private void encryptFunction_CheckedChanged(object sender, EventArgs e)
        {
            if (encryptFunction.Checked)
            {
                decryptFunction.Checked = false;
            }
        }

        private void decryptFunction_CheckedChanged(object sender, EventArgs e)
        {
            if (decryptFunction.Checked)
            {
                encryptFunction.Checked = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Eerst checken of er een bestand is geselecteerd en password is ingevoerd
            if (!File.Exists(filepathTextbox.Text))
            {
                MessageBox.Show("Please select a file to encrypt or decrypt");
                return;
            }
            if (String.IsNullOrEmpty(passwordTextbox.Text))
            {
                MessageBox.Show("Please enter a password");
                return;
            }

            //Encrypt functie hierzo
            if (encryptFunction.Checked)
            {
                try
                {
                    //Verzamel de inhoud van het bestand en het wachtwoord
                    var fileDataOpen = File.OpenRead(filepathTextbox.Text);
                    var fileDataSend = File.Create(filepathTextbox.Text);
                    byte[] password = Encoding.ASCII.GetBytes(passwordTextbox.Text);

                    //Encryptie
                    using (Aes aesAlgoritm = Aes.Create())
                    {
                        aesAlgoritm.Key = password;

                        ICryptoTransform encryptor = aesAlgoritm.CreateEncryptor(aesAlgoritm.Key, aesAlgoritm.IV);

                        using (var cryptoStream = new CryptoStream(fileDataSend, encryptor, CryptoStreamMode.Write))
                        {
                            fileDataOpen.CopyTo(cryptoStream);
                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Couldn't read file. Please close other programs");
                    return;
                }
            }
            if (decryptFunction.Checked)
            {
                try
                {

                }
                catch
                {
                    MessageBox.Show("Make sure you selected the right file");
                    return;
                }
            }
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            //Functie waarbij het wachtwoord verborgen is en met een knop zichtbaar kan worden en weer verborgen kan worden
            if (showPasswordButton.Text == "Show")
            {
                passwordTextbox.PasswordChar = (char)0;
                showPasswordButton.Text = "Hide";
                return;
            }

            if (showPasswordButton.Text == "Hide")
            {
                passwordTextbox.PasswordChar = (char) '•';
                showPasswordButton.Text = "Show";
                return;
            }
        }
    }
}
