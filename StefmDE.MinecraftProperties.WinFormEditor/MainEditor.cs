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
        public MainEditor()
        {
            InitializeComponent();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            ServerProperties properties = new ServerProperties();
            properties.LoadFile(tbxConfigFile.Text);
            LoadPropertiesToUi(properties);
        }

        private void LoadPropertiesToUi(ServerProperties serverProperties)
        {
            dataGridView1.Rows.Clear();

            var type = typeof(ServerProperties);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var prop = (dynamic)property.GetValue(serverProperties);

                dataGridView1.Rows.Add(prop.IniName, prop.Type.Name, prop.DefaultValue, prop.MinValue, prop.MaxValue, prop.Value, prop.AddedInVersion?.ToString(), prop.Description);
            }



            dataGridView1.Sort(ColumnKey, ListSortDirection.Ascending);
        }
    }
}
