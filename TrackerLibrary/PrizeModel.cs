﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the number of the place, 1 being the winner of the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of this particular place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize given to this particular place.
        /// </summary>
        public Decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize given to this particular place as a percentage of the total entry fees.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}