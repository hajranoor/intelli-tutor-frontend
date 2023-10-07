using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend
{
    internal interface compilerInterface
    {
        string CompileCode(string code);
        string compileType1(string startercode, string code, string trigger);
    }
}
