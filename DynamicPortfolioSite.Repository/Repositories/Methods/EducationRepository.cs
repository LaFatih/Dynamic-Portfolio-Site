﻿using DynamicPortfolioSite.Entities.Entities;
using DynamicPortfolioSite.Repository.Contexts;
using DynamicPortfolioSite.Repository.DataAccess.EntityFramework;
using DynamicPortfolioSite.Repository.Repositories.Interfaces;

namespace DynamicPortfolioSite.Repository.Repositories.Methods
{
    public class EducationRepository : EfCoreEntityRepository<Education>, IEducationRepository
    {
        public EducationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
