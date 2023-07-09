using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PruebaRendimientoForms {
	class Reportaje {
		private readonly Queue<string> actualizaciones;
		private readonly ListBox listBox;

		public Reportaje(ListBox listBox, ProgressBar barra, Opcion metodo) {
			this.BarraProgreso = new Progreso(barra, metodo);
			this.listBox = listBox;
			this.actualizaciones = new Queue<string>();

			this.TiempoTotal = new TimeSpan(0);
			this.PromedioPorTest = new TimeSpan(0);
			this.PromedioCada100Items = new TimeSpan(0);
		}

		public TimeSpan TiempoTotal { get; private set; }

		public TimeSpan PromedioPorTest { get; private set; }

		public TimeSpan PromedioCada100Items { get; private set; }

		public Progreso BarraProgreso { get; private set; }

		#region Acciones de Proceso de Reporte
		public void Preparar() {
			this.listBox.Items.Clear();
		}

		public void Actualizar() {
			this.BarraProgreso.Actualizar();

			string actualizacion;
			while(this.actualizaciones.Count > 0) {
				actualizacion = this.actualizaciones.Dequeue();
				if(actualizacion != null) {
					this.listBox.Items.Add(actualizacion);
					this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
				}
			}
		}

		public void CargarTotales(TimeSpan total, int cantidadTestsProcesados, int cantidadItemsProcesados) {
			this.TiempoTotal = total;
			this.PromedioPorTest = new TimeSpan(total.Ticks / cantidadTestsProcesados);
			this.PromedioCada100Items = new TimeSpan(total.Ticks / (cantidadItemsProcesados / 100));
		}
		#endregion

		#region ListBox
		public void Escribir(string item) {
			this.actualizaciones.Enqueue(item);
		}

		public void EscribirSincronico(string item) {
			this.listBox.Items.Add(item);
			this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
		}

		public string Leer() {
			return this.actualizaciones.Dequeue();
		}
		#endregion
	}
}
