﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donation1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"]== null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void DonationButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation a = new Donation();
        a.DonationAmount = Decimal.Parse(DonationTextBox.Text);
        a.DonationDate = DateTime.Now;
        a.PersonKey = (int)Session["PersonKey"];

        db.Donations.Add(a);
        db.SaveChanges();

        Response.Redirect("DonationList.aspx");


    }
}