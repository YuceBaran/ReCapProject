using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //        new Car {Id=1, BrandId=1,ColorId=1,DailyPrice=250000,ModelYear=2015,Description="M.CLA"},
        //        new Car {Id=2, BrandId=1,ColorId=1,DailyPrice=700000,ModelYear=2020,Description="M.Classe E"},
        //        new Car {Id=3, BrandId=2,ColorId=2,DailyPrice=1000000,ModelYear=2015,Description="C.Impala"},
        //        new Car {Id=4, BrandId=3,ColorId=1,DailyPrice=200000,ModelYear=2015,Description="A.A6"},
        //        new Car {Id=5, BrandId=4,ColorId=2,DailyPrice=1000000,ModelYear=1967,Description="F.Mustang Sheelby"}
        //    };
        //}
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carUpToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
