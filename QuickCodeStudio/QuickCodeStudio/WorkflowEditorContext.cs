using System.Windows;

namespace QuickCodeStudio
{
    public class WorkflowEditorContext : DependencyObject
    {
        public static readonly DependencyProperty PropertyInspectorViewProperty =
            DependencyProperty.Register("PropertyInspectorView", typeof (UIElement), typeof (WorkflowEditorContext));

        private WorkflowEditorContext()
        {
        }

        public static WorkflowEditorContext Current { get; } = new WorkflowEditorContext();

        public UIElement PropertyInspectorView
        {
            get { return (UIElement) GetValue(PropertyInspectorViewProperty); }
            set { SetValue(PropertyInspectorViewProperty, value); }
        }
    }
}