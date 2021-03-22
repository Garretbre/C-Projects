using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Net;
using System.Net.Mail;
using Microsoft.Graph;

namespace CarInsurance
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
       protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage();
        msg.To.Add(txtto.Text);
        msg.From = new MailAddress("grretb@gmail.com", "instructor@learncodinganywhere.com");
        msg.Subject = "Sending App_Data";
        msg.Body = Folder.App_Data;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "relay-hosting.secureserver.net";
        smtp.Port = 25;
        smtp.Credentials = new System.Net.NetworkCredential"grretb@gmail.com", "Password");
        smtp.Send(msg);
        lblmsg.Text = "Message Send Successfully";


    }
}
