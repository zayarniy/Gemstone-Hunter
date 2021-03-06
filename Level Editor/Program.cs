using System;

namespace Level_Editor
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
        static void Main(string[] args)
        {
            MapEditor form = new MapEditor();
            form.Show();
            form.game = new Game1(
            form.pctSurface.Handle,
            form,
            form.pctSurface);
            form.game.Run();
        }
    }
#endif
}
