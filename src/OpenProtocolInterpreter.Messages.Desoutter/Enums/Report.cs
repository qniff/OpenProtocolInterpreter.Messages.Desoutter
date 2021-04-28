namespace OpenProtocolInterpreter.Messages.Desoutter
{
    /// <summary>
    /// Report field. Used in <see cref="DetailedTightening.Mid7404"/> and Mid7406.
    /// </summary>
    public enum Report
    {
        TORQUE_MIN = 0,
        TORQUE_MAX = 1,
        ANGLE_MIN = 2,
        ANGLE_MAX = 3,
        RATE_MIN = 4,
        RATE_MAX = 5,
        TIME_MIN = 6,
        TIME_MAX = 7,
        MONITORING_MIN = 8,
        MONITORING_MAX = 9,
        C1_C2 = 10,
        ACCELERATION_RATE = 11,
        OVERCURRENT = 12,
        SURGEGUARD = 13,
        THERMAL_CONTACT = 14,
        FLEX = 15,
        SPI = 16,
        PROG = 17,
        GROUP = 18,
        SLAVE_ERROR = 19,
        TRIGGER = 20,
        I_MAX = 21,
        TIME_OUT = 22,
        EXTERNAL_STOP = 23,
        SYNCHRONISATION = 24,
        NOT_FINISHED = 25,
        // TODO: ADD TIGHTENING TYPE
    }
}
