using OpenProtocolInterpreter.Converters;
using OpenProtocolInterpreter.Messages.Desoutter.Converters;
using OpenProtocolInterpreter.Tightening;

namespace OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening
{
    /// <summary>
    /// Last detailed tightening result data
    /// <para>Upload last detailed tightening result.</para>
    /// <para>Message sent by: Controller</para>
    /// <para>Answer: <see cref="Mid7405"/> Last tightening result data acknowledge</para>
    /// </summary>
    class Mid7404 : Mid, ITightening, IController
    {
        private readonly IValueConverter<int> _intConverter;
        private readonly IValueConverter<ReportOptions> _reportOptionsConverter;
        private const int LAST_REVISION = 1;
        public const int MID = 7404;

        public int SpindleNumber
        {
            get => GetField(1, (int)DataFields.SPINDLE_NUMBER).GetValue(_intConverter.Convert);
            set => GetField(1, (int)DataFields.SPINDLE_NUMBER).SetValue(_intConverter.Convert, value);
        }
        public int CycleNumber
        {
            get => GetField(1, (int)DataFields.CYCLE_NUMBER).GetValue(_intConverter.Convert);
            set => GetField(1, (int)DataFields.CYCLE_NUMBER).SetValue(_intConverter.Convert, value);
        }
        public int PhaseNumber
        {
            get => GetField(1, (int)DataFields.PHASE_NUMBER).GetValue(_intConverter.Convert);
            set => GetField(1, (int)DataFields.PHASE_NUMBER).SetValue(_intConverter.Convert, value);
        }
        public string PhaseName
        {
            get => GetField(1, (int)DataFields.PHASE_NAME).Value;
            set => GetField(1, (int)DataFields.PHASE_NAME).SetValue(value);
        }
        public string MethodName
        {
            get => GetField(1, (int)DataFields.METHOD_NAME).Value;
            set => GetField(1, (int)DataFields.METHOD_NAME).SetValue(value);
        }
        // TODO: add missing fields
        public Report Report
        {
            get => (Report)GetField(1, (int)DataFields.REPORT).GetValue(_intConverter.Convert);
            set => GetField(1, (int)DataFields.REPORT).SetValue(_intConverter.Convert, (int)value);
        }

        public Mid7404() : this(LAST_REVISION)
        {

        }

        public Mid7404(int revision = LAST_REVISION) : base(MID, revision)
        {
            var byteArrayConverter = new ByteArrayConverter();
            _intConverter = new Int32Converter();
            _reportOptionsConverter = new ReportOptionsConverter(byteArrayConverter);
        }

        public enum DataFields
        {
            SPINDLE_NUMBER,
            CYCLE_NUMBER,
            PHASE_NUMBER,
            PHASE_NAME,
            METHOD_NAME,
            REPORT
        }
    }
}
