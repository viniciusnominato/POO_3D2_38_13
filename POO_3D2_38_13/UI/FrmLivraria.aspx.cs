using System;
using POO_3D2_38_13.DTO;
using POO_3D2_38_13.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO_3D2_38_13.UI
{
   
        public partial class FrmLivraria : System.Web.UI.Page
        {
            tblLivroBLL livroBLL = new tblLivroBLL();
            tblLivroDTO livroDTO = new tblLivroDTO();
            tblLivroBLL autorBLL = new tblLivroBLL();
            tblLivroBLL editoraBLL = new tblLivroBLL();

        protected void Page_Load(object sender, EventArgs e)
            {
                if (IsPostBack == false)
                {
                    ExibirGridLivros();
                    this.PreencherAutor();
                    this.PreencherEditora();
                }

            }

            public void PreencherAutor()
            {
                drpAutor.DataSource = autorBLL.ListarAutores();
                drpAutor.DataTextField = "nome";
                drpAutor.DataValueField = "idAutor";
                drpAutor.DataBind();
            }

            public void PreencherEditora()
            {
                drpEditora.DataSource = editoraBLL.ListarEditoras();
                drpEditora.DataTextField = "nome";
                drpEditora.DataValueField = "idEditora";
                drpEditora.DataBind();
            }

            protected void btnInserir_Click(object sender, EventArgs e)
            {
                try
                {
                    // inserir os dados da UI no DTO
                    livroDTO.Titulo = txtTitulo.Text;
                    livroDTO.NumPaginas = int.Parse(txtNumPaginas.Text);
                    livroDTO.Valor = double.Parse(txtValor.Text);
                    livroDTO.IdAutor = int.Parse(drpAutor.SelectedValue.ToString());
                    livroDTO.IdEditora = int.Parse(drpEditora.SelectedValue.ToString());

                    // Inserir na tabela de livros
                    livroBLL.InserirLivro(livroDTO);
                    this.ExibirGridLivros();
                }
                catch (Exception ex)
                {
                    msgerro.Visible = true;
                    msgerro.Text = ex.Message;
                }
            }

            public void ExibirGridLivros()
            {
                GridClientes.DataSource = livroBLL.ListarLivros();
                GridClientes.DataBind();
            }

            protected void GridClientes_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
            {

                try
                {
                    livroDTO.IdLivro = Convert.ToInt32(Registro.Values[0]);
                    livroBLL.ExcluirLivro(livroDTO);
                    this.ExibirGridLivros();
                }
                catch (Exception ex)
                {
                    msgerro.Visible = true;
                    msgerro.Text = ex.Message;
                }
            }

            protected void GridClientes_RowEditing(object sender, GridViewEditEventArgs e)
            {
                GridClientes.EditIndex = e.NewEditIndex;
                this.ExibirGridLivros();
            }

            protected void GridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
            {
                try
                {
                    livroDTO.IdLivro = int.Parse(e.NewValues[0].ToString());
                    livroDTO.Titulo = e.NewValues[3].ToString();
                    livroDTO.NumPaginas = int.Parse(e.NewValues[4].ToString());
                    livroDTO.Valor = double.Parse(e.NewValues[5].ToString());
                    livroDTO.IdAutor = int.Parse(e.NewValues[1].ToString());
                    livroDTO.IdEditora = int.Parse(e.NewValues[2].ToString());
                    livroBLL.AlterarLivro(livroDTO);
                    GridClientes.EditIndex = -1;
                    this.ExibirGridLivros();
                }
                catch (Exception ex)
                {
                    msgerro.Visible = true;
                    msgerro.Text = ex.Message;
                }
            }

            protected void GridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
            {
                GridClientes.EditIndex = -1;
                this.ExibirGridLivros();
            }
        }
}