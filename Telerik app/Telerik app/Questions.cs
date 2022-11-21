using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_app
{
    internal class Questions
    {
        public void QuestionsChange(int clicks, string[] headText, string[] mainText, string[] img, Label head, Label main, Image mainIMg)
        {
            head.Text = headText[clicks];
            main.Text = mainText[clicks];

            mainIMg.Source = img[clicks];
        }
    }
}
