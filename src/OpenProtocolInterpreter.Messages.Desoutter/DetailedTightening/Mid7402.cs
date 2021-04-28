using OpenProtocolInterpreter.Tightening;

namespace OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening
{
    /// <summary>
    /// Last Desoutter tightening result data subscribe
    /// <para>
    ///     This command is used to subscribe to the tightening results, from the controller.
    ///     The controller will then start to send phases results (<see cref="Mid7404"/>) and cycle results(MID 7406)
    ///     event telegrams after every tightening.
    /// </para>
    /// <para>Message sent by: Integrator</para>
    /// <para>
    ///     Answer: <see cref="Communication.Mid0005"/> Command accepted or 
    ///             <see cref="Communication.Mid0004"/> Command error, Last tightening subscription already exists or MID revision not supported
    /// </para>
    /// </summary>
    class Mid7402 : Mid, ITightening, IIntegrator
    {
        private const int LAST_REVISION = 1;
        public const int MID = 7402;

        public Mid7402() : this(LAST_REVISION)
        {

        }

        public Mid7402(int revision = LAST_REVISION, int? noAckFlag = 0) : base(MID, revision, noAckFlag)
        {

        }
    }
}
