using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dataTable_edited.Models
{
    public class CombinedViewModel
    {
        public List<trn_kanban_machine_size_info> MachineSizeInfoList { get; set; }
        public List<trn_kanban_productivity> ProductivityList { get; set; }

        public List<CombinedLossData> CombinedLossDataList { get; set; }

    }
    public class CombinedLossData
    {
        public trn_kanban_loss_summary LossSummary { get; set; }
        public trn_kanban_loss_comment LossComment { get; set; }
    }
}