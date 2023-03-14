﻿using System;
using System.Runtime.InteropServices;

namespace COMClient
{
    [ComVisible(true)]
    [Guid(ContractGuids.ServerClass)]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("COMServer.Server")]
    public class Server : IServer
    {
        double IServer.ComputePi()
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
