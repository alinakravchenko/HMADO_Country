﻿namespace HMADO_Country
{
    partial class FormShowInfo
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
            this.dataGridViewShowInfo = new System.Windows.Forms.DataGridView();
            this.buttonInfoTop3CountryCountPeople = new System.Windows.Forms.Button();
            this.buttonInfoCapitalTop3CountPeople = new System.Windows.Forms.Button();
            this.buttonTopInfoCountryCountPeople = new System.Windows.Forms.Button();
            this.buttonTopCityCountPeople = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowInfo
            // 
            this.dataGridViewShowInfo.AllowUserToAddRows = false;
            this.dataGridViewShowInfo.AllowUserToDeleteRows = false;
            this.dataGridViewShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowInfo.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewShowInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShowInfo.MultiSelect = false;
            this.dataGridViewShowInfo.Name = "dataGridViewShowInfo";
            this.dataGridViewShowInfo.ReadOnly = true;
            this.dataGridViewShowInfo.RowHeadersWidth = 51;
            this.dataGridViewShowInfo.RowTemplate.Height = 24;
            this.dataGridViewShowInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowInfo.Size = new System.Drawing.Size(504, 180);
            this.dataGridViewShowInfo.TabIndex = 0;
            // 
            // buttonInfoTop3CountryCountPeople
            // 
            this.buttonInfoTop3CountryCountPeople.Location = new System.Drawing.Point(87, 206);
            this.buttonInfoTop3CountryCountPeople.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfoTop3CountryCountPeople.Name = "buttonInfoTop3CountryCountPeople";
            this.buttonInfoTop3CountryCountPeople.Size = new System.Drawing.Size(350, 35);
            this.buttonInfoTop3CountryCountPeople.TabIndex = 1;
            this.buttonInfoTop3CountryCountPeople.Text = "Отображение топ-3 стран по наибольшему количеству жителей";
            this.buttonInfoTop3CountryCountPeople.UseVisualStyleBackColor = true;
            this.buttonInfoTop3CountryCountPeople.Click += new System.EventHandler(this.buttonInfoTop3CountryCountPeople_Click);
            // 
            // buttonInfoCapitalTop3CountPeople
            // 
            this.buttonInfoCapitalTop3CountPeople.Location = new System.Drawing.Point(87, 254);
            this.buttonInfoCapitalTop3CountPeople.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfoCapitalTop3CountPeople.Name = "buttonInfoCapitalTop3CountPeople";
            this.buttonInfoCapitalTop3CountPeople.Size = new System.Drawing.Size(350, 35);
            this.buttonInfoCapitalTop3CountPeople.TabIndex = 2;
            this.buttonInfoCapitalTop3CountPeople.Text = "Отображение топ-3 столиц по наибольшему количеству жителей";
            this.buttonInfoCapitalTop3CountPeople.UseVisualStyleBackColor = true;
            this.buttonInfoCapitalTop3CountPeople.Click += new System.EventHandler(this.buttonInfoCapitalTop3CountPeople_Click);
            // 
            // buttonTopInfoCountryCountPeople
            // 
            this.buttonTopInfoCountryCountPeople.Location = new System.Drawing.Point(87, 305);
            this.buttonTopInfoCountryCountPeople.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTopInfoCountryCountPeople.Name = "buttonTopInfoCountryCountPeople";
            this.buttonTopInfoCountryCountPeople.Size = new System.Drawing.Size(350, 35);
            this.buttonTopInfoCountryCountPeople.TabIndex = 3;
            this.buttonTopInfoCountryCountPeople.Text = "Отобразить страну с самым большим количеством жителей";
            this.buttonTopInfoCountryCountPeople.UseVisualStyleBackColor = true;
            this.buttonTopInfoCountryCountPeople.Click += new System.EventHandler(this.buttonTopInfoCountryCountPeople_Click);
            // 
            // buttonTopCityCountPeople
            // 
            this.buttonTopCityCountPeople.Location = new System.Drawing.Point(87, 360);
            this.buttonTopCityCountPeople.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTopCityCountPeople.Name = "buttonTopCityCountPeople";
            this.buttonTopCityCountPeople.Size = new System.Drawing.Size(350, 35);
            this.buttonTopCityCountPeople.TabIndex = 4;
            this.buttonTopCityCountPeople.Text = "Отобразить город с самым большим количеством жителей";
            this.buttonTopCityCountPeople.UseVisualStyleBackColor = true;
            this.buttonTopCityCountPeople.Click += new System.EventHandler(this.buttonTopCityCountPeople_Click);
            // 
            // FormShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 406);
            this.Controls.Add(this.buttonTopCityCountPeople);
            this.Controls.Add(this.buttonTopInfoCountryCountPeople);
            this.Controls.Add(this.buttonInfoCapitalTop3CountPeople);
            this.Controls.Add(this.buttonInfoTop3CountryCountPeople);
            this.Controls.Add(this.dataGridViewShowInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочная информация";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowInfo;
        private System.Windows.Forms.Button buttonInfoTop3CountryCountPeople;
        private System.Windows.Forms.Button buttonInfoCapitalTop3CountPeople;
        private System.Windows.Forms.Button buttonTopInfoCountryCountPeople;
        private System.Windows.Forms.Button buttonTopCityCountPeople;
    }
}