using Nova.UltraSound.Executable.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace Nova.UltraSound.Executable
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        #region Fields
        TouchWindow touchWindow = null;
        #endregion

        protected override void OnStartup(StartupEventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen("Resources/Images/SplashScreen.png");
            splashScreen.Show(true, true);
            base.OnStartup(e);
        }

        /// <summary>
        /// 创建window
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell()
        {
            touchWindow = Container.Resolve<TouchWindow>();
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        /// <summary>
        /// 初始化touchwindow
        /// </summary>
        /// <param name="shell"></param>
        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
        }

        /// <summary>
        /// 最后的show出来
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
