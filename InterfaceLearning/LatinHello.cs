using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning {
    class LatinHello : ISpeakable{
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Equo, Eques",
            [1] = "Salve",
            [2] = "Vale",
            [9999] = "nuntium non inveni"
        };

        public void SayHello() {
            Console.WriteLine("Salve");
        }
        public void SayGoodbye() {
            Console.WriteLine("Vale");
        }
        public string GetMessage(int MessageNumber) {
            if (!messages.ContainsKey(MessageNumber)) {
                return messages[9999];
            }
            return messages[MessageNumber];
        }
    }
}
