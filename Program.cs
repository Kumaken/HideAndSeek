using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HideAndSeek
{
    static class Program
    {
        static List<List<int>> tree;
        static bool[] isBody;
        static int [] pointsTo;
        static bool[] visited;
        static long[] arrive;
        static long[] leave;
        static long globaleZeit = 1;
        [STAThread]

        static List<int> generatePath(int bottom, int upper, bool reverse)
        {
            List<int> Path = new List<int>();
            int current = bottom;
            while (current != pointsTo[upper])
            {
                Console.WriteLine(current);
                Path.Add(current);
                current = pointsTo[current];
            }
            if (reverse)
            {
                Path.Reverse();
            }
            return Path;
        }
        static void buildTree(ref StreamReader sr, int jmlRumah)
        {
            tree = new List<List<int>>(jmlRumah + 1);
            pointsTo = new int[jmlRumah + 1];
            isBody = new bool[jmlRumah + 1];
            isBody[1] = true;

            for (int i = 0; i <= jmlRumah; i++)
            {
                tree.Add(new List<int>());
            }

            List<(int, int)> pending = new List<(int a, int b)>();

            for (int i = 0; i < jmlRumah - 1; i++)
            {
                string[] line = sr.ReadLine().Split();

                int a = Int32.Parse(line[0]);
                int b = Int32.Parse(line[1]);
                if (isBody[a])
                {
                    pointsTo[b] = a;
                    isBody[b] = true;
                }
                else if (isBody[b])
                {
                    pointsTo[a] = b;
                    isBody[a] = true;
                }
                else
                {
                    pending.Add((a, b));
                }
                tree[a].Add(b);
                tree[b].Add(a);
            }
            int idx = 0;
            while (pending.Any())
            {
                if (idx>=pending.Count())
                {
                    idx = 0;
                }
                int a = pending[idx].Item1;
                int b = pending[idx].Item2;
                if (isBody[a])
                {
                    pointsTo[b] = a;
                    isBody[b] = true;
                    pending.RemoveAt(idx);
                }
                else if (isBody[b])
                {
                    pointsTo[a] = b;
                    isBody[a] = true;
                    pending.RemoveAt(idx);
                }
                else
                {
                    idx++;
                }
            }
        }

        static void DFS(int startNode, ref List<List<int>> tree)
        {
            visited[startNode] = true;
            arrive[startNode] = globaleZeit++;
            foreach(var childNode in tree[startNode])
            {
                if (!visited[childNode])
                {
                    DFS(childNode, ref tree);
                }
            }
            leave[startNode] = globaleZeit++;
        }

        static bool isChildOf(int nodeChild, int nodeParent)
        {
            return arrive[nodeChild] > arrive[nodeParent] && leave[nodeChild] < leave[nodeParent];
        }
        static void Main()
        {
            StreamReader sr = new StreamReader(@"Peta.txt");
            string Rumah = sr.ReadLine();
            int jmlRumah = Int32.Parse(Rumah);

            buildTree(ref sr, jmlRumah);

            //DFS
            arrive = new long[jmlRumah + 1];
            leave = new long[jmlRumah + 1];
            visited = new bool[jmlRumah + 1];

            DFS(1, ref tree);

            string Query = sr.ReadLine();
            int jmlQuery = Int32.Parse(Query);

            for (int i = 0; i < jmlQuery; i++)
            {
                string[] line = sr.ReadLine().Split();
                int Q = Int32.Parse(line[0]);
                int dest = Int32.Parse(line[1]);
                int source = Int32.Parse(line[2]);

                if (Q == 1)
                {
                    if (isChildOf(dest,source))
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine(String.Join(" -> ", generatePath(dest, source, true)));
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    if (isChildOf(source, dest))
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine(String.Join(" -> ", generatePath(source, dest, false)));
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
    }
}
