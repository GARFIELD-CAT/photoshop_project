using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPhotoshop
{
    class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
            var window = new MainWindow();
            window.AddFilter(new PixelFilter<LighteningParameters>(
                "����������/����������",
                (original, parameters) => original * parameters.Coefficient
            ));
            window.AddFilter(new PixelFilter<EmptyParameters>(
                "50 �������� ������ / ��� ����",
                (original, parameters) => {
                    var lightness = original.R + original.G + original.B;
                    lightness /= 3;

                    return new Pixel(lightness, lightness, lightness);
                }
            ));

            window.AddFilter(new TransformFilter<RotationParameters>(
                "��������� ��������", new RotateTransformer()
            ));

            Application.Run(window);
        }
	}
}
