using System.Reflection;


namespace SpecflowNetCoreTesteBuscaCEP.Helpers
{
    public static class TestHelpers
    {
        public static string PastaDoExecutavel =>
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
