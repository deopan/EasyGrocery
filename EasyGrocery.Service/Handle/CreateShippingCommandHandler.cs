using AutoMapper;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class CreateShippingCommandHandler : IRequestHandler<CreateShippingCommand, int>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public CreateShippingCommandHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateShippingCommand request, CancellationToken cancellationToken)
        {

            var result = await _shippingRepository.InsertShippingData(request.payload);
            return result;

        }
    }
}
