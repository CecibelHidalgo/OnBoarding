using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class AspectoConductualBLL
    {
        public async Task<List<AspectosConductualesBE>> Listar()
        {
            try
            {
                List<AspectosConductualesBE> lista = null;
                AspectoConductualDAL dal = new AspectoConductualDAL();
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
