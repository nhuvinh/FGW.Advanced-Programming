using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Builder
    {
        // Template method
        public void Build()
        {
            Test();
            Lint();
            Assemble();
            Deploy();
        }

        abstract public void Test();
        abstract public void Lint();
        abstract public void Assemble();
        abstract public void Deploy();
    }
}
