﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_login : Form
    {
        F_escola f_login;
        DataTable dt = new DataTable();
        public F_login( F_escola f)
        {
            InitializeComponent();
            f_login = f;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string senha = tb_senha.Text;
            if (username == "" || senha == "")
            {

                MessageBox.Show("Preencha todos os campos");
                tb_user.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE username_usuario='"+username+"'AND senha_usuario='"+senha+"'";
            dt = Database.ConsultaSql(sql);
            if (dt.Rows.Count == 1) 
            {

                // O ItemArray lista na ordem do bd Ex: Item 5 é o nivel do user
                f_login.lb_nivel.Text = dt.Rows[0].ItemArray[5].ToString();
                // Segunda forma de obter os dados do dataTable
                f_login.lb_user.Text = dt.Rows[0].Field<string>("username_usuario");
                f_login.pb_login.Image = Properties.Resources.green;
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString()) ;
                // Set para a classe global
                this.Close();
            }
            else
            {
                MessageBox.Show("Login e Senha inválidos");
            }
        }      
    }
}
