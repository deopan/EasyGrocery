using AutoMapper;
using Dapper;
using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Repository.DataModel;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EasyGrocery.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        protected readonly IDbConnectionFactory _dbConnectionFactory;
        protected readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public OrderDetailRepository(IDbConnectionFactory dbConnectionFactory, IConfiguration configuration, IMapper mapper)
        {
            _dbConnectionFactory = dbConnectionFactory;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<bool> AddOrderDetail(List<OrderDetailEntity> orderDetailEntity)
        {
            var orderdetailModal = _mapper.Map<List<OrderDetailDataModel>>(orderDetailEntity);


            using (IDbConnection dbConnection = _dbConnectionFactory.CreateConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                dbConnection.Open();

                using (var transaction = dbConnection.BeginTransaction())
                {
                    // Execute the insert query for each row in the DataTable
                    foreach (var row in orderdetailModal)
                    {
                        dbConnection.Execute(OrderDetailDataModel.InsertQuery, row, transaction);
                    }

                    transaction.Commit();
                }
            }

            return  true;
        }
 

        
    }
}
