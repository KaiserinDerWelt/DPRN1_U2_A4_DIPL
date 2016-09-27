using System;

namespace Actividad4U3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			CSalario salario1;

			Console.WriteLine ("==== Calculadora Salario A4U3 ====");

			salario1 = new CSalario ();
			Console.WriteLine ("Ingrese nombre del empleado:");
			salario1.nombre = Console.ReadLine ();
			Console.WriteLine ("Ingrese apellidos del empleado:");
			salario1.apellidos = Console.ReadLine ();
			Console.WriteLine ("Ingrese el departamento del empleado:");
			salario1.departamento = Console.ReadLine ();
			Console.WriteLine ("Ingrese sueldo por hora:");
			salario1.sueldoXHora = Double.Parse(Console.ReadLine());
			Console.WriteLine ("Ingrese las horas trabajadas:");
			var salarioBase = salario1.salarioBase (Int32.Parse(Console.ReadLine()));
			var salarioNeto = salario1.salarioNeto (salarioBase);

			Console.WriteLine ("\n\nNombre del empleado: {0} {1}\n" +
				"Departamento: {2}\n" +
				"Total a pagar: {3: 0.00}", salario1.nombre, salario1.apellidos, salario1.departamento, salarioNeto);
		}
	}

	class CSalario
	{
		public string nombre;
		public string apellidos;
		public string departamento;
		public double sueldoXHora;

		public CSalario ()
		{
			Console.WriteLine ("Diego Antonio Plascencia Lara, ES1421004131 \n" +
			"Actividad 4. Programa que utiliza métodos que devuelve resultados \n" +
			"{0} \n\n", DateTime.Now);
		}

		public double salarioBase (int horas)
		{
			double salarioBase;
			double salarioExtra = 0;
			if (horas <= 40) {
				salarioBase = horas * sueldoXHora;
			} else {
				salarioBase = 40 * sueldoXHora;
				salarioExtra = ((horas - 40) * sueldoXHora) * 2;
			}

			return (salarioBase * 1.12) + salarioExtra;
		}

		public double salarioNeto(double salarioBase)
		{
			double salarioNeto;
			salarioNeto = salarioBase * 1.16;
			salarioNeto = salarioNeto - (salarioBase * 0.1);
			salarioNeto = salarioNeto - ((salarioBase * 0.16) * 0.1067);
			return salarioNeto;
		}
	}
}
