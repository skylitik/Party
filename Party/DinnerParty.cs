using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class DinnerParty
    {
        private int NumberOfPeople;
        private decimal CostOfDecorations;
        private decimal CostOfBeveragesPerPerson;
        private const int CostOfFoodPerPerson = 25;

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecoration(fancy);
        }
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }

        }
        public void CalculateCostOfDecoration(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal result = CostOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople);

            if (healthyOption)
            {
               return result * .95M;
            }
            else
            {
                return result;
            }
        }
    }
}
