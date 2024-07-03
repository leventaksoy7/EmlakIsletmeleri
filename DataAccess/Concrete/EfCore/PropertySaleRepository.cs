﻿using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class PropertySaleRepository : GenericRepository<PropertySale>, IPropertySaleRepository
    {
        public PropertySaleRepository(EfContext context) : base(context)
        {
        }
    }
}
