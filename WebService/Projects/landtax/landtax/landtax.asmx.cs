using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace landtax
{
    /// <summary>
    /// Summary description for landtax
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class landtax : System.Web.Services.WebService
    {

        [WebMethod]
        // ที่ดินเพื่อพาณิชยกรรม
        public double CalculateIndustrialLandTax(double landValue)
        {
            if (landValue <= 50000000)
                return landValue * 0.003; // 0.3%
            else if (landValue <= 200000000)
                return landValue * 0.004; // 0.4%
            else if (landValue <= 1000000000)
                return landValue * 0.005; // 0.5%
            else if (landValue <= 5000000000)
                return landValue * 0.006; // 0.6%
            else
                return landValue * 0.007; // 0.7%
        }

        [WebMethod]
        // ที่ดินรกร้างว่างเปล่า
        public double CalculateVacantLandTax(double landValue)
        {
            if (landValue <= 50000000)
                return landValue * 0.003; // 0.3%
            else if (landValue <= 200000000)
                return landValue * 0.004; // 0.4%
            else if (landValue <= 1000000000)
                return landValue * 0.005; // 0.5%
            else if (landValue <= 5000000000)
                return landValue * 0.006; // 0.6%
            else
                return landValue * 0.007; // 0.7%
        }

        [WebMethod]
        //ที่ดินการเกษตรของบุคคลธรรมดา
        public decimal CalculateTaxForIndividual(decimal landValue, decimal buildingValue)
        {
            decimal totalValue = landValue + buildingValue;
            decimal taxRate = 0.0m;

            if (totalValue <= 50000000)
            {
                // ได้รับการยกเว้นภาษี
                return 0.0m;
            }
            else if (totalValue <= 125000000)
            {
                taxRate = 0.0001m; // 0.01%
            }
            else if (totalValue <= 150000000)
            {
                taxRate = 0.0003m; // 0.03%
            }
            else if (totalValue <= 550000000)
            {
                taxRate = 0.0005m; // 0.05%
            }
            else if (totalValue <= 1050000000)
            {
                taxRate = 0.0007m; // 0.07%
            }
            else
            {
                taxRate = 0.001m; // 0.1%
            }

            return totalValue * taxRate;
        }

        [WebMethod]
        //ที่ดินการเกษตรของนิตบุคคล
        public decimal CalculateTaxForLegalEntity(decimal landValue, decimal buildingValue)
        {
            decimal totalValue = landValue + buildingValue;
            decimal taxRate = 0.0m;

            if (totalValue <= 75000000)
            {
                taxRate = 0.0001m; // 0.01%
            }
            else if (totalValue <= 100000000)
            {
                taxRate = 0.0003m; // 0.03%
            }
            else if (totalValue <= 500000000)
            {
                taxRate = 0.0005m; // 0.05%
            }
            else if (totalValue <= 1000000000)
            {
                taxRate = 0.0007m; // 0.07%
            }
            else
            {
                taxRate = 0.001m; // 0.1%
            }

            return totalValue * taxRate;
        }

        [WebMethod]
            //ที่ดินที่อยู่อาศัย

        public decimal CalculateResidenceTax1(decimal landValue, decimal buildingValue)
            // บุคคลธรรมดาผู้เป็นเจ้าของที่ดินและสิ่งปลูกสร้างหลังเดียว
        {
            decimal totalValue = landValue + buildingValue;
            decimal taxRate = 0.0m;

            if (totalValue <= 50000000)
            {
                // ได้รับการยกเว้นภาษี
                return 0.0m;
            }
            else if (totalValue <= 75000000)
            {
                taxRate = 0.0003m; // 0.03%
            }
            else if (totalValue <= 100000000)
            {
                taxRate = 0.0005m; // 0.05%
            }
            else
            {
                taxRate = 0.001m; // 0.1%
            }

            return totalValue * taxRate;
        }
        [WebMethod]
        public decimal CalculateResidenceTax2(decimal landValue, decimal buildingValue)
        // บุคคลธรรมดาผู้เป็นเจ้าของเฉพาะสิ่งปลูกสร้างหลังเดียว
        {
            decimal totalValue = landValue + buildingValue;
            decimal taxRate = 0.0m;

            if (totalValue <= 10000000)
            {
                // ได้รับการยกเว้นภาษี
                return 0.0m;
            }
            else if (totalValue <= 50000000)
            {
                taxRate = 0.0002m; // 0.02%
            }
            else if (totalValue <= 75000000)
            {
                taxRate = 0.0003m; // 0.03%
            }
            else if (totalValue <= 100000000)
            {
                taxRate = 0.0005m; // 0.05%
            }
            else
            {
                taxRate = 0.001m; // 0.1%
            }

            return totalValue * taxRate;
        }
        [WebMethod]
        public decimal CalculateResidenceTax3(decimal landValue, decimal buildingValue)
        // บุคคลธรรมดาผู้เป็นเจ้าของที่ดินหรือสิ่งปลูกสร้าง 2 หลังขึ้นไป 
    {
        decimal totalValue = landValue + buildingValue;
        decimal taxRate = 0.0m;

        if (totalValue <= 50000000)
        {
            taxRate = 0.0002m; // 0.02%
        }
        else if (totalValue <= 75000000)
        {
            taxRate = 0.0003m; // 0.03%
        }
        else if (totalValue <= 100000000)
        {
            taxRate = 0.0005m; // 0.05%
        }
        else
        {
            taxRate = 0.001m; // 0.1%
        }

        return totalValue * taxRate;
    }
}
    }

    
