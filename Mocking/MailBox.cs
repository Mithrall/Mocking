using System;
using System.Collections.Generic;
using System.Linq;

namespace Mocking {
    public class MailBox {
        
        List<Mail> mail = new List<Mail>();

        public MailBox() {
        }

        public int NumReceivedMessages { get; set; }

        public void Add(Mail o) {
            mail.Add(o);
            NumReceivedMessages++;
        }

        public string GetLatestMessageText() {
            int antal = mail.Count();
            string res = mail[antal - 1].Content;            
            return res;
        }
    }
}