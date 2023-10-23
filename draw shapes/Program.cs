using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


 

namespace draw_shapes
{
	
	internal class Program
	{
		static void show_figure(char[,] array ,int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{

					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}

		}

		static void null_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					array[i, j] = '*';
				}
			}
			show_figure(array, size);
		}

		static void first_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j<=i)
					{
						array[i, j] = '*';
					}
				}
			}
			show_figure(array, size);
		}

		static void second_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j + i < size )
					{
						array[i, j] = '*';
					}
				}
			}
			show_figure(array, size);
		}

		static void third_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (i <= j)
					{
						array[i, j] = '*';
					}
				}
			}
			show_figure(array, size);
		}

		static void fourth_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j + i>= size-1)
					{
						array[i, j] = '*';
					}
				}
			}
			show_figure(array, size);
		}

		static void fifth_qu(int size)
		{
			size = size*2;
			char[,] array = new char[size, size];
			for (int i = 0; i < size / 2; i++)
			{
				for (int j = 0; j < size / 2; j++)
				{
					if (j + i >= size / 2 - 1 && j + i < size / 2)
					{
						array[i, j] = '/';
					}
					if (j + i >= size /2 - 1 && j + i < size / 2)
					{
						array[i + size / 2, j + size / 2] = '/';
					}
					if (j <= i && i <= j)
					{
						array[i, j + size / 2] = '\\';
					}
					if (j <= i && i <= j)
					{
						array[i + size / 2, j] = '\\';
					}
				}
			}
			show_figure(array, size);
		}

		static void sixth_qu(int size)
		{
			char[,] array = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if ((i + j) % 2 == 0)
					{
						array[i, j] = '+';
					}
					if ((i + j) % 2 == 1)
					{
						array[i, j] = '-';
					}

				}

			}
			show_figure(array, size);
		}

		static void color_start(int number_color)
		{

			ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = colors[number_color];

	}

		static void color_end()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;

		}

		static void Main(string[] args)
		{
			int size = 5;

			Console.WriteLine("Введите размер фигур в диапозоне от 1-20:");
			size = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			if (size >= 20 || size < 0)
			{
				size = 5;
				Console.Clear();
				color_start(12);
				Console.WriteLine("Размер введен неправильно, по умолчаню поставлен 5");
				color_end();
				Thread.Sleep(1300);
				Console.Clear();
				Console.WriteLine();

			}
			else
			{
				color_start(10);
				Console.Clear();
				Console.WriteLine("Размер установлен на: " + size);
				Thread.Sleep(1300);
				color_end();
				Console.WriteLine();
			}


			color_start(13);
			Console.WriteLine("0-фигура");
			color_end();
			null_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("1-фигура");
			color_end();
			first_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("2-фигура");
			color_end();
			second_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("3-фигура");
			color_end();
			third_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("4-фигура");
			color_end();
			fourth_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("5-фигура");
			color_end();
			fifth_qu(size);
			Console.WriteLine();
			Thread.Sleep(200);

			color_start(13);
			Console.WriteLine("6-фигура");
			color_end();
			sixth_qu(size);
			Console.WriteLine();
		}
	}
}
