using System.Collections.Generic;
using System.Linq;

namespace PruebaRendimientoForms {
	class Omision {
		private List<int> tipo;
		private int metodo;
		private int cantidad;

		public Omision() {
			this.tipo = new List<int>();
			this.metodo = -1;
			this.cantidad = -1;
		}

		public Omision DeTipo(params int[] tipos) {
			foreach(int tipo in tipos)
				this.tipo.Add(tipo);

			return this;
		}

		public Omision DeMetodo(int metodo) {
			this.metodo = metodo;
			return this;
		}

		public Omision DesdeCantidad(int cantidad) {
			this.cantidad = cantidad;
			return this;
		}

		public bool EsOmitido(int tipo, int metodo, int cantidad) {
			if(this.tipo.All(t => t != tipo))
				return false;
			if(this.metodo != -1 && this.metodo != metodo)
				return false;
			if(this.cantidad >= cantidad)
				return false;
			return true;
		}
	}
}
