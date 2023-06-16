namespace Pasechnik_IVT1_Practice
{
    partial class MainForm
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.panelRequestsButtons = new System.Windows.Forms.Panel();
            this.buttonRequests3 = new System.Windows.Forms.Button();
            this.buttonRequests2 = new System.Windows.Forms.Button();
            this.buttonRequests1 = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.panelTablesButtons = new System.Windows.Forms.Panel();
            this.buttonMats = new System.Windows.Forms.Button();
            this.buttonRings = new System.Windows.Forms.Button();
            this.buttonSportsEquipment = new System.Windows.Forms.Button();
            this.buttonCountries = new System.Windows.Forms.Button();
            this.buttonRegions = new System.Windows.Forms.Button();
            this.buttonMainTable = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SideBar.SuspendLayout();
            this.panelRequestsButtons.SuspendLayout();
            this.panelTablesButtons.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SideBar.Controls.Add(this.panelRequestsButtons);
            this.SideBar.Controls.Add(this.buttonRequests);
            this.SideBar.Controls.Add(this.panelTablesButtons);
            this.SideBar.Controls.Add(this.buttonTables);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 543);
            this.SideBar.TabIndex = 0;
            // 
            // panelRequestsButtons
            // 
            this.panelRequestsButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRequestsButtons.Controls.Add(this.buttonRequests3);
            this.panelRequestsButtons.Controls.Add(this.buttonRequests2);
            this.panelRequestsButtons.Controls.Add(this.buttonRequests1);
            this.panelRequestsButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRequestsButtons.Location = new System.Drawing.Point(0, 420);
            this.panelRequestsButtons.Name = "panelRequestsButtons";
            this.panelRequestsButtons.Size = new System.Drawing.Size(200, 124);
            this.panelRequestsButtons.TabIndex = 4;
            // 
            // buttonRequests3
            // 
            this.buttonRequests3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequests3.FlatAppearance.BorderSize = 0;
            this.buttonRequests3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRequests3.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRequests3.Location = new System.Drawing.Point(0, 80);
            this.buttonRequests3.Name = "buttonRequests3";
            this.buttonRequests3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonRequests3.Size = new System.Drawing.Size(200, 40);
            this.buttonRequests3.TabIndex = 2;
            this.buttonRequests3.Text = "Продажи матов \nвыше, чем рингов.";
            this.buttonRequests3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequests3.UseVisualStyleBackColor = true;
            // 
            // buttonRequests2
            // 
            this.buttonRequests2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequests2.FlatAppearance.BorderSize = 0;
            this.buttonRequests2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRequests2.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRequests2.Location = new System.Drawing.Point(0, 40);
            this.buttonRequests2.Name = "buttonRequests2";
            this.buttonRequests2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonRequests2.Size = new System.Drawing.Size(200, 40);
            this.buttonRequests2.TabIndex = 1;
            this.buttonRequests2.Text = "Среднее количество продаж \nпредставленных товаров выше 300 тыс. шт.";
            this.buttonRequests2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequests2.UseVisualStyleBackColor = true;
            // 
            // buttonRequests1
            // 
            this.buttonRequests1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequests1.FlatAppearance.BorderSize = 0;
            this.buttonRequests1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRequests1.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRequests1.Location = new System.Drawing.Point(0, 0);
            this.buttonRequests1.Name = "buttonRequests1";
            this.buttonRequests1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonRequests1.Size = new System.Drawing.Size(200, 40);
            this.buttonRequests1.TabIndex = 0;
            this.buttonRequests1.Text = "Страны с максимальным кол-вом продаж";
            this.buttonRequests1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequests1.UseVisualStyleBackColor = true;
            // 
            // buttonRequests
            // 
            this.buttonRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequests.FlatAppearance.BorderSize = 0;
            this.buttonRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRequests.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRequests.Location = new System.Drawing.Point(0, 380);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonRequests.Size = new System.Drawing.Size(200, 40);
            this.buttonRequests.TabIndex = 3;
            this.buttonRequests.Text = "Запросы";
            this.buttonRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // panelTablesButtons
            // 
            this.panelTablesButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelTablesButtons.Controls.Add(this.buttonMats);
            this.panelTablesButtons.Controls.Add(this.buttonRings);
            this.panelTablesButtons.Controls.Add(this.buttonSportsEquipment);
            this.panelTablesButtons.Controls.Add(this.buttonCountries);
            this.panelTablesButtons.Controls.Add(this.buttonRegions);
            this.panelTablesButtons.Controls.Add(this.buttonMainTable);
            this.panelTablesButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTablesButtons.Location = new System.Drawing.Point(0, 140);
            this.panelTablesButtons.Name = "panelTablesButtons";
            this.panelTablesButtons.Size = new System.Drawing.Size(200, 240);
            this.panelTablesButtons.TabIndex = 2;
            // 
            // buttonMats
            // 
            this.buttonMats.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMats.FlatAppearance.BorderSize = 0;
            this.buttonMats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMats.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMats.Location = new System.Drawing.Point(0, 200);
            this.buttonMats.Name = "buttonMats";
            this.buttonMats.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonMats.Size = new System.Drawing.Size(200, 40);
            this.buttonMats.TabIndex = 5;
            this.buttonMats.Text = "Маты";
            this.buttonMats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMats.UseVisualStyleBackColor = true;
            // 
            // buttonRings
            // 
            this.buttonRings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRings.FlatAppearance.BorderSize = 0;
            this.buttonRings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRings.Location = new System.Drawing.Point(0, 160);
            this.buttonRings.Name = "buttonRings";
            this.buttonRings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonRings.Size = new System.Drawing.Size(200, 40);
            this.buttonRings.TabIndex = 4;
            this.buttonRings.Text = "Ринги";
            this.buttonRings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRings.UseVisualStyleBackColor = true;
            // 
            // buttonSportsEquipment
            // 
            this.buttonSportsEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSportsEquipment.FlatAppearance.BorderSize = 0;
            this.buttonSportsEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSportsEquipment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSportsEquipment.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSportsEquipment.Location = new System.Drawing.Point(0, 120);
            this.buttonSportsEquipment.Name = "buttonSportsEquipment";
            this.buttonSportsEquipment.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonSportsEquipment.Size = new System.Drawing.Size(200, 40);
            this.buttonSportsEquipment.TabIndex = 3;
            this.buttonSportsEquipment.Text = "Спортивные снаряды";
            this.buttonSportsEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSportsEquipment.UseVisualStyleBackColor = true;
            // 
            // buttonCountries
            // 
            this.buttonCountries.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCountries.FlatAppearance.BorderSize = 0;
            this.buttonCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountries.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCountries.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCountries.Location = new System.Drawing.Point(0, 80);
            this.buttonCountries.Name = "buttonCountries";
            this.buttonCountries.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonCountries.Size = new System.Drawing.Size(200, 40);
            this.buttonCountries.TabIndex = 2;
            this.buttonCountries.Text = "Страны";
            this.buttonCountries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCountries.UseVisualStyleBackColor = true;
            this.buttonCountries.Click += new System.EventHandler(this.buttonCountries_Click);
            // 
            // buttonRegions
            // 
            this.buttonRegions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegions.FlatAppearance.BorderSize = 0;
            this.buttonRegions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegions.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRegions.Location = new System.Drawing.Point(0, 40);
            this.buttonRegions.Name = "buttonRegions";
            this.buttonRegions.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonRegions.Size = new System.Drawing.Size(200, 40);
            this.buttonRegions.TabIndex = 1;
            this.buttonRegions.Text = "Регионы";
            this.buttonRegions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegions.UseVisualStyleBackColor = true;
            this.buttonRegions.Click += new System.EventHandler(this.buttonRegions_Click);
            // 
            // buttonMainTable
            // 
            this.buttonMainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMainTable.FlatAppearance.BorderSize = 0;
            this.buttonMainTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMainTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMainTable.Location = new System.Drawing.Point(0, 0);
            this.buttonMainTable.Name = "buttonMainTable";
            this.buttonMainTable.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonMainTable.Size = new System.Drawing.Size(200, 40);
            this.buttonMainTable.TabIndex = 0;
            this.buttonMainTable.Text = "Основная таблица";
            this.buttonMainTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainTable.UseVisualStyleBackColor = true;
            // 
            // buttonTables
            // 
            this.buttonTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTables.FlatAppearance.BorderSize = 0;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTables.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTables.Location = new System.Drawing.Point(0, 100);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonTables.Size = new System.Drawing.Size(200, 40);
            this.buttonTables.TabIndex = 1;
            this.buttonTables.Text = "Таблицы";
            this.buttonTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.MainPanel.Size = new System.Drawing.Size(660, 543);
            this.MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonAddCountry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(25, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 103);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(485, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(247, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.buttonAddCountry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.buttonAddCountry.FlatAppearance.BorderSize = 0;
            this.buttonAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCountry.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddCountry.Location = new System.Drawing.Point(5, 25);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(120, 35);
            this.buttonAddCountry.TabIndex = 0;
            this.buttonAddCountry.Text = "Добавить";
            this.buttonAddCountry.UseVisualStyleBackColor = false;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 543);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideBar);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SideBar.ResumeLayout(false);
            this.panelRequestsButtons.ResumeLayout(false);
            this.panelTablesButtons.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SideBar;
        private Panel MainPanel;
        private Panel panel1;
        private Button buttonTables;
        private Panel panelRequestsButtons;
        private Button buttonRequests3;
        private Button buttonRequests2;
        private Button buttonRequests1;
        private Button buttonRequests;
        private Panel panelTablesButtons;
        private Button buttonMats;
        private Button buttonRings;
        private Button buttonSportsEquipment;
        private Button buttonCountries;
        private Button buttonRegions;
        private Button buttonMainTable;
        private DataGridView dataGridView1;
        private Panel panel2;
        
        private Button button2;
        private Button button1;
        private Button buttonAddCountry;
    }
}