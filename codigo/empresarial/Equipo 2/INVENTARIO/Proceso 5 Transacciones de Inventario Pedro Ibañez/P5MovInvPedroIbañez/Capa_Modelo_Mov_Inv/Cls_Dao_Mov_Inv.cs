using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Dao_Mov_Inv
    {

        Cls_Conexion_MYSQL conexion = new Cls_Conexion_MYSQL();
        // Obtener ID MOVIMIENTO
        public DataTable fun_ObtenerIDMOV()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_movimiento_id
                    FROM tbl_movimiento_inventario_encabezado; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los movimientos: " + ex.Message);
            }

            return dtResultado;
        }

        //================================================
        // Obtener Tipo Movimiento
        public DataTable fun_ObtenerTypeMov()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_tipo_movimiento_id,
                    CONCAT(pk_tipo_movimiento_id, ' - ',nombre_tipo_inv, ' - ',efecto) AS TipoMov
                    FROM tbl_tipo_movimiento_inventario; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Tipo Movimiento: " + ex.Message);
            }

            return dtResultado;
        }

        //================================================
        // Obtener Tipo Movimiento
        public DataTable fun_ObtenerInventario()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_inventario_id,
                    CONCAT(pk_inventario_id, ' - ', nombre_prod) AS INVENTARIO
                    FROM tbl_inventario; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Tipo Movimiento: " + ex.Message);
            }

            return dtResultado;
        }
        //================================================
        // Obtener Bodegas
        public DataTable fun_ObtenerBodega()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    Pk_Id_Bodega,
                    CONCAT(Pk_Id_Bodega, ' - ', Cmp_Nombre_Bodega) AS BODEGA
                    FROM tbl_bodega; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las bodegas: " + ex.Message);
            }

            return dtResultado;
        }


        public bool fun_InsertarMovimientoCompleto(int idTipoMov, DateTime fechaMov, string descripcion,
                                             List<Cls_Constructores> detalle)
        {
            bool resultado = false;

            string sQueryEncabezado = @"INSERT INTO tbl_movimiento_inventario_encabezado 
                                (fk_tipo_movimiento_id, fecha_transaccion, descripcion) 
                                VALUES (?, ?, ?)";

            string sQueryDetalle = @"INSERT INTO tbl_movimiento_inventario_detalle 
                            (fk_movimiento_id, fk_inventario_id, cantidad_transaccionada) 
                            VALUES (?, ?, ?)";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();

                    // Iniciar transacción
                    OdbcTransaction transaccion = oConn.BeginTransaction();

                    try
                    {
                        //  Insertar encabezado
                        int idMovimientoGenerado = 0;
                        using (OdbcCommand oCmdEnc = new OdbcCommand(sQueryEncabezado, oConn, transaccion))
                        {
                            oCmdEnc.Parameters.AddWithValue("?", idTipoMov);
                            oCmdEnc.Parameters.AddWithValue("?", fechaMov.ToString("yyyy-MM-dd HH:mm:ss"));
                            oCmdEnc.Parameters.AddWithValue("?", descripcion);
                            oCmdEnc.ExecuteNonQuery();
                        }

                        //  Obtener ID generado del encabezado
                        using (OdbcCommand oCmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", oConn, transaccion))
                        {
                            idMovimientoGenerado = Convert.ToInt32(oCmdId.ExecuteScalar());
                        }

                        //  Insertar cada fila del detalle
                        foreach (var item in detalle)
                        {
                            using (OdbcCommand oCmdDet = new OdbcCommand(sQueryDetalle, oConn, transaccion))
                            {
                                oCmdDet.Parameters.AddWithValue("?", idMovimientoGenerado);
                                oCmdDet.Parameters.AddWithValue("?", item.CodigoProducto);
                                oCmdDet.Parameters.AddWithValue("?", item.Cantidad);
                                oCmdDet.ExecuteNonQuery();
                            }
                        }

                        //  Si todo salió bien, confirmar transacción
                        transaccion.Commit();
                        resultado = true;
                        Console.WriteLine("Transacción completada. ID movimiento: " + idMovimientoGenerado);
                    }
                    catch (Exception ex)
                    {
                        //  Si algo falló, revertir TODO incluyendo el encabezado
                        transaccion.Rollback();
                        Console.WriteLine("Rollback ejecutado. Error: " + ex.Message);
                        resultado = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return resultado;
        }
    }
}
