using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUIZMELLO32_3A1.Code.DAL;
using LUIZMELLO32_3A1.Code.DTO;


namespace LUIZMELLO32_3A1.Code.BLL
{
    class LoginBLL
    {
        Banco banco = new Banco();
        string tabela = "clientes";


        public bool RealizarLogin(LoginDTO loginDTO) { 
            string sql = $"select * from {tabela} where email = '{loginDTO.Usuario}' and senha = '{loginDTO.Senha}'";
            DataTable dt = banco.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

    }
}
