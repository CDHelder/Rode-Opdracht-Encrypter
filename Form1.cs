using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
            /*
            if (String.IsNullOrEmpty(passwordTextbox.Text))
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            */
            //Encrypt gedeelte
            if (encryptFunction.Checked)
            {
                //try
                //{
                    //Collect the content of file and password and then encrypt
                    using (var fileDataOpen = File.OpenRead(filepathTextbox.Text))
                    using (var aesCrypto = new AesCryptoServiceProvider())
                    {
                        HashAlgorithm hash = MD5.Create();
                        aesCrypto.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordTextbox.Text));
                        aesCrypto.Padding = PaddingMode.PKCS7;

                        using (var createCrypto = aesCrypto.CreateEncryptor(aesCrypto.Key,aesCrypto.IV))
                        using (var fileDataSend = File.Create(filepathTextbox.Text + " Encrypted"))
                        using (var cryptoStream = new CryptoStream(fileDataSend, createCrypto, CryptoStreamMode.Write))
                        {
                            fileDataOpen.CopyTo(cryptoStream);
                        }
                    }
                /*}
                catch
                {
                    MessageBox.Show("Couldn't read the file. Please close other programs");
                    return;
                }*/
            }
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Decrypter, not yet done
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            if (decryptFunction.Checked)
            {
                //try
                //{
                //Collect the data from file and password to decrypt
                using (var fileDataOpen = File.OpenRead(filepathTextbox.Text))
                using (var aesCrypto = new AesCryptoServiceProvider())
                {
                    HashAlgorithm hash = MD5.Create();
                    aesCrypto.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordTextbox.Text));
                    aesCrypto.Padding = PaddingMode.PKCS7;

                    using (var createDecrypto = aesCrypto.CreateDecryptor(aesCrypto.Key, aesCrypto.IV))
                    using (var fileDataSend = File.Create(filepathTextbox.Text.Replace(" Encrypted", " Decrypted")))
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(fileDataOpen, createDecrypto, CryptoStreamMode.Read))
                        {
                            cryptoStream.CopyTo(fileDataSend);
                        }
                    } 
                }
            }
                /*}
                catch
                {
                    MessageBox.Show("Make sure you selected the right file");
                    return;
                }*/
            
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
                passwordTextbox.PasswordChar = (char)'•';
                showPasswordButton.Text = "Show";
                return;
            }
        }
    }
}
