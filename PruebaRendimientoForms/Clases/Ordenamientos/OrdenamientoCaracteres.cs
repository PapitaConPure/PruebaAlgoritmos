using System;

//Me disculpo por todos los pecados cometidos en este código

namespace PruebaRendimientoForms.Ordenamientos {
	class OrdenamientoChar {
		public static void BubbleSort(char[] vec) {
			int l = vec.Length;
			int i, j;
			char aux;

			for(i = 0; i < l - 1; i++) {
				aux = vec[i];
				for(j = i + 1; j < l; j++)
					if(aux > vec[j]) {
						vec[i] = vec[j];
						vec[j] = aux;
						aux = vec[i];
					}
			}
		}

		public static void MergeSort(char[] vec) {
			int l = vec.Length;
			char[] origen = vec;
			char[] destino = new char[l];
			char[] aux;
			int i, j;

			for(i = 1; i < l; i *= 2) {
				for(j = 0; j < l; j += 2 * i)
					Merge(origen, destino, j, Math.Min(j + i, l), Math.Min(j + 2 * i, l));

				#region Intercambiar sub-vectores
				aux = origen;
				origen = destino;
				destino = aux;
				#endregion
			}

			if(origen != vec)
				Array.Copy(origen, vec, l);
		}

		public static void Merge(char[] origen, char[] destino, int izq, int med, int der) {
			int i = izq;
			int j = med;
			int k;
			for(k = izq; k < der; k++) {
				if(i < med && (j >= der || origen[i] <= origen[j]))
					destino[k] = origen[i++];
				else
					destino[k] = origen[j++];
			}
		}

		public static void SelectionSort(char[] vec) {
			int l = vec.Length;
			int i, j;
			int menorJ;

			for(i = 0; i < l - 1; i++) {
				menorJ = i;

				for(j = i + 1; j < l; j++)
					if(vec[j] < vec[menorJ])
						menorJ = j;

				if(menorJ != i)
					Intercambiar(vec, i, menorJ);
			}
		}

		public static void QuickSort(char[] vec) {
			int inicio = 0;
			int fin = vec.Length - 1;

			int[] stack = new int[vec.Length];
			int cnt = 0;

			#region Push
			stack[cnt++] = inicio;
			stack[cnt++] = fin;
			#endregion

			while(cnt > 0) {
				#region Pop
				fin = stack[--cnt];
				inicio = stack[--cnt];
				#endregion

				#region Partición
				char pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && vec[izq] <= pivote) izq++;
					while(inicio < der && pivote <= vec[der]) der--;

					if(izq < der)
						Intercambiar(vec, izq, der);
				}
				vec[inicio] = vec[der];
				vec[der] = pivote;
				#endregion

				if(inicio <= der - 1) {
					#region Push
					stack[cnt++] = inicio;
					stack[cnt++] = der - 1;
					#endregion
				}
				if(der + 1 <= fin) {
					#region Push
					stack[cnt++] = der + 1;
					stack[cnt++] = fin;
					#endregion
				}
			}
		}

		private static void Intercambiar(char[] vec, int a, int b) {
			char temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}

	class OrdenamientoString {
		public static void BubbleSort(string[] vec) {
			int l = vec.Length;
			int i, j;
			string aux;

			for(i = 0; i < l - 1; i++) {
				aux = vec[i];
				for(j = i + 1; j < l; j++)
					if(aux.CompareTo(vec[j]) > 0) {
						vec[i] = vec[j];
						vec[j] = aux;
						aux = vec[i];
					}
			}
		}

		public static void MergeSort(string[] vec) {
			int l = vec.Length;
			string[] origen = vec;
			string[] destino = new string[l];
			string[] aux;
			int i, j;

			for(i = 1; i < l; i *= 2) {
				for(j = 0; j < l; j += 2 * i)
					Merge(origen, destino, j, Math.Min(j + i, l), Math.Min(j + 2 * i, l));

				#region Intercambiar sub-vectores
				aux = origen;
				origen = destino;
				destino = aux;
				#endregion
			}

			if(origen != vec)
				Array.Copy(origen, vec, l);
		}

		public static void Merge(string[] origen, string[] destino, int izq, int med, int der) {
			int i = izq;
			int j = med;
			int k;
			for(k = izq; k < der; k++) {
				if(i < med && (j >= der || origen[i].CompareTo(origen[j]) <= 0))
					destino[k] = origen[i++];
				else
					destino[k] = origen[j++];
			}
		}

		public static void SelectionSort(string[] vec) {
			int l = vec.Length;
			int i, j;
			int menorJ;

			for(i = 0; i < l - 1; i++) {
				menorJ = i;

				for(j = i + 1; j < l; j++)
					if(vec[j].CompareTo(vec[menorJ]) < 0)
						menorJ = j;

				if(menorJ != i)
					Intercambiar(vec, i, menorJ);
			}
		}

		public static void QuickSort(string[] vec) {
			int inicio = 0;
			int fin = vec.Length - 1;

			int[] stack = new int[vec.Length];
			int cnt = 0;

			#region Push
			stack[cnt++] = inicio;
			stack[cnt++] = fin;
			#endregion

			while(cnt > 0) {
				#region Pop
				fin = stack[--cnt];
				inicio = stack[--cnt];
				#endregion

				#region Partición
				string pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && vec[izq].CompareTo(pivote) <= 0) izq++;
					while(inicio < der && pivote.CompareTo(vec[der]) <= 0) der--;

					if(izq < der)
						Intercambiar(vec, izq, der);
				}
				vec[inicio] = vec[der];
				vec[der] = pivote;
				#endregion

				if(inicio <= der - 1) {
					#region Push
					stack[cnt++] = inicio;
					stack[cnt++] = der - 1;
					#endregion
				}
				if(der + 1 <= fin) {
					#region Push
					stack[cnt++] = der + 1;
					stack[cnt++] = fin;
					#endregion
				}
			}
		}

		private static void Intercambiar(string[] vec, int a, int b) {
			string temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}
}
