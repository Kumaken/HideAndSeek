using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Glee.Drawing;
using System.Drawing.Imaging;

namespace HideAndSeek
{
    public partial class Form1 : Form
    {
    //Constructor:
        public Form1()
        {
            InitializeComponent();
        }

    //Various Windows Form Event Handler:
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.fileURLTextBox.Text = this.openFileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            Process.runQuery(this);
        }

        private void fileURLTextBox_TextChanged(object sender, EventArgs e)
        {
            this.changePictureIDLE();
            this.label10.Visible = false;
            Process.runDFS(this);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Setter & Getter from Form1 Class for Process Class:
        //Get External File URL:
        public String getFileURL()
        {
            return this.fileURLTextBox.Text;
        }
        //Get 0/1 from textbox:
        public String get01()
        {
            return this.comboBox1.Text;
        }
        //Get "rumah" to be checked from textbox:
        public String geta()
        {
            return this.textBox1.Text;
        }
        //Get starting point from textbox:
        public String getb()
        {
            return this.textBox2.Text;
        }
    //Miscellaneous Functions:
        //Display Query Result:
        public void displayQans(int truthval)
        {
            this.label10.Visible = true;
            if (truthval==1)
                this.Qans.Text = "YES";
            else
                this.Qans.Text = "NO";
        }
        //Change Rilakuma to YES!:
        public void changePictureYES()
        {
            pictureBox1.Image = Properties.Resources.yay;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }
        //Change Rilakuma to NO!:
        public void changePictureNO()
        {
            pictureBox1.Image = Properties.Resources.no;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }
        //Change Rilakuma to IDLE FACE!:
        public void changePictureIDLE()
        {
            pictureBox1.Image = Properties.Resources.hide;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }
    }

    //MAIN FUNCTIONS:
    static class Process
    {
        static List<List<int>> tree;
        static bool[] visited;
        static long[] arrive;
        static long[] leave;
        static long globaleZeit = 1;
        //[STAThread]
        static void buildTree(ref List<List<int>> tree)
        {
            tree.RemoveAt(0);
        }

        static void DFS(int startNode, ref List<List<int>> tree)
        {
            Console.WriteLine(startNode);
            visited[startNode] = true;
            arrive[startNode] = globaleZeit++;
            foreach (var childNode in tree[startNode])
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

     // FUNCTION TO DO LOAD GRAPH AND RUN DFS:
        public static void runDFS(Form1 f1)
        {
            //Creating form for graph visualization
            System.Windows.Forms.Form graphForm = new System.Windows.Forms.Form();
            //Create object GViewer to view the constructed graph
            Microsoft.Glee.GraphViewerGdi.GViewer viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            //Create graph object
            Microsoft.Glee.Drawing.Graph graph = new Microsoft.Glee.Drawing.Graph("graph");
     
            tree = new List<List<int>>();

            StreamReader sr = new StreamReader(@f1.getFileURL());
            string Rumah = sr.ReadLine();

            int jmlRumah = Int32.Parse(Rumah);


            tree = new List<List<int>>(jmlRumah + 1);
            for (int i = 0; i <= jmlRumah; i++)
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
                //Add edges between 2 vertices to graph object:
                Microsoft.Glee.Drawing.Edge e = graph.AddEdge(line[0], line[1]);
                //Set edges without arrowhead => UNDIRECTED GRAPH!
                e.Attr.ArrowHeadAtTarget = ArrowStyle.None;
            }

            //DFS
            arrive = new long[jmlRumah + 1];
            leave = new long[jmlRumah + 1];
            visited = new bool[jmlRumah + 1];

            DFS(1, ref tree);

            //COLOR THE ROOT (1) WITH SEAGREEN COLOR
            Microsoft.Glee.Drawing.Node n1 = graph.FindNode("1");
            n1.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
            //Make Root a double-circled vertex just for emphasis, hehe:
            n1.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;

            //SHOWING THE GRAPH:
            //Bind the graph to the viewer
            viewer.Graph = graph;

            //Associate the viewer with the created form
                graphForm.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                graphForm.Controls.Add(viewer);
                graphForm.ResumeLayout();

            //Show the form as a new window, BUT not locked there!
                graphForm.Show();
        }

    // FUNCTION TO DO QUERY:
        public static void runQuery(Form1 f1)
        {
            if (f1.get01() != "" || f1.geta() != "" || f1.getb() != "")
            {
                //Parse input (string) into integer from textboxes.
                int Q = Int32.Parse(f1.get01());
                int _a = Int32.Parse(f1.geta());
                int _b = Int32.Parse(f1.getb());

                //Check for answer:
                if (Q == 1)
                {
                    if (isChildOf(_a, _b))
                    {
                        f1.displayQans(1);
                        f1.changePictureYES();
                    }
                    else
                    {
                        f1.displayQans(0);
                        f1.changePictureNO();
                    }
                }
                else
                {
                    if (isChildOf(_b, _a))
                    {
                        f1.displayQans(1);
                        f1.changePictureYES();
                    }
                    else
                    {
                        f1.displayQans(0);
                        f1.changePictureNO();
                    }
                }
            }
            
        }
    }


}
