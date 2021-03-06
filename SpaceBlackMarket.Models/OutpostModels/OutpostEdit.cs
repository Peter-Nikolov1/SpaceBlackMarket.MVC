using SpaceBlackMarket.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBlackMarket.Models.OutpostModels
{
    public class OutpostEdit
    {
        public int OutpostId { get; set; }

        [Display(Name = "Outpost Name")]
        public string OutpostName { get; set; }

        [Display(Name = "Galaxy Name")]
        public string GalaxyName { get; set; }

        [Display(Name = "Planet Name")]
        public string PlanetName { get; set; }

        [Display(Name = "How Dangerous Is It?")]
        public DangerLevel DangerLevel { get; set; }
    }
}
