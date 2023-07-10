using System;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace PruebaRendimientoForms {
	class Reportaje {
		private readonly ListBox listBox;
		private readonly ConcurrentQueue<string> filaReportes;

		public Reportaje(ListBox listBox, ProgressBar barra, Opcion metodo) {
			this.BarraProgreso = new Progreso(barra, metodo);
			this.listBox = listBox;
			this.filaReportes = new ConcurrentQueue<string>();

			this.TiempoTotal = new TimeSpan(0);
			this.PromedioPorTest = new TimeSpan(0);
			this.PromedioCada100Items = new TimeSpan(0);
		}

		#region Propiedades
		public TimeSpan TiempoTotal { get; private set; }

		public TimeSpan PromedioPorTest { get; private set; }

		public TimeSpan PromedioCada100Items { get; private set; }

		public Progreso BarraProgreso { get; private set; }

		public bool Actualizado {
			get {
				return this.filaReportes.IsEmpty;
			}
		}
		#endregion

		#region Acciones de Proceso de Reporte
		public static string FormatearIntervalo(TimeSpan t) {
			string formato = "";

			if(t.Days > 0)
				formato += $"{t.Days}D";
			if(t.Hours > 0)
				formato += $"{t.Hours}h";
			if(t.Minutes > 0)
				formato += $"{t.Minutes}m";
			if(t.Seconds > 0)
				formato += $"{t.Seconds}s";

			formato += $"{t.Milliseconds}ms";

			return formato;
		}

		public void Preparar() {
			this.listBox.Items.Clear();
		}

		public void Actualizar() {
			this.BarraProgreso.Actualizar();

			string actualizacion;
			while(this.filaReportes.Count > 0) {
				actualizacion = this.Leer();
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

		public void Escribir(string item) {
			this.filaReportes.Enqueue(item);
		}

		private string Leer() {
			if(this.filaReportes.IsEmpty)
				return null;

			string item;
			this.filaReportes.TryDequeue(out item);
			return item;
		}
		#endregion
	}
}
