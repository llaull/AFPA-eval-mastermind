﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    /// <summary>
    /// C'est de la balle! vive github
    /// Ah non c'est la cata en fait... j'aime bien le hobie cat
    /// </summary>
    class RandoNumber
    {
        Random random = new Random(DateTime.Now.Millisecond);
        
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, (max+1));
        }
    }
}
