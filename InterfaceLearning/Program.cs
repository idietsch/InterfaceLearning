﻿using System;
using System.Collections.Generic;

namespace InterfaceLearning {
    class Program {
        static void Main(string[] args) {

            var english = new EnglishHello();
            var spanish = new SpanishHello();
            var hello = new Hello(english);
            hello.Speak();
            var hello2 = new Hello(spanish);
            hello2.Speak();

            var hellofr = new Hello(new FrenchHello());
            hellofr.Speak();

            var hellolat = new Hello(new LatinHello());
            hellolat.Speak();

            

        }
        static void TestInterfaceWidgets() { 

            var w1 = new Widget();
            var aw = new AdvWidget();
            var sw = new SuperWidget();

            var widgets = new List<iPrintable>();
            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);

            foreach(var widget in widgets) {
                widget.Print();
            }
        }
    }
}
