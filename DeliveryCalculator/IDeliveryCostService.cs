namespace DeliveryCalculator;

public interface IDeliveryCostService
{
    decimal Calculate(
        VolumeWeight volumeWeight,
        DeliveryType deliveryType);
}
