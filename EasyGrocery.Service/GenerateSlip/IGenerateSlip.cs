using EasyGrocery.Common.Entities;

namespace ESasyGrocery.Service.Validation
{
    public interface IGenerateSlip
    {
        bool GeneratePdf(ShippingSlipEntity order);

    }
}
