using Atalasoft.Imaging;
using ScriptCs.Contracts;

namespace ScriptCs.DotImage
{
    /// <summary>
    /// DotImage ScriptCs Script Pack interface.
    /// </summary>
    public class DotImage : IScriptPackContext
    {
        /// <summary>
        /// Loads specified image into AtalaImage object.
        /// </summary>
        /// <param name="path">File path of the image to load.</param>
        /// <param name="pageNumber">Optional page number inside the image (in case of multipage images).</param>
        /// <returns>Loaded image.</returns>
        public AtalaImage Load(string path, int pageNumber = 0)
        {
            return new AtalaImage(path, pageNumber, null);
        }
    }
}
