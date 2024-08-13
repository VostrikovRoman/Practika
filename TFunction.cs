using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practika
{
    static class TFunction
    {
        static public void NextMainForm(string TypeNextMainForm, Form CurrentForm)
        {
            Type T = Type.GetType(TypeNextMainForm);
            object MainForm = Activator.CreateInstance(T);

            Program.Context.MainForm = (MainForm as Form);
            (MainForm as Form).Show();
            CurrentForm.Dispose();
        }
    }
}
