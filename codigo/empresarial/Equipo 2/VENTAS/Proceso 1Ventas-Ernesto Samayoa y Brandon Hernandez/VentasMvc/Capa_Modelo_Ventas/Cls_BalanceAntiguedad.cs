using System;

namespace Capa_Modelo_Ventas
{
    public class Cls_BalanceAntiguedad
    {
        public int      Pk_Id_Cliente      { get; set; }
        public string   NombreCliente      { get; set; }
        public string   NIT                { get; set; }
        public int      IdCxC              { get; set; }
        public int      NoVenta            { get; set; }
        public DateTime FechaDeuda         { get; set; }
        public DateTime FechaVencimiento   { get; set; }
        public decimal  MontoTotal         { get; set; }
        public decimal  TotalPagado        { get; set; }
        public decimal  SaldoPendiente     { get; set; }
        public int      DiasVencidos       { get; set; }
        public string   RangoAntiguedad    { get; set; }
        public decimal  MontoCorriente     { get; set; }
        public decimal  Monto1a30          { get; set; }
        public decimal  Monto31a60         { get; set; }
        public decimal  Monto61a90         { get; set; }
        public decimal  MontoMas90         { get; set; }
    }
}
