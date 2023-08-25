using System;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace PruebaRendimientoForms {
	class Reportaje {
		private readonly ListBox listBox;
		private readonly TextBox textBox;
		private readonly ConcurrentQueue<string> filaReportes;
		private DateTime inicio;
		private TimeSpan diff;
		private bool finalizado;

		public Reportaje(ListBox listBox, ProgressBar barra, TextBox textBox, Opcion metodo) {
			this.BarraProgreso = new Progreso(barra, metodo);
			this.listBox = listBox;
			this.textBox = textBox;
			this.filaReportes = new ConcurrentQueue<string>();
			this.inicio = DateTime.Now;
			this.finalizado = false;

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
			if(t.TotalMilliseconds < 1)
				return $"{t.Ticks}T";

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

		public void Comenzar() {
			this.inicio = DateTime.Now;
			this.finalizado = false;
			this.textBox.Text = FormatearIntervalo(new TimeSpan());
			this.BarraProgreso.Comenzar();
			this.listBox.Items.Clear();
		}

		public void Actualizar() {
			if(!this.finalizado) {
				this.diff = DateTime.Now - this.inicio;
				this.BarraProgreso.Actualizar();
				this.textBox.Text = FormatearIntervalo(diff);
			}

			string actualizacion;
			while(this.filaReportes.Count > 0) {
				actualizacion = this.Leer();
				if(actualizacion != null) {
					this.listBox.Items.Add(actualizacion);
					this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
				}
			}
		}

		public void Finalizar() {
			this.finalizado = true;
			this.BarraProgreso.Detener();
			this.textBox.Text = FormatearIntervalo(this.diff);

			this.Escribir("♦ Tiempos Totales:");
			this.Escribir("  • Promedio:");
			this.Escribir($"    . Por Test: {FormatearIntervalo(this.PromedioPorTest)}");
			this.Escribir($"    . c/100 Items: {FormatearIntervalo(this.PromedioCada100Items)}");
			this.Escribir($"  • Acumulado: {FormatearIntervalo(this.TiempoTotal)}");
			this.Escribir("");
			this.Escribir("✔ Finalizado");
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
