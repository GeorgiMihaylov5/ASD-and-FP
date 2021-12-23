
using System;
//https://www.geeksforgeeks.org/dijkstras-shortest-path-algorithm-greedy-algo-7/
class GFG
{
	static int V = 6;

	static void printSolution(int[] dist)
	{
		Console.Write("Vertex \t\t Distance " + "from Source\n");
		for (int i = 0; i < V; i++)
			Console.Write(i + " \t\t " + dist[i] + "\n");
	}
	static int minDistance(int[] dist, bool[] sptSet)
	{
		int min = int.MaxValue, min_index = -1;//

		for (int v = 0; v < V; v++)
			if (sptSet[v] == false && dist[v] <= min)//ако възела не е включен и пътят до него е по-малък от последния минимален път
			{
				min = dist[v];
				min_index = v;
			}

		return min_index;//от всички изчислени възли този е най малък
	}

	static void dijkstra(int[,] graph, int src)
	{
		int[] dist = new int[V]; //съдържа дистанцията от първоначланата точка до текущата. Например: начална тока 0, dist съдържа разстоянието от 0-левата точка до всяка друга					 
		bool[] sptSet = new bool[V]; //истина ако възела е включен в пътя


		for (int i = 0; i < V; i++)
		{
			dist[i] = int.MaxValue; //максимална дистанция при инициализация
			sptSet[i] = false;//Initially, this set is empty.
		}
		Console.Write("\n   * = {0}", int.MaxValue);


		dist[src] = 0;														


		for (int count = 0; count < V - 1; count++)
		{
			Console.Write("\n\nSend dist to minDistance:   "); for (int i = 0; i < dist.Length; i++) { if (dist[i] != int.MaxValue) Console.Write(dist[i] + "    "); else Console.Write(" *" + "    "); }
			Console.Write("\nSend sptSet to minDistance: "); for (int i = 0; i < sptSet.Length; i++) Console.Write(sptSet[i] + " ");

			int u = minDistance(dist, sptSet);          //избор на нов възел
			Console.WriteLine("\n   minDistance Vertex: u=" + u + " =====================================================================");

			sptSet[u] = true;
			Console.Write("                Set Vertex: "); for (int i = 0; i < sptSet.Length; i++) Console.Write(sptSet[i] + " ");
			Console.WriteLine();
			//Преглежда всички връзки на взълите с възел u
			for (int v = 0; v < V; v++)
				if (!sptSet[v] && //ако възела v не е все още включен в пътя
					graph[u, v] != 0 && //ако от възел u към възел v имаме връзка
					dist[u] != int.MaxValue && //ако дистанцията е реална смислена стойност
					/*dist[u] + graph[u, v] < dist[v]*/ trace1(dist, graph, u, v)		//================================
					)
					{
						int tmp = dist[v] = dist[u] + graph[u, v];
						Console.WriteLine("Add: dist[{0}] = dist[{1}] + graph[{1}, {0}] = {2}", v, u, tmp);
					}
		}

		printSolution(dist);
	}

	public static void Main()
	{
		//int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
		//							{ 4, 0, 8, 0, 0, 0, 0, 11, 0 },
		//							{ 0, 8, 0, 7, 0, 4, 0, 0, 2 },
		//							{ 0, 0, 7, 0, 9, 14, 0, 0, 0 },
		//							{ 0, 0, 0, 9, 0, 10, 0, 0, 0 },
		//							{ 0, 0, 4, 14, 10, 0, 2, 0, 0 },
		//							{ 0, 0, 0, 0, 0, 2, 0, 1, 6 },
		//							{ 8, 11, 0, 0, 0, 0, 1, 0, 7 },
		//							{ 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
		int[,] graph = new int[,] { { 0, 3, 0, 0, 1, 0 },
									{ 3, 0, 8, 9, 7, 0 },
									{ 0, 8, 0, 4, 0, 7 },
									{ 0, 9, 4, 0, 5, 8 },
									{  1, 7, 0, 5, 0, 0 },
									{ 0, 0, 7, 8, 0, 0 } };

		dijkstra(graph, 0);
	}

	
	static bool trace1(int[] dist, int[,] graph, int u, int v)
	{
		bool tmp = dist[u] + graph[u, v] < dist[v];
		Console.WriteLine("IF:  dist[{1}] + graph[{1}, {0}] < dist[{0}] => {2}", v, u, tmp);
		return tmp;
	}
}
