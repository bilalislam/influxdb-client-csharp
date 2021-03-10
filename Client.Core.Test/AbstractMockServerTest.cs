using NUnit.Framework;
using WireMock.ResponseBuilders;
using WireMock.Server;
using WireMock.Settings;

namespace InfluxDB.Client.Core.Test
{
    public class AbstractMockServerTest : AbstractTest
    {
        protected FluentMockServer MockServer;
        protected string MockServerUrl;

        [SetUp]
        public new void SetUp()
        {
            if (MockServer != null && MockServer.IsStarted)
            {
                return;
            }
            
            MockServer = FluentMockServer.Start(new FluentMockServerSettings
            {
                UseSSL = false
            });

            MockServerUrl = MockServer.Urls[0];
        }

        [TearDown]
        public void ResetServer()
        {
            MockServer.Reset();
        }
        
        [OneTimeTearDown]
        public void ShutdownServer()
        {
            MockServer?.Stop();
        }

        protected IResponseBuilder CreateErrorResponse(string influxDbError)
        {
            var body = "{\"error\":\"" + influxDbError + "\"}";

            return Response.Create().WithStatusCode(500)
                .WithHeader("X-Influx-Error", influxDbError)
                .WithBody(body);
        }

        protected IResponseBuilder CreateResponse(string data, string contentType = "text/csv")
        {
            return Response.Create()
                .WithHeader("Content-Type", contentType + "; charset=utf-8")
                .WithHeader("Date", "Tue, 26 Jun 2018 13:15:01 GMT")
                .WithBody(data);
        }
    }
}