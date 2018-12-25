using DevExpress.XtraScheduler.Localization;
using System.Windows.Forms;

namespace FrenchScheduler {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Uncomment the code below to use translations provided by a custom localizer instead of localized resources.
            // Note that in this instance you should provide all required translations.
            //MyLocalizer myLocalizer = new MyLocalizer();
            //DefaultActiveLocalizerProvider<SchedulerStringId> provider =
            //    new DefaultActiveLocalizerProvider<SchedulerStringId>(myLocalizer);
            //SchedulerLocalizer.SetActiveLocalizerProvider(provider);
            //SchedulerLocalizer.Active = myLocalizer;           
        }

        public class MyLocalizer : SchedulerLocalizer {
            public override string GetLocalizedString(SchedulerStringId id) {
                string ret = "";
                switch(id) {
                    case SchedulerStringId.MenuCmd_LabelAs:
                        return "Actions possibles";
                    default:
                        ret = base.GetLocalizedString(id);
                        break;
                }
                return ret;
            }
        }
        
    }
}