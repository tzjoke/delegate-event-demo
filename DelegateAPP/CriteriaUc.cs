using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DelegateAPP
{
    public partial class CriteriaUc : UserControl
    {
        public CriteriaUc()
        {
            InitializeComponent();
        }

        public void Init()
        {
            cbxRule.Items.Clear();
            cbxRule.DataSource = new List<string> {"A", "B", "C"};
            cbxRule.SelectedIndex = 0;
        }

        #region rule changed event

        public delegate void RuleChangedEventHandler(object sender, RuleChangedEventArgs e);

        public event RuleChangedEventHandler RuleChanged;

        private void cbxRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRule.SelectedIndex == -1) return;

            var val = cbxRule.Text;
            RuleChanged?.Invoke(sender, new RuleChangedEventArgs(val));
        }

        public class RuleChangedEventArgs : EventArgs
        {
            public string RuleName;

            public RuleChangedEventArgs(string rulename)
            {
                RuleName = rulename;
            }
        }

        #endregion
        
    }
}
