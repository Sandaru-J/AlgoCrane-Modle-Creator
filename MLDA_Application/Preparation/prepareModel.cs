using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDA_Application.Preparation
{
    public class prepareModel
    {
        private string dsPath;

        public string path
        {
            get { return dsPath; }
            set { dsPath = value;
                Console.WriteLine("model:" + dsPath);
            }
        }

        public frmP_Main send_path
        {
            get => default;
            set
            {
            }
        }
    }
}
