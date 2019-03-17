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
        static int [] pointsTo;
        static bool[] visited;
        static long[] arrive;
        static long[] leave;
        static long globaleZeit = 1;
        [STAThread]
        static void buildTree(ref StreamReader sr, int jmlRumah)
        {
            tree = new List<List<int>>(jmlRumah + 1);
            pointsTo = new int[jmlRumah + 1];
            for (int i = 0; i <= jmlRumah; i++)
            {
                tree.Add(new List<int>());
            }

            for (int i = 0; i < jmlRumah - 1; i++)
            {
                string[] line = sr.ReadLine().Split();

                int a = Int32.Parse(line[0]);
                int b = Int32.Parse(line[1]);
                //Console.WriteLine(jmlRumah);
                pointsTo[b] = a;
                tree[a].Add(b);
                tree[b].Add(a);
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
                        List<int> Path = new List<int>();
                        int current = dest;
                        while (current != pointsTo[source])
                        {
                            Path.Add(current);
                            current = pointsTo[current];
                        }
                        Path.Reverse();
                        Console.WriteLine(String.Join(" -> ", Path));
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
                        List<int> Path = new List<int>();
                        int current = source;
                        while (current != pointsTo[dest])
                        {
                            Path.Add(current);
                            current = pointsTo[current];
                        }
                        Console.WriteLine(String.Join(" -> ", Path));
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
