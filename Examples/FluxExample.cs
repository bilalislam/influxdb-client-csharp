using System;
using System.Threading.Tasks;
using InfluxDB.Client.Flux;

namespace Examples
{
    public static class FluxExample
    {
        public static async Task Main(string[] args)
        {
            var fluxClient = FluxClientFactory.Create("http://localhost:8086/");

//             var fluxQuery = "from(bucket: \"telegraf\")\n"
//   + "|> range(start: -5m)"
//   + "|> filter(fn: (r) => r._measurement == \"influxdb_httpd\")";

            var fluxQuery = "from(bucket: \"telegraf/autogen\")\n"
                                + "|> range(start: -5m)"
                                + "|> filter(fn: (r) => r._measurement == \"cpu\")"
                                + "|> mean()"
                                + "|> group(columns: [\"_time\", \"_start\", \"_stop\", \"_value\"], mode: \"except\")";

            await fluxClient.QueryAsync(fluxQuery, (cancellable, record) =>
                            {
                                // process the flux query records
                                Console.WriteLine(record.GetMeasurement() + ": " + record.GetValue());
                            },
                            (error) =>
                            {
                                // error handling while processing result
                                Console.WriteLine(error.ToString());

                            }, () =>
                            {
                                // on complete
                                Console.WriteLine("Query completed");
                            });
        }
    }
}