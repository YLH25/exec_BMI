using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算BMI
			Console.Write("請輸入身高(m):");
			string input1 = Console.ReadLine();
			Console.Write("請輸入體重(kg)");
			string input2 = Console.ReadLine();

			bool h = double.TryParse(input1, out double height);
			bool w = double.TryParse(input2, out double weight);

			double bmi = weight / (height * height);

			Console.WriteLine("bmi是"+bmi.ToString("0.0"));
		}
	}
}
