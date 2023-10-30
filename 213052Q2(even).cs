namespace SalaryCalulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateSalaryButton_Click(object sender, EventArgs e)
        {
         
            int basicSalary = 0;
            if (DirectorRadioButton.Checked)
                basicSalary = 100000;
            else if (ManagerRadioButton.Checked)
                basicSalary = 50000;
            else if (ProjectManagerRadioButton.Checked)
                basicSalary = 40000;
            else if (ProgrammerRadioButton.Checked)
                basicSalary = 30000;

          
            int benefits = 0;
            if (HousingCheckBox.Checked)
                benefits += 20000;
            if (ConveyanceCheckBox.Checked)
                benefits += 15000;
            if (OtherBenefit1CheckBox.Checked)
                benefits += 10000;
            if (OtherBenefit2CheckBox.Checked)
                benefits += 10000;

            
            int bonuses = 0;
            foreach (var bonus in BonusesCheckedListBox.CheckedItems)
            {
                if (bonus.ToString() == "Project Completion Bonus")
                    bonuses += 20000;
                else if (bonus.ToString() == "Year End Bonus")
                    bonuses += 30000;
                else if (bonus.ToString() == "Performance Bonus")
                    bonuses += 25000;
                else if (bonus.ToString() == "Customer appreciation Bonus")
                    bonuses += 15000;
            }

          
            int providentFundDeduction = 0;
            if (!string.IsNullOrEmpty(ProvidentFundTextBox.Text))
                providentFundDeduction = int.Parse(ProvidentFundTextBox.Text);

            int medicalDeduction = 0;
            if (!string.IsNullOrEmpty(MedicalDeductionTextBox.Text))
                medicalDeduction = int.Parse(MedicalDeductionTextBox.Text);

            int deductionsTotal = providentFundDeduction + medicalDeduction;

            int totalSalary = basicSalary + benefits + bonuses - deductionsTotal;

           
            MessageBox.Show($"Total Salary: {totalSalary}");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BonusesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SalaryGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}