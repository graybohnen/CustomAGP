private SplashScreenViewModel _ssvm;
protected override System.Windows.Window OnShowSplashScreen()
{
	if (_ssvm == null)
	{
        _ssvm = new SplashScreenViewModel();
    }
	var splash = new SplashScreen(Assembly.GetCallingAssembly());
    splash.DataContext = _ssvm;           
    return splash;
}