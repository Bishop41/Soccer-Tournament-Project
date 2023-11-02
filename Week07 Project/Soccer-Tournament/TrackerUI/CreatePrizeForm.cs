using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUI
{
    public partial class CreatePrizeform : Form
    {
        public CreatePrizeform()
        {
            InitiallizeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output =  true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            
            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool pricePercentageValid = int.TryParse(prizePercentageValue, out prizePercentage);

            if (prizeAmountValid == false || pricePercentageValid == false)
            {
                output = false;
            }
            if (prizeAmount <=0 && prizePercentage <= 0)
            {
                output = false;
                
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                
            }
            return output;


        }
    }
}    