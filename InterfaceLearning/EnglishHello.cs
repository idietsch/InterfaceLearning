using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning {
    class EnglishHello : ISpeakable {

        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Pony up, cowboy",
            [1] = "Hello",
            [2] = "See ya",
            [9999] = "Message Not Found"
        };
        
        public void SayHello() {
            Console.WriteLine("Hello");            
        }
        public void SayGoodbye() {
            Console.WriteLine("Bye");
        }
        //public string GetMessage(int MessageNumber) {
        //    if (!messages.ContainsKey(MessageNumber)) {
        //        return messages[9999];
        //   }
        //    return messages[MessageNumber];
        //}
    }
}
