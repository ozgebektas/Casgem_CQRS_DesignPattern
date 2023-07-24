﻿using Casgem_CQRS_DesignPattern.CQRSPattern.Results;
using CQRS.DataAccessLayer.Concrete;

namespace Casgem_CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values=_context.Products.Select(x=>new GetProductQueryResult
            {
                Brand=x.Brand,
                Category=x.Category,
                Name=x.Name,
                Price=x.Price,
                ProductID=x.ProductID,
                Stock=x.Stock,
            }).ToList();
               
                return values;
            }
        }
    }

