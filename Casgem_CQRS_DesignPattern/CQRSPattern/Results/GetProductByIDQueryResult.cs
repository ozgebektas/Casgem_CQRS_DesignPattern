﻿namespace Casgem_CQRS_DesignPattern.CQRSPattern.Results
{
    public class GetProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductMark { get; set; }
    }
}
