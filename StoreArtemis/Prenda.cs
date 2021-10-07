namespace StoreArtemis
{
    public class Prenda
    {
		// Atributos

		// No se declaran privados ya que serian inutiles.
		// Podemos ver el uso de private en Form1
		public string TipoPrenda { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public int Talla { get; set; }
        public double Precio { get; set; }

		// Constructores
		public Prenda()
		{

		}

		public Prenda(string tipoPrenda, string color, string marca, int talla, double precio)
        {
            this.TipoPrenda = tipoPrenda;
			this.Color = color;
			this.Marca = marca;
			this.Talla = talla;
			this.Precio = precio;
        }
    }
}