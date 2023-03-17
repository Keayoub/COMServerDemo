using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMServerFramwork48
{

    [ComVisible(true)]
    [Guid("BB41BA7B-036F-49B5-B7D7-BA2B1B47F514")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("COMServer.ServerFramework")]
    public class Server
    {
        public double ComputePi()
        {
            double sum = 0.0;
            int sign = 1;
            for (int i = 0; i < 1024; ++i)
            {
                sum += sign / (2.0 * i + 1.0);
                sign *= -1;
            }

            return 4.0 * sum;
        }
    }
}
