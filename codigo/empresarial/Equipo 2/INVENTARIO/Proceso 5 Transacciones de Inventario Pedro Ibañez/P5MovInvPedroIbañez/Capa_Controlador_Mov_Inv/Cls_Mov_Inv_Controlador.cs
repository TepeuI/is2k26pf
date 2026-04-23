using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Mov_Inv;

namespace Capa_Controlador_Mov_Inv
{
    public class Cls_Mov_Inv_Controlador
    {
        Cls_Dao_Mov_Inv Dao = new Cls_Dao_Mov_Inv();

        public DataTable fun_CargarIdsMovimiento()
        {
            DataTable dtIdMovInv = Dao.fun_ObtenerIDMOV();
            return dtIdMovInv;
        }


        public DataTable fun_CargarIdTypeMov()
        {
            DataTable dtIdTypeMov = Dao.fun_ObtenerTypeMov();
            return dtIdTypeMov;
        }

        public DataTable fun_CargarIdInventario()
        {
            DataTable dtIdInv = Dao.fun_ObtenerInventario();
            return dtIdInv;
        }

        public DataTable fun_CargarIdBodega()
        {
            DataTable dtIdbod = Dao.fun_ObtenerBodega();
            return dtIdbod;
        }

        public bool fun_GuardarMovimiento(int idBodega, int idTipoMovimiento, DateTime fechaMovimiento,
                                           string descripcion, List<Cls_Constructores> detalle)
        {
            try
            {
                bool resultado = Dao.fun_InsertarMovimientoCompleto(idTipoMovimiento, fechaMovimiento,
                                                                    descripcion, detalle);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador: " + ex.Message);
                return false;
            }
        }
    }
}
