﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Category
    {
       [Key]
       public int CategoryID { get; set; }
       public string CategoryName { get; set; }
       public string Description { get; set; }
       public string Picture { get; set; }

    }
}