﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int colorId);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult Add(Car car);
    }
}
