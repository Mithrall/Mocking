using System;

namespace Mocking {
    public class User {
        public User() {
        }
        internal Rights Rights { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int NumMessagesCreated { get; internal set; }

        internal string ViewAllEmployees() {
            return "Here is the list";
        }
    }
}