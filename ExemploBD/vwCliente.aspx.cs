using ExemploBD.Models;
using ExemploBD.Models.DAO;
using System;

namespace ExemploBD
{
    public partial class vwCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void PreencherCampos(Cliente c)
        {
            if (c != null)
            {
                txtId.Text = Convert.ToString(c.Id);
                txtNome.Text = c.Nome;
                txtCPF.Text = c.Cpf;
                txtRG.Text = c.Rg;
                txtEndereco.Text = c.Endereco_id;
            }
            else
            {
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtEndereco.Text = "";
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" || txtNome.Text != "" || txtCPF.Text != "" || txtRG.Text != "")
            {
                Cliente cliente = new Cliente(txtNome.Text, txtCPF.Text, txtRG.Text, txtEndereco.Text);
                cliente = ClienteDAO.Inserir(cliente);
                if (cliente != null)
                {
                    Session["cliente"] = cliente;
                    Response.Redirect("~/vwEndereco.aspx");
                }
            }
            else
            {
                lblResultado.Text = "Não foi possivel adicionar um cliente!";
            }
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                Cliente c = ClienteDAO.BuscarPorId(Convert.ToInt32(txtId.Text));
                lblResultado.Text = "";
                if (c != null)
                {
                    PreencherCampos(c);
                }
                else
                {
                    lblResultado.Text = "Não existe um cliente com esse ID!";
                }
            }
            else
            {
                lblResultado.Text = "ID não preenchido!";
            }


        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nome = txtNome.Text,
                Cpf = txtCPF.Text,
                Rg = txtRG.Text
            };
            if (ClienteDAO.Alterar(c))
            {
                lblResultado.Text = "Cliente alterado com sucesso!";
            }
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Cliente c = ClienteDAO.BuscarPorId(Convert.ToInt32(txtId.Text));
                if (ClienteDAO.Deletar(c))
                {
                    lblResultado.Text = "Cliente deletado com sucesso!";
                }
            }
            else
            {
                lblResultado.Text = "Não foi possivel deletar o cliente.";
            }
        }


        protected void btnEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}