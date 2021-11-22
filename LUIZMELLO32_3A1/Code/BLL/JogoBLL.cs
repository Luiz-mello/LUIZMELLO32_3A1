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
    class JogoBLL
    {
        Banco banco = new Banco();
        string tabela = "jogos";

        public void Inserir(JogoDTO jogoDTO)
        {
            string inserir = $"insert into {tabela} value (null, '{jogoDTO.NomeJogo}', '{jogoDTO.Categoria}')";
            banco.ExecutarComando(inserir);
        }

        public void Editar(JogoDTO jogoDTO)
        {
            string alterar = $"update {tabela} set nomejogo  = '{jogoDTO.NomeJogo}', categoria = '{jogoDTO.Categoria}'" +
                $" where id = '{jogoDTO.Id}'";
            banco.ExecutarComando(alterar);
        }

        public void Exclui(JogoDTO jogoDTO)
        {
            string excluir = $"delete from {tabela} where id = '{jogoDTO.Id}'";
            banco.ExecutarComando(excluir);
        }


        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return banco.ExecutarConsulta(sql);
        }





    }
}
