﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQLTest.Abstraction
{
 public   interface IEntity
    {
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
    }
}
