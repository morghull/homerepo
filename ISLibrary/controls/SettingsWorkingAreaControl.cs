using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ISLibrary
{
    [Designer(typeof(WorkingAreaDesigner))]
    public class SettingsWorkingAreaControl : Panel
    {
        public SettingsWorkingAreaControl()
        {
            base.Dock = DockStyle.Fill;
            base.Margin = new Padding(0);
        }
    }
    public class WorkingAreaDesigner : ScrollableControlDesigner
    {
        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            properties.Remove("Dock");
            base.PreFilterProperties(properties);
        }
    }
}
