using OpenProtocolInterpreter.Converters;
using OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening;

namespace OpenProtocolInterpreter.Messages.Desoutter.Converters
{
    public class ReportOptionsConverter : BitConverter, IValueConverter<ReportOptions>
    {
        private readonly IValueConverter<byte[]> _byteArrayConverter;

        public ReportOptionsConverter(IValueConverter<byte[]> byteArrayConverter)
        {
            _byteArrayConverter = byteArrayConverter;
        }

        public ReportOptions Convert(string value)
        {
            var bytes = _byteArrayConverter.Convert(value);
            return ConvertFromBytes(bytes);
        }

        public string Convert(ReportOptions value)
        {
            byte[] bytes = ConvertToBytes(value);
            return _byteArrayConverter.Convert(bytes);
        }

        public string Convert(char paddingChar, int size, DataField.PaddingOrientations orientation, ReportOptions value) => Convert(value);

        public ReportOptions ConvertFromBytes(byte[] value)
        {
            return new ReportOptions
            {
                //byte 0
                TorqueMin = GetBit(value[0], 1),
                TorqueMax = GetBit(value[0], 2),
                AngleMin = GetBit(value[0], 3),
                AngleMax = GetBit(value[0], 4),
                RateMin = GetBit(value[0], 5),
                RateMax = GetBit(value[0], 6),
                TimeMin = GetBit(value[0], 7),
                TimeMax = GetBit(value[0], 8),
                //byte 1
                MonitoringMin = GetBit(value[1], 1),
                MonitoringMax = GetBit(value[1], 2),
                C1C2 = GetBit(value[1], 3),
                AccelerationRate = GetBit(value[1], 4),
                Overcurrent = GetBit(value[1], 5),
                Surgeguard = GetBit(value[1], 6),
                ThermalContact = GetBit(value[1], 7),
                Flex = GetBit(value[1], 8),
                //byte 2
                SPI = GetBit(value[2], 1),
                Prog = GetBit(value[2], 2),
                Group = GetBit(value[2], 3),
                SlaveError = GetBit(value[2], 4),
                Trigger = GetBit(value[2], 5),
                IMax = GetBit(value[2], 6),
                TimeOut = GetBit(value[2], 7),
                ExternalStop = GetBit(value[2], 8),
                //byte 3
                Synchronisation = GetBit(value[3], 1),
                NotFinished = GetBit(value[3], 2)
            };
        }

        public byte[] ConvertToBytes(ReportOptions value)
        {
            byte[] bytes = new byte[10];
            bytes[0] = SetByte(new bool[]
            {
                value.TorqueMin,
                value.TorqueMax,
                value.AngleMin,
                value.AngleMax,
                value.RateMin,
                value.RateMax,
                value.TimeMin,
                value.TimeMax
            });
            bytes[1] = SetByte(new bool[]
            {
                value.MonitoringMin,
                value.MonitoringMax,
                value.C1C2,
                value.AccelerationRate,
                value.Overcurrent,
                value.Surgeguard,
                value.ThermalContact,
                value.Flex
            });
            bytes[2] = SetByte(new bool[]
            {
                value.SPI,
                value.Prog,
                value.Group,
                value.SlaveError,
                value.Trigger,
                value.IMax,
                value.TimeOut,
                value.ExternalStop
            });
            bytes[3] = SetByte(new bool[]
            {
                value.Synchronisation,
                value.NotFinished
                // TODO: Add unused + tightening type 
            });
            bytes[4] = bytes[5] = bytes[6] = bytes[7] = bytes[8] = bytes[9] = 0;

            return bytes;
        }

        public byte[] ConvertToBytes(char paddingChar, int size, DataField.PaddingOrientations orientation, ReportOptions value) => ConvertToBytes(value);
    }
}
