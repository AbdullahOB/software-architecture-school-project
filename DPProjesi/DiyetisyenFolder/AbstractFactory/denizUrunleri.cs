﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjesi.DiyetisyenFolder.AbstractFactory.YontemInterface;
namespace DPProjesi.DiyetisyenFolder.AbstractFactory
{
    class denizUrunleri : IDiyetYontem
    {
        public string Name => "Deniz Ürünleri";
    }
}
