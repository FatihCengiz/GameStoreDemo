using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public String CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
