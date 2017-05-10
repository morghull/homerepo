using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ISLibrary
{
    class SettingsWorkingAreaControl : Panel
    {
        [Designer(typeof(WorkingAreaDesigner))]
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
