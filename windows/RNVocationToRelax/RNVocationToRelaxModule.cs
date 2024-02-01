using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Vocation.To.Relax.RNVocationToRelax
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNVocationToRelaxModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNVocationToRelaxModule"/>.
        /// </summary>
        internal RNVocationToRelaxModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNVocationToRelax";
            }
        }
    }
}
