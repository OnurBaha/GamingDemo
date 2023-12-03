using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale (Gamer gamer, Sale sale, Campaign campaign);
    }
}
