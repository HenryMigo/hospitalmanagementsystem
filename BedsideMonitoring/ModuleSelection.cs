using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    public partial class ModuleSelection : Form
    {
        private BedsideController thisBedsideController;
        private List<string> allModulesAvailableList = new List<string>();
        private List<ComboBox> comboBoxesList;
        public string BN;

        private bool confirmButtonHasBeenClicked = false;
 
        public ModuleSelection(string bedsideNumber, BedsideController createdBedsideController)
        {
            InitializeComponent();
            thisBedsideController = createdBedsideController;
            lblName.Text = bedsideNumber;
            this.Text += ": " + lblName.Text;
            comboBoxesList = new List<ComboBox>() {cmbbModule1, cmbbModule2, cmbbModule3, cmbbModule4};

            allModulesAvailableList = ModuleControllerSubclassListing.GetAllInheritingClassesModuleController();
           
        }

        

        #region ComboBoxBehaviour
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            thisBedsideController.SetSelectedModules(cmbbModule1.Text, cmbbModule2.Text, cmbbModule3.Text, cmbbModule4.Text, lblName.Text, txtPatientName.Text);
            confirmButtonHasBeenClicked = true;
            Close();
        }

        private void cmbbModule_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox currentComboBox = sender as ComboBox;
            allModulesAvailableList.RemoveAt(currentComboBox.SelectedIndex);
        }

        private void cmbbModule_Click(object sender, EventArgs e)
        {
            ComboBox currentComboBox = sender as ComboBox;
            currentComboBox.Items.Clear();
            PopulateComboBoxesModuleSelection();
        }
        
        private void ModuleSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirmButtonHasBeenClicked)
            {
                Program.NewCentralStationOverview.Show();
            }
        }
        #endregion

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
