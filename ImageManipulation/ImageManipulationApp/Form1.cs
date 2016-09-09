using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImagePluginSDK;

namespace ImageManipulationApp
{
    public partial class Form1 : Form
    {
        //The collection of currently active plugins
        private PluginCollection _plugins = null;
        private List<Image> _imagesUploaded = null;

        public Form1()
        {
            InitializeComponent();
            // Make the Form an MDI parent.
            this.IsMdiContainer = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadPlugins();
        }

        private void btnUploadImages_Click(object sender, EventArgs e)
        {
            UploadFiles();
        }

        private void UploadFiles()
        {
            ImageFileDialog.Filter = "图片文件|*.bmp;*.png;*.jpg;*gif"; //显示所有图片文件
            if (ImageFileDialog.ShowDialog() != DialogResult.OK) return;

            _imagesUploaded = new List<Image>();
            foreach (var fileName in ImageFileDialog.FileNames)
            {
                _imagesUploaded.Add(Image.FromFile(fileName));
            }
        }

        private void LoadPlugins()
        {
            //Retrieve a plugin collection using our custom Configuration section handler
            try
            {
                _plugins = (PluginCollection)ConfigurationManager.GetSection("plugins");
                FillPluginMenu();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        private void FillPluginMenu()
        {
            //Create the delegate right from the start
            //no need to create one for each menu item seperatly
            EventHandler handler = OnPluginClick;

            foreach (IImageManipulationPlugin plugin in _plugins)
            {
                // Create a MenuStrip control with a new window.
                MenuStrip ms = new MenuStrip();
                ToolStripMenuItem windowMenu = new ToolStripMenuItem("Plugin");
                ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("&" + plugin.Name, null, handler);
                windowMenu.DropDownItems.Add(windowNewMenu);
                ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
                ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

                // Assign the ToolStripMenuItem that displays 
                // the list of child forms.
                ms.MdiWindowListItem = windowMenu;

                // Add the window ToolStripMenuItem to the MenuStrip.
                ms.Items.Add(windowMenu);

                // Dock the MenuStrip to the top of the form.
                ms.Dock = DockStyle.Top;

                // The Form.MainMenuStrip property determines the merge target.
                this.MainMenuStrip = ms;

                // Add the MenuStrip last.
                // This is important for correct placement in the z-order.
                this.Controls.Add(ms);
            }
        }

        private void OnPluginClick(object sender, EventArgs args)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string plugName = item.Text.Replace("&", "");
            ExecutePlugin(plugName);
        }

        //Execute a plugin by name
        private void ExecutePlugin(string pluginName)
        {
            if (_imagesUploaded == null) return;

            int width = int.Parse(tbWidth.Text.Trim());
            int height = int.Parse(tbHeight.Text.Trim());
            int radius = RadiusBar.Value;
            ImageContext context = new ImageContext(_imagesUploaded, radius, width, height);

            foreach (IImageManipulationPlugin plugin in _plugins)
            {
                if (plugin.Name == pluginName)
                {
                    plugin.PerformEffects(context);
                    ImageFileDialog.Dispose();
                    foreach (var image in context.ImagesAfterManipulate)
                    {
                        SaveFileDialog dialog = new SaveFileDialog();
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            image.Save(dialog.FileName);
                            image.Dispose();
                        }

                    }
                    return;
                }
            }
        }

        private void RadiusBar_Scroll(object sender, EventArgs e)
        {
            lblRadius.Text = RadiusBar.Value.ToString();
        }
    }
}
