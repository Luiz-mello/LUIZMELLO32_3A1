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


namespace LUIZMELLO32_3A1
{
    public partial class Form1 : Form
    {
        JogoBLL jogoBLL = new JogoBLL();
        JogoDTO jogoDTO = new JogoDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            jogoDTO.NomeJogo = txt_nomeJogo.Text;
            jogoDTO.Categoria = txt_Categoria.Text;

            jogoBLL.Inserir(jogoDTO);

            MessageBox.Show("Cadastro Concluido!");

            jogoBLL.Listar();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            jogoDTO.Id = int.Parse(txt_id.Text);
            jogoDTO.NomeJogo = txt_nomeJogo.Text;
            jogoDTO.Categoria = txt_Categoria.Text;

            jogoBLL.Editar(jogoDTO);

            MessageBox.Show("Alteração Concluido!");

            jogoBLL.Listar();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            jogoDTO.Id = int.Parse(txt_id.Text);

            jogoBLL.Exclui(jogoDTO);

            MessageBox.Show("Alteração Concluido!");

            jogoBLL.Listar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_todosJogos.DataSource = jogoBLL.Listar();
        }

        private void dtg_todosJogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_id.Text = dtg_todosJogos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomeJogo.Text = dtg_todosJogos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Categoria.Text = dtg_todosJogos.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
