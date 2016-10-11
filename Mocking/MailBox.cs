using System;
using System.Collections.Generic;
using System.Linq;

namespace Mocking {
    public class MailBox : IMailModule {
        
        List<Mail> mail = new List<Mail>();

        public MailBox() {
        }

        public int NumReceivedMessages { get; set; }

        public void Add(Mail o) {
            mail.Add(o);
            NumReceivedMessages++;
        }

        public void AddToDraft(Mail mail) {
            throw new NotImplementedException();
        }

        public void AddToSentMessages(Mail mail) {
            throw new NotImplementedException();
        }

        public void AddToSentSpam(Mail mail) {
            throw new NotImplementedException();
        }

        public List<Mail> GetAllMail() {
            throw new NotImplementedException();
        }

        public Mail GetEmailById(int id) {
            throw new NotImplementedException();
        }

        public string GetLatestMessageText() {
            int antal = mail.Count();
            string res = mail[antal - 1].Content;
            return res;
        }

        public void SendMail(Mail mail, Employee employee) {
            throw new NotImplementedException();
        }
    }
}