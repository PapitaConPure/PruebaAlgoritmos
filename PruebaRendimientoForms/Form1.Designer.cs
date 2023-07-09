
namespace PruebaRendimientoForms {
	partial class Form1 {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.btnProbar = new System.Windows.Forms.Button();
			this.btnResultados = new System.Windows.Forms.Button();
			this.gbComprobacion = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.cmbMetodo = new System.Windows.Forms.ComboBox();
			this.lblMetodo = new System.Windows.Forms.Label();
			this.lsbNumeros = new System.Windows.Forms.ListBox();
			this.gbRendimiento = new System.Windows.Forms.GroupBox();
			this.tlpResultados = new System.Windows.Forms.TableLayoutPanel();
			this.gbBubble = new System.Windows.Forms.GroupBox();
			this.lsbBubble = new System.Windows.Forms.ListBox();
			this.gbMerge = new System.Windows.Forms.GroupBox();
			this.lsbMerge = new System.Windows.Forms.ListBox();
			this.gbSelection = new System.Windows.Forms.GroupBox();
			this.lsbSelection = new System.Windows.Forms.ListBox();
			this.gbQuick = new System.Windows.Forms.GroupBox();
			this.lsbQuick = new System.Windows.Forms.ListBox();
			this.pgbBubble = new System.Windows.Forms.ProgressBar();
			this.pgbMerge = new System.Windows.Forms.ProgressBar();
			this.pgbSelection = new System.Windows.Forms.ProgressBar();
			this.pgbQuick = new System.Windows.Forms.ProgressBar();
			this.gbComprobacion.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.gbRendimiento.SuspendLayout();
			this.tlpResultados.SuspendLayout();
			this.gbBubble.SuspendLayout();
			this.gbMerge.SuspendLayout();
			this.gbSelection.SuspendLayout();
			this.gbQuick.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnProbar
			// 
			this.btnProbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.btnProbar.FlatAppearance.BorderSize = 0;
			this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProbar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProbar.ForeColor = System.Drawing.Color.White;
			this.btnProbar.Location = new System.Drawing.Point(6, 537);
			this.btnProbar.Name = "btnProbar";
			this.btnProbar.Size = new System.Drawing.Size(169, 46);
			this.btnProbar.TabIndex = 0;
			this.btnProbar.Text = "Comprobar";
			this.btnProbar.UseVisualStyleBackColor = false;
			this.btnProbar.Click += new System.EventHandler(this.BtnComprobar_Click);
			// 
			// btnResultados
			// 
			this.btnResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.btnResultados.FlatAppearance.BorderSize = 0;
			this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResultados.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResultados.ForeColor = System.Drawing.Color.White;
			this.btnResultados.Location = new System.Drawing.Point(6, 537);
			this.btnResultados.Name = "btnResultados";
			this.btnResultados.Size = new System.Drawing.Size(866, 46);
			this.btnResultados.TabIndex = 1;
			this.btnResultados.Text = "Probar Rendimiento";
			this.btnResultados.UseVisualStyleBackColor = false;
			this.btnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
			// 
			// gbComprobacion
			// 
			this.gbComprobacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbComprobacion.Controls.Add(this.tableLayoutPanel1);
			this.gbComprobacion.Controls.Add(this.btnProbar);
			this.gbComprobacion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbComprobacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.gbComprobacion.Location = new System.Drawing.Point(12, 12);
			this.gbComprobacion.Name = "gbComprobacion";
			this.gbComprobacion.Size = new System.Drawing.Size(181, 589);
			this.gbComprobacion.TabIndex = 2;
			this.gbComprobacion.TabStop = false;
			this.gbComprobacion.Text = "Comprobar Funcionamiento";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.gbControl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lsbNumeros, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 511);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.splitContainer1);
			this.gbControl.Controls.Add(this.cmbMetodo);
			this.gbControl.Controls.Add(this.lblMetodo);
			this.gbControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.gbControl.Location = new System.Drawing.Point(3, 396);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(163, 112);
			this.gbControl.TabIndex = 25;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "Control";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(6, 20);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.cmbTipo);
			this.splitContainer1.Panel1.Controls.Add(this.lblTipo);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lblCantidad);
			this.splitContainer1.Panel2.Controls.Add(this.nudCantidad);
			this.splitContainer1.Size = new System.Drawing.Size(151, 46);
			this.splitContainer1.SplitterDistance = 90;
			this.splitContainer1.TabIndex = 23;
			// 
			// cmbTipo
			// 
			this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(0, 18);
			this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(87, 21);
			this.cmbTipo.TabIndex = 24;
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTipo.Location = new System.Drawing.Point(0, 2);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(29, 13);
			this.lblTipo.TabIndex = 25;
			this.lblTipo.Text = "Tipo";
			// 
			// lblCantidad
			// 
			this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCantidad.Location = new System.Drawing.Point(3, 2);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(51, 13);
			this.lblCantidad.TabIndex = 20;
			this.lblCantidad.Text = "Cantidad";
			// 
			// nudCantidad
			// 
			this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudCantidad.Location = new System.Drawing.Point(3, 19);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudCantidad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(51, 20);
			this.nudCantidad.TabIndex = 19;
			this.nudCantidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// cmbMetodo
			// 
			this.cmbMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMetodo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbMetodo.FormattingEnabled = true;
			this.cmbMetodo.Location = new System.Drawing.Point(6, 85);
			this.cmbMetodo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
			this.cmbMetodo.Name = "cmbMetodo";
			this.cmbMetodo.Size = new System.Drawing.Size(151, 21);
			this.cmbMetodo.TabIndex = 17;
			// 
			// lblMetodo
			// 
			this.lblMetodo.AutoSize = true;
			this.lblMetodo.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.lblMetodo.Location = new System.Drawing.Point(6, 69);
			this.lblMetodo.Name = "lblMetodo";
			this.lblMetodo.Size = new System.Drawing.Size(45, 13);
			this.lblMetodo.TabIndex = 22;
			this.lblMetodo.Text = "Método";
			// 
			// lsbNumeros
			// 
			this.lsbNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsbNumeros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbNumeros.FormattingEnabled = true;
			this.lsbNumeros.IntegralHeight = false;
			this.lsbNumeros.ItemHeight = 14;
			this.lsbNumeros.Location = new System.Drawing.Point(3, 3);
			this.lsbNumeros.Name = "lsbNumeros";
			this.lsbNumeros.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lsbNumeros.Size = new System.Drawing.Size(163, 387);
			this.lsbNumeros.TabIndex = 10;
			// 
			// gbRendimiento
			// 
			this.gbRendimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbRendimiento.Controls.Add(this.tlpResultados);
			this.gbRendimiento.Controls.Add(this.btnResultados);
			this.gbRendimiento.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbRendimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.gbRendimiento.Location = new System.Drawing.Point(199, 12);
			this.gbRendimiento.Name = "gbRendimiento";
			this.gbRendimiento.Size = new System.Drawing.Size(878, 589);
			this.gbRendimiento.TabIndex = 3;
			this.gbRendimiento.TabStop = false;
			this.gbRendimiento.Text = "Pruebas de Rendimiento";
			// 
			// tlpResultados
			// 
			this.tlpResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpResultados.ColumnCount = 4;
			this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpResultados.Controls.Add(this.gbBubble, 0, 0);
			this.tlpResultados.Controls.Add(this.gbMerge, 1, 0);
			this.tlpResultados.Controls.Add(this.gbSelection, 2, 0);
			this.tlpResultados.Controls.Add(this.gbQuick, 3, 0);
			this.tlpResultados.Controls.Add(this.pgbBubble, 0, 1);
			this.tlpResultados.Controls.Add(this.pgbMerge, 1, 1);
			this.tlpResultados.Controls.Add(this.pgbSelection, 2, 1);
			this.tlpResultados.Controls.Add(this.pgbQuick, 3, 1);
			this.tlpResultados.Location = new System.Drawing.Point(6, 20);
			this.tlpResultados.Name = "tlpResultados";
			this.tlpResultados.RowCount = 2;
			this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlpResultados.Size = new System.Drawing.Size(866, 511);
			this.tlpResultados.TabIndex = 11;
			// 
			// gbBubble
			// 
			this.gbBubble.Controls.Add(this.lsbBubble);
			this.gbBubble.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbBubble.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbBubble.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbBubble.Location = new System.Drawing.Point(3, 3);
			this.gbBubble.Name = "gbBubble";
			this.gbBubble.Size = new System.Drawing.Size(210, 475);
			this.gbBubble.TabIndex = 10;
			this.gbBubble.TabStop = false;
			this.gbBubble.Text = "Bubble Sort";
			// 
			// lsbBubble
			// 
			this.lsbBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsbBubble.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbBubble.FormattingEnabled = true;
			this.lsbBubble.IntegralHeight = false;
			this.lsbBubble.ItemHeight = 14;
			this.lsbBubble.Location = new System.Drawing.Point(6, 20);
			this.lsbBubble.Name = "lsbBubble";
			this.lsbBubble.Size = new System.Drawing.Size(198, 449);
			this.lsbBubble.TabIndex = 1;
			// 
			// gbMerge
			// 
			this.gbMerge.Controls.Add(this.lsbMerge);
			this.gbMerge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbMerge.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbMerge.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbMerge.Location = new System.Drawing.Point(219, 3);
			this.gbMerge.Name = "gbMerge";
			this.gbMerge.Size = new System.Drawing.Size(210, 475);
			this.gbMerge.TabIndex = 10;
			this.gbMerge.TabStop = false;
			this.gbMerge.Text = "Merge Sort";
			// 
			// lsbMerge
			// 
			this.lsbMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsbMerge.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbMerge.FormattingEnabled = true;
			this.lsbMerge.IntegralHeight = false;
			this.lsbMerge.ItemHeight = 14;
			this.lsbMerge.Location = new System.Drawing.Point(6, 20);
			this.lsbMerge.Name = "lsbMerge";
			this.lsbMerge.Size = new System.Drawing.Size(198, 449);
			this.lsbMerge.TabIndex = 1;
			// 
			// gbSelection
			// 
			this.gbSelection.Controls.Add(this.lsbSelection);
			this.gbSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbSelection.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbSelection.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbSelection.Location = new System.Drawing.Point(435, 3);
			this.gbSelection.Name = "gbSelection";
			this.gbSelection.Size = new System.Drawing.Size(210, 475);
			this.gbSelection.TabIndex = 10;
			this.gbSelection.TabStop = false;
			this.gbSelection.Text = "Selection Sort";
			// 
			// lsbSelection
			// 
			this.lsbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsbSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbSelection.FormattingEnabled = true;
			this.lsbSelection.IntegralHeight = false;
			this.lsbSelection.ItemHeight = 14;
			this.lsbSelection.Location = new System.Drawing.Point(6, 20);
			this.lsbSelection.Name = "lsbSelection";
			this.lsbSelection.Size = new System.Drawing.Size(198, 449);
			this.lsbSelection.TabIndex = 1;
			// 
			// gbQuick
			// 
			this.gbQuick.Controls.Add(this.lsbQuick);
			this.gbQuick.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbQuick.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.gbQuick.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbQuick.Location = new System.Drawing.Point(651, 3);
			this.gbQuick.Name = "gbQuick";
			this.gbQuick.Size = new System.Drawing.Size(212, 475);
			this.gbQuick.TabIndex = 10;
			this.gbQuick.TabStop = false;
			this.gbQuick.Text = "Quick Sort";
			// 
			// lsbQuick
			// 
			this.lsbQuick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsbQuick.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbQuick.FormattingEnabled = true;
			this.lsbQuick.IntegralHeight = false;
			this.lsbQuick.ItemHeight = 14;
			this.lsbQuick.Location = new System.Drawing.Point(6, 20);
			this.lsbQuick.Name = "lsbQuick";
			this.lsbQuick.Size = new System.Drawing.Size(200, 449);
			this.lsbQuick.TabIndex = 1;
			// 
			// pgbBubble
			// 
			this.pgbBubble.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgbBubble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.pgbBubble.Location = new System.Drawing.Point(3, 484);
			this.pgbBubble.Name = "pgbBubble";
			this.pgbBubble.Size = new System.Drawing.Size(210, 24);
			this.pgbBubble.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pgbBubble.TabIndex = 11;
			// 
			// pgbMerge
			// 
			this.pgbMerge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgbMerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.pgbMerge.Location = new System.Drawing.Point(219, 484);
			this.pgbMerge.Name = "pgbMerge";
			this.pgbMerge.Size = new System.Drawing.Size(210, 24);
			this.pgbMerge.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pgbMerge.TabIndex = 11;
			// 
			// pgbSelection
			// 
			this.pgbSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgbSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.pgbSelection.Location = new System.Drawing.Point(435, 484);
			this.pgbSelection.Name = "pgbSelection";
			this.pgbSelection.Size = new System.Drawing.Size(210, 24);
			this.pgbSelection.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pgbSelection.TabIndex = 11;
			// 
			// pgbQuick
			// 
			this.pgbQuick.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgbQuick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(74)))));
			this.pgbQuick.Location = new System.Drawing.Point(651, 484);
			this.pgbQuick.Name = "pgbQuick";
			this.pgbQuick.Size = new System.Drawing.Size(212, 24);
			this.pgbQuick.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pgbQuick.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1089, 613);
			this.Controls.Add(this.gbRendimiento);
			this.Controls.Add(this.gbComprobacion);
			this.MinimumSize = new System.Drawing.Size(748, 304);
			this.Name = "Form1";
			this.Text = "Prueba de Rendimiento";
			this.gbComprobacion.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.gbRendimiento.ResumeLayout(false);
			this.tlpResultados.ResumeLayout(false);
			this.gbBubble.ResumeLayout(false);
			this.gbMerge.ResumeLayout(false);
			this.gbSelection.ResumeLayout(false);
			this.gbQuick.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnProbar;
		private System.Windows.Forms.Button btnResultados;
		private System.Windows.Forms.GroupBox gbComprobacion;
		private System.Windows.Forms.GroupBox gbRendimiento;
		private System.Windows.Forms.ListBox lsbBubble;
		private System.Windows.Forms.ListBox lsbMerge;
		private System.Windows.Forms.ListBox lsbQuick;
		private System.Windows.Forms.ListBox lsbSelection;
		private System.Windows.Forms.GroupBox gbQuick;
		private System.Windows.Forms.GroupBox gbSelection;
		private System.Windows.Forms.GroupBox gbMerge;
		private System.Windows.Forms.GroupBox gbBubble;
		private System.Windows.Forms.TableLayoutPanel tlpResultados;
		private System.Windows.Forms.ProgressBar pgbBubble;
		private System.Windows.Forms.ProgressBar pgbMerge;
		private System.Windows.Forms.ProgressBar pgbSelection;
		private System.Windows.Forms.ProgressBar pgbQuick;
		private System.Windows.Forms.Label lblMetodo;
		private System.Windows.Forms.ComboBox cmbMetodo;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.ListBox lsbNumeros;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox gbControl;
	}
}

