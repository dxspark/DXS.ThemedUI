namespace DXS.ThemedUI
{
    public static class ThemedUI
    {
        public static ITheme CurrentTheme { get; private set; } = new DefaultTheme();

        public static void Init(ITheme selectedTheme = null)
        {
            CurrentTheme = selectedTheme ?? new DefaultTheme();
        }
    }
}
