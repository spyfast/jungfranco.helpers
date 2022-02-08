using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JungFranco.Helpers.Events
{
    public static class KeyPress
    {
        /// <summary>
        /// Запрет ввода букв.
        /// </summary>
        public static void IsNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }
    }
}
