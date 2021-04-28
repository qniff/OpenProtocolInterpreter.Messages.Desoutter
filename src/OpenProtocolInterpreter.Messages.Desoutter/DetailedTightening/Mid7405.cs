using OpenProtocolInterpreter.Tightening;

namespace OpenProtocolInterpreter.Messages.Desoutter.DetailedTightening
{
    /// <summary>
    /// Last detailed tightening result data acknowledge
    /// <para>Acknowledgement of last detailed tightening result data.</para>
    /// <para>Message sent by: Integrator</para>
    /// <para>Answer: None</para>
    /// </summary>
    class Mid7405 : Mid, ITightening, IIntegrator
    {
        private const int LAST_REVISION = 1;
        public const int MID = 7405;

        public Mid7405() : this(LAST_REVISION)
        {

        }

        public Mid7405(int revision = LAST_REVISION) : base(MID, revision)
        {

        }
    }
}
