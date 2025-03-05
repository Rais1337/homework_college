using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;

namespace DarkRP_Professions
{
    public partial class MainForm : Form
    {
        private List<ICommand> commands = new List<ICommand>
        {
            new PoliceOfficerCommand(),
            new DoctorCommand(),
            new MechanicCommand()
        };

        public MainForm()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            foreach (ICommand cmd in commands)
            {
                CreateButton(cmd);
            }
        }

        private void CreateButton(ICommand cmd)
        {
            Button btn = new Button
            {
                Text = cmd.GetInfo(),
                AutoSize = true
            };
            btn.Click += (sender, e) => cmd.Execute(new List<object>());
            flowLayoutPanel1.Controls.Add(btn);
        }
    }
}
