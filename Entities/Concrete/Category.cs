using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
