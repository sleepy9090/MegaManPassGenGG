using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaManPassGenGG
{
    public partial class FormMegaManPassGenGG : Form
    {
        public FormMegaManPassGenGG()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            DisablePasswordCheckboxes();
            SetComboBoxes();
        }

        private void DisablePasswordCheckboxes()
        {
            checkBoxA1.Enabled = false;
            checkBoxA2.Enabled = false;
            checkBoxA3.Enabled = false;
            checkBoxA4.Enabled = false;
            checkBoxA5.Enabled = false;
            checkBoxA6.Enabled = false;

            checkBoxB1.Enabled = false;
            checkBoxB2.Enabled = false;
            checkBoxB3.Enabled = false;
            checkBoxB4.Enabled = false;
            checkBoxB5.Enabled = false;
            checkBoxB6.Enabled = false;

            checkBoxC1.Enabled = false;
            checkBoxC2.Enabled = false;
            checkBoxC3.Enabled = false;
            checkBoxC4.Enabled = false;
            checkBoxC5.Enabled = false;
            checkBoxC6.Enabled = false;

            checkBoxD1.Enabled = false;
            checkBoxD2.Enabled = false;
            checkBoxD3.Enabled = false;
            checkBoxD4.Enabled = false;
            checkBoxD5.Enabled = false;
            checkBoxD6.Enabled = false;

            checkBoxE1.Enabled = false;
            checkBoxE2.Enabled = false;
            checkBoxE3.Enabled = false;
            checkBoxE4.Enabled = false;
            checkBoxE5.Enabled = false;
            checkBoxE6.Enabled = false;

            checkBoxF1.Enabled = false;
            checkBoxF2.Enabled = false;
            checkBoxF3.Enabled = false;
            checkBoxF4.Enabled = false;
            checkBoxF5.Enabled = false;
            checkBoxF6.Enabled = false;
        }

        private void ClearPasswordCheckboxes()
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;
            checkBoxA5.Checked = false;
            checkBoxA6.Checked = false;

            checkBoxB1.Checked = false;
            checkBoxB2.Checked = false;
            checkBoxB3.Checked = false;
            checkBoxB4.Checked = false;
            checkBoxB5.Checked = false;
            checkBoxB6.Checked = false;

            checkBoxC1.Checked = false;
            checkBoxC2.Checked = false;
            checkBoxC3.Checked = false;
            checkBoxC4.Checked = false;
            checkBoxC5.Checked = false;
            checkBoxC6.Checked = false;

            checkBoxD1.Checked = false;
            checkBoxD2.Checked = false;
            checkBoxD3.Checked = false;
            checkBoxD4.Checked = false;
            checkBoxD5.Checked = false;
            checkBoxD6.Checked = false;

            checkBoxE1.Checked = false;
            checkBoxE2.Checked = false;
            checkBoxE3.Checked = false;
            checkBoxE4.Checked = false;
            checkBoxE5.Checked = false;
            checkBoxE6.Checked = false;

            checkBoxF1.Checked = false;
            checkBoxF2.Checked = false;
            checkBoxF3.Checked = false;
            checkBoxF4.Checked = false;
            checkBoxF5.Checked = false;
            checkBoxF6.Checked = false;
        }

        private void SetComboBoxes()
        {
            comboBoxGameMode.Items.Add("Normal");
            comboBoxGameMode.Items.Add("Hard");
            comboBoxGameMode.SelectedIndex = 0;
        }

        private int GetTotalChecked()
        {
            int totalChecked = 0;

            if (checkBoxFlashStopper.Checked)
            {
                totalChecked++;
            }

            if (checkBoxNapalmBomb.Checked)
            {
                totalChecked++;
            }

            if (checkBoxPowerStone.Checked)
            {
                totalChecked++;
            }

            if (checkBoxStarCrash.Checked)
            {
                totalChecked++;
            }

            return totalChecked;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            ClearPasswordCheckboxes();

            bool hasFlashStopper = checkBoxFlashStopper.Checked;
            bool hasNapalmBomb = checkBoxNapalmBomb.Checked;
            bool hasPowerStone = checkBoxPowerStone.Checked;
            bool hasStarCrash = checkBoxStarCrash.Checked;

            int totalChecked = GetTotalChecked();
            int gameMode = comboBoxGameMode.SelectedIndex;

            if (gameMode == 0) // Normal
            {
                if (totalChecked == 4)
                {
                    checkBoxA4.Checked = true;
                    checkBoxB4.Checked = true;
                    checkBoxB5.Checked = true;
                    checkBoxC1.Checked = true;
                    checkBoxF6.Checked = true;
                }
                else if (totalChecked == 3)
                {
                    if (hasFlashStopper && hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxC3.Checked = true;
                        checkBoxC4.Checked = true;
                        checkBoxD3.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxE6.Checked = true;
                    }
                    else if (hasStarCrash && hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxA5.Checked = true;
                        checkBoxC1.Checked = true;
                        checkBoxC3.Checked = true;
                        checkBoxC4.Checked = true;
                        checkBoxD3.Checked = true;
                    }
                    else if (hasStarCrash && hasFlashStopper && hasPowerStone)
                    {
                        checkBoxA5.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxD2.Checked = true;
                        checkBoxD4.Checked = true;
                        checkBoxD6.Checked = true;
                    }
                    else if (hasStarCrash && hasFlashStopper && hasNapalmBomb)
                    {
                        checkBoxB2.Checked = true;
                        checkBoxD2.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxE5.Checked = true;
                        checkBoxF2.Checked = true;
                    }
                }
                else if (totalChecked == 2)
                {
                    if (hasStarCrash && hasFlashStopper)
                    {
                        checkBoxB3.Checked = true;
                        checkBoxC6.Checked = true;
                        checkBoxD1.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxE3.Checked = true;
                    }
                    else if (hasStarCrash && hasNapalmBomb)
                    {
                        checkBoxA3.Checked = true;
                        checkBoxD3.Checked = true;
                        checkBoxE1.Checked = true;
                        checkBoxF1.Checked = true;
                        checkBoxF3.Checked = true;
                    }
                    else if (hasStarCrash && hasPowerStone)
                    {
                        checkBoxC3.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxE2.Checked = true;
                        checkBoxE4.Checked = true;
                        checkBoxF1.Checked = true;
                    }
                    else if (hasFlashStopper && hasNapalmBomb)
                    {
                        checkBoxA2.Checked = true;
                        checkBoxB1.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxD2.Checked = true;
                        checkBoxD3.Checked = true;
                    }
                    else if (hasFlashStopper && hasPowerStone)
                    {
                        checkBoxA4.Checked = true;
                        checkBoxA6.Checked = true;
                        checkBoxE2.Checked = true;
                        checkBoxE3.Checked = true;
                        checkBoxE4.Checked = true;
                    }
                    else if (hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxA3.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxC1.Checked = true;
                        checkBoxC5.Checked = true;
                        checkBoxF2.Checked = true;
                    }
                }
                else if (totalChecked == 1)
                {
                    if (hasStarCrash)
                    {
                        checkBoxA3.Checked = true;
                        checkBoxA6.Checked = true;
                        checkBoxB2.Checked = true;
                        checkBoxC1.Checked = true;
                        checkBoxE5.Checked = true;
                    }
                    else if (hasFlashStopper)
                    {
                        checkBoxA2.Checked = true;
                        checkBoxA4.Checked = true;
                        checkBoxB4.Checked = true;
                        checkBoxC1.Checked = true;
                        checkBoxD1.Checked = true;
                    }
                    else if (hasNapalmBomb)
                    {
                        checkBoxB3.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxC1.Checked = true;
                        checkBoxC4.Checked = true;
                        checkBoxD4.Checked = true;
                    }
                    else if (hasPowerStone)
                    {
                        checkBoxB3.Checked = true;
                        checkBoxC3.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxE5.Checked = true;
                        checkBoxF2.Checked = true;
                    }
                }
            }
            else //Hard
            {
                if (totalChecked == 4)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB5.Checked = true;
                    checkBoxC3.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxE5.Checked = true;
                }
                else if (totalChecked == 3)
                {
                    if (hasFlashStopper && hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxA2.Checked = true;
                        checkBoxB3.Checked = true;
                        checkBoxD3.Checked = true;
                        checkBoxE3.Checked = true;
                        checkBoxE5.Checked = true;
                    }
                    else if (hasStarCrash && hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxB1.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxE1.Checked = true;
                        checkBoxF2.Checked = true;
                        checkBoxF5.Checked = true;
                    }
                    else if (hasStarCrash && hasFlashStopper && hasPowerStone)
                    {
                        checkBoxC3.Checked = true;
                        checkBoxC5.Checked = true;
                        checkBoxD4.Checked = true;
                        checkBoxE4.Checked = true;
                        checkBoxE6.Checked = true;
                    }
                    else if (hasStarCrash && hasFlashStopper && hasNapalmBomb)
                    {
                        checkBoxA6.Checked = true;
                        checkBoxE3.Checked = true;
                        checkBoxE4.Checked = true;
                        checkBoxF4.Checked = true;
                        checkBoxF6.Checked = true;
                    }
                }
                else if (totalChecked == 2)
                {
                    if (hasStarCrash && hasFlashStopper)
                    {
                        checkBoxA3.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxC3.Checked = true;
                        checkBoxD4.Checked = true;
                        checkBoxE4.Checked = true;
                    }
                    else if (hasStarCrash && hasNapalmBomb)
                    {
                        checkBoxA1.Checked = true;
                        checkBoxA3.Checked = true;
                        checkBoxA4.Checked = true;
                        checkBoxD6.Checked = true;
                        checkBoxF3.Checked = true;
                    }
                    else if (hasStarCrash && hasPowerStone)
                    {
                        checkBoxA4.Checked = true;
                        checkBoxA6.Checked = true;
                        checkBoxC2.Checked = true;
                        checkBoxD4.Checked = true;
                        checkBoxF5.Checked = true;
                    }
                    else if (hasFlashStopper && hasNapalmBomb)
                    {
                        checkBoxB1.Checked = true;
                        checkBoxB5.Checked = true;
                        checkBoxE2.Checked = true;
                        checkBoxE5.Checked = true;
                        checkBoxE6.Checked = true;
                    }
                    else if (hasFlashStopper && hasPowerStone)
                    {
                        checkBoxA3.Checked = true;
                        checkBoxB4.Checked = true;
                        checkBoxB6.Checked = true;
                        checkBoxC2.Checked = true;
                        checkBoxE6.Checked = true;
                    }
                    else if (hasNapalmBomb && hasPowerStone)
                    {
                        checkBoxA5.Checked = true;
                        checkBoxB3.Checked = true;
                        checkBoxC3.Checked = true;
                        checkBoxC5.Checked = true;
                        checkBoxE3.Checked = true;
                    }
                }
                else if (totalChecked == 1)
                {
                    if (hasStarCrash)
                    {
                        checkBoxC5.Checked = true;
                        checkBoxC6.Checked = true;
                        checkBoxE2.Checked = true;
                        checkBoxF2.Checked = true;
                        checkBoxF6.Checked = true;
                    }
                    else if (hasFlashStopper) // Bugged, game resumes in normal mode instead of hard mode
                    {
                        checkBoxB2.Checked = true;
                        checkBoxD1.Checked = true;
                        checkBoxD4.Checked = true;
                        checkBoxD5.Checked = true;
                        checkBoxD6.Checked = true;
                    }
                    else if (hasNapalmBomb)
                    {
                        checkBoxB3.Checked = true;
                        checkBoxB6.Checked = true;
                        checkBoxC5.Checked = true;
                        checkBoxE5.Checked = true;
                        checkBoxF5.Checked = true;
                    }
                    else if (hasPowerStone) // Bugged, game resumes in normal mode instead of hard mode
                    {
                        checkBoxC1.Checked = true;
                        checkBoxC2.Checked = true;
                        checkBoxC5.Checked = true;
                        checkBoxD2.Checked = true;
                        checkBoxE1.Checked = true;
                    }
                }
            }
        }
    }
}
