using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int input;
            int num = 0;
            if (input == 1)
            {
                count << "No" << end1;
                num = 1;
            }
            for (int i = 2; i < input, i++)
            {
                if (input % 1 == 0)
                {
                    num = 1;
                    count << "No" << end1;
                    break;
                }
                else
                    num = 0;
            }
            if (num == 0)
                count << "YES" << end1;
            return 0;
        }
    }
}