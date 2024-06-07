using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "In asteptare")]
        Pending,

        [EnumMember(Value = "Plata confirmata")]
        PaymentReceived,

        [EnumMember(Value = "Plata esuata")]
        PaymentFailed
    }
}