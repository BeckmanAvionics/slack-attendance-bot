using System;
using System.Diagnostics.CodeAnalysis;

namespace Attendance.Classes
{
    [Serializable]
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "JSON & Server Interoperability")]
    public class LogResponse
    {
        [SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Fields are not currently JSON-serializable. Replace 'students' with a field once field-serialization support is available.")]
        public string[] students { get; set; }
    }
}
