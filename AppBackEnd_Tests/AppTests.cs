using System.Net;

namespace IDSP_Boiler_Plate_Tests;

public class UnitTest1{

    [Fact]
    public void Test1()
    {   
        var mockHttpHandler = new MockHttpHandler();
        var resp = new HttpResponseMessage(HttpStatusCode.Accepted);
        mockHttpHandler.setResponse(resp);

    }
}