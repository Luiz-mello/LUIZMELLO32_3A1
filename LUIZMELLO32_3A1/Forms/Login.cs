using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LUIZMELLO32_3A1.Code.BLL;
using LUIZMELLO32_3A1.Code.DTO;

namespace LUIZMELLO32_3A1.Forms
{
    public partial class Login : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Usuario = txt_usuario.Text;
            loginDTO.Senha = txt_senha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }

        }
    }
}
