using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace BedsideMonitoring.WinForms
{
    public partial class ModuleSelection : Form
    {
        private readonly BedsideController thisBedsideController;
        private readonly List<string> allModulesAvailableList = new();
        private readonly List<ComboBox> comboBoxesList;

        private bool confirmButtonHasBeenClicked = false;

        public ModuleSelection(string bedsideNumber, BedsideController createdBedsideController)
        {
            InitializeComponent();
            thisBedsideController = createdBedsideController;
            lblName.Text = bedsideNumber;
            Text += ": " + lblName.Text;
            comboBoxesList = new List<ComboBox>() { cmbbModule1, cmbbModule2, cmbbModule3, cmbbModule4 };

            allModulesAvailableList = ModuleControllerSubclassListing.GetAllInheritingClassesModuleController();

            PopulateComboBoxesModuleSelection();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // TODO: This is a horrible way of doing validation
            // need to come back and clean this up. This stops 
            // situations where no values are entered at least.
            var errors = new List<int>();

            if (string.IsNullOrWhiteSpace(cmbbModule1.Text))
            {
                errors.Add(1);
            }

            if (string.IsNullOrWhiteSpace(cmbbModule2.Text))
            {
                errors.Add(2);
            }

            if (string.IsNullOrWhiteSpace(cmbbModule3.Text))
            {
                errors.Add(3);
            }

            if (string.IsNullOrWhiteSpace(cmbbModule4.Text))
            {
                errors.Add(4);
            }

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errors.Add(5);
            }

            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    switch (error)
                    {
                        case 1:
                            cmbbModule1.BackColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            cmbbModule2.BackColor = System.Drawing.Color.Red;
                            break;
                        case 3:
                            cmbbModule3.BackColor = System.Drawing.Color.Red;
                            break;
                        case 4:
                            cmbbModule4.BackColor = System.Drawing.Color.Red;
                            break;
                        case 5:
                            txtPatientName.BackColor = System.Drawing.Color.Red;
                            break;
                    }
                }
            }
            else
            {
                thisBedsideController.SetSelectedModules(cmbbModule1.Text, cmbbModule2.Text, cmbbModule3.Text, cmbbModule4.Text, lblName.Text, txtPatientName.Text);
                confirmButtonHasBeenClicked = true;
                Close();
            }
        }

        private void CmbbModule_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox currentComboBox = sender as ComboBox;
            var item = currentComboBox.SelectedItem.ToString();

            foreach (var combox in comboBoxesList.Where(x => x != currentComboBox))
            {
                if (combox.Items.Contains(item))
                {
                    combox.Items.Remove(item);
                }
            }
        }

        private void ModuleSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmButtonHasBeenClicked)
            {
                Program.NewCentralStationOverview.Show();
            }
        }

        private void PopulateComboBoxesModuleSelection()
        {
            foreach (var comboBox in comboBoxesList)
            {
                foreach (string moduleName in allModulesAvailableList)
                {
                    comboBox.Items.Add(moduleName);
                }
            }
        }
    }
}
