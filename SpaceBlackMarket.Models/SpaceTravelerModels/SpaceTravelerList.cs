using SpaceBlackMarket.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBlackMarket.Models.SpaceTravelerModels
{
    public class SpaceTravelerList
    {
        [Display(Name = "Traveler Id")]
        public int SpaceTravelerProfileId { get; set; }

        [Display(Name = "Owner Id")]
        public Guid OwnerId { get; set; }

        [Display(Name = "Alias")]
        public string TravelerAlias { get; set; }

        [Display(Name = "Wanted Level")]
        public WantedLevel WantedLevel { get; set; }
        
        [Display(Name = "Will they Cooperate?")]
        public bool WillingToCooperate { get; set; }

    }
}
