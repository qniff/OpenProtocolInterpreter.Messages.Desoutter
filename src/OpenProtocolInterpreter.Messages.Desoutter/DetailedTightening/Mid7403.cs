using OpenProtocolInterpreter.Tightening;

namespace OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening
{
    /// <summary>
    /// Last Desoutter tightening result data subscribe
    /// <para>
    ///     This command is used to stop receiving phases and cycle results from the controller.
    /// </para>
    /// <para>Message sent by: Integrator</para>
    /// <para>
    ///     Answer: <see cref="Communication.Mid0005"/> Command accepted or 
    ///             <see cref="Communication.Mid0004"/> Command error, Last tightening subscription does not exist or MID revision not supported
    /// </para>
    /// </summary>
    class Mid7403 : Mid, ITightening, IIntegrator
    {
        private const int LAST_REVISION = 1;
        public const int MID = 7403;

        public Mid7403() : this(LAST_REVISION)
        {

        }

        public Mid7403(int revision = LAST_REVISION, int? noAckFlag = 0) : base(MID, revision, noAckFlag)
        {

        }
    }
}
