using System;

namespace MonoWithWF
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            form.Show();
            form.game = new Game1(form.pctSurface.Handle, form, form.pctSurface);
            form.game.Run();
        }
    }
#endif
}
