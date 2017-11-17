using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalLowLevelHooks;

namespace Rapidiff
{
    class Program
    {
        private static KeyboardHook keyboardHook;

        static void Main(string[] args)
        {

            Console.Beep();
            //keyboardHook = new KeyboardHook();
            //keyboardHook.KeyDown += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
            //keyboardHook.KeyUp += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);

            ////Installing the Keyboard Hooks
            //keyboardHook.Install();

            //Console.ReadLine();

            //keyboardHook.KeyDown -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
            //keyboardHook.KeyUp -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);
            //keyboardHook.Uninstall();
        }


        private static void keyboardHook_KeyUp(KeyboardHook.VKeys key)
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] KeyUp Event {" + key.ToString() + "}");
        }
        private static void keyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] KeyDown Event {" + key.ToString() + "}");
        }
    }
}
