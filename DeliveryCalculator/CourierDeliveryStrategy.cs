namespace DeliveryCalculator;

// Доставка кур'єром додому: 80 грн + 15 грн за кг розрахункової ваги
public class CourierDeliveryStrategy : IDeliveryCostStrategy
{
    public DeliveryType DeliveryType => DeliveryType.Courier;

    public decimal Calculate(VolumeWeight volumeWeight)
    {
        return 80m + volumeWeight.ChargeableWeight * 15m;
    }
}
