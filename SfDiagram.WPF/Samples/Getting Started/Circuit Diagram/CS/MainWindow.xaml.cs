#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Controls;
using System.Collections.ObjectModel;
using SPath = System.Windows.Shapes.Path;
using Syncfusion.Windows.Shared;

namespace circuit_demo_tutorial_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
       public MainWindow()
        {
            InitializeComponent();

            //To Disable ContextMenu
            diagramcontrol.Menu = null;

            //Initialize Constraints
            InitializeDiagram();
        }
      
        private void InitializeDiagram()
        {
            //Bridging Constraints used to enable/disable the Bridging.
            diagramcontrol.Constraints = diagramcontrol.Constraints | GraphConstraints.Bridging | (GraphConstraints.Zoomable | GraphConstraints.Pannable);
            diagramcontrol.Tool = Tool.ZoomPan;
        }
    }

    //Class for IAnnotation Collection
    public class AnnotationCollection : ObservableCollection<IAnnotation>
    {

    }
}



