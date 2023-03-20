using System.Runtime.InteropServices;
using COMServerFramwork48;

namespace COMServer
{
    [ComVisible(true)]
    [Guid("12345678-ABCD-1234-ABCD-123456789ABC")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IServer
    {
        double ComputePi();
    }


    [ComVisible(true)]
    [Guid("98765432-ABCD-1234-ABCD-123456789ABC")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("COMServer.Server")]
    public class Server : IServer
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
