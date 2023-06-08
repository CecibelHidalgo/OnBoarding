using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class DetalleAspectoBLL
    {
        public async Task<List<DetalleAspectosBE>> Listar()
        {
            try
            {
                List<DetalleAspectosBE> lista = null;
                DetalleAspectoDAL dal = new DetalleAspectoDAL();
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
