public SplashScreenViewModel(Assembly assembly)
{
    AppName = "Config Demo pt 2";
    Author = "Gray Bohnen";            
    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
    string version = fileVersionInfo.ProductVersion;
    AssemblyVersion = $"Build {version}";
}