using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class AspectoTecnicoBLL
    {
        public async Task<List<AspectoTecnicoBE>> Listar()
        {
            try
            {
                List<AspectoTecnicoBE> lista = null;
                AspectoTenicoDAL dal = new AspectoTenicoDAL();
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
