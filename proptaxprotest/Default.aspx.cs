using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendMail(object sender, EventArgs e)

    {
        if (!IsValid)
        {
            return;
        }
        else
        {



            MailMessage mail = new MailMessage();


            mail.From = new MailAddress(EmailTB.Text);
            mail.To.Add("leads.proptaxprotest@gmail.com");
            mail.Subject = "NEW LEAD - " + PropertyTB.Text;
            mail.IsBodyHtml = true;
            mail.Body = "First Name: " + FNameTB.Text + "<br />";
            mail.Body += "Last Name: " + LNameTB.Text + "<br />";
            mail.Body += "Email: " + EmailTB.Text + "<br />";
            mail.Body += "Phone Number: " + PhoneTB.Text + "<br />";
            mail.Body += "Comments: " + CommentsTB.Text + "<br />";


            SmtpClient client = new SmtpClient();

            client.Send(mail);

            try
            {
                formPH.Visible = false;
                sucessPH.Visible = true;
            }

            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }



        }
    }
    protected void Reset(object s, EventArgs e)
    {
        PropertyTB.Text = "";
        FNameTB.Text = "";
        LNameTB.Text = "";
        EmailTB.Text = "";
        CommentsTB.Text = "";
    }
}
