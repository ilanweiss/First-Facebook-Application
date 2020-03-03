using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstFBApp
{
    class Logic_CollageView
    {
        internal static void saveCollage(Image m_collage)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.Jpeg)|*.Jpeg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_collage.Save(saveFileDialog.FileName);
                    MessageBox.Show("Your collage saved!");
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
