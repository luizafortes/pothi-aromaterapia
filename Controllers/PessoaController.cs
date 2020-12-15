using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Interfaces;
using Repositories;

namespace Controllers
{
    public class PessoaController
    {
        public Object BD(char _comando, Object _param)
        {
            try
            {
                PessoaRepository _rep = new PessoaRepository();

                switch (_comando)
                {
                    case 't':
                        return _rep.GetAll();
                    case 'o':
                        return _rep.GetForID((int)_param);
                    case 'i':
                        return _rep.Insert((PessoaModel)_param);
                    case 'd':
                        return _rep.Delete((int)_param);
                    case 'u':
                        return _rep.Update((PessoaModel)_param);
                    case 'f'://Adicionado para implementar as opções de filtro
                        return _rep.BuscarListaFiltrada((String)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
