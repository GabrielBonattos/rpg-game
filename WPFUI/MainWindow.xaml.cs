using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.Controllers; //WPFUI tem referencia ao Engine Project

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSessionController gameSession;
        public MainWindow()
        {
            InitializeComponent();

            gameSession = new GameSessionController();

            DataContext = gameSession;
            // DataContext e uma built-in propriedade do xmal
            // a mainWindow tem a variavel dataContext guardando o objeto GameSessionController que tem a propriedade CurrentPlayer
        }
    }
}