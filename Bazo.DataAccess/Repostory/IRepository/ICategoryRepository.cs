﻿using BazoWebbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazo.DataAccess.Repostory.IRepository
{
    public interface ICategoryRepository : IRepository<Category>   
    {
        void Update(Category category);
        void save();
    }
}
