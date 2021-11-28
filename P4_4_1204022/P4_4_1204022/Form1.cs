using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbNama_Leave(object sender, EventArgs e)
        {
            
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Textbox nama tidak boleh kosong!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbNama, "Inputan hanya boleh huruf!");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbNPM_Leave(object sender, EventArgs e)
        {
            if (tbNPM.Text == "")
            {
                epWarning.SetError(tbNPM, "Textbox NPM tidak boleh kosong!");
                epWrong.SetError(tbNPM, "");
                epCorrect.SetError(tbNPM, "");
            }
            else
            {
                if ((tbNPM.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbNPM, "Betul!");
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "");
                }
                else
                {
                    epCorrect.SetError(tbNPM, "");
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "Inputan hanya boleh angka!");
                }
            }
        }

        private void tbTelp_TextChanged(object sender, EventArgs e)
        {
           tbTelp.MaxLength = 13;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "Format email salah!\nContoha@b.c");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbHBesar_TextChanged(object sender, EventArgs e)
        {
            tbHBesar.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Nama : " + tbNama.Text +
                   "\nNPM : " + tbNPM.Text +
                   "\nNo Telp : " + tbTelp.Text +
                   "\nEmail : " + tbEmail.Text +
                   "\nUsename Huruf Kapital : " + tbHBesar.Text+
                   "\nUsername Huruf Kecil : " + tbHKecil.Text +
                   "\nUmur Ayah : "+ textBox1.Text +
                   "\nUmur Ibu : " + textBox2.Text,
                   "Informasi Pendaftaran",
                   MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void tbHKecil_TextChanged(object sender, EventArgs e)
        {
            tbHKecil.CharacterCasing = CharacterCasing.Lower;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if ((textBox1.Text).All(Char.IsNumber))
            {
                if (textBox1.Text == "")
                {
                    epWarning.SetError(textBox1, "Umur Ayah Belum terisi");
                }

                else
                {
                    epCorrect.SetError(textBox1, "Umur Ibu sudah Terisi");
                }
            }

            else if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Textbox umur tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox1, "inputan hanya boleh Angka!");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ((textBox2.Text).All(Char.IsNumber))
            {
                int Angka1 = int.Parse(textBox1.Text);
                int Angka2 = int.Parse(textBox2.Text);
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(textBox1, "Umur ayah lebih tua dari pada umur ibu ");
                }
            }

            else if ((textBox2.Text == ""))
            {
                epWarning.SetError(textBox2, "Textbox umur tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(textBox2, "inputan hanya boleh Angka!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
