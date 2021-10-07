using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreArtemis
{
    public partial class Form1 : Form
    {
		// Atributos estaticos
		private static List<Prenda> prendas;
		private static int CantidadDePrendas { get; set; }

		// Constructores

		// Constructor estatico
		static Form1()
		{
			prendas = new List<Prenda>();
			CantidadDePrendas = 0;
		}

        public Form1()
        {
            InitializeComponent();
        }
    }
}
