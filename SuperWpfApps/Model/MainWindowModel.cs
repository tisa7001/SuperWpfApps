using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MahApps.Metro.IconPacks;

namespace SuperWpfApps.Model
{
    public class MainWindowModel
    {

        /// <summary>
        /// Update Image on Toggle Button 
        /// </summary>
        public void ToggleBtnImageUpdate(ImageSource _togglebtnImageSource)
        {
            _togglebtnImageSource = new BitmapImage(new Uri(@"../Assets/arrow - left.png"));
        }

        
    }
}
