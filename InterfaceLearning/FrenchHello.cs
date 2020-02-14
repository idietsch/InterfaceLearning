using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning {
    class FrenchHello : ISpeakable{
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Poney jusqu'a, cowboy",
            [1] = "Bonjour",
            [2] = "au revoir",
            [9999] = "Message Non Trouve"
        };

        public void SayHello() {
            Console.WriteLine("Bonjour");
        }
        public void SayGoodbye() {
            Console.WriteLine("Au revoir");
        }
        public string GetMessage(int MessageNumber) {
            if (!messages.ContainsKey(MessageNumber)) {
                return messages[9999];
            }
            return messages[MessageNumber];
        }
    }
}
