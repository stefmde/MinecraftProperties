using StefmDE.MinecraftProperties.Properties.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StefmDE.MinecraftProperties.WinFormEditor
{
    public partial class PropertyEditorInt : Form
    {
        public PropertyWrapper<int>? Property { get; set; }
        public bool DoSave { get; set; }

        public PropertyEditorInt(PropertyWrapper<int>? property)
        {
            Property = property;
            InitializeComponent();

            if(Property is null)
            {
                return;
            }

            lblDefaultValue.Text = Property.DefaultValue.ToString();
            lblPropertyName.Text = Property.IniName;
            numericUpDown.Value = Property.Value;
            tbxDescription.Text = Property.Description;

            if (Property.MinValue.HasValue)
            {
                numericUpDown.Minimum = Property.MinValue.Value;
            }

            if (Property.MaxValue.HasValue)
            {
                numericUpDown.Maximum = Property.MaxValue.Value;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numericUpDown.Value = Property.DefaultValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Property.SetValue((int)numericUpDown.Value);
            DoSave = true;
            this.Close();
        }
    }
}
