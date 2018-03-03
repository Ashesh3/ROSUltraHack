using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Whynot.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Whynot.Properties.Resources.resourceMan == null)
          Whynot.Properties.Resources.resourceMan = new ResourceManager("RosPublicCheat.Properties.Resources", typeof (Whynot.Properties.Resources).Assembly);
        return Whynot.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Whynot.Properties.Resources.resourceCulture;
      }
      set
      {
        Whynot.Properties.Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
