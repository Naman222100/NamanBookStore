﻿using NamanBooks.DataAccess.Repository.IRepository;
using NamanBooks.Models;
using NamanBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamanBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update( Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.ID == category.ID); 
            if (objFromDb !=null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
            throw new NotImplementedException();
        }
    }
}
