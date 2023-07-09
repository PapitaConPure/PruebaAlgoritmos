using System;
using System.Windows.Forms;

namespace PruebaRendimientoForms {
	class Progreso {
		private readonly ProgressBar barra;
		private readonly int idMetodo;
		private long progreso;
		private long maximo;

		public bool EnEjecucion { get; private set; }

		public Progreso(ProgressBar barra, Opcion metodo) {
			this.barra = barra;
			this.barra.Value = 0;
			this.barra.Maximum = 100;
			this.progreso = 0;
			this.idMetodo = metodo.Id;
			this.EnEjecucion = false;
		}

		public void Preparar(int cntTipos, int cntMetodos, int cntItems) {
			this.barra.Value = 0;
			this.progreso = 0;
			this.maximo = cntTipos * cntItems;
		}

		public void Comenzar() {
			this.barra.Value = 0;
			this.progreso = 0;
			this.EnEjecucion = true;
		}

		public void Aumentar(int cntElementos) {
			this.progreso += cntElementos;

			if(this.progreso > this.maximo - 1)
				this.progreso = this.maximo - 1;
		}

		public void Actualizar() {
			if(!this.EnEjecucion)
				return;

			int progresoBarra = (int)(this.progreso * 100 / this.maximo);
			if(progresoBarra < this.barra.Maximum - 1) {
				if(this.barra.Value < progresoBarra)
					this.barra.Value = progresoBarra;
			} else
				this.EnEjecucion = false;
		}

		public void Detener() {
			this.progreso = 0;
			this.barra.Value = this.barra.Maximum;
			this.EnEjecucion = false;
		}
	}
}
