using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using POO_3D2_38_13.DAL;
using POO_3D2_38_13.DTO;


namespace POO_3D2_38_13.BLL
{
    public class tblLivroBLL
    {
        private dalsql daobanco = new dalsql();

        public class tblAutorBLL
        {
            private dalsql daoBanco = new dalsql();
            public DataTable ListarAutores()
            {
                string sql = string.Format($@"select * from TBL_Autor");
                return daoBanco.executarConsulta(sql);
            }
        }

        public class tblEditoraBLL
        {
            private dalsql daoBanco = new dalsql();
            public DataTable ListarEditoras()
            {
                string sql = string.Format($@"select * from TBL_Editora");
                return daoBanco.executarConsulta(sql);
            }
        }

        public DataTable ListarLivro()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daobanco.executarConsulta(sql);        
        
        }

        public void InserirLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"insert into TBL_Livro values (NULL, '{dtoLivro.IdAutor}',
                                                                               {dtoLivro.IdEditora}',
                                                                               {dtoLivro.Titulo}',
                                                                               {dtoLivro.NumPaginas}',
                                                                               {dtoLivro.Valor}');");
            daobanco.executarComando(sql);
        }

        public void ExcluirLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"delete from TBL_Livro where idLivro = {dtoLivro.IdLivro};");
            daobanco.executarComando(sql);

        }

        public void AlterarLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"update TBL_Livro set idAutor = '{dtoLivro.IdAutor}',
                                                                             idEditora = '{dtoLivro.IdEditora}',
                                                                              titulo = '{dtoLivro.Titulo}',
                                                                              numPaginas = '{dtoLivro.NumPaginas}',
                                                                               valor = '{dtoLivro.Valor}'
                                                                               where idLivro = '{dtoLivro.IdLivro}';");

            daobanco.executarComando(sql);
        }

       
    }
}