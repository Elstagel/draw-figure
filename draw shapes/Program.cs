using System;
using System.Collections;
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

		static void seventh_qu(int size)
		{
			size= size * 2;
			char[,] array = new char[size / 2, size];

			for (int i = 0; i < size / 2; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (i == 0 && j == 0) array[i, j]= '┌';
					else if(i == 0 && j == size - 1) array[i, j]= '┐';
					else if(i == size/2-1 && j == 0) array[i, j]= '└';
					else if(i == size/2-1 && j == size - 1) array[i, j]= '┘';
					else if(i == 0 || i == size/2-1) array[i, j] = '─';
					else if (j == 0 || j == size-1) array[i, j] = '│';
					else if ((i + j) % 2 == 0){array[i, j] = '8';}
					else if ((i + j) % 2 == 1){array[i, j] = '4';}
				}
			}

			for (int i = 0; i < size / 2; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (array[i, j] == '8')
					{
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write(array[i, j]);
						color_end();
					}
					else if (array[i, j] == '4')
					{
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.Write(array[i, j]);
						color_end();
					}
					else Console.Write(array[i, j]); 
				}
				Console.WriteLine();
			}
		}

		static void eighth_qu(int size)							 
		{
			size= size / 2;
			char[,,,] array = new char[size, size, size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					for (int k = 0; k < size; k++)
					{
						for (int l = 0; l < size; l++)
						{
							if ((i + k) % 2 == 0)
							{
								array[i, j, k, l] = '*';
							}
							else
							{
								array[i, j, k, l] = '-';
							}
						}
					}
				}
			}

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					for (int k = 0; k < size; k++)
					{
						for (int l = 0; l < size; l++)
						{
							if ((i + k) % 2 == 0)
							{
								Console.Write(array[i, j, k, l] + " ");
							}
							else
							{
							    Console.Write(array[i, j, k, l] + " ");	
							}
						}
					}
					Console.WriteLine();
				}
			}
		}

		static void color_start(int number_color)
		{
			//Black       0
			//Blue        9
			//Cyan        11
			//DarkBlue    1
			//DarkCyan    3
			//DarkGray    8
			//DarkGreen   2
			//DarkMagenta 5
			//DarkRed     4
			//DarkYellow  6
			//Gray        7
			//Green       10
			//Magenta     13
			//Red     12
			//White       15
			//Yellow      14
			
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
			color_start(14);
			Console.WriteLine("Для 7 и 8 фигуры размер уменьшен для коректной отрисовки всех фигур");
			color_end();
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

			color_start(13);
			Console.WriteLine("7-фигура");
			color_end();
			seventh_qu(size);
			Console.WriteLine();

			color_start(13);
			Console.WriteLine("8-фигура(размер уменьшен в двое)");
			color_end();
			eighth_qu(size);
			Console.WriteLine();

		}
	}
}
