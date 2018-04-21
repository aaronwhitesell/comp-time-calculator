namespace CompTimeCalculator
{
    partial class Form1
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
            this.labelStartTravel = new System.Windows.Forms.Label();
            this.labelEndTravel = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dateTimePickerStartTravel = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTravel = new System.Windows.Forms.DateTimePicker();
            this.labelStartWork = new System.Windows.Forms.Label();
            this.labelEndWork = new System.Windows.Forms.Label();
            this.groupBoxTravel = new System.Windows.Forms.GroupBox();
            this.groupBoxWork = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEndWork = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartWork = new System.Windows.Forms.DateTimePicker();
            this.textCapDecimal = new System.Windows.Forms.TextBox();
            this.labelCap = new System.Windows.Forms.Label();
            this.labelHoursAndMinutes1 = new System.Windows.Forms.Label();
            this.labelDecimalHours1 = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.dateTimePickerCap = new System.Windows.Forms.DateTimePicker();
            this.textCompDecimal = new System.Windows.Forms.TextBox();
            this.textCompTime = new System.Windows.Forms.TextBox();
            this.textMealDecimal = new System.Windows.Forms.TextBox();
            this.textMealTime = new System.Windows.Forms.TextBox();
            this.textWorkDecimal = new System.Windows.Forms.TextBox();
            this.textWorkTime = new System.Windows.Forms.TextBox();
            this.textTravelDecimal = new System.Windows.Forms.TextBox();
            this.textTravelTime = new System.Windows.Forms.TextBox();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelMeals = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.labelTravel = new System.Windows.Forms.Label();
            this.groupBoxTravel.SuspendLayout();
            this.groupBoxWork.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStartTravel
            // 
            this.labelStartTravel.AutoSize = true;
            this.labelStartTravel.Location = new System.Drawing.Point(25, 43);
            this.labelStartTravel.Name = "labelStartTravel";
            this.labelStartTravel.Size = new System.Drawing.Size(77, 17);
            this.labelStartTravel.TabIndex = 2;
            this.labelStartTravel.Text = "Start travel";
            // 
            // labelEndTravel
            // 
            this.labelEndTravel.AutoSize = true;
            this.labelEndTravel.Location = new System.Drawing.Point(25, 95);
            this.labelEndTravel.Name = "labelEndTravel";
            this.labelEndTravel.Size = new System.Drawing.Size(72, 17);
            this.labelEndTravel.TabIndex = 3;
            this.labelEndTravel.Text = "End travel";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(246, 483);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(157, 35);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerStartTravel
            // 
            this.dateTimePickerStartTravel.Location = new System.Drawing.Point(144, 40);
            this.dateTimePickerStartTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStartTravel.Name = "dateTimePickerStartTravel";
            this.dateTimePickerStartTravel.Size = new System.Drawing.Size(105, 22);
            this.dateTimePickerStartTravel.TabIndex = 7;
            // 
            // dateTimePickerEndTravel
            // 
            this.dateTimePickerEndTravel.Location = new System.Drawing.Point(144, 92);
            this.dateTimePickerEndTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndTravel.Name = "dateTimePickerEndTravel";
            this.dateTimePickerEndTravel.Size = new System.Drawing.Size(105, 22);
            this.dateTimePickerEndTravel.TabIndex = 8;
            // 
            // labelStartWork
            // 
            this.labelStartWork.AutoSize = true;
            this.labelStartWork.Location = new System.Drawing.Point(31, 43);
            this.labelStartWork.Name = "labelStartWork";
            this.labelStartWork.Size = new System.Drawing.Size(71, 17);
            this.labelStartWork.TabIndex = 11;
            this.labelStartWork.Text = "Start work";
            // 
            // labelEndWork
            // 
            this.labelEndWork.AutoSize = true;
            this.labelEndWork.Location = new System.Drawing.Point(31, 95);
            this.labelEndWork.Name = "labelEndWork";
            this.labelEndWork.Size = new System.Drawing.Size(66, 17);
            this.labelEndWork.TabIndex = 12;
            this.labelEndWork.Text = "End work";
            // 
            // groupBoxTravel
            // 
            this.groupBoxTravel.Controls.Add(this.labelStartTravel);
            this.groupBoxTravel.Controls.Add(this.labelEndTravel);
            this.groupBoxTravel.Controls.Add(this.dateTimePickerStartTravel);
            this.groupBoxTravel.Controls.Add(this.dateTimePickerEndTravel);
            this.groupBoxTravel.Location = new System.Drawing.Point(19, 55);
            this.groupBoxTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTravel.Name = "groupBoxTravel";
            this.groupBoxTravel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTravel.Size = new System.Drawing.Size(283, 143);
            this.groupBoxTravel.TabIndex = 13;
            this.groupBoxTravel.TabStop = false;
            this.groupBoxTravel.Text = "1: Travel";
            // 
            // groupBoxWork
            // 
            this.groupBoxWork.Controls.Add(this.dateTimePickerEndWork);
            this.groupBoxWork.Controls.Add(this.dateTimePickerStartWork);
            this.groupBoxWork.Controls.Add(this.labelStartWork);
            this.groupBoxWork.Controls.Add(this.labelEndWork);
            this.groupBoxWork.Location = new System.Drawing.Point(346, 55);
            this.groupBoxWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWork.Name = "groupBoxWork";
            this.groupBoxWork.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWork.Size = new System.Drawing.Size(283, 143);
            this.groupBoxWork.TabIndex = 14;
            this.groupBoxWork.TabStop = false;
            this.groupBoxWork.Text = "2: Work (subset of travel)";
            // 
            // dateTimePickerEndWork
            // 
            this.dateTimePickerEndWork.Location = new System.Drawing.Point(140, 92);
            this.dateTimePickerEndWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndWork.Name = "dateTimePickerEndWork";
            this.dateTimePickerEndWork.Size = new System.Drawing.Size(105, 22);
            this.dateTimePickerEndWork.TabIndex = 14;
            // 
            // dateTimePickerStartWork
            // 
            this.dateTimePickerStartWork.Location = new System.Drawing.Point(140, 40);
            this.dateTimePickerStartWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStartWork.Name = "dateTimePickerStartWork";
            this.dateTimePickerStartWork.Size = new System.Drawing.Size(105, 22);
            this.dateTimePickerStartWork.TabIndex = 13;
            // 
            // textCapDecimal
            // 
            this.textCapDecimal.Location = new System.Drawing.Point(208, 113);
            this.textCapDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.textCapDecimal.Name = "textCapDecimal";
            this.textCapDecimal.ReadOnly = true;
            this.textCapDecimal.Size = new System.Drawing.Size(73, 22);
            this.textCapDecimal.TabIndex = 29;
            // 
            // labelCap
            // 
            this.labelCap.AutoSize = true;
            this.labelCap.Location = new System.Drawing.Point(218, 31);
            this.labelCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCap.Name = "labelCap";
            this.labelCap.Size = new System.Drawing.Size(49, 17);
            this.labelCap.TabIndex = 30;
            this.labelCap.Text = "3: Cap";
            // 
            // labelHoursAndMinutes1
            // 
            this.labelHoursAndMinutes1.AutoSize = true;
            this.labelHoursAndMinutes1.Location = new System.Drawing.Point(29, 65);
            this.labelHoursAndMinutes1.Name = "labelHoursAndMinutes1";
            this.labelHoursAndMinutes1.Size = new System.Drawing.Size(54, 17);
            this.labelHoursAndMinutes1.TabIndex = 15;
            this.labelHoursAndMinutes1.Text = "HH:MM";
            // 
            // labelDecimalHours1
            // 
            this.labelDecimalHours1.AutoSize = true;
            this.labelDecimalHours1.Location = new System.Drawing.Point(29, 116);
            this.labelDecimalHours1.Name = "labelDecimalHours1";
            this.labelDecimalHours1.Size = new System.Drawing.Size(58, 17);
            this.labelDecimalHours1.TabIndex = 16;
            this.labelDecimalHours1.Text = "Decimal";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dateTimePickerCap);
            this.groupBoxResults.Controls.Add(this.textCompDecimal);
            this.groupBoxResults.Controls.Add(this.textCapDecimal);
            this.groupBoxResults.Controls.Add(this.textCompTime);
            this.groupBoxResults.Controls.Add(this.textMealDecimal);
            this.groupBoxResults.Controls.Add(this.textMealTime);
            this.groupBoxResults.Controls.Add(this.labelCap);
            this.groupBoxResults.Controls.Add(this.textWorkDecimal);
            this.groupBoxResults.Controls.Add(this.textWorkTime);
            this.groupBoxResults.Controls.Add(this.textTravelDecimal);
            this.groupBoxResults.Controls.Add(this.textTravelTime);
            this.groupBoxResults.Controls.Add(this.labelComp);
            this.groupBoxResults.Controls.Add(this.labelMeals);
            this.groupBoxResults.Controls.Add(this.labelWork);
            this.groupBoxResults.Controls.Add(this.labelTravel);
            this.groupBoxResults.Controls.Add(this.labelHoursAndMinutes1);
            this.groupBoxResults.Controls.Add(this.labelDecimalHours1);
            this.groupBoxResults.Location = new System.Drawing.Point(19, 251);
            this.groupBoxResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResults.Size = new System.Drawing.Size(610, 170);
            this.groupBoxResults.TabIndex = 17;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // dateTimePickerCap
            // 
            this.dateTimePickerCap.Location = new System.Drawing.Point(208, 62);
            this.dateTimePickerCap.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCap.Name = "dateTimePickerCap";
            this.dateTimePickerCap.Size = new System.Drawing.Size(73, 22);
            this.dateTimePickerCap.TabIndex = 33;
            // 
            // textCompDecimal
            // 
            this.textCompDecimal.Location = new System.Drawing.Point(499, 113);
            this.textCompDecimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCompDecimal.Name = "textCompDecimal";
            this.textCompDecimal.ReadOnly = true;
            this.textCompDecimal.Size = new System.Drawing.Size(73, 22);
            this.textCompDecimal.TabIndex = 28;
            // 
            // textCompTime
            // 
            this.textCompTime.Location = new System.Drawing.Point(499, 62);
            this.textCompTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCompTime.Name = "textCompTime";
            this.textCompTime.ReadOnly = true;
            this.textCompTime.Size = new System.Drawing.Size(73, 22);
            this.textCompTime.TabIndex = 27;
            // 
            // textMealDecimal
            // 
            this.textMealDecimal.Location = new System.Drawing.Point(305, 113);
            this.textMealDecimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMealDecimal.Name = "textMealDecimal";
            this.textMealDecimal.ReadOnly = true;
            this.textMealDecimal.Size = new System.Drawing.Size(73, 22);
            this.textMealDecimal.TabIndex = 26;
            // 
            // textMealTime
            // 
            this.textMealTime.Location = new System.Drawing.Point(305, 62);
            this.textMealTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMealTime.Name = "textMealTime";
            this.textMealTime.ReadOnly = true;
            this.textMealTime.Size = new System.Drawing.Size(73, 22);
            this.textMealTime.TabIndex = 25;
            // 
            // textWorkDecimal
            // 
            this.textWorkDecimal.Location = new System.Drawing.Point(402, 113);
            this.textWorkDecimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWorkDecimal.Name = "textWorkDecimal";
            this.textWorkDecimal.ReadOnly = true;
            this.textWorkDecimal.Size = new System.Drawing.Size(73, 22);
            this.textWorkDecimal.TabIndex = 24;
            // 
            // textWorkTime
            // 
            this.textWorkTime.Location = new System.Drawing.Point(402, 62);
            this.textWorkTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWorkTime.Name = "textWorkTime";
            this.textWorkTime.ReadOnly = true;
            this.textWorkTime.Size = new System.Drawing.Size(73, 22);
            this.textWorkTime.TabIndex = 23;
            // 
            // textTravelDecimal
            // 
            this.textTravelDecimal.Location = new System.Drawing.Point(111, 113);
            this.textTravelDecimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTravelDecimal.Name = "textTravelDecimal";
            this.textTravelDecimal.ReadOnly = true;
            this.textTravelDecimal.Size = new System.Drawing.Size(73, 22);
            this.textTravelDecimal.TabIndex = 22;
            // 
            // textTravelTime
            // 
            this.textTravelTime.Location = new System.Drawing.Point(111, 62);
            this.textTravelTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTravelTime.Name = "textTravelTime";
            this.textTravelTime.ReadOnly = true;
            this.textTravelTime.Size = new System.Drawing.Size(73, 22);
            this.textTravelTime.TabIndex = 11;
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(512, 31);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(44, 17);
            this.labelComp.TabIndex = 21;
            this.labelComp.Text = "Comp";
            // 
            // labelMeals
            // 
            this.labelMeals.AutoSize = true;
            this.labelMeals.Location = new System.Drawing.Point(318, 31);
            this.labelMeals.Name = "labelMeals";
            this.labelMeals.Size = new System.Drawing.Size(45, 17);
            this.labelMeals.TabIndex = 20;
            this.labelMeals.Text = "Meals";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(417, 31);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(41, 17);
            this.labelWork.TabIndex = 18;
            this.labelWork.Text = "Work";
            // 
            // labelTravel
            // 
            this.labelTravel.AutoSize = true;
            this.labelTravel.Location = new System.Drawing.Point(122, 31);
            this.labelTravel.Name = "labelTravel";
            this.labelTravel.Size = new System.Drawing.Size(48, 17);
            this.labelTravel.TabIndex = 17;
            this.labelTravel.Text = "Travel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 583);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxTravel);
            this.Controls.Add(this.groupBoxWork);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Comp Time Calculator";
            this.TopMost = true;
            this.groupBoxTravel.ResumeLayout(false);
            this.groupBoxTravel.PerformLayout();
            this.groupBoxWork.ResumeLayout(false);
            this.groupBoxWork.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelStartTravel;
        private System.Windows.Forms.Label labelEndTravel;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTravel;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTravel;
        private System.Windows.Forms.Label labelStartWork;
        private System.Windows.Forms.Label labelEndWork;
        private System.Windows.Forms.GroupBox groupBoxTravel;
        private System.Windows.Forms.GroupBox groupBoxWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartWork;
        private System.Windows.Forms.Label labelHoursAndMinutes1;
        private System.Windows.Forms.Label labelDecimalHours1;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.Label labelTravel;
        private System.Windows.Forms.Label labelMeals;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox textCompDecimal;
        private System.Windows.Forms.TextBox textCompTime;
        private System.Windows.Forms.TextBox textMealDecimal;
        private System.Windows.Forms.TextBox textMealTime;
        private System.Windows.Forms.TextBox textWorkDecimal;
        private System.Windows.Forms.TextBox textWorkTime;
        private System.Windows.Forms.TextBox textTravelDecimal;
        private System.Windows.Forms.TextBox textTravelTime;
        private System.Windows.Forms.TextBox textCapDecimal;
        private System.Windows.Forms.Label labelCap;
        private System.Windows.Forms.DateTimePicker dateTimePickerCap;
    }
}

