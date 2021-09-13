using System;

namespace Entidades
{
    public class EntidadProducto
    {
        private int id;
        private string nombredelproducto;
        private string descripciondelproducto;
        private double preciodelproducto;
        private int cantidaddelproducto;
        private string cobro;

        public int Id { get => id; set => id = value; }
        public string Nombredelproducto { get => nombredelproducto; set => nombredelproducto = value; }
        public string Descripciondelproducto { get => descripciondelproducto; set => descripciondelproducto = value; }
        public double Preciodelproducto { get => preciodelproducto; set => preciodelproducto = value; }
        public int Cantidaddelproducto { get => cantidaddelproducto; set => cantidaddelproducto = value; }
        public string Cobro { get => cobro; set => cobro = value; }

        public EntidadProducto() { }

        public EntidadProducto(int id, string nombredelproducto, string descripciondelproducto, double preciodelproducto, int cantidaddelproducto)
        {
            this.id = id;
            this.nombredelproducto = nombredelproducto;
            this.descripciondelproducto = descripciondelproducto;
            this.preciodelproducto = preciodelproducto;
            this.cantidaddelproducto = cantidaddelproducto;
        }

        public EntidadProducto(string cobro)
        {
            this.cobro = cobro;

        }
    }
}
