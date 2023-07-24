using Casgem_CQRS_DesignPattern.CQRSPattern.Queries;
using Casgem_CQRS_DesignPattern.CQRSPattern.Results;
using CQRS.DataAccessLayer.Concrete;

namespace Casgem_CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values=_context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductMark = values.Brand,
                ProductName = values.Name
            };
        }
    }
}
