using System.Linq;
using ScriptCs.Contracts;

namespace ScriptCs.DotImage
{
    /// <summary>
    /// ScriptPack initialization / termination code.
    /// </summary>
    public class ScriptPack : IScriptPack
    {
        /// <inheritdoc/>
        public void Initialize(IScriptPackSession session)
        {
            // Common namespaces to include by default
            new[]
            {
                "Atalasoft.Imaging",
                "Atalasoft.Imaging.Codec",
                "System.Drawing"
            }.ToList().ForEach(session.ImportNamespace);
        }

        /// <inheritdoc/>
        public IScriptPackContext GetContext()
        {
            return new DotImage();
        }

        /// <inheritdoc/>
        public void Terminate()
        {
            // do nothing
        }
    }
}
