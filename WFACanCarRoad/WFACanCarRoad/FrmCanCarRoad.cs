using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACanCarRoad
{
    public partial class FrmCanCarRoad : Form
    {
        public FrmCanCarRoad()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string strMessage = string.Empty;
            string strPlate = mtxPlate.Text;

            if (strPlate == string.Empty || strPlate == "   -" || strPlate.Length <= 7)
            {
                strMessage = "Input the license plate number";
                lblResult.Text = strMessage;
                erPError.SetError(mtxPlate, "Invalid Plate Number");
                lblResult.ForeColor = Color.Orange;
                return;
            }
            else
                erPError.SetError(mtxPlate, "");



            string strDate = mtxDate.Text;

            if (strDate == string.Empty || strDate == "" || strDate.Length <= 7)
            {

                strMessage = "Input the date";
                lblResult.Text = strMessage;
                erPError.SetError(mtxDate, "Invalid Date");
                lblResult.ForeColor = Color.Orange;
                return;
            }
            else
            {
                try
                { DateTime dtAux = Convert.ToDateTime(strDate); }
                catch
                {
                    strMessage = "Input the date";
                    lblResult.Text = strMessage;
                    erPError.SetError(mtxDate, "Invalid Date");
                    lblResult.ForeColor = Color.Orange;
                    return;
                }
                erPError.SetError(mtxDate, "");
            }


            string strTime = mtxTime.Text;

            if (strTime == string.Empty || strDate == "" || strTime.Length <= 3)
            {
                strMessage = "Input the time";
                lblResult.Text = strMessage;
                erPError.SetError(mtxTime, "Invalid Date");
                lblResult.ForeColor = Color.Orange;
                return;
            }
            else
                erPError.SetError(mtxTime, "");

            CarInfo objCar = new CarInfo(strPlate, strDate, strTime);

            if (objCar.ValidationCanCarRoad())
            {
                strMessage = "Car can be on road";
                lblResult.Text = strMessage;
                lblResult.ForeColor = Color.Blue;
                return;
            }
            {
                strMessage = "Car can NOT be on road";
                lblResult.Text = strMessage;
                lblResult.ForeColor = Color.Red;
                return;
            }
        }
    }
}
