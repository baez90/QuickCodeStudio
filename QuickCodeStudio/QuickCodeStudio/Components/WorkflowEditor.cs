using System.Activities.Core.Presentation;
using System.Activities.Presentation;
using System.Activities.Statements;
using Xceed.Wpf.AvalonDock.Layout;

namespace QuickCodeStudio.Components
{
    public class WorkflowEditor : LayoutDocument
    {
        public WorkflowEditor()
        {
            var dm = new DesignerMetadata();
            dm.Register();
            Designer = new WorkflowDesigner();
            Designer.Load(new Sequence());
            Content = Designer.View;
            IsSelectedChanged += (sender, args) =>
            {
                HandleSelectionChanged();
            };

            IsActiveChanged += (sender, args) =>
            {
                HandleSelectionChanged();
            };
        }

        public WorkflowDesigner Designer { get; }

        public void LoadSequence(Sequence sequenceToLoad, string documentName)
        {
            Designer.Load(sequenceToLoad);
            Title = documentName;
        }

        private void HandleSelectionChanged()
        {
            if (IsSelected)
            {
                WorkflowEditorContext.Current.PropertyInspectorView = Designer.PropertyInspectorView;
            }
        }
    }
}