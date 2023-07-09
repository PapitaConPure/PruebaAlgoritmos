namespace PruebaRendimientoForms {
	class Opcion {
		public Opcion(int id, string muestra) {
			this.Id = id;
			this.Muestra = muestra;
		}

		public int Id { get; private set; }

		public string Muestra { get; private set; }
	}
}
