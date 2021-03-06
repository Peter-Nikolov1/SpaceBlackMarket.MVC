using SpaceBlackMarket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBlackMarket.Models.ProfilePage
{
    public class ProfileEdit
    {
        public int SpaceTravelerProfileId { get; set; }

        public string TravelerAlias { get; set; }

        public double Credits { get; set; }

        public WantedLevel WantedLevel { get; set; }

        public bool WillingToCooperate { get; set; }
    }
}
