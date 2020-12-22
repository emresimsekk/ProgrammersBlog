﻿using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryListDto:DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}
