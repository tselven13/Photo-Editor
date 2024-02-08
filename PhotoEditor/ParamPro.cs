using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PhotoEditor
{
    public static class ParamPro
    {
        public static string path;
        public static string fname;
        public static int abHeight;
        public static int abWidth;
        public static int Res;
        public static string tool;
        public static string[] toolBar = { "undo", "red", "recsel", "text", "rotate", "move", "flip", "pen", "eraser", "crop", "stamp", "Brush" };
        public static void toolS(int toolno)
        {
            tool = toolBar[toolno];
        }
        public static string LName;
        public static string CIndex;
    }
}
