using System;

namespace UlearnMe_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Sample1
        {
            static void F()
            {
                i = 1;
            }
            static int i = 0;
        }

		class Sample2
		{
			static string who = "class";

			static void F()
			{
				string who = "F";
			}

			static void G()
			{
				F();
				Console.WriteLine(who);
			}

			static void H()
			{
				string who = "H";
				F();
				Console.Write(who);
			}
		}

		class Sample3
		{
			static string who = "class";

			static void Mixed()
			{
				Console.Write(who + " ");
				string who = "Mixed";
				Console.Write(who);
			}
		}

		class Sample4
		{
			void M1()
			{
				int i = 0;
				{
					int i = 1;
				}
			}
			void M2(int i)
			{
				int i = 0;
			}
			void M3()
			{
				// Фигурными скобками можно группировать операторы (правда почти никогда этого делать не стоит)
				// и каждая пара фигурных скобок создает свою область видимости.
				{
					int i = 0;
				}
				{
					int i = 1;
				}
			}
		}
	}
}
