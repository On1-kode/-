namespace DeliveryCalculator;

/// <summary>
/// ВАРІАНТ 1 — РАННЄ ЗВ'ЯЗУВАННЯ.
/// Сервіс сам створює конкретні класи (new ...DeliveryStrategy()) залежно від DeliveryType.
/// Змінні мають конкретні типи, тому виклик Calculate() визначається на етапі компіляції.
/// Сервіс жорстко залежить від усіх класів доставки: новий спосіб = зміна коду сервісу (switch).
/// </summary>
public class EarlyBindingDeliveryCostService : IDeliveryCostService
{
    public decimal Calculate(VolumeWeight volumeWeight, DeliveryType deliveryType)
    {
        switch (deliveryType)
        {
            case DeliveryType.Department:
                DepartmentDeliveryStrategy department = new DepartmentDeliveryStrategy();
                return department.Calculate(volumeWeight);

            case DeliveryType.Courier:
                CourierDeliveryStrategy courier = new CourierDeliveryStrategy();
                return courier.Calculate(volumeWeight);

            case DeliveryType.ExpressCourier:
                ExpressCourierDeliveryStrategy express = new ExpressCourierDeliveryStrategy();
                return express.Calculate(volumeWeight);

            default:
                throw new ArgumentOutOfRangeException(nameof(deliveryType), deliveryType, "Невідомий спосіб доставки.");
        }
    }
}
