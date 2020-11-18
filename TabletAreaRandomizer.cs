using System;
using OpenTabletDriver.Plugin.Logging;
using OpenTabletDriver.Plugin.Platform.Pointer;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Attributes;

namespace TabletAreaRandomizer
{
    [PluginName("Tablet Area Randomizer")]
    public class TabletAreaRandomizer : AbsoluteOutputMode
    {

        public override IVirtualTablet VirtualTablet {get;}
        [Property("Minimum Width"), Unit("mm")]
        public float minWidth { set; get; }

        [Property("Minimum Height"), Unit("mm")]
        public float minHeight { set; get; }

        [Property("Maximum Width"), Unit("mm")]
        public float maxWidth { set; get; }

        [Property("Maximim Height"), Unit("mm")]
        public float maxHeight { set; get; }

        [Property("Randomization delay"), Unit("s")]
        public int randDelay {set; get;}
    }
}
