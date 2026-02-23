using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Citas;

namespace CapaVista_Citas
{
    public partial class Cls_Citas : Form
    {
        private readonly Cls_CitasControlador prcontrolador = new Cls_CitasControlador();
        public Cls_Citas()
        {
            InitializeComponent();
            
        }
        public void fun_Cargar_Combos()
        {
            try
            {
                var dt = prcontrolador.Fun_obtenerSedes(); // <-- con ()
                Cbo_Sedes.DataSource = dt;
                Cbo_Sedes.DisplayMember = "Cmp_Direccion";
                Cbo_Sedes.ValueMember = "Pk_Id_sede";
                Cbo_Sedes.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al cargar combos: " );
            }
        }

        private void Cbo_Sedes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AjustarHoraMinimaSiEsHoy()
        {
            if (Dtp_Fecha.Value.Date == DateTime.Today)
            {
                // Si la hora seleccionada es menor a la hora actual, la subimos a "ahora"
                if (Dtp_Hora.Value.TimeOfDay < DateTime.Now.TimeOfDay)
                {
                    // Recomendación: redondear al próximo minuto para evitar segundos
                    var now = DateTime.Now;
                    var redondeado = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

                    Dtp_Hora.Value = redondeado;
                }
            }
        }

        private void Btn_Constancia_Click(object sender, EventArgs e)
        {


            if (Cbo_Sedes.SelectedIndex == -1 || Cbo_Sedes.SelectedIndex == -1)
            {

                MessageBox.Show("Debe Seleccionar una sede", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int iIdSede = Convert.ToInt32(Cbo_Sedes.SelectedValue);
            DateTime fecha = Dtp_Fecha.Value.Date;         // solo fecha
            TimeSpan hora = Dtp_Hora.Value.TimeOfDay;      // solo hora
            DateTime fechayhora = fecha.Add(hora);         // combinado (fecha + hora)

            prcontrolador.bInsertarCita(iIdSede, fechayhora);
            fun_Cargar_Combos();





        }

        private void Cls_CItas_Load(object sender, EventArgs e)
        {
            fun_Cargar_Combos();
            // Fecha: con calendario
            Dtp_Fecha.Format = DateTimePickerFormat.Short; // 21/02/2026, etc.
            Dtp_Fecha.ShowUpDown = false;                  // permite desplegar calendario
            Dtp_Fecha.Value = DateTime.Today;

            // Hora: solo hora con spinner
            Dtp_Hora.Format = DateTimePickerFormat.Time;
            Dtp_Hora.ShowUpDown = true;                    // spinner para hora/min
            Dtp_Hora.Value = DateTime.Now;
        }

        private void Dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {
            AjustarHoraMinimaSiEsHoy();
        }

        private void Dtp_Hora_ValueChanged(object sender, EventArgs e)
        {
            AjustarHoraMinimaSiEsHoy();
        }
    }
    }


