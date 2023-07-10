using System;

//Me disculpo por todos los pecados cometidos en este código

namespace PruebaRendimientoForms.Ordenamientos {
	class OrdenamientoFloat {
		public static void BubbleSort(float[] vec) {
			int l = vec.Length;
			int i, j;
			float aux;

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

		public static void MergeSort(float[] vec) {
			int l = vec.Length;
			float[] origen = vec;
			float[] destino = new float[l];
			float[] aux;
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

		public static void Merge(float[] origen, float[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(float[] vec) {
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

		public static void QuickSort(float[] vec) {
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
				float pivote = vec[inicio];
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

		private static void Intercambiar(float[] vec, int a, int b) {
			float temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}

	class OrdenamientoDouble {
		public static void BubbleSort(double[] vec) {
			int l = vec.Length;
			int i, j;
			double aux;

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

		public static void MergeSort(double[] vec) {
			int l = vec.Length;
			double[] origen = vec;
			double[] destino = new double[l];
			double[] aux;
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

		public static void Merge(double[] origen, double[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(double[] vec) {
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

		public static void QuickSort(double[] vec) {
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
				double pivote = vec[inicio];
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

		private static void Intercambiar(double[] vec, int a, int b) {
			double temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}

	class OrdenamientoDecimal {
		public static void BubbleSort(decimal[] vec) {
			int l = vec.Length;
			int i, j;
			decimal aux;

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

		public static void MergeSort(decimal[] vec) {
			int l = vec.Length;
			decimal[] origen = vec;
			decimal[] destino = new decimal[l];
			decimal[] aux;
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

		public static void Merge(decimal[] origen, decimal[] destino, int izq, int med, int der) {
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

		public static void SelectionSort(decimal[] vec) {
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

		public static void QuickSort(decimal[] vec) {
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
				decimal pivote = vec[inicio];
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

		private static void Intercambiar(decimal[] vec, int a, int b) {
			decimal temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}
}
