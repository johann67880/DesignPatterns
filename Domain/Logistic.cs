using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Logistic
    {
        public abstract ITransport CreateTransport(string transport);
    }
}
