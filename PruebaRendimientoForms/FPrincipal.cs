using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using PruebaRendimientoForms.Ordenamientos;
using System.Drawing;

namespace PruebaRendimientoForms {
	public partial class FPrincipal: Form {
		#region Parámetros de Prueba
		private static readonly bool usarBubble = true;
		private static readonly bool usarMerge = true;
		private static readonly bool usarSelection = true;
		private static readonly bool usarQuick = true;

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

		private static readonly int[] cantidadesElementos = new int[] {
			10_000,
			100_000,
			500_000,
			1_000_000,
			5_000_000,
		};

		//Para omitir ordenamientos que pueden llegar tardar demasiado tiempo con ciertos tipos o cantidad de elementos
		//Poné "permitirOmisiones" en false si querés evitar este efecto
		private static readonly bool permitirOmisiones = true;
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
			new Omision()
				.DeMetodo(CtrlOrd.METODO_QUICK_SORT.Id)
				.DeTipo(CtrlOrd.TIPO_DECIMAL128.Id,
						CtrlOrd.TIPO_STRING32.Id)
				.DesdeCantidad(5_000_000),
		};
		#endregion

		private readonly Reportaje[] reportajes;
		public static bool cancelado;
		private static bool corriendo;

		public FPrincipal() {
			this.InitializeComponent();

			CheckForIllegalCrossThreadCalls = false;

			#region Preparar Controles
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
			#endregion

			#region Preparar Reportajes
			this.reportajes = new Reportaje[] {
				new Reportaje(this.lsbBubble,    this.pgbBubble,    this.tbBubble,    CtrlOrd.METODO_BUBBLE_SORT),
				new Reportaje(this.lsbMerge,     this.pgbMerge,     this.tbMerge,     CtrlOrd.METODO_MERGE_SORT),
				new Reportaje(this.lsbSelection, this.pgbSelection, this.tbSelection, CtrlOrd.METODO_SELECTION_SORT),
				new Reportaje(this.lsbQuick,     this.pgbQuick,     this.tbQuick,     CtrlOrd.METODO_QUICK_SORT)
			};

			int cntItems = 0;
			foreach(int cantidad in cantidadesElementos)
				cntItems += cantidad;

			foreach(Reportaje reportaje in this.reportajes)
				reportaje.BarraProgreso.Preparar(tipos.Length, cntItems);
			#endregion
		}

		#region Interacciones con el Formulario
		private void BtnComprobar_Click(object sender, EventArgs e) {
			int n = (int)this.nudCantidad.Value;
			int idMetodo = this.cmbMetodo.SelectedIndex;
			int idTipo = this.cmbTipo.SelectedIndex;
			Ordenamiento.activo = true;

			this.MostrarVectorComprobacion(CtrlOrd.Ordenar(n, idMetodo, idTipo));
		}

		private void BtnResultados_Click(object sender, EventArgs e) {
			if(corriendo) {
				this.btnResultados.Text = "Probar Rendimiento";
				Ordenamiento.activo = false;
				return;
			}

			long totalElementos = 0;

			foreach(int cantidadElementos in cantidadesElementos)
				totalElementos += cantidadElementos;

			totalElementos *= tipos.Length;
			totalElementos *= 4;

			DialogResult confirmacion = MessageBox.Show(
				"¿Estás seguro de que deseas comenzar las pruebas?\n\n" +
				$"Se van a ordenar un total de {totalElementos:###,###,###,###} elementos, sin ignorar las pruebas omitidas.\n\n" +
				"Los ordenamientos se ejecutarán en paralelo por método hasta concluirse o hasta que se cierre el programa. Se recomienda un CPU de al menos 4 núcleos.\n\n" +
				"Esto puede demorar días. Esta acción no puede cancelarse.",

				"Comenzar Prueba de Rendimiento",

				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning
			);

			if(confirmacion != DialogResult.OK)
				return;

			this.btnResultados.Text = "Cancelar";
			corriendo = true;
			Ordenamiento.activo = true;

			Task.Run(this.ReportajeInterfaz_DoWork);
			Task.WhenAll(
				Task.Run(this.BubbleSort_DoWork),
				Task.Run(this.MergeSort_DoWork),
				Task.Run(this.SelectionSort_DoWork),
				Task.Run(this.QuickSort_DoWork)
			).ContinueWith(delegate {
				this.Finalizacion_DoWork();
			});
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			char tecla = char.ToUpper(e.KeyChar);

			if(tecla == 'C')
				this.btnComprobar.PerformClick();

			if(tecla == 'R')
				this.btnResultados.PerformClick();

			if(nudCantidad.Focused) {
				if(tecla == (char)Keys.Escape)
					this.cmbMetodo.Focus();

				return;
			}

			switch(tecla) {
			case '1':
				AlternarComboBox(this.cmbTipo);
				break;
			case '2':
				this.nudCantidad.Focus();
				break;
			case '3':
				AlternarComboBox(this.cmbMetodo);
				break;
			}
		}

		private void NudCantidad_Focused(object sender, EventArgs e) {
			this.nudCantidad.Select(0, 5);
		}
		#endregion

		#region Hilos
		private void BubbleSort_DoWork() {
			if(usarBubble)
				this.ProbarMetodo(CtrlOrd.METODO_BUBBLE_SORT);
		}

		private void MergeSort_DoWork() {
			if(usarMerge)
				this.ProbarMetodo(CtrlOrd.METODO_MERGE_SORT);
		}

		private void SelectionSort_DoWork() {
			if(usarSelection)
				this.ProbarMetodo(CtrlOrd.METODO_SELECTION_SORT);
		}

		private void QuickSort_DoWork() {
			if(usarQuick)
				this.ProbarMetodo(CtrlOrd.METODO_QUICK_SORT);
		}

		private void ReportajeInterfaz_DoWork() {
			foreach(Reportaje reportaje in this.reportajes)
				reportaje.Comenzar();

			while(corriendo)
				foreach(Reportaje reportaje in this.reportajes)
					reportaje.Actualizar();
		}

		private void Finalizacion_DoWork() {
			#region Asegurarse de vaciar reportajes primero
			bool proceder;
			do {
				proceder = true;
				foreach(Reportaje reportaje in this.reportajes)
					if(!reportaje.Actualizado)
						proceder = false;
			} while(!proceder);
			#endregion

			this.btnResultados.Text = "Probar Rendimiento";
			this.btnResultados.Enabled = true;
			corriendo = false;
		}
		#endregion

		#region Funcionalidad
		private void ProbarMetodo(Opcion metodo) {
			Reportaje reportaje = this.reportajes[metodo.Id];
			TimeSpan total = new TimeSpan();
			TimeSpan diff;
			DateTime fi, ff;
			int cantidadTestsProcesados = 0, cantidadItemsProcesados = 0;

			foreach(Opcion tipo in tipos) {
				reportaje.Escribir($"♦ Tiempos de {tipo.Muestra}");

				foreach(int cantidadElementos in cantidadesElementos) {
					if(!TestSeProcesa(tipo, metodo, cantidadElementos))
						continue;

					fi = DateTime.Now;
					CtrlOrd.OrdenarSinCopiar(cantidadElementos, metodo.Id, tipo.Id);
					ff = DateTime.Now;

					diff = ff - fi;
					total += diff;
					cantidadTestsProcesados++;
					cantidadItemsProcesados += cantidadElementos;
					reportaje.BarraProgreso.Aumentar(cantidadElementos);
					reportaje.Escribir($"  • {cantidadElementos:###,###,###,###}: {Reportaje.FormatearIntervalo(diff)}");

					if(!Ordenamiento.activo)
						break;
				}

				reportaje.Escribir("");

				if(!Ordenamiento.activo)
					break;
			}

			reportaje.CargarTotales(total, cantidadTestsProcesados, cantidadItemsProcesados);
			reportaje.Finalizar();
		}
		
		private void MostrarVectorComprobacion(object[] vec) {
			this.lsbNumeros.Items.Clear();
			for(int i = 0; i < vec.Length; i++)
				this.lsbNumeros.Items.Add(vec[i]);
		}

		private static bool TestSeProcesa(Opcion tipo, Opcion metodo, int cantidadElementos) {
			if(!permitirOmisiones)
				return true;

			bool procesar = true;

			int i = 0;
			do {
				if(omisiones[i].EsOmitido(tipo.Id, metodo.Id, cantidadElementos))
					procesar = false;
				i++;
			} while(procesar && i < omisiones.Length);

			return procesar;
		}

		private static void AlternarComboBox(ComboBox comboBox) {
			comboBox.Focus();
			if(comboBox.SelectedIndex == comboBox.Items.Count - 1)
				comboBox.SelectedIndex = 0;
			else
				comboBox.SelectedIndex++;
		}
		#endregion
	}
}
