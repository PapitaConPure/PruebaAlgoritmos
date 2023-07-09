using System;

//Me disculpo por todos los pecados cometidos en este código

namespace PruebaRendimientoForms.Ordenamientos {
	class OrdenamientoInt16 {
		public static void BubbleSort(short[] vec) {
			int l = vec.Length;
			int i, j;
			short aux;

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

		public static void MergeSort(short[] vec) {
			int l = vec.Length;
			short[] origen = vec;
			short[] destino = new short[l];
			short[] aux;
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

		public static void Merge(short[] origen, short[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(short[] vec) {
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

		public static void QuickSort(short[] vec) {
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
				short pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && vec[izq] <= pivote) izq++;
					while(inicio < der && pivote < vec[der]) der--;

					if(izq < der)
						Intercambiar(vec, izq, der);
				}
				vec[inicio] = vec[der];
				vec[der] = pivote;
				#endregion

				if(inicio < der - 1) {
					#region Push
					stack[cnt++] = inicio;
					stack[cnt++] = der - 1;
					#endregion
				}

				if(der + 1 < fin) {
					#region Push
					stack[cnt++] = der + 1;
					stack[cnt++] = fin;
					#endregion
				}
			}
		}

		private static void Intercambiar(short[] vec, int a, int b) {
			short temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}

	class OrdenamientoInt32 {
		public static void BubbleSort(int[] vec) {
			int l = vec.Length;
			int i, j;
			int aux;

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

		public static void MergeSort(int[] vec) {
			int l = vec.Length;
			int[] origen = vec;
			int[] destino = new int[l];
			int[] aux;
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

		public static void Merge(int[] origen, int[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(int[] vec) {
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

		public static void QuickSort(int[] vec) {
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
				int pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && vec[izq] <= pivote) izq++;
					while(inicio < der && pivote < vec[der]) der--;

					if(izq < der)
						Intercambiar(vec, izq, der);
				}
				vec[inicio] = vec[der];
				vec[der] = pivote;
				#endregion

				if(inicio < der - 1) {
					#region Push
					stack[cnt++] = inicio;
					stack[cnt++] = der - 1;
					#endregion
				}

				if(der + 1 < fin) {
					#region Push
					stack[cnt++] = der + 1;
					stack[cnt++] = fin;
					#endregion
				}
			}
		}

		private static void Intercambiar(int[] vec, int a, int b) {
			int temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}

	class OrdenamientoInt64 {
		public static void BubbleSort(long[] vec) {
			int l = vec.Length;
			int i, j;
			long aux;

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

		public static void MergeSort(long[] vec) {
			int l = vec.Length;
			long[] origen = vec;
			long[] destino = new long[l];
			long[] aux;
			int ancho, i;

			for(ancho = 1; ancho < l; ancho *= 2) {
				for(i = 0; i < l; i += 2 * ancho)
					Merge(origen, destino, i, Math.Min(i + ancho, l), Math.Min(i + 2 * ancho, l));

				#region Intercambiar sub-vectores
				aux = origen;
				origen = destino;
				destino = aux;
				#endregion
			}

			if(origen != vec)
				Array.Copy(origen, vec, l);
		}

		public static void Merge(long[] origen, long[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(long[] vec) {
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

		public static void QuickSort(long[] vec) {
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
				long pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && vec[izq] <= pivote) izq++;
					while(inicio < der && pivote < vec[der]) der--;

					if(izq < der)
						Intercambiar(vec, izq, der);
				}
				vec[inicio] = vec[der];
				vec[der] = pivote;
				#endregion

				if(inicio < der - 1) {
					#region Push
					stack[cnt++] = inicio;
					stack[cnt++] = der - 1;
					#endregion
				}

				if(der + 1 < fin) {
					#region Push
					stack[cnt++] = der + 1;
					stack[cnt++] = fin;
					#endregion
				}
			}
		}

		private static void Intercambiar(long[] vec, int a, int b) {
			long temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}
}
