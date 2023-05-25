﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Data;
using SalesMVC.Models;

namespace SalesMVC.Services
{
    public class SellerService
    {
        private readonly SalesMVCContext _context;
        public SellerService(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
