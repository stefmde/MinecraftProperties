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
    public partial class PropertyEditorString : Form
    {
        public PropertyWrapper<string>? Property { get; set; }
        public bool DoSave { get; set; }

        public PropertyEditorString(PropertyWrapper<string>? property)
        {
            Property = property;
            InitializeComponent();

            if(Property is null)
            {
                return;
            }

            lblDefaultValue.Text = Property.DefaultValue;
            lblPropertyName.Text = Property.IniName;
            tbxValue.Text = Property.Value;
            tbxDescription.Text = Property.Description;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxValue.Text = Property.DefaultValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Property.SetValue(tbxValue.Text);
            DoSave = true;
            this.Close();
        }
    }
}
