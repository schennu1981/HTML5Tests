using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPolls.DAL;

namespace UserPolls.BOs.Opearations
{
   public  class PollItem
    {
       public POLL_Questions Question { get; set; }
       public POLL_Options[] OptionsToQuestion { get; set; }

       public static PollItem[] StubData()
       {
           var PollItemList = new List<PollItem>();

           PollItem items = new PollItem();
           items.Question = new POLL_Questions() { ID = 1, Catagory = 1, Statement = "How are you today", StatusID = 1 };
           var Options = new List<POLL_Options>();
           Options.Add(new POLL_Options() { PollID = 1, AnswerID = 1, AnesDescription = "Yes" });
           Options.Add(new POLL_Options() { PollID = 1, AnswerID = 2, AnesDescription = "No" });
           items.OptionsToQuestion = Options.ToArray();
           PollItemList.Add(items);

           items = new PollItem();
           items.Question = new POLL_Questions() { ID = 2, Catagory = 1, Statement = "How is movie one", StatusID = 1 };
           Options = new List<POLL_Options>();
           Options.Add(new POLL_Options() { PollID = 2, AnswerID = 3, AnesDescription = "Yes" });
           Options.Add(new POLL_Options() { PollID = 2, AnswerID = 4, AnesDescription = "No" });
           items.OptionsToQuestion = Options.ToArray();
           PollItemList.Add(items);
           return PollItemList.ToArray();
       }
   }

   
}
