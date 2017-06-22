using System.Windows.Forms;

namespace DelegateAPP
{
    public partial class ResultUc : UserControl
    {
        public ResultUc()
        {
            InitializeComponent();
        }

        public void UpdateResult(string ruleName)
        {
            lblRule.Text = ruleName;
        }
    }
}
