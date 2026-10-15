namespace DeliveryCalculator;

// Доставка у відділення: 40 грн + 10 грн за кг розрахункової ваги
public class DepartmentDeliveryStrategy : IDeliveryCostStrategy
{
    public DeliveryType DeliveryType => DeliveryType.Department;

    public decimal Calculate(VolumeWeight volumeWeight)
    {
        return 40m + volumeWeight.ChargeableWeight * 10m;
    }
}
