namespace DeliveryCalculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {

        this.grpParams = new System.Windows.Forms.GroupBox();
        this.lblFormula = new System.Windows.Forms.Label();
        this.lblWeight = new System.Windows.Forms.Label();
        this.nudWeight = new System.Windows.Forms.NumericUpDown();
        this.lblLength = new System.Windows.Forms.Label();
        this.nudLength = new System.Windows.Forms.NumericUpDown();
        this.lblWidth = new System.Windows.Forms.Label();
        this.nudWidth = new System.Windows.Forms.NumericUpDown();
        this.lblHeight = new System.Windows.Forms.Label();
        this.nudHeight = new System.Windows.Forms.NumericUpDown();
        this.grpMethod = new System.Windows.Forms.GroupBox();
        this.cmbDeliveryType = new System.Windows.Forms.ComboBox();
        this.btnCalculate = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.grpResult = new System.Windows.Forms.GroupBox();
        this.lblActualWeight = new System.Windows.Forms.Label();
        this.lblActualWeightValue = new System.Windows.Forms.Label();
        this.lblVolumetricWeight = new System.Windows.Forms.Label();
        this.lblVolumetricWeightValue = new System.Windows.Forms.Label();
        this.lblChargeableWeight = new System.Windows.Forms.Label();
        this.lblChargeableWeightValue = new System.Windows.Forms.Label();
        this.lblDeliveryType = new System.Windows.Forms.Label();
        this.lblDeliveryTypeValue = new System.Windows.Forms.Label();
        this.pnlPrice = new System.Windows.Forms.Panel();
        this.lblPriceCaption = new System.Windows.Forms.Label();
        this.lblPrice = new System.Windows.Forms.Label();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
        this.grpParams.SuspendLayout();
        this.grpMethod.SuspendLayout();
        this.grpResult.SuspendLayout();
        this.pnlPrice.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
        this.SuspendLayout();
        // grpParams
        this.grpParams.Location = new System.Drawing.Point(12, 12);
        this.grpParams.Name = "grpParams";
        this.grpParams.Size = new System.Drawing.Size(340, 220);
        this.grpParams.TabIndex = 0;
        this.grpParams.TabStop = false;
        this.grpParams.Text = "Параметри посилки";
        this.grpParams.Controls.Add(this.lblWeight);
        this.grpParams.Controls.Add(this.nudWeight);
        this.grpParams.Controls.Add(this.lblLength);
        this.grpParams.Controls.Add(this.nudLength);
        this.grpParams.Controls.Add(this.lblWidth);
        this.grpParams.Controls.Add(this.nudWidth);
        this.grpParams.Controls.Add(this.lblHeight);
        this.grpParams.Controls.Add(this.nudHeight);
        this.grpParams.Controls.Add(this.lblFormula);
        // lblWeight
        this.lblWeight.AutoSize = true;
        this.lblWeight.Location = new System.Drawing.Point(15, 33);
        this.lblWeight.Name = "lblWeight";
        this.lblWeight.Text = "Вага, кг";
        // nudWeight
        this.nudWeight.DecimalPlaces = 2;
        this.nudWeight.Location = new System.Drawing.Point(150, 30);
        this.nudWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.nudWeight.Name = "nudWeight";
        this.nudWeight.Size = new System.Drawing.Size(170, 27);
        this.nudWeight.TabIndex = 0;
        this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // lblLength
        this.lblLength.AutoSize = true;
        this.lblLength.Location = new System.Drawing.Point(15, 71);
        this.lblLength.Name = "lblLength";
        this.lblLength.Text = "Довжина, см";
        // nudLength
        this.nudLength.DecimalPlaces = 2;
        this.nudLength.Location = new System.Drawing.Point(150, 68);
        this.nudLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.nudLength.Name = "nudLength";
        this.nudLength.Size = new System.Drawing.Size(170, 27);
        this.nudLength.TabIndex = 1;
        this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // lblWidth
        this.lblWidth.AutoSize = true;
        this.lblWidth.Location = new System.Drawing.Point(15, 109);
        this.lblWidth.Name = "lblWidth";
        this.lblWidth.Text = "Ширина, см";
        // nudWidth
        this.nudWidth.DecimalPlaces = 2;
        this.nudWidth.Location = new System.Drawing.Point(150, 106);
        this.nudWidth.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.nudWidth.Name = "nudWidth";
        this.nudWidth.Size = new System.Drawing.Size(170, 27);
        this.nudWidth.TabIndex = 2;
        this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // lblHeight
        this.lblHeight.AutoSize = true;
        this.lblHeight.Location = new System.Drawing.Point(15, 147);
        this.lblHeight.Name = "lblHeight";
        this.lblHeight.Text = "Висота, см";
        // nudHeight
        this.nudHeight.DecimalPlaces = 2;
        this.nudHeight.Location = new System.Drawing.Point(150, 144);
        this.nudHeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.nudHeight.Name = "nudHeight";
        this.nudHeight.Size = new System.Drawing.Size(170, 27);
        this.nudHeight.TabIndex = 3;
        this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // lblFormula
        this.lblFormula.AutoSize = true;
        this.lblFormula.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblFormula.Location = new System.Drawing.Point(15, 188);
        this.lblFormula.Name = "lblFormula";
        this.lblFormula.Text = "Об'ємна вага = (Д × Ш × В) / 4000";
        // grpMethod
        this.grpMethod.Controls.Add(this.cmbDeliveryType);
        this.grpMethod.Location = new System.Drawing.Point(12, 242);
        this.grpMethod.Name = "grpMethod";
        this.grpMethod.Size = new System.Drawing.Size(340, 75);
        this.grpMethod.TabIndex = 1;
        this.grpMethod.TabStop = false;
        this.grpMethod.Text = "Спосіб доставки";
        // cmbDeliveryType
        this.cmbDeliveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbDeliveryType.FormattingEnabled = true;
        this.cmbDeliveryType.Location = new System.Drawing.Point(15, 30);
        this.cmbDeliveryType.Name = "cmbDeliveryType";
        this.cmbDeliveryType.Size = new System.Drawing.Size(305, 28);
        this.cmbDeliveryType.TabIndex = 0;
        // btnCalculate
        this.btnCalculate.Location = new System.Drawing.Point(12, 330);
        this.btnCalculate.Name = "btnCalculate";
        this.btnCalculate.Size = new System.Drawing.Size(165, 40);
        this.btnCalculate.TabIndex = 2;
        this.btnCalculate.Text = "Розрахувати";
        this.btnCalculate.UseVisualStyleBackColor = true;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        // btnClear
        this.btnClear.Location = new System.Drawing.Point(187, 330);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(165, 40);
        this.btnClear.TabIndex = 3;
        this.btnClear.Text = "Очистити";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // grpResult
        this.grpResult.Location = new System.Drawing.Point(365, 12);
        this.grpResult.Name = "grpResult";
        this.grpResult.Size = new System.Drawing.Size(375, 358);
        this.grpResult.TabIndex = 4;
        this.grpResult.TabStop = false;
        this.grpResult.Text = "Результат";
        this.grpResult.Controls.Add(this.lblActualWeight);
        this.grpResult.Controls.Add(this.lblActualWeightValue);
        // lblActualWeight
        this.lblActualWeight.AutoSize = true;
        this.lblActualWeight.Location = new System.Drawing.Point(15, 35);
        this.lblActualWeight.Name = "lblActualWeight";
        this.lblActualWeight.Text = "Фактична вага:";
        // lblActualWeightValue
        this.lblActualWeightValue.AutoSize = true;
        this.lblActualWeightValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblActualWeightValue.Location = new System.Drawing.Point(190, 35);
        this.lblActualWeightValue.Name = "lblActualWeightValue";
        this.lblActualWeightValue.Text = "—";
        this.grpResult.Controls.Add(this.lblVolumetricWeight);
        this.grpResult.Controls.Add(this.lblVolumetricWeightValue);
        // lblVolumetricWeight
        this.lblVolumetricWeight.AutoSize = true;
        this.lblVolumetricWeight.Location = new System.Drawing.Point(15, 80);
        this.lblVolumetricWeight.Name = "lblVolumetricWeight";
        this.lblVolumetricWeight.Text = "Об'ємна вага:";
        // lblVolumetricWeightValue
        this.lblVolumetricWeightValue.AutoSize = true;
        this.lblVolumetricWeightValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblVolumetricWeightValue.Location = new System.Drawing.Point(190, 80);
        this.lblVolumetricWeightValue.Name = "lblVolumetricWeightValue";
        this.lblVolumetricWeightValue.Text = "—";
        this.grpResult.Controls.Add(this.lblChargeableWeight);
        this.grpResult.Controls.Add(this.lblChargeableWeightValue);
        // lblChargeableWeight
        this.lblChargeableWeight.AutoSize = true;
        this.lblChargeableWeight.Location = new System.Drawing.Point(15, 125);
        this.lblChargeableWeight.Name = "lblChargeableWeight";
        this.lblChargeableWeight.Text = "Розрахункова вага:";
        // lblChargeableWeightValue
        this.lblChargeableWeightValue.AutoSize = true;
        this.lblChargeableWeightValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblChargeableWeightValue.Location = new System.Drawing.Point(190, 125);
        this.lblChargeableWeightValue.Name = "lblChargeableWeightValue";
        this.lblChargeableWeightValue.Text = "—";
        this.grpResult.Controls.Add(this.lblDeliveryType);
        this.grpResult.Controls.Add(this.lblDeliveryTypeValue);
        // lblDeliveryType
        this.lblDeliveryType.AutoSize = true;
        this.lblDeliveryType.Location = new System.Drawing.Point(15, 170);
        this.lblDeliveryType.Name = "lblDeliveryType";
        this.lblDeliveryType.Text = "Спосіб доставки:";
        // lblDeliveryTypeValue
        this.lblDeliveryTypeValue.AutoSize = true;
        this.lblDeliveryTypeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblDeliveryTypeValue.Location = new System.Drawing.Point(190, 170);
        this.lblDeliveryTypeValue.Name = "lblDeliveryTypeValue";
        this.lblDeliveryTypeValue.Text = "—";
        this.grpResult.Controls.Add(this.pnlPrice);
        // pnlPrice
        this.pnlPrice.BackColor = System.Drawing.Color.FromArgb(229, 238, 250);
        this.pnlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlPrice.Controls.Add(this.lblPrice);
        this.pnlPrice.Controls.Add(this.lblPriceCaption);
        this.pnlPrice.Location = new System.Drawing.Point(15, 225);
        this.pnlPrice.Name = "pnlPrice";
        this.pnlPrice.Size = new System.Drawing.Size(345, 115);
        this.pnlPrice.TabIndex = 0;
        // lblPriceCaption
        this.lblPriceCaption.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblPriceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblPriceCaption.ForeColor = System.Drawing.Color.FromArgb(21, 82, 170);
        this.lblPriceCaption.Name = "lblPriceCaption";
        this.lblPriceCaption.Size = new System.Drawing.Size(343, 45);
        this.lblPriceCaption.Text = "Вартість доставки";
        this.lblPriceCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // lblPrice
        this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
        this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(21, 82, 170);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Text = "— грн";
        this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // statusStrip1
        this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
        this.statusStrip1.Name = "statusStrip1";
        // lblStatus
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Готово до розрахунку";
        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(754, 421);
        this.Controls.Add(this.grpParams);
        this.Controls.Add(this.grpMethod);
        this.Controls.Add(this.btnCalculate);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.grpResult);
        this.Controls.Add(this.statusStrip1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Розрахунок вартості доставки";
        ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
        this.grpParams.ResumeLayout(false);
        this.grpParams.PerformLayout();
        this.grpMethod.ResumeLayout(false);
        this.grpResult.ResumeLayout(false);
        this.grpResult.PerformLayout();
        this.pnlPrice.ResumeLayout(false);
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpParams;
    private System.Windows.Forms.Label lblFormula;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.NumericUpDown nudWeight;
    private System.Windows.Forms.Label lblLength;
    private System.Windows.Forms.NumericUpDown nudLength;
    private System.Windows.Forms.Label lblWidth;
    private System.Windows.Forms.NumericUpDown nudWidth;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.NumericUpDown nudHeight;
    private System.Windows.Forms.GroupBox grpMethod;
    private System.Windows.Forms.ComboBox cmbDeliveryType;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.GroupBox grpResult;
    private System.Windows.Forms.Label lblActualWeight;
    private System.Windows.Forms.Label lblActualWeightValue;
    private System.Windows.Forms.Label lblVolumetricWeight;
    private System.Windows.Forms.Label lblVolumetricWeightValue;
    private System.Windows.Forms.Label lblChargeableWeight;
    private System.Windows.Forms.Label lblChargeableWeightValue;
    private System.Windows.Forms.Label lblDeliveryType;
    private System.Windows.Forms.Label lblDeliveryTypeValue;
    private System.Windows.Forms.Panel pnlPrice;
    private System.Windows.Forms.Label lblPriceCaption;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblStatus;
}
