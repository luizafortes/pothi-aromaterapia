using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Controllers
{
    public class EstadoController
    {

        #region "Operações com banco de dados"
        public Object BD(char _comando, Object _param)
        {
            try
            {
                EstadoRepository dao = new EstadoRepository();

                switch (_comando)
                {
                    case 't':
                        return dao.GetAll();
                        /*
                    case 'o':
                        //return dao.GetForID((Int64)_param);
                    case 'i':
                        //return dao.Insert((Estado)_param);
                    case 'd':
                        //return dao.Delete((Int64)_param);
                    case 'u':
                        //return dao.Update((Estado)_param);
                    case 'f':
                        //return dao.BuscarListaFiltrada((String)_param);
                        */
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
