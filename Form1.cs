using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using GraphX.Controls.Models;
using QuickGraph;
using GraphX.PCL.Common.Models;


namespace HideAndSeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Done";
            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();
        }

        private ZoomControl _zoomctrl;
        private GraphAreaExample _gArea;

        private UIElement GenerateWpfVisuals()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphAreaExample
            {
                // EnableWinFormsHostingMode = false,
                LogicCore = logic,
                EdgeLabelFactory = new DefaultEdgelabelFactory()
            };
            _gArea.ShowAllEdgesLabels(true);
            
            logic.Graph = GenerateGraph();
            _gArea.ShowAllEdgesArrows(false);
            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.Sugiyama;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.Sugiyama);
            //((LinLogLayoutParameters)logic.DefaultLayoutAlgorithmParams). = 100;
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.SimpleER;
            logic.AsyncAlgorithmCompute = false;
            _zoomctrl.Content = _gArea;
            _gArea.RelayoutFinished += gArea_RelayoutFinished;


            var myResourceDictionary = new ResourceDictionary { Source = new Uri("Templates\\template.xaml", UriKind.Relative) };
            _zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);
            
            return _zoomctrl;
        }

        void gArea_RelayoutFinished(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
            
        }

        private GraphExample GenerateGraph()
        {
            //FOR DETAILED EXPLANATION please see SimpleGraph example project
            var dataGraph = new GraphExample();
            for (int i = 0; i < 1000; i++)
            {
                var dataVertex = new DataVertex("MyVertex " + i);
                dataGraph.AddVertex(dataVertex);
            }
            var vlist = dataGraph.Vertices.ToList();
            //Then create two edges optionaly defining Text property to show who are connected
            //var dataEdge = new DataEdge(vlist[0], vlist[1]) { Text = string.Format("{0} -> {1}", vlist[0], vlist[1]) };
            //dataGraph.AddEdge(dataEdge);
            //dataEdge = new DataEdge(vlist[2], vlist[3]) { Text = string.Format("{0} -> {1}", vlist[2], vlist[3]) };
            //dataGraph.AddEdge(dataEdge);
            for (int i = 0; i < 999; i++)
            {
                var dataEdge = new DataEdge(vlist[i], vlist[i+1]) { Text = string.Format("{0} -> {1}", vlist[i], vlist[i+1]) };
                dataGraph.AddEdge(dataEdge);
            }


            //dataEdge = new DataEdge(vlist[2], vlist[2]) { Text = string.Format("{0} -> {1}", vlist[2], vlist[2]) };
            //dataGraph.AddEdge(dataEdge);
            
            return dataGraph;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            _gArea.GenerateGraph(true,true);
            _gArea.ShowAllEdgesArrows(false);
            _gArea.ShowAllEdgesLabels(false);
            _gArea.SetEdgesDashStyle(EdgeDashStyle.Dash);
            
            

            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _gArea.RelayoutGraph();
            _gArea.SetEdgesDashStyle(EdgeDashStyle.Dash);
            
        }
    }
    public class GraphAreaExample : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>> { }
    public class GraphExample : BidirectionalGraph<DataVertex, DataEdge> { }
    public class DataVertex : VertexBase
    {
        /// <summary>
        /// Some string property for example purposes
        /// </summary>
        public string Text { get; set; }

        #region Calculated or static props

        public override string ToString()
        {
            return Text;
        }


        #endregion

        /// <summary>
        /// Default parameterless constructor for this class
        /// (required for YAXLib serialization)
        /// </summary>
        public DataVertex() : this("")
        {
        }

        public DataVertex(string text = "")
        {
            Text = text;
        }
    }
    public class DataEdge : EdgeBase<DataVertex>
    {
        /// <summary>
        /// Default constructor. We need to set at least Source and Target properties of the edge.
        /// </summary>
        /// <param name="source">Source vertex data</param>
        /// <param name="target">Target vertex data</param>
        /// <param name="weight">Optional edge weight</param>
        public DataEdge(DataVertex source, DataVertex target, double weight = 1)
            : base(source, target, weight)
        {
        }
        /// <summary>
        /// Default parameterless constructor (for serialization compatibility)
        /// </summary>
        public DataEdge()
            : base(null, null, 1)
        {
        }

        /// <summary>
        /// Custom string property for example
        /// </summary>
        public string Text { get; set; }

        #region GET members
        public override string ToString()
        {
            return Text;
        }
        #endregion
    }
}
