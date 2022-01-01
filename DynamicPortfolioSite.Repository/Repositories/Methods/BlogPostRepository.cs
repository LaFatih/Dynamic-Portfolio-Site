﻿using DynamicPortfolioSite.Entities.Entities;
using DynamicPortfolioSite.Entities.Models.Blog;
using DynamicPortfolioSite.Repository.Contexts;
using DynamicPortfolioSite.Repository.DataAccess.EntityFramework;
using DynamicPortfolioSite.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicPortfolioSite.Repository.Repositories.Methods
{
    public class BlogPostRepository : EfCoreEntityRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<BlogPost>> CustomSearchAsync(BlogCustomSearchModel model)
        {
            var iQueryableData = _entities.AsQueryable().Where(i => i.IsActive);

            if (model.CreateDateRange_Start != default && model.CreateDateRange_End != default)
            {
                iQueryableData = iQueryableData.Where(i => i.CreatedDate >= model.CreateDateRange_Start && i.CreatedDate <= model.CreateDateRange_End);
            }

            return await iQueryableData.ToListAsync();
        }
    }
}
