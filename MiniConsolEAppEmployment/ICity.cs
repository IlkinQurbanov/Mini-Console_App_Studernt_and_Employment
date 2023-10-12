using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsolEAppEmployment
{
    public interface ICity
    {
        void AddHuman(Human human);
        IEnumerable<Human> SearchHumans(string name);
    }

}
