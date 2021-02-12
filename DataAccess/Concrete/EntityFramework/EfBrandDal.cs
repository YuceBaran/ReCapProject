﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.EfBrand
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>,IBrandDal
    {
        
    }
}