using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Console.ApiControllers
{
    public class MailController : ApiController
    {
        public IHttpActionResult Get(string folder)
        {
            try
            {
                List<Mail> mails = new List<Mail>()
                {
                    new Mail(){Id = 1,From = "X", To= "Y", Subject = "Subject", Date = DateTime.Now},
                    new Mail(){Id = 2,From = "X", To= "Y", Subject = "Subject", Date = DateTime.Now},
                    new Mail(){Id = 3,From = "X", To= "Y", Subject = "Subject", Date = DateTime.Now}
                };
                var responseMsg = Request.CreateResponse(HttpStatusCode.OK, mails);
                return ResponseMessage(responseMsg);
            }
            catch (Exception ex)
            {
                throw new Exception("MailController::Get: Error " + ex.Message, ex);
            }
        }


        public IHttpActionResult GetMailById(string mailId)
        {
            try
            {
                var mail = new Mail() { Id = 1, From = "X", To = "Y", Subject = "Subject", Date = DateTime.Now,MessageContent="test" };
                var responseMsg = Request.CreateResponse(HttpStatusCode.OK, mail);
                return ResponseMessage(responseMsg);
            }
            catch (Exception ex)
            {
                throw new Exception("MailController::Get: Error " + ex.Message, ex);
            }
        }
    }

    public class Mail
    {
        public int Id { set; get; }

        public string From { set; get; }

        public string To { set; get; }

        public string Subject { set; get; }

        public DateTime Date { set; get; }


        public string MessageContent { set; get; }
    }
}
