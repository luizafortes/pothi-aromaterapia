using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Controllers
{
    public class SintomaController
    {        
        public Object BD(char _comando, Object _param)
        {
            try
            {
                SintomaRepository _rep = new SintomaRepository();

                switch (_comando)
                {
                    case 't':
                        return _rep.GetAll();
                    case 'o':
                        return _rep.GetForID((int)_param);
                    case 'i':
                        return _rep.Insert((SintomaModel)_param);
                    case 'd':
                        return _rep.Delete((int)_param);
                    case 'u':
                        return _rep.Update((SintomaModel)_param);
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
