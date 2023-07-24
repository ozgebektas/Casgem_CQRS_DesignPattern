using Casgem_CQRS_DesignPattern.CQRSPattern.Commands;
using CQRS.DataAccessLayer.Concrete;

namespace Casgem_CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Brand=command.Brand;
            values.Name=command.Name;   
            values.Price=command.Price;
            values.Stock=command.Stock;
            values.Category=command.Category;

            _context.SaveChanges();
        }
    }
}
