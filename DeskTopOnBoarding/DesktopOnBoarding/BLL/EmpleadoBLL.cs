using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace BLL
{
    public class EmpleadoBLL
    {
        public async Task<List<EmpleadoBE>> Listar()
        {
            try
            {
                List<EmpleadoBE> lista = null;
                EmpleadoDAL dal = new EmpleadoDAL();
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
