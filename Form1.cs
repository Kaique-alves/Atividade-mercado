using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211469
{
    public partial class frm_Avaliacao : Form
    {
        //definindo variaveis globais
        int contator = 1;
        double calculo = 0;
        
        

        public frm_Avaliacao()
        {
            InitializeComponent();
        }
               
        void limpar()
        {

            //função para limpar

            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            //ignorar esse bloco
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //definindo a variavel correspondente a textbox
            int quantidade = int.Parse(txtQuantidade.Text);
            int valor_uni = int.Parse(txtValor.Text);
                        
            //define o textbox de cada coluna
            dgvPainel.Rows.Add(txtDescricao.Text, txtQuantidade.Text, txtValor.Text);


            //realização do calculo mais variavel que acumula o valor
            calculo += quantidade * valor_uni;
                        

            MessageBox.Show("Produto adicionado com sucesso", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

            limpar();

            lblTotal.Text = calculo.ToString("C");
            lblTotal.ForeColor = Color.Blue;

            txtDescricao.Focus();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            //define a variavel correspondente a celula do datagrid.
            double quantidade = double.Parse(dgvPainel.CurrentRow.Cells[1].Value.ToString());
            double valor_uni = double.Parse(dgvPainel.CurrentRow.Cells[2].Value.ToString());

            if (dgvPainel.RowCount > 0)
            {
                //remove a linha selecionada
                dgvPainel.Rows.RemoveAt(dgvPainel.CurrentRow.Index);


                //atualiza o total
                calculo -= quantidade * valor_uni;

                MessageBox.Show("Produto removido com sucesso", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                


                lblTotal.Text = calculo.ToString("C");

                txtDescricao.Focus();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            //define a variavel correspondente a celula do datagrid.
            double quantidade = double.Parse(dgvPainel.CurrentRow.Cells[1].Value.ToString());
            double valor_uni = double.Parse(dgvPainel.CurrentRow.Cells[2].Value.ToString());


            if (txtSelecionado.Text != "")
            {
                
                //move o valor da celula na coluna quantidade para a textbox
                dgvPainel.CurrentRow.Cells["qntd"].Value = txtSelecionado.Text;


                //atualiza o saldo
                calculo += quantidade * valor_uni;


                MessageBox.Show("Quantidade Alterada com Sucesso!", "Alteração", MessageBoxButtons.OK,MessageBoxIcon.Information);

                
                lblTotal.Text = calculo.ToString("C");


                txtSelecionado.Clear();

            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //limpa os campos e o datagrid

            limpar();

            dgvPainel.RowCount = 0;

            calculo = 0;

            lblTotal.Text= calculo.ToString("C");

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //limpa os campos
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            
            //zera o datagrid
            dgvPainel.RowCount = 0;

            //atualiza a varialvel global para 0
            calculo = 0;

            lblTotal.Text = calculo.ToString("C");

            MessageBox.Show("Venda Gravada com Sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
            //atualiza o contador de vendas 
            contator += 1;

            lblVenda.Text = contator.ToString();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPainel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dgvPainel.RowCount > 0)
            {
                txtSelecionado.Text = dgvPainel.CurrentRow.Cells["qntd"].Value.ToString();

                txtSelecionado.Focus();
            }
        }
    }
}
