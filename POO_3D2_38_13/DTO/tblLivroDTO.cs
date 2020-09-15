using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO_3D2_38_13.DTO
{
    public class tblLivroDTO
    {
        private int idLivro;
        private int idEditora, idAutor, numPaginas;
        private double valor;
        private string titulo;

        public int IdLivro { get => idLivro; set => idLivro = value; }

        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo Título é obrigatório");
                }

            }
            get { return this.titulo; }

        }
        public int NumPaginas
        {
            set
            {
                if (value != 0)
                {
                    this.numPaginas = value;
                }
                else
                {
                    throw new Exception("O campo Número de Páginas é obrigatório");
                }

            }

            get { return this.numPaginas; }
        }

        public int IdEditora
        {
            set
            {
                if (value != 0)
                {
                    this.idEditora = value;
                }
                else
                {
                    throw new Exception("O campo editora é obrigatório");
                }

            }
            get { return this.idEditora; }

        }

        public int IdAutor
        {
            set
            {
                if (value != 0)
                {
                    this.idAutor = value;
                }
                else
                {
                    throw new Exception("O campo autor é obrigatório");
                }

            }
            get { return this.idAutor; }

        }

        public double Valor
        {
            set
            {
                if (value != 0)
                {
                    this.valor = value;
                }
                else
                {
                    throw new Exception("O campo valor é obrigatório");
                }

            }
            get { return this.valor; }
        }
    }
}