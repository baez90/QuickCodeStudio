using System.Activities.Presentation.Toolbox;
using System.Activities.Statements;
using QuickCodeStudio.i18n.Components.Toolbars;
using Xceed.Wpf.AvalonDock.Layout;

namespace QuickCodeStudio.Components.Toolbars
{
    public class WorkflowItemsToolbox : LayoutAnchorable
    {
        public WorkflowItemsToolbox()
        {
            var toolbox = new ToolboxControl();
            var controlElementsCategory = new ToolboxCategory(WorkflowItemsToolboxResources.TBCHeader)
            {
                new ToolboxItemWrapper("System.Activities.Statements.Assign", typeof (Assign).Assembly.FullName, null,
                    WorkflowItemsToolboxResources.TBIAssignLabel),
                new ToolboxItemWrapper("System.Activities.Statements.DoWhile", typeof (DoWhile).Assembly.FullName, null,
                    WorkflowItemsToolboxResources.TBIDoWhileLabel)
            };

            toolbox.Categories.Add(controlElementsCategory);

            Content = toolbox;
            Title = WorkflowItemsToolboxResources.LATitle;
        }
    }
}