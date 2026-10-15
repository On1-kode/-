namespace DeliveryCalculator;

/// <summary>
/// ВАРІАНТ 2 — ПІЗНЄ ЗВ'ЯЗУВАННЯ.
/// Сервіс працює лише з інтерфейсом IDeliveryCostStrategy і нічого не знає про конкретні класи.
/// У виклику strategy.Calculate(volumeWeight) змінна має тип інтерфейсу,
/// а яка саме реалізація виконається — визначається під час роботи програми
/// за фактичним типом об'єкта.
/// Новий спосіб доставки = новий клас-стратегія, сервіс не змінюється.
/// </summary>
public class DeliveryCostService : IDeliveryCostService
{
    private readonly Dictionary<DeliveryType, IDeliveryCostStrategy> _strategies;

    public DeliveryCostService(IEnumerable<IDeliveryCostStrategy> strategies)
    {
        _strategies = strategies.ToDictionary(s => s.DeliveryType);
    }

    public decimal Calculate(VolumeWeight volumeWeight, DeliveryType deliveryType)
    {
        if (!_strategies.TryGetValue(deliveryType, out IDeliveryCostStrategy? strategy))
        {
            throw new ArgumentOutOfRangeException(nameof(deliveryType), deliveryType, "Для цього способу доставки немає стратегії.");
        }

        return strategy.Calculate(volumeWeight);
    }
}
