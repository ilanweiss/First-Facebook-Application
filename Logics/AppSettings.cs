using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FirstFBApp
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public String LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(300, 330);
            RememberUser = false;
            LastAccessToken = null;
        }

    }
}
