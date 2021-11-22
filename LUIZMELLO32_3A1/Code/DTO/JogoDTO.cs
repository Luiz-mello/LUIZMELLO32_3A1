using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUIZMELLO32_3A1.Code.DTO
{
    class JogoDTO
    {
        private int _id;
        private string _nomeJogo;
        private string _categoria;

        public int Id { get => _id; set => _id = value; }
        public string NomeJogo { get => _nomeJogo; set => _nomeJogo = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
