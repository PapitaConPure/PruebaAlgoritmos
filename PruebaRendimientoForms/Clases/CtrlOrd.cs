﻿using System;
using PruebaRendimientoForms.Ordenamientos;

namespace PruebaRendimientoForms {
	static class CtrlOrd {
		public static readonly Opcion METODO_BUBBLE_SORT = new Opcion(0, "Bubble Sort");
		public static readonly Opcion METODO_MERGE_SORT = new Opcion(1, "Merge Sort");
		public static readonly Opcion METODO_SELECTION_SORT = new Opcion(2, "Selection Sort");
		public static readonly Opcion METODO_QUICK_SORT = new Opcion(3, "Quick Sort");

		public static readonly Opcion TIPO_INT16 = new Opcion(0, "Int16");
		public static readonly Opcion TIPO_INT32 = new Opcion(1, "Int32");
		public static readonly Opcion TIPO_INT64 = new Opcion(2, "Int64");
		public static readonly Opcion TIPO_FLOAT32 = new Opcion(3, "Float32 (Float)");
		public static readonly Opcion TIPO_FLOAT64 = new Opcion(4, "Float64 (Double)");
		public static readonly Opcion TIPO_DECIMAL128 = new Opcion(5, "Decimal128");
		public static readonly Opcion TIPO_CHAR = new Opcion(6, "Char");
		public static readonly Opcion TIPO_STRING8 = new Opcion(7, "String8");
		public static readonly Opcion TIPO_STRING32 = new Opcion(8, "String32");

		private static Random random;

		public static object[] Ordenar(int n, int idMetodo, int idTipo) {
			object[] vec = new object[n];
			random = new Random(0);

			if(idTipo == TIPO_INT16.Id)
				OrdenarInt16(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_INT32.Id)
				OrdenarInt32(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_INT64.Id)
				OrdenarInt64(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_FLOAT32.Id)
				OrdenarFloat32(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_FLOAT64.Id)
				OrdenarFloat64(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_DECIMAL128.Id)
				OrdenarDecimal128(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_CHAR.Id)
				OrdenarChar(n, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_STRING8.Id)
				OrdenarString(n, 8, idMetodo).CopyTo(vec, 0);
			else if(idTipo == TIPO_STRING32.Id)
				OrdenarString(n, 32, idMetodo).CopyTo(vec, 0);

			return vec;
		}

		public static void OrdenarSinCopiar(int n, int idMetodo, int idTipo) {
			random = new Random(0);

			if(idTipo == TIPO_INT16.Id)
				OrdenarInt16(n, idMetodo);
			else if(idTipo == TIPO_INT32.Id)
				OrdenarInt32(n, idMetodo);
			else if(idTipo == TIPO_INT64.Id)
				OrdenarInt64(n, idMetodo);
			else if(idTipo == TIPO_FLOAT32.Id)
				OrdenarFloat32(n, idMetodo);
			else if(idTipo == TIPO_FLOAT64.Id)
				OrdenarFloat64(n, idMetodo);
			else if(idTipo == TIPO_DECIMAL128.Id)
				OrdenarDecimal128(n, idMetodo);
			else if(idTipo == TIPO_CHAR.Id)
				OrdenarChar(n, idMetodo);
			else if(idTipo == TIPO_STRING8.Id)
				OrdenarString(n, 8, idMetodo);
			else if(idTipo == TIPO_STRING32.Id)
				OrdenarString(n, 32, idMetodo);
		}

		private static short[] OrdenarInt16(int n, int idx) {
			short[] vec = new short[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = (short)random.Next(short.MaxValue);

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoInt16.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoInt16.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoInt16.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoInt16.QuickSort(vec);

			return vec;
		}

		private static int[] OrdenarInt32(int n, int idx) {
			int[] vec = new int[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = random.Next();

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoInt32.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoInt32.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoInt32.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoInt32.QuickSort(vec);

			return vec;
		}

		private static long[] OrdenarInt64(int n, int idx) {
			long[] vec = new long[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = (long)(random.NextDouble() * long.MaxValue);

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoInt64.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoInt64.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoInt64.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoInt64.QuickSort(vec);

			return vec;
		}

		private static float[] OrdenarFloat32(int n, int idx) {
			float[] vec = new float[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = (float)random.NextDouble() * 100;

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoFloat.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoFloat.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoFloat.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoFloat.QuickSort(vec);

			return vec;
		}

		private static double[] OrdenarFloat64(int n, int idx) {
			double[] vec = new double[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = random.NextDouble() * 10000;

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoDouble.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoDouble.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoDouble.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoDouble.QuickSort(vec);

			return vec;
		}

		private static decimal[] OrdenarDecimal128(int n, int idx) {
			decimal[] vec = new decimal[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = (decimal)random.NextDouble() * 100000000;

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoDecimal.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoDecimal.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoDecimal.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoDecimal.QuickSort(vec);

			return vec;
		}

		private static char[] OrdenarChar(int n, int idx) {
			char[] vec = new char[n];
			for(int i = 0; i < vec.Length; i++)
				vec[i] = (char)random.Next(32, 127);

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoChar.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoChar.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoChar.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoChar.QuickSort(vec);

			return vec;
		}

		private static string[] OrdenarString(int n, int w, int idx) {
			#region Generar caracteres aleatorios
			string[] caracteres = new string[] {
				"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Ñ",
				"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "ñ",
				"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "_", ",", ".", "!", "?", "=", "#", "@", "&", "$", "%"
			};
			string s;

			string[] vec = new string[n];

			for(int i = 0; i < n; i++) {
				s = "";
				for(int j = 0; j < w; j++)
					s += caracteres[random.Next(caracteres.Length)];
				vec[i] = s;
			}
			#endregion

			if(idx == METODO_BUBBLE_SORT.Id)
				OrdenamientoString.BubbleSort(vec);
			else if(idx == METODO_MERGE_SORT.Id)
				OrdenamientoString.MergeSort(vec);
			else if(idx == METODO_SELECTION_SORT.Id)
				OrdenamientoString.SelectionSort(vec);
			else if(idx == METODO_QUICK_SORT.Id)
				OrdenamientoString.QuickSort(vec);

			return vec;
		}
	}
}
