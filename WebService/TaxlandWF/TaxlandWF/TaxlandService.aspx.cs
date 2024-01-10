using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Text;
using System.Xml;
using System.Xml.Linq;

using System.Data;


namespace TaxlandWF
{
    public partial class TaxlandService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            XElement xelement = XElement.Load(Server.MapPath("~/App_Data/TaxlandService.xml"));

            var name = from nm in xelement.Elements("Car")

                       where (string)nm.Element("Location") == ddlLocation.Text

                       select nm;

            Response.Write("รถทั้งหมดในสาขา : " + ddlLocation.Text);

            foreach (XElement xEle in name)

                Response.Write("<br><br>" + xEle);
        }
        protected void btnBrand_Click(object sender, EventArgs e)
        {
            XElement xelement = XElement.Load(Server.MapPath("~/App_Data/TaxlandService.xml"));

            var name = from nm in xelement.Elements("Car")

                       where (string)nm.Element("Brand") == ddlBrand.Text

                       select nm;

            Response.Write("รถยี่ห้อ : " + ddlBrand.Text);

            foreach (XElement xEle in name)

                Response.Write("<br><br>" + xEle);
        }
        protected void btnBrandSection_Click(object sender, EventArgs e)
        {
            XElement xelement = XElement.Load(Server.MapPath("~/App_Data/TaxlandService.xml"));

            var name = from nm in xelement.Elements("Car")

                       where (string)nm.Element("Brand") == ddlBrand.Text && (string)nm.Element("Location") == ddlLocation.Text

                       select nm;

            Response.Write("รถยี่ห้อ : " + ddlBrand.Text);

            foreach (XElement xEle in name)

                Response.Write("<br><br>" + xEle);
        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            localhost.landtax myService = new localhost.landtax();

            double payInterest = myService.CalculateIndustrialLandTax(Convert.ToDouble(ddlYear.Text), Convert.ToDouble(txtPrice.Text));

            double price = Convert.ToDouble(txtPrice.Text);
            double totalPrice = price + payInterest;

            double downPayment = Convert.ToDouble(txtDown.Text);

            double finalPrice = totalPrice - downPayment;

            double fiveYears = finalPrice / 60;
            string fiveYearsString = String.Format("{0:0,0.00}", fiveYears);
            lbl5Years.Text = fiveYearsString;

            double fourYears = finalPrice / 48;
            string fourYearsString = String.Format("{0:0,0.00}", fourYears);
            lbl4Years.Text = fourYearsString;

            double threeYears = finalPrice / 36;
            string threeYearsString = String.Format("{0:0,0.00}", threeYears);
            lbl3Years.Text = threeYearsString;

            double twoYears = finalPrice / 24;
            string twoYearsString = String.Format("{0:0,0.00}", twoYears);
            lbl2Years.Text = twoYearsString;

            if (Convert.ToDouble(ddlYear.Text) >= 2014 && Convert.ToDouble(ddlYear.Text) <= 2018)
            {
                lblShowInterest.Text = "ดอกเบี้ย 3.85% ต่อปี";
            }
            else if (Convert.ToDouble(ddlYear.Text) >= 2009 && Convert.ToDouble(ddlYear.Text) <= 2013)
            {
                lblShowInterest.Text = "ดอกเบี้ย 4.14% ต่อปี";
            }
            else
            {
                lblShowInterest.Text = "ดอกเบี้ย 4.5% ต่อปี";
            }

        }
}