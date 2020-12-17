using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Enums;
using Entities.Interfaces.Repositories;

namespace Repositories
{
    public class PessoaRepository
    {

        #region "Operações com Banco de Dados"

        public Dictionary<Int32, PessoaModel> GetAll()
        {
            Dictionary<Int32, PessoaModel> mapaPessoas = new Dictionary<Int32, PessoaModel>();
            try
            {
                String SQL = "SELECT * FROM pessoa;";

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    PessoaModel p = new PessoaModel();

                    p.PessoaId = Convert.ToInt32(data["PessoaId"]);
                    p.Cpf = Convert.ToInt64(data["Cpf"]);
                    p.Nome = data["Nome"].ToString();
                    p.Tel = data["Tel"].ToString();
                    p.Email = data["Email"].ToString();
                    //p.Sexo = data.GetInt32(8);
                    //p.EstadoCivil = data.GetInt32(9);
                    p.Filhos = Convert.ToInt32(data["Filhos"]);
                    p.Animais = Convert.ToInt32(data["Animais"]);
                    p.Fumante = Convert.ToInt32(data["Fumante"]);


                    //p.Endereco.TipoLogradouro = data.GetInt32(4);
                    //p.Endereco.Logradouro = data.GetString(5);
                    //p.Endereco.Cidade = data.GetInt32(6);
                    //p.Endereco.Estado = data.GetInt32(7);

                    mapaPessoas.Add(p.PessoaId, p);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaPessoas;
        }

        public PessoaModel GetForID(Int32 _pessoaId)
        {
            PessoaModel p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pessoa WHERE pessoaId = {0};", _pessoaId);

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new PessoaModel();

                    p.PessoaId = Convert.ToInt32(data["PessoaId"]);
                    p.Cpf = Convert.ToInt64(data["Cpf"]);
                    p.Nome = data["Nome"].ToString();
                    p.Tel = data["Tel"].ToString();
                    p.Email = data["Email"].ToString();
                    //p.Sexo = data.GetInt32(8);
                    //p.EstadoCivil = data.GetInt32(9);
                    p.Filhos = Convert.ToInt32(data["Filhos"]);
                    p.Animais = Convert.ToInt32(data["Animais"]);
                    p.Fumante = Convert.ToInt32(data["Fumante"]);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public Boolean Insert(PessoaModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO pessoa (" +
                    "cpf, " +
                    "nome, " +
                    "tel, " +
                    "email, " +
                    "filhos, " +
                    "animais, " +
                    "fumante) " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', {6})",
                    _obj.Cpf.ToString(),
                    _obj.Nome,
                    _obj.Tel,
                    _obj.Email,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante
                    );

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);
                
                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean Delete(Int32 _pessoaId)
        {
            Boolean resultado = false;
            try
            {
                String SQL = "DELETE FROM pessoa WHERE pessoaId = " + _pessoaId.ToString();

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Update(PessoaModel _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("UPDATE pessoa SET " +
                    "nome = '{0}', " +
                    "cpf = '{1}', " +
                    "tel = '{2}', " +
                    "email = '{3}', " +
                    "filhos = '{4}', " +
                    "animais = '{5}', " +
                    "fumante = '{6}' WHERE PessoaId = {7}",
                    _obj.Nome,
                    _obj.Cpf.ToString(),
                    _obj.Tel,
                    _obj.Email,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante,
                    _obj.PessoaId
                    );

                int linhasAfetadas = Conexao.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Adicionado para implementar as opções de filtro
        public Dictionary<Int64, PessoaModel> BuscarListaFiltrada(String _filtros)
        {
            Dictionary<Int64, PessoaModel> mapaPessoas = new Dictionary<Int64, PessoaModel>();
            try
            {
                String SQL = "SELECT * FROM pessoa WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("cpf = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlDataReader data = Conexao.ExecutarSelect(SQL);

                while (data.Read())
                {
                    PessoaModel p = new PessoaModel();

                    p.Cpf = Convert.ToInt64(data["Cpf"]);
                    p.Nome = data["Nome"].ToString();
                    p.Tel = data["Tel"].ToString();
                    p.Email = data["Email"].ToString();
                    //p.Sexo = data.GetInt32(8);
                    //p.EstadoCivil = data.GetInt32(9);
                    p.Filhos = Convert.ToInt32(data["Filhos"]);
                    p.Animais = Convert.ToInt32(data["Animais"]);
                    p.Fumante = Convert.ToInt32(data["Fumante"]);

                    mapaPessoas.Add(p.Cpf, p);
                }

                data.Close();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaPessoas;
        }

        #endregion


        #region "Operações com Arquivos"

        //    public Dictionary<string, PessoaModel> GetAll()
        //    {
        //        Dictionary<string, PessoaModel> pessoas = new Dictionary<string, PessoaModel>();
        //        try
        //        {
        //            string SQL = "SELECT * FROM PESSOA;";
        //            SqlDataReader dr = Conexao.ExecutarSelect(SQL);

        //            while (dr.HasRows)
        //            {
        //                PessoaModel pessoa = new PessoaModel();
        //                pessoa.Cpf = dr.GetString(0);
        //                pessoa.Nome = dr.GetString(1);
        //                pessoa.Tel = dr.GetString(2);
        //                pessoa.Email = dr.GetString(3);
        //                pessoa.Sexo = dr.GetInt32(4) == 1 ? Sexo.Feminino : Sexo.Masculino;
        //                pessoa.EstadoCivil = dr.GetInt32(5) == 1 ? EstadoCivil.Solteiro : (dr.GetInt32(5) == 2 ? EstadoCivil.Casado : (dr.GetInt32(5) == 3 ? EstadoCivil.Divorciado : (dr.GetInt32(5) == 4 ? EstadoCivil.Viuvo : EstadoCivil.Invalido)));
        //                pessoa.Filhos = Convert.ToBoolean(dr.GetString(6));
        //                pessoa.Animais = Convert.ToBoolean(dr.GetString(7));
        //                pessoa.Fumante = Convert.ToBoolean(dr.GetString(8));
        //                //pessoa.Endereco = dr.GetString(9);

        //                pessoas.Add(pessoa.Cpf, pessoa);

        //            }
        //            dr.Close();
        //            Conexao.FecharConexao();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        return pessoas;
        //    }

        //    public object BuscarListaFiltrada(string param)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public object Update(PessoaModel param)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public object Delete(long param)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public object GetForID(long param)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public PessoaModel GetById(int _id)
        //    {
        //        PessoaModel pessoa = null;
        //        try
        //        {
        //            String SQL = String.Format("SELECT * FROM pessoa WHERE id = {0};", _id); 
        //            SqlDataReader dr = Conexao.ExecutarSelect(SQL);

        //            if (dr.Read())
        //            {
        //                pessoa = new PessoaModel();
        //                pessoa.Cpf = dr.GetString(0);
        //                pessoa.Nome = dr.GetString(1);
        //                pessoa.Tel = dr.GetString(2);
        //                pessoa.Email = dr.GetString(3);
        //                pessoa.Sexo = dr.GetInt32(4) == 1 ? Sexo.Feminino : Sexo.Masculino;
        //                pessoa.EstadoCivil = dr.GetInt32(5) == 1 ? EstadoCivil.Solteiro : (dr.GetInt32(5) == 2 ? EstadoCivil.Casado : (dr.GetInt32(5) == 3 ? EstadoCivil.Divorciado : (dr.GetInt32(5) == 4 ? EstadoCivil.Viuvo : EstadoCivil.Invalido)));
        //                pessoa.Filhos = Convert.ToBoolean(dr.GetString(6));
        //                pessoa.Animais = Convert.ToBoolean(dr.GetString(7));
        //                pessoa.Fumante = Convert.ToBoolean(dr.GetString(8));
        //                //pessoa.Endereco = dr.GetString(9);
        //            }

        //            dr.Close();
        //            Conexao.FecharConexao();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);

        //        }
        //        return pessoa;
        //    }

        //    public Boolean Insert(PessoaModel _model)
        //    {
        //        Boolean resultado = false;
        //        try
        //        {
        //            String SQL = String.Format("INSERT INTO pessoa (" +
        //                "cpf, " +
        //                "nome, " +
        //                "tel, " +
        //                "email, " +
        //                "genero, " +
        //                "estado_civil, " +
        //                "filhos, " +
        //                "animais, " +
        //                "fumante, " +
        //                "endereco ) " +
        //                "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}', '{9}')",
        //                _model.Cpf,
        //                _model.Nome,
        //                _model.Tel,
        //                _model.Email,
        //                _model.Sexo,
        //                _model.EstadoCivil,
        //                _model.Filhos,
        //                _model.Animais,
        //                _model.Fumante,
        //                _model.Endereco
        //                );

        //            int linhasAfetadas = Conexao.ExecutarIDU(SQL);

        //            if (linhasAfetadas > 0)
        //            {
        //                resultado = true;
        //            }

        //            return resultado;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }

        //    public Boolean Update(int _id, PessoaModel _model)
        //    {
        //        Boolean resultado = false;
        //        try
        //        {
        //            String SQL = String.Format("UPDATE pessoa SET " +
        //                "cpf = '{0}', " +
        //                "nome = '{1}', " +
        //                "tel = '{2}', " +
        //                "email = '{3}', " +
        //                "sexo = '{4}', " +
        //                "estado_civil = '{5}', " +
        //                "filhos = '{6}', " +
        //                "animais = '{7}', " +
        //                "fumante = '{8}' WHERE id = {9}",

        //                _model.Cpf,
        //                _model.Nome,
        //                _model.Tel,
        //                _model.Email,
        //                _model.Sexo,
        //                _model.EstadoCivil,
        //                _model.Filhos,
        //                _model.Animais,
        //                _model.Fumante,
        //                _model.Endereco,
        //                _id
        //                );

        //            int linhasAfetadas = Conexao.ExecutarIDU(SQL);

        //            if (linhasAfetadas > 0)
        //            {
        //                resultado = true;
        //            }

        //            return resultado;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }

        //    public Boolean Delete(int _id)
        //    {
        //        Boolean resultado = false;
        //        try
        //        {
        //            String SQL = "DELETE FROM pessoa WHERE id = " + _id;

        //            int linhasAfetadas = Conexao.ExecutarIDU(SQL);

        //            if (linhasAfetadas > 0)
        //            {
        //                resultado = true;
        //            }

        //            return resultado;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }

        //    #endregion


        //    #region "Operações com arquivos"
        //    string caminho = @"C:\Users\luiza\luiza-github\projects\pothiAromaterapia\bd.txt";
        //    public bool SalvarPessoaNoArquivo(PessoaModel _model)
        //    {
        //        bool result = false;
        //        try
        //        {
        //            StreamWriter streamWriter = new StreamWriter(caminho, true);

        //            streamWriter.Write(_model.Cpf + ";");
        //            streamWriter.Write(_model.Nome + ";");
        //            streamWriter.Write(_model.Tel + ";");
        //            streamWriter.Write(_model.Email + ";");
        //            streamWriter.Write(_model.Sexo + ";");
        //            streamWriter.Write(_model.EstadoCivil + ";");
        //            streamWriter.Write(_model.Filhos + ";");
        //            streamWriter.Write(_model.Animais + ";");
        //            streamWriter.Write(_model.Fumante + ";");
        //            streamWriter.Write(_model.Endereco.TipoLogradouro + " " + _model.Endereco.Logradouro + " " + _model.Endereco.Complemento + ", " + _model.Endereco.Cep + ", " + _model.Endereco.Estado + ", " + _model.Endereco.Estado + ";");

        //            streamWriter.WriteLine();

        //            streamWriter.Close();
        //            result = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        return result;
        //    }

        //    public Dictionary<string, PessoaModel> ListarPessoasDoArquivo()
        //    {
        //        Dictionary<string, PessoaModel> tabelaPessoas = new Dictionary<string, PessoaModel>();
        //        try
        //        {
        //            StreamReader streamReader = new StreamReader(caminho);

        //            string arquivo = streamReader.ReadToEnd();
        //            char[] divisorLinhas = { '\n' };
        //            char[] divisorColunas = { ';' };
        //            string[] linhas = arquivo.Split(divisorLinhas);

        //            for (int i = 0; i < linhas.Length; i++)
        //            {
        //                string[] colunas = linhas[0].Split(divisorColunas);

        //                PessoaModel pessoa = new PessoaModel();

        //                pessoa.Cpf = colunas[0];
        //                pessoa.Nome = colunas[1];
        //                pessoa.Tel = colunas[2];
        //                pessoa.Email = colunas[3];
        //                //pessoa.Sexo = colunas[4];
        //                //pessoa.EstadoCivil = colunas[5];
        //                pessoa.Filhos = Convert.ToBoolean(colunas[6]);
        //                pessoa.Animais = Convert.ToBoolean(colunas[7]);
        //                pessoa.Fumante = Convert.ToBoolean(colunas[8]);
        //                //pessoa.Endereco = colunas[9];

        //                tabelaPessoas.Add(pessoa.Cpf, pessoa);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("ERRO AO LER O ARQUIVO; " + ex.Message);
        //        }
        //        return tabelaPessoas;
        //    }
        #endregion

    }
}
