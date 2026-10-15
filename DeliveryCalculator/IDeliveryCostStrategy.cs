namespace DeliveryCalculator;

public interface IDeliveryCostStrategy
{
    DeliveryType DeliveryType { get; }

    decimal Calculate(VolumeWeight volumeWeight);
}
