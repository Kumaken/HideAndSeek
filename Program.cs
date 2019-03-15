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
        static bool[] visited;
        static long[] arrive;
        static long[] leave;
        static long globaleZeit = 1;
        [STAThread]
        static void buildTree(ref List<List<int>> tree)
        {
            tree.RemoveAt(0);
        }

        static void DFS(int startNode, ref List<List<int>> tree)
        {
            Console.WriteLine(startNode);
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
            tree = new List<List<int>>();

            StreamReader sr = new StreamReader(@"Peta.txt");
            string Rumah = sr.ReadLine();
            
            int jmlRumah = Int32.Parse(Rumah);

            
            tree = new List<List<int>>(jmlRumah + 1);
            for (int i=0; i<=jmlRumah; i++)
            {
                tree.Add(new List<int>());
            }

            for (int i = 0; i < jmlRumah - 1; i++)
            {
                string[] line = sr.ReadLine().Split();

                int a = Int32.Parse(line[0]);
                int b = Int32.Parse(line[1]);
                tree[a].Add(b);
                tree[b].Add(a);
            }

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
                int a = Int32.Parse(line[1]);
                int b = Int32.Parse(line[2]);

                if (Q == 1)
                {
                    if (isChildOf(a,b))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    if (isChildOf(b, a))
                    {
                        Console.WriteLine("YES");
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
