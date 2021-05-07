using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mocha
{
    public partial class FormMocha : Form
    {
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        public FormMocha()
        {
            InitializeComponent();
        }
        private void FormMocha_Load(object sender, EventArgs e)
        {
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void NotifyIconMocha_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconMocha.Visible = false;
        }

        private void HideForm()
        {
            notifyIconMocha.Visible = true;
            Hide();
        }

        private void SetState()
        {
            pnlDisplayBoost.BackColor = Color.FromKnownColor(KnownColor.Control);
            pnlSystemBoost.BackColor = Color.FromKnownColor(KnownColor.Control);
            if (BoostEnabled)
            {                
                if (cbDisplayRequired.Checked && cbSystemRequired.Checked)
                {
                    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
                    pnlDisplayBoost.BackColor = Color.FromKnownColor(KnownColor.Green);
                    pnlSystemBoost.BackColor = Color.FromKnownColor(KnownColor.Green);
                }
                else if (cbDisplayRequired.Checked)
                {
                    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
                    pnlDisplayBoost.BackColor = Color.FromKnownColor(KnownColor.Green);

                }
                else if (cbSystemRequired.Checked)
                {
                    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                    pnlSystemBoost.BackColor = Color.FromKnownColor(KnownColor.Green);
                }
                else
                {
                    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
                }
            }
            else
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }

            pnlSchedule.Visible = !cbBoostAlwaysOn.Checked;
            lblNextDay.Visible = (tpBoostOn.Value.TimeOfDay > tpBoostOff.Value.TimeOfDay);
        }
        private bool BoostEnabled
        {
            get
            {
                DateTime Now = DateTime.Now;
                if (tpBoostOn.Value.TimeOfDay < tpBoostOff.Value.TimeOfDay)
                {
                    return (cbBoostAlwaysOn.Checked
                       || ((tpBoostOn.Value.TimeOfDay < Now.TimeOfDay) && (tpBoostOff.Value.TimeOfDay > Now.TimeOfDay))
                       );
                }
                else
                {
                    return (cbBoostAlwaysOn.Checked
                      || ((tpBoostOn.Value.TimeOfDay < Now.TimeOfDay) && (tpBoostOff.Value.TimeOfDay.Add(new TimeSpan(1, 0, 0, 0)) > Now.TimeOfDay))
                      );
                }
            }
        }
        private void FormMocha_Shown(object sender, EventArgs e)
        {
            HideForm();
            SetState();
        }

        private void timerMocha_Tick(object sender, EventArgs e)
        {
            SetState();
        }

        private void cbDisplayRequired_CheckedChanged(object sender, EventArgs e)
        {
            SetState();
        }

        private void cbSystemRequired_CheckedChanged(object sender, EventArgs e)
        {
            SetState();
        }

        private void cbBoostAlwaysOn_CheckedChanged(object sender, EventArgs e)
        {
            SetState();
        }

        private void tpBoostOn_ValueChanged(object sender, EventArgs e)
        {
            SetState();
        }

        private void tpBoostOff_ValueChanged(object sender, EventArgs e)
        {
            SetState();
        }
    }
}
