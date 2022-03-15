using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
