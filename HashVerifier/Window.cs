using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashVerifier
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path to the file
                textBoxFilePath.Text = openFileDialog.FileName;
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            // Read file to byte
            byte[] fileBytes = File.ReadAllBytes(textBoxFilePath.Text);
 
            // Generate MD5 hash
            MD5 md5 = MD5.Create();
            byte[] md5HashByte = md5.ComputeHash(fileBytes);
            string md5Hash = ConvertToHex(md5HashByte);
            
            // Generate SHA1 hash
            SHA1 sha1 = SHA1.Create();
            byte[] sha1HashByte = sha1.ComputeHash(fileBytes);
            string sha1Hash = ConvertToHex(sha1HashByte);

            // Show hash
            textBoxGeneratedMD5.Text = md5Hash;
            textBoxGeneratedSHA1.Text = sha1Hash;

            // Verify if hash is equal
            if (textBoxSupplierMD5.Text != string.Empty && textBoxSupplierMD5.Text == textBoxGeneratedMD5.Text ||
                textBoxSupplierSHA1.Text != string.Empty && textBoxSupplierSHA1.Text == textBoxGeneratedSHA1.Text)
            {
                labelResult.Text = "Hash equal";
            }
            else
            {
                labelResult.Text = "No hash provided";
            }
        }

        private static string ConvertToHex(byte[] md5Hash)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < md5Hash.Length; i++)
            {
                stringBuilder.Append(md5Hash[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
