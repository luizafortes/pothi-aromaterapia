using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Controllers
{
    public class OleoController
    {
        public Object BD(char _comando, Object _param)
        {
            try
            {
                OleoRepository _rep = new OleoRepository();

                switch (_comando)
                {
                    case 't':
                        return _rep.GetAll();
                    case 'o':
                        return _rep.GetForID((int)_param);
                    case 'i':
                        return _rep.Insert((OleoModel)_param);
                    case 'd':
                        return _rep.Delete((int)_param);
                    case 'u':
                        return _rep.Update((OleoModel)_param);
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
