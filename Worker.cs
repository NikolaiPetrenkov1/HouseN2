using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    public interface IWorker
    {
        bool IsWorkFinish { get; }
        void Work(House house);
    }
}