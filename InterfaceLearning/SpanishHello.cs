using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning {
    class SpanishHello : ISpeakable {
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Poni vaquero",
            [1] = "Hola",
            [2] = "Adios",
            [9999] = "Mensaje no encontrado"
        };

        public void SayHello() {
            Console.WriteLine("Hola");
        }
        public void SayGoodbye() {
            Console.WriteLine("Adios");
        }
        public string GetMessage(int MessageNumber) {
            if (!messages.ContainsKey(MessageNumber)) {
                return messages[9999];
            }
            return messages[MessageNumber];
        }
    }
}
