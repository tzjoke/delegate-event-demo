using System;
using System.Windows.Forms;

namespace DelegateAPP
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            criteriaUc1.Init();
        }

        private void criteriaUc1_RuleChanged(object sender, CriteriaUc.RuleChangedEventArgs e)
        {
            resultUc1.UpdateResult(e.RuleName);
        }
    }
}
