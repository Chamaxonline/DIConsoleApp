using System;
using System.Collections.Generic;
using System.Text;

namespace DIConsole
{
    public class GuidGenerator
    {
        public Guid Generate { get; set; } = Guid.NewGuid();
    }
}
