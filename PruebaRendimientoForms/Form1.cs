using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PruebaRendimientoForms {
	public partial class Form1: Form {
		#region Parámetros de Prueba
		private static readonly Opcion[] tipos = new Opcion[] {
			CtrlOrd.TIPO_INT16,
			CtrlOrd.TIPO_INT32,
			CtrlOrd.TIPO_INT64,
			CtrlOrd.TIPO_FLOAT32,
			CtrlOrd.TIPO_FLOAT64,
			CtrlOrd.TIPO_DECIMAL128,
			CtrlOrd.TIPO_CHAR,
			CtrlOrd.TIPO_STRING8,
			CtrlOrd.TIPO_STRING32,
		};

		private static readonly bool usarBubble    = true;
		private static readonly bool usarMerge     = true;
		private static readonly bool usarSelection = true;
		private static readonly bool usarQuick     = true;

		private static readonly int[] cantidadesElementos = new int[] {
			100_000,
			500_000,
			1_000_000,
			5_000_000,
		};

		private static readonly Omision[] omisiones = new Omision[] {
			new Omision()
				.DeMetodo(CtrlOrd.METODO_BUBBLE_SORT.Id)
				.DeTipo(CtrlOrd.TIPO_STRING32.Id),
			new Omision()
				.DeMetodo(CtrlOrd.METODO_BUBBLE_SORT.Id)
				.DeTipo(CtrlOrd.TIPO_STRING8.Id)
				.DesdeCantidad(100_000),
			new Omision()
				.DeMetodo(CtrlOrd.METODO_BUBBLE_SORT.Id)
				.DesdeCantidad(500_000),
			new Omision()
				.DeMetodo(CtrlOrd.METODO_SELECTION_SORT.Id)
				.DeTipo(CtrlOrd.TIPO_CHAR.Id,
					    CtrlOrd.TIPO_STRING8.Id,
						CtrlOrd.TIPO_STRING32.Id)
				.DesdeCantidad(500_000),
		};
		#endregion

		private readonly Reportaje[] reportajes;

		public Form1() {
			this.InitializeComponent();

			CheckForIllegalCrossThreadCalls = false;

			this.cmbMetodo.Items.Add(CtrlOrd.METODO_BUBBLE_SORT.Muestra);
			this.cmbMetodo.Items.Add(CtrlOrd.METODO_MERGE_SORT.Muestra);
			this.cmbMetodo.Items.Add(CtrlOrd.METODO_SELECTION_SORT.Muestra);
			this.cmbMetodo.Items.Add(CtrlOrd.METODO_QUICK_SORT.Muestra);
			this.cmbMetodo.SelectedIndex = 0;

			this.cmbTipo.Items.Add(CtrlOrd.TIPO_INT16.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_INT32.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_INT64.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_FLOAT32.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_FLOAT64.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_DECIMAL128.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_CHAR.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_STRING8.Muestra);
			this.cmbTipo.Items.Add(CtrlOrd.TIPO_STRING32.Muestra);
			this.cmbTipo.SelectedIndex = 0;

			this.reportajes = new Reportaje[] {
				new Reportaje(this.lsbBubble,    this.pgbBubble,    CtrlOrd.METODO_BUBBLE_SORT),
				new Reportaje(this.lsbMerge,     this.pgbMerge,     CtrlOrd.METODO_MERGE_SORT),
				new Reportaje(this.lsbSelection, this.pgbSelection, CtrlOrd.METODO_SELECTION_SORT),
				new Reportaje(this.lsbQuick,     this.pgbQuick,     CtrlOrd.METODO_QUICK_SORT)
			};

			//Calcular máximo de elementos sin omisiones consideradas
			int cntItems = 0;
			foreach(int cantidad in cantidadesElementos)
				cntItems += cantidad;

			foreach(Reportaje reportaje in this.reportajes)
				reportaje.BarraProgreso.Preparar(tipos.Length, this.reportajes.Length, cntItems);
		}

		private void BtnComprobar_Click(object sender, EventArgs e) {
			int n = (int)this.nudCantidad.Value;
			int idMetodo = this.cmbMetodo.SelectedIndex;
			int idTipo = this.cmbTipo.SelectedIndex;

			this.MostrarVectorComprobacion(CtrlOrd.Ordenar(n, idMetodo, idTipo));
		}

		private void BtnResultados_Click(object sender, EventArgs e) {
			this.btnResultados.Text = "Ordenando...";
			this.btnResultados.Enabled = false;

			Task.Run(this.ActualizarInterfaz);
			Task.WhenAll(
				Task.Run(this.BgwBubble_DoWork),
				Task.Run(this.BgwMerge_DoWork),
				Task.Run(this.BgwSelection_DoWork),
				Task.Run(this.BgwQuick_DoWork)
			).ContinueWith(delegate {
				this.ConcluirOrdenamientos();
			});
		}

		private void ConcluirOrdenamientos() {
			foreach(Reportaje reportaje in this.reportajes) {
				reportaje.EscribirSincronico("✔ Finalizado. Tiempos:");
				reportaje.EscribirSincronico("  • Promedio:");
				reportaje.EscribirSincronico($"    . Por Test: {FormatearIntervalo(reportaje.PromedioPorTest)}");
				reportaje.EscribirSincronico($"    . c/100 Items: {FormatearIntervalo(reportaje.PromedioCada100Items)}");
				reportaje.EscribirSincronico($"  • Total: {FormatearIntervalo(reportaje.TiempoTotal)}");

				reportaje.BarraProgreso.Detener();
			}

			this.btnResultados.Text = "Probar Rendimiento";
			this.btnResultados.Enabled = true;
		}

		private void BgwBubble_DoWork() {
			if(usarBubble)
				this.ProbarMetodo(CtrlOrd.METODO_BUBBLE_SORT);
		}

		private void BgwMerge_DoWork() {
			if(usarMerge)
				this.ProbarMetodo(CtrlOrd.METODO_MERGE_SORT);
		}

		private void BgwSelection_DoWork() {
			if(usarSelection)
				this.ProbarMetodo(CtrlOrd.METODO_SELECTION_SORT);
		}

		private void BgwQuick_DoWork() {
			if(usarQuick)
				this.ProbarMetodo(CtrlOrd.METODO_QUICK_SORT);
		}

		private void ProbarMetodo(Opcion metodo) {
			Reportaje reportaje = this.reportajes[metodo.Id];
			TimeSpan total = new TimeSpan();
			TimeSpan diff;
			DateTime fi, ff;
			int cantidadTestsProcesados = 0, cantidadItemsProcesados = 0;
			int ol = omisiones.Length;
			int i;

			reportaje.BarraProgreso.Comenzar();

			reportaje.Escribir(null);
			foreach(Opcion tipo in tipos) {
				reportaje.Escribir($"♦ Tiempos de {tipo.Muestra}");

				foreach(int cantidadElementos in cantidadesElementos) {
					bool procesar = true;
					i = 0;
					do {
						if(omisiones[i].EsOmitido(tipo.Id, metodo.Id, cantidadElementos))
							procesar = false;
						i++;
					} while(procesar && i < ol);

					if(!procesar)
						continue;

					fi = DateTime.Now;
					CtrlOrd.OrdenarSinCopiar(cantidadElementos, metodo.Id, tipo.Id);
					ff = DateTime.Now;

					diff = ff - fi;
					total += diff;
					cantidadTestsProcesados++;
					cantidadItemsProcesados += cantidadElementos;
					reportaje.BarraProgreso.Aumentar(cantidadElementos);
					reportaje.Escribir($"  • {cantidadElementos:###,###,###,###}: {FormatearIntervalo(diff)}");
				}

				this.reportajes[metodo.Id].Escribir("");
			}

			reportaje.CargarTotales(total, cantidadTestsProcesados, cantidadItemsProcesados);
		}

		private void ActualizarInterfaz() {
			foreach(Reportaje reportaje in this.reportajes)
				reportaje.Preparar();

			while(!this.btnResultados.Enabled) {
				foreach(Reportaje reportaje in this.reportajes)
					reportaje.Actualizar();
			}
		}

		private static string FormatearIntervalo(TimeSpan t) {
			string formato = "";

			if(t.Hours > 0)
				formato += $"{t.Hours}h ";
			if(t.Minutes > 0)
				formato += $"{t.Minutes}m ";

			formato += $"{t.Seconds}s {t.Milliseconds}ms";

			return formato;
		}

		private void MostrarVectorComprobacion(object[] vec) {
			this.lsbNumeros.Items.Clear();
			for(int i = 0; i < vec.Length; i++)
				this.lsbNumeros.Items.Add(vec[i]);
		}
	}
}
