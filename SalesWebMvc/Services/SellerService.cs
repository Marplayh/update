﻿using System;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services
{
    public class SellerService
    {

        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
    }
}
