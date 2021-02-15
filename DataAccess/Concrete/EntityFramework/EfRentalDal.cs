using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.Id equals c.Id
                             join u in context.Users on r.Id equals u.Id
                             join b in context.Brands on r.Id equals b.BrandId
                             join co in context.Colors on r.Id equals co.ColorId
                             join cu in context.Customers on r.Id equals cu.UserId
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 ColorName = co.ColorName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
