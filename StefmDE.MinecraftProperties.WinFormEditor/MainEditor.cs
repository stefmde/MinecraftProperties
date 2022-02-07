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
    public partial class MainEditor : Form
    {
        private ServerProperties _currentProperties;

        public MainEditor()
        {
            InitializeComponent();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            _currentProperties = new ServerProperties();
            _currentProperties.LoadFile(tbxConfigFileRead.Text);
            LoadPropertiesToUi();
        }

        private void btnNewConfig_Click(object sender, EventArgs e)
        {
            _currentProperties = new ServerProperties();
            LoadPropertiesToUi();
        }

        private void LoadPropertiesToUi()
        {
            dataGridView1.Rows.Clear();

            var type = typeof(ServerProperties);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var prop = (dynamic)property.GetValue(_currentProperties);

                dataGridView1.Rows.Add(prop.IniName, prop.Type.Name, prop.DefaultValue, prop.Value, prop.MinValue, prop.MaxValue, prop.AddedInVersion?.ToString(), prop.Description);
            }

            dataGridView1.Sort(ColumnKey, ListSortDirection.Ascending);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            Version version = null;

            if(tbxCompatibleVersion.TextLength > 0)
            {
                version = new Version(tbxCompatibleVersion.Text);
            }

            _currentProperties.WriteFile(tbxConfigFileWrite.Text, chbxWriteDefaults.Checked, chbxWriteDescriptions.Checked, version);
        }

        private void tbxConfigFileRead_TextChanged(object sender, EventArgs e)
        {
            tbxConfigFileWrite.Text = tbxConfigFileRead.Text;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if(index < 0)
            {
                return;
            }

            var key = dataGridView1.Rows[index].Cells[0].Value;

            var type = typeof(ServerProperties);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var prop = (dynamic)property.GetValue(_currentProperties);

                if(prop.IniName != key)
                {
                    continue;
                }

                if (prop.Type == typeof(int))
                {
                    PropertyEditorInt editor = new PropertyEditorInt(prop);
                    editor.ShowDialog();

                    if (!editor.DoSave)
                    {
                        return;
                    }
                    property.SetValue(_currentProperties, editor.Property);
                }
                else if (prop.Type == typeof(string))
                {
                    PropertyEditorString editor = new PropertyEditorString(prop);
                    editor.ShowDialog();

                    if (!editor.DoSave)
                    {
                        return;
                    }
                    property.SetValue(_currentProperties, editor.Property);
                }
                else if (prop.Type == typeof(bool))
                {
                    PropertyEditorBool editor = new PropertyEditorBool(prop);
                    editor.ShowDialog();

                    if (!editor.DoSave)
                    {
                        return;
                    }
                    property.SetValue(_currentProperties, editor.Property);
                }

                LoadPropertiesToUi();

                break;
            }
        }
    }
}
