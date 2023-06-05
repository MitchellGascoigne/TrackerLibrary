namespace TrackerUI
{
    partial class CreatePrizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            priceAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prixePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(13, 22);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(253, 91);
            placeNumberValue.Margin = new Padding(6, 7, 6, 7);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(229, 35);
            placeNumberValue.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(39, 88);
            placeNumberLabel.Margin = new Padding(6, 0, 6, 0);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(253, 152);
            placeNameValue.Margin = new Padding(6, 7, 6, 7);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(229, 35);
            placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(39, 149);
            placeNameLabel.Margin = new Padding(6, 0, 6, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(253, 216);
            prizeAmountValue.Margin = new Padding(6, 7, 6, 7);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(229, 35);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            prizeAmountValue.TextChanged += prizeAmountValue_TextChanged;
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            priceAmountLabel.Location = new Point(39, 213);
            priceAmountLabel.Margin = new Padding(6, 0, 6, 0);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(176, 37);
            priceAmountLabel.TabIndex = 17;
            priceAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(253, 340);
            prizePercentageValue.Margin = new Padding(6, 7, 6, 7);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(229, 35);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            // 
            // prixePercentageLabel
            // 
            prixePercentageLabel.AutoSize = true;
            prixePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prixePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prixePercentageLabel.Location = new Point(39, 337);
            prixePercentageLabel.Margin = new Padding(6, 0, 6, 0);
            prixePercentageLabel.Name = "prixePercentageLabel";
            prixePercentageLabel.Size = new Size(212, 37);
            prixePercentageLabel.TabIndex = 19;
            prixePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(208, 276);
            orLabel.Margin = new Padding(6, 0, 6, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 21;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(98, 409);
            createPrizeButton.Margin = new Padding(5, 6, 5, 6);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(285, 68);
            createPrizeButton.TabIndex = 26;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 524);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prixePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "CreatePrize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label priceAmountLabel;
        private TextBox prizePercentageValue;
        private Label prixePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}