using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_Citas;

namespace CapaControlador_Citas
{
    public class Cls_CitasControlador
    {
        private readonly Cls_CitasDAO prDAO = new Cls_CitasDAO();
        private readonly Cls_Conexion prConexion = new Cls_Conexion();
        public DataTable Fun_obtenerSedes()
        {
            return prDAO.fun_Obtener_sedes();
        }
            
        public void bInsertarCita(int fkIdSede, DateTime fechaHora)
        {
            if (fechaHora < DateTime.Now)
            {
                MessageBox.Show("No se puede ingresar una cita con fecha y hora anterior a la del sistema.",
                    "Fecha/Hora inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // (Opcional) Validación de sede
            if (fkIdSede <= 0)
            {
                MessageBox.Show("Debe seleccionar una sede válida.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cls_Citas nuevaCita = new Cls_Citas
            {
                iFk_Id_Sede = fkIdSede,
                dCmp_Fecha_Hora = fechaHora
               
            };

            bool ok = prDAO.bInsertar_Citas(nuevaCita);

            if (ok)
            {
                MessageBox.Show("Cita registrada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar la cita.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
