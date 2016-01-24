using System;
using System.Activities.Presentation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickCodeStudio.Components
{
    /// <summary>
    /// Interaction logic for WorkflowEditor.xaml
    /// </summary>
    [ContentProperty("View")]
    public partial class WorkflowEditor : UserControl
    {

        private WorkflowDesigner _wd;

        public WorkflowEditor()
        {
            _wd = new WorkflowDesigner();
            InitializeComponent();
            
        }

        public UIElement View => _wd.View;
    }
}
