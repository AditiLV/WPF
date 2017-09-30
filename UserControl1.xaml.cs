using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace thumbresize
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        double yadjust;
        double xadjust;
        public UserControl1()
        {
            InitializeComponent();
        }
        void onDragDelta(object sender, DragDeltaEventArgs e)
        {
            //Move the Thumb to the mouse position during the drag operation
            yadjust = myCanvasStretch.Height + e.VerticalChange;
            xadjust = myCanvasStretch.Width + e.HorizontalChange;
            if ((xadjust >= 0) && (yadjust >= 0))
            {
                myCanvasStretch.Width = xadjust;
                myCanvasStretch.Height = yadjust;
                Canvas.SetLeft(myThumb, Canvas.GetLeft(myThumb) +
                                        e.HorizontalChange);
                Canvas.SetTop(myThumb, Canvas.GetTop(myThumb) +
                                        e.VerticalChange);
               
            }
        }

    }
}
