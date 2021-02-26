﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()  //ctor Constructor blogu
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=300,Description="Family car"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=400,Description="Classic car"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=500,Description="Super car"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2018,DailyPrice=450,Description="Sports car"},
                new Car{Id=5,BrandId=3,ColorId=3,ModelYear=2005,DailyPrice=350,Description="Single door car"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
