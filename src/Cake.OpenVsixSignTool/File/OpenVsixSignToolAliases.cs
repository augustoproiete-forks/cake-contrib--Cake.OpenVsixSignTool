using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.OpenVsixSignTool
{
    /// <summary>
    /// Contains functionality for working with OpenVsixSignTool.
    /// </summary>
    [CakeAliasCategory("Signing")]
    public static partial class OpenVsixSignToolAliases
    {
        /// <summary>
        /// Invokes sign with array of from arguments.
        /// </summary>
        /// <param name="context">Cake context</param>
        /// <param name="settings">The file settings.</param>
        [CakeMethodAlias]
        public static void OpenVsixSignToolFile(this ICakeContext context, OpenVsixSignToolSignSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            var runner = new OpenVsixSignToolRunner<OpenVsixSignToolSignSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.Run("file", settings, new string[0]);
        }
    }
}
