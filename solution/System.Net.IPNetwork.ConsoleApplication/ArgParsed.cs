﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Net.IPNetwork.ConsoleApplication {
    public class ArgParsed {
        public int Arg;
        private event ArgParsedDelegate OnArgParsed;
        public delegate void ArgParsedDelegate(ProgramContext ac, string arg);

        public void Run(ProgramContext ac, string arg) {
            if (this.OnArgParsed != null) {
                this.OnArgParsed(ac, arg);
            }
        }

        public ArgParsed(int arg, ArgParsedDelegate onArgParsed) {
            this.Arg = arg;
            this.OnArgParsed += onArgParsed;
        }



    }
}
