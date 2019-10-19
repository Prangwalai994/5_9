using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crwating_Mock_Object_Using_Moq5_9.Mocking
{
    public static void Main()
    {
        var service = new VideoService();
        var title = service.ReadVideoTitle();
    }
}
