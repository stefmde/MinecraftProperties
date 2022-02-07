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
    public partial class PropertyEditorBool : Form
    {
        public PropertyWrapper<bool>? Property { get; set; }
        public bool DoSave { get; set; }

        public PropertyEditorBool(PropertyWrapper<bool>? property)
        {
            Property = property;
            InitializeComponent();

            if(Property is null)
            {
                return;
            }

            chbxDefaultValue.Checked = Property.DefaultValue;
            lblPropertyName.Text = Property.IniName;
            chbxValue.Checked = Property.Value;
            tbxDescription.Text = Property.Description;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chbxValue.Checked = Property.DefaultValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Property.SetValue(chbxValue.Checked);
            DoSave = true;
            this.Close();
        }
    }
}
