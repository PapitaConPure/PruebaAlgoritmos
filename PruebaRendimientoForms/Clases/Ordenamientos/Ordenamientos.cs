using System;
using System.Collections.Generic;

namespace PruebaRendimientoForms.Ordenamientos {
	static class Ordenamiento {
		public static bool activo = false;

		public static void BubbleSort<T>(T[] vec) {
			int l = vec.Length;
			int i, j;
			T aux;

			for(i = 0; i < l - 1 && activo; i++) {
				aux = vec[i];
				for(j = i + 1; j < l; j++)
					if(Comparar(aux, vec[j]) > 0) {
						vec[i] = vec[j];
						vec[j] = aux;
						aux = vec[i];
					}
			}
		}

		public static void MergeSort<T>(T[] vec) {
			int l = vec.Length;
			T[] origen = vec;
			T[] destino = new T[l];
			T[] aux;
			int i, j;

			for(i = 1; i < l && activo; i *= 2) {
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

		public static void Merge<T>(T[] origen, T[] destino, int izq, int med, int der) {
			int i = izq;
			int j = med;
			int k;
			for(k = izq; k < der; k++) {
				if(i < med && (j >= der || Comparar(origen[i], origen[j]) <= 0))
					destino[k] = origen[i++];
				else
					destino[k] = origen[j++];
			}
		}

		public static void SelectionSort<T>(T[] vec) {
			int l = vec.Length;
			int i, j;
			int menorJ;

			for(i = 0; i < l - 1 && activo; i++) {
				menorJ = i;

				for(j = i + 1; j < l; j++)
					if(Comparar(vec[j], vec[menorJ]) < 0)
						menorJ = j;

				if(menorJ != i)
					Intercambiar(vec, i, menorJ);
			}
		}

		public static void QuickSort<T>(T[] vec) {
			int inicio = 0;
			int fin = vec.Length - 1;

			int[] stack = new int[vec.Length];
			int cnt = 0;

			#region Push
			stack[cnt++] = inicio;
			stack[cnt++] = fin;
			#endregion

			while(cnt > 0 && activo) {
				#region Pop
				fin = stack[--cnt];
				inicio = stack[--cnt];
				#endregion

				#region Partición
				T pivote = vec[inicio];
				int izq = inicio + 1;
				int der = fin;

				while(izq <= der) {
					while(izq <= fin && Comparar(vec[izq], pivote) <= 0) izq++;
					while(inicio < der && Comparar(pivote, vec[der]) <= 0 ) der--;

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

		private static int Comparar<T>(T a, T b) {
			return Comparer<T>.Default.Compare(a, b);
		}

		private static void Intercambiar<T>(T[] vec, int a, int b) {
			T temp = vec[a];
			vec[a] = vec[b];
			vec[b] = temp;
		}
	}
}
