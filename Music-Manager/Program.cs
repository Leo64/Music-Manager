using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Music_Manager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        static Timer oTimer = new Timer();
        static int contador = 0;
        static bool b = false;

        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_Splash ofrm_Splash = new frm_Splash();

            oTimer.Tick += new EventHandler(TimerPick);

            oTimer.Interval = 1000;

            oTimer.Start();

            while (b == false)
            {
                ofrm_Splash.Show();

                Application.DoEvents();

                if (b == true)
                {
                    ofrm_Splash.Dispose();
                    Application.Run(new frm_Principal());
                    break;
                }
            }
        }

        static void TimerPick (Object sender, EventArgs e)
        {
            oTimer.Stop();

            if (contador < 4)
            {
                oTimer.Enabled = true;
                contador++;
            }

            if (contador == 4)
                b = true;
        }
    }
}