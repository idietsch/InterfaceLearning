using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning {
    public class Hello {

        ISpeakable Language;

        public void Speak() {
            Language.SayHello();
            Language.SayGoodbye();

        }


        public Hello(ISpeakable language) {
            Language = language;
        }

        //public void Say(int messageNumber) {
        //    Language.GetMessage();
        //}
    }
}
