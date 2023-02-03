using System;

namespace CSharpApplication.methodsOfArray
{
	public class Program
	{
		public static void Main()
		{

			/*#region задание 1
			int[] ar = new int[10];
			Random rnd = new Random();
			int ch = 0, nch = 0;
			Console.WriteLine("Массив");
			int countUnique = 0, counter = 0;
			for (int i = 0; i < ar.Length; i++)
			{
				ar[i] = rnd.Next(0, 20);
				Console.Write("{0,4}", ar[i]);

				if (ar[i] % 2 == 0)
				{
					ch++;
				}
				else
				{
					nch++;
				}
				for(int j=0;j<ar.Length;j++)
                {
					if(ar[i]==ar[j])
                    {
						counter++;
                    }
                }
				if(counter==1)

                {
					countUnique++;
                }
			}

			Console.WriteLine();
			Console.WriteLine("Кол-во четных:" + ch);
			Console.WriteLine("Кол-во нечетных: " + nch);
			Console.WriteLine("Уникальных элементов: " + countUnique);
			#endregion



			#region задание 2
			Console.WriteLine("Введите цифру");
			int number=Convert.ToInt32(Console.ReadLine());

			//я не знаю правильно ли я поняла задание, поэтому сделала 2 варианта
			//это первый:

			int[] array = new int[number-1];
			Random rand = new Random();
			Console.WriteLine("В массиве количество значений меньше заданного числа: "+number);
			for(int i=0;i<array.Length;i++)
			{
			array[i] = rand.Next(0, 10);
			Console.Write("{0,2}", array[i]);	
			}

			//это второй:
			int[] array2 = new int[10];
			Random random = new Random();
			Console.WriteLine("В массиве количество значений меньше заданного числа: "+number);
			for(int i=0;i<array2.Length;i++)
			{
			array2[i] = random.Next(0, number-1);
			Console.Write("{0,4}", array2[i]);	
			}
			#endregion*/




			Console.WriteLine();


			#region задание 3
			int[] arr = new int[8];
			Random Rand = new Random();
			Console.WriteLine("Ввелите числа: ");
			int Num1 = Convert.ToInt32(Console.ReadLine());
			int Num2 = Convert.ToInt32(Console.ReadLine());
			int Num3 = Convert.ToInt32(Console.ReadLine());
			int c1=0,c2=0,c3 = 0;
			Console.WriteLine();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = Rand.Next(1, 10);
				Console.Write(arr[i] + "  ");
				if (arr[i] == Num1)
				{
					c1++;
				}
				if (arr[i] == Num2)
				{
					c2++;
				}
				if (arr[i] == Num3)
				{
					c3++;
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Info about array: ");
			Console.WriteLine($"Цифра {Num1} повторяется {c1} в массиве");
			Console.WriteLine($"Цифра {Num2} повторяется {c2} в массиве");
			Console.WriteLine($"Цифра {Num3} повторяется {c3} в массиве");


			#endregion


		}
	}
}