using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class RecursoBLL
    {
        public async Task<List<RecursoBE>> Listar()
        {
            try
            {
                List<RecursoBE> lista = null;
                RecursoDAL dal = new RecursoDAL();
                lista = await dal.Listar();

                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
    
        }
    }
}
