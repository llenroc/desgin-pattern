﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
    abstract class PersonAbstractFactory
    {
        public abstract IPerson GetPerson();
    }
}
