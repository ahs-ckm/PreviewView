using MyApplication;

namespace PreviewView
{
	public class Launcher : ILauncher
	{
		public void Launch(string[] args)
		{
            //new MainWindow().ShowDialog();
            new PreviewView.Form1().ShowDialog();
        }
	}
}