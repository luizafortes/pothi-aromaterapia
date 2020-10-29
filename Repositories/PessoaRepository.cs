using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories.Interfaces;

namespace Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        string diretorio;
        string nomeArquivo;

        #region "Operações com arquivos"

        #endregion

        public bool Insert(PessoaModel _model)
        {
            bool result = false;
            try
            {
                string caminho = @"C:\Users\luiza\luiza-github\projects\pothiAromaterapia\bd.txt";

                StreamWriter streamWriter = new StreamWriter(caminho, true);

                streamWriter.Write(_model.Cpf + ";");
                streamWriter.Write(_model.Nome + ";");

                streamWriter.Close();
                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public void Update(int _id, PessoaModel _model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int _id)
        {
            throw new NotImplementedException();
        }

        public List<PessoaModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PessoaModel GetById(int _id)
        {
            throw new NotImplementedException();
        }
        public List<PessoaModel> GetByNome(string _nome)
        {
            throw new NotImplementedException();
        }

        public PessoaModel GetByEmail(string _email)
        {
            throw new NotImplementedException();
        }

        public PessoaModel GetByCpf(string _cpf)
        {
            throw new NotImplementedException();
        }

        public List<PessoaModel> GetByCidade(string _cidade)
        {
            throw new NotImplementedException();
        }

        public List<PessoaModel> GetByEstado(string _estado)
        {
            throw new NotImplementedException();
        }
    }
}
