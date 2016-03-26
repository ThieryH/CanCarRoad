using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACanCarRoad
{
    public class CarInfo
    {
        string strPlate; 
        string strDate;
        string strTime;

        public CarInfo(string aPlate, string aDate, string aTime)
        {
            strPlate = aPlate;
            strDate = aDate;
            strTime = aTime;
        }

        public bool ValidationCanCarRoad()
        {
            bool blnResult = false;
            string strLastDigitPlate = strPlate.Substring(strPlate.Length - 1, 1);
            DateTime dtDate = Convert.ToDateTime(strDate);
            int intDay = (int)dtDate.DayOfWeek;
            
            switch (intDay)
            {
                case 1:
                    if (strLastDigitPlate == "1" || strLastDigitPlate == "2")
                        return ValidateHour();
                    break;
                case 2:
                    if (strLastDigitPlate == "3" || strLastDigitPlate == "4")
                        return ValidateHour();
                    break;
                case 3:
                    if (strLastDigitPlate == "5" || strLastDigitPlate == "6")
                        return ValidateHour();
                    break;
                case 4:
                    if (strLastDigitPlate == "7" || strLastDigitPlate == "8")
                        return ValidateHour();
                    break;
                case 5:
                    if (strLastDigitPlate == "9" || strLastDigitPlate == "0")
                        return ValidateHour();
                    break;
                default:
                    blnResult = true;
                    break;
            }
            return blnResult;
        }

        private bool ValidateHour()
        {
            string[] Time = strTime.Split(':');

            double douHour = double.Parse(Time[0]) + double.Parse(Time[1]) / 100;

            if ((douHour < 7 || douHour > 9.3) && (douHour < 16 || douHour > 19.3))
                return true;

            return false;
        }
    }
}
