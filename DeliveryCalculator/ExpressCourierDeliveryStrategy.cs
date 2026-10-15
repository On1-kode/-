namespace DeliveryCalculator;

// Експрес-доставка кур'єром додому: 120 грн + 24 грн за кг розрахункової ваги
public class ExpressCourierDeliveryStrategy : IDeliveryCostStrategy
{
    public DeliveryType DeliveryType => DeliveryType.ExpressCourier;

    public decimal Calculate(VolumeWeight volumeWeight)
    {
        return 120m + volumeWeight.ChargeableWeight * 24m;
    }
}
