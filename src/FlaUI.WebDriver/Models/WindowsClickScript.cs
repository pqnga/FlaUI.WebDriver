﻿namespace FlaUI.WebDriver.Models
{
    public class WindowsClickScript
    {
        public string? ElementId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public string? Button { get; set; }
        public string[]? ModifierKeys { get; set; }
        public int? DurationMs { get; set; }
        public int? Times { get; set; }
        public int? InterClickDelayMs { get; set; }
    }
}