namespace EFUniversty;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtCity = new TextBox();
        btnCityAdd = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // txtCity
        // 
        txtCity.Font = new Font("Segoe UI", 12F);
        txtCity.Location = new Point(52, 31);
        txtCity.Name = "txtCity";
        txtCity.Size = new Size(175, 34);
        txtCity.TabIndex = 0;
        // 
        // btnCityAdd
        // 
        btnCityAdd.Location = new Point(52, 82);
        btnCityAdd.Name = "btnCityAdd";
        btnCityAdd.Size = new Size(175, 33);
        btnCityAdd.TabIndex = 1;
        btnCityAdd.Text = "Şehir Ekle";
        btnCityAdd.UseVisualStyleBackColor = true;
        btnCityAdd.Click += btnCityAdd_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(52, 148);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(300, 280);
        dataGridView1.TabIndex = 2;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(482, 450);
        Controls.Add(dataGridView1);
        Controls.Add(btnCityAdd);
        Controls.Add(txtCity);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtCity;
    private Button btnCityAdd;
    private DataGridView dataGridView1;
}
