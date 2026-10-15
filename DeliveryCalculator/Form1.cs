namespace DeliveryCalculator;

public partial class Form1 : Form
{
    private readonly IDeliveryCostService _deliveryCostService;

    public Form1()
    {
        InitializeComponent();

        // Пізнє зв'язування (варіант 2): сервіс отримує стратегії через інтерфейс.
        _deliveryCostService = new DeliveryCostService(new IDeliveryCostStrategy[]
        {
            new DepartmentDeliveryStrategy(),
            new CourierDeliveryStrategy(),
            new ExpressCourierDeliveryStrategy()
        });

        // Раннє зв'язування (варіант 1) — щоб порівняти, замініть код вище на:
        // _deliveryCostService = new EarlyBindingDeliveryCostService();

        cmbDeliveryType.DataSource = new List<KeyValuePair<DeliveryType, string>>
        {
            new(DeliveryType.Department, "Доставка у відділення"),
            new(DeliveryType.Courier, "Кур'єром додому"),
            new(DeliveryType.ExpressCourier, "Експрес кур'єром додому")
        };
        cmbDeliveryType.DisplayMember = "Value";
        cmbDeliveryType.ValueMember = "Key";
        cmbDeliveryType.SelectedIndex = 0;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        var volumeWeight = new VolumeWeight
        {
            Weight = nudWeight.Value,
            Length = nudLength.Value,
            Width = nudWidth.Value,
            Height = nudHeight.Value
        };

        if (volumeWeight.Weight <= 0 || volumeWeight.Length <= 0 ||
            volumeWeight.Width <= 0 || volumeWeight.Height <= 0)
        {
            MessageBox.Show("Вага та розміри посилки мають бути більшими за нуль.",
                "Некоректні дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            lblStatus.Text = "Перевірте введені дані";
            return;
        }

        DeliveryType deliveryType = (DeliveryType)cmbDeliveryType.SelectedValue!;

        decimal price = _deliveryCostService.Calculate(
            volumeWeight,
            deliveryType);

        lblActualWeightValue.Text = $"{volumeWeight.Weight:0.##} кг";
        lblVolumetricWeightValue.Text = $"{volumeWeight.VolumetricWeight:0.##} кг";
        lblChargeableWeightValue.Text = $"{volumeWeight.ChargeableWeight:0.##} кг";
        lblDeliveryTypeValue.Text = cmbDeliveryType.Text;
        lblPrice.Text = $"{price:0.##} грн";
        lblStatus.Text = "Розрахунок виконано";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        nudWeight.Value = 0;
        nudLength.Value = 0;
        nudWidth.Value = 0;
        nudHeight.Value = 0;
        cmbDeliveryType.SelectedIndex = 0;

        lblActualWeightValue.Text = "—";
        lblVolumetricWeightValue.Text = "—";
        lblChargeableWeightValue.Text = "—";
        lblDeliveryTypeValue.Text = "—";
        lblPrice.Text = "— грн";
        lblStatus.Text = "Готово до розрахунку";
    }
}
