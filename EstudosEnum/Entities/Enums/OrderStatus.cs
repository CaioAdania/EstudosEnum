namespace EstudosEnum.Entities.Enums
{
    enum OrderStatus : int //derivação de tipo
    {
        PendingPayments = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}