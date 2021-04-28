namespace OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening
{
    /// <summary>
    /// Represents a Report Options entity
    /// </summary>
    public class ReportOptions
    {
        public bool TorqueMin { get; set; }
        public bool TorqueMax { get; set; }
        public bool AngleMin { get; set; }
        public bool AngleMax { get; set; }
        public bool RateMin { get; set; }
        public bool RateMax { get; set; }
        public bool TimeMin { get; set; }
        public bool TimeMax { get; set; }
        public bool MonitoringMin { get; set; }
        public bool MonitoringMax { get; set; }
        public bool C1C2 { get; set; }
        public bool AccelerationRate { get; set; }
        public bool Overcurrent { get; set; }
        public bool Surgeguard { get; set; }
        public bool ThermalContact { get; set; }
        public bool Flex { get; set; }
        public bool SPI { get; set; }
        public bool Prog { get; set; }
        public bool Group { get; set; }
        public bool SlaveError { get; set; }
        public bool Trigger { get; set; }
        public bool IMax { get; set; }
        public bool TimeOut { get; set; }
        public bool ExternalStop { get; set; }
        public bool Synchronisation { get; set; }
        public bool NotFinished { get; set; }
        // TODO add TighteningType data field
    }
}
