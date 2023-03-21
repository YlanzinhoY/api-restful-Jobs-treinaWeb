using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs.Core.Models;
using TWJobs.Core.Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using TWJobs. Api. Jobs. Dtos;

namespace TWJobs.Core.Repositories.Jobs;

    public class JobRepository : IJobRepository
    {
        private readonly TWJobsDbContext _context;

        public JobRepository(TWJobsDbContext context)
        {
            _context = context;
        }

        public Job Create(Job model)
        {
            _context.Jobs.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteById(int id)
        {
            var job = _context.Jobs.Find(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                _context.SaveChanges();
            }
        }

        public bool ExistsById(int id)
        {
            return _context.Jobs.Any(j => j.Id == id);
        }

        public ICollection<Job> FindAll()
        {
        return _context.Jobs.AsNoTracking().ToList();
        }

    public PagedResult<Job> FindAll ( PaginationOptions options )
    {
        var totalElements = _context.Jobs.Count();
        var items = _context.Jobs.Skip((options.PageNumber - 1) * options.PageSize).
        Take(options.PageSize).ToList();
        return new PagedResult<Job>(items, options.PageNumber, options.PageSize, totalElements);
    }

    public Job FindById(int id)
        {
            return _context.Jobs.AsNoTracking().FirstOrDefault(j => j.Id == id);
        }

    public Job Update(Job model)
        {
            _context.Jobs.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
