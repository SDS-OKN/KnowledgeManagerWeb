using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManagerOnline
{
    using Microsoft.JSInterop;

    public class HelloHelper
    {
        public HelloHelper(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        [JSInvokable]
        public string GetHelloMessage() => $"Hello, {Name}!";
    }
}
