using System;
using System.Diagnostics.CodeAnalysis;

namespace Attendance.Classes
{
    /// <summary>
    /// Encodes a slash command request for interoperability with the Slack API.
    /// https://api.slack.com/interactivity/slash-commands
    /// </summary>
    [Serializable]
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "JSON & Server Interoperability")]
    public class CommandRequest
    {
        private string _command = "";

        /// <summary>
        /// This is a verification token, a deprecated feature that you shouldn't use any more. It was used to verify that requests were legitimately being sent by Slack to your app, but you should use the signed secrets functionality to do this instead.
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// The command that was typed in to trigger this request. This value can be useful if you want to use a single Request URL to service multiple Slash Commands, as it lets you tell them apart.
        /// </summary>
        public string command
        {
            get => _command;
            set => _command = value.StartsWith("/") ? value : ("/" + value);
        }

        /// <summary>
        /// This is the part of the Slash Command after the command itself, and it can contain absolutely anything that the user might decide to type. It is common to use this text parameter to provide extra context for the command. 
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// A temporary webhook URL that you can use to generate messages responses.
        /// </summary>
        public string response_url { get; set; }

        /// <summary>
        /// A short-lived ID that will let your app open a modal.
        /// </summary>
        public string trigger_id { get; set; }

        /// <summary>
        /// The ID of the user who triggered the command.
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// The plain text name of the user who triggered the command.
        /// </summary>
        public string user_name { get; set; }

        public string team_id { get; set; }
        public string team_name { get; set; }

        public string enterprise_id { get; set; }
        public string enterprise_name { get; set; }

        public string channel_id { get; set; }
        public string channel_name { get; set; }
    }
}
