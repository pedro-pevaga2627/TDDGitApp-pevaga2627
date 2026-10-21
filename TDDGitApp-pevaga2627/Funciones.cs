using System;
using System.Collections.Generic;
using System.Text;

// Autor: Pedro Valles Gambín - pevaga2627
namespace TDDGitApp_pevaga2627
{
	public class Funciones
	{
		public static long CalcularFactorial(int n)
		{
			if (n < 0)
				return -1;

			long resultado = 1;
			for (int i = 2; i <= n; i++)
				resultado *= i;

			return resultado;
		}

		// Autor: Pedro Valles Gambín - pevaga2627
		public static bool EsContrasenyaValida(string contrasenya)
		{
			if (contrasenya == null)
				return false;

			if (contrasenya == "")
				return false;

			if (contrasenya.Length < 8)
				return false;

			if (!contrasenya.Contains("#"))
				return false;

			return true;
		}
	}
}
