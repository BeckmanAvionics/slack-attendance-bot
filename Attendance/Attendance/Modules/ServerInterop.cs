using Attendance.Classes;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Attendance.Modules
{
    public static class ServerInterop
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private const string MIME_APPLICATION_JSON = "application/json";

        /// <summary>
        /// Gets attendance information for the specified date.
        /// </summary>
        /// <param name="path">The server address hosting the application.</param>
        /// <param name="date">The date of the meeting.</param>
        /// <returns>An AttendanceLogResponse containing a list of members present at the meeting.</returns>
        public static async Task<LogResponse> GetAttendanceAsync(string path, DateTime date) =>
            (LogResponse)JsonSerializer.Deserialize(await SendCommandAsync(path, new CommandRequest()
            {
                token = "UI",
                command = "attendance",
                text = date.ToString("yyyy-M-d", CultureInfo.InvariantCulture.DateTimeFormat),
                user_name = "AttendanceUI"
            }), typeof(LogResponse));

        /// <summary>
        /// Sends a command request to the server and returns a string response.
        /// </summary>
        /// <param name="path">The server address hosting the application.</param>
        /// <param name="commandRequest">The command request object.</param>
        /// <returns>A string containing the response as a JSON or plain-text.</returns>
        public static async Task<string> SendCommandAsync(string path, CommandRequest commandRequest) => await (await httpClient.PostAsync(path, new StringContent(JsonSerializer.Serialize(commandRequest, typeof(CommandRequest)), Encoding.UTF8, MIME_APPLICATION_JSON))).Content.ReadAsStringAsync();
    }
}
