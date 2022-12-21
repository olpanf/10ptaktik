using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    internal interface CRUD
    {
        void Create();
        void Read();
        void Update();
        void Delete(int Massiv);
    }
}
