using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    public class CWShop
    {
        public void AiZhou(List<DongWu> dongwus)
        {
            foreach (DongWu item in dongwus)
            {
                item.Jiao();
            }
        }
    }
}
