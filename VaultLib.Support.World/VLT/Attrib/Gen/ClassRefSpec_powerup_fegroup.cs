using VaultLib.Core.Data;
using VaultLib.Core.Types;
using VaultLib.Core.Types.Attrib.Gen;

namespace VaultLib.Support.World.VLT.Attrib.Gen
{
    [VLTTypeInfo("Attrib::Gen::ClassRefSpec_powerup_fegroup")]
    public class ClassRefSpec_powerup_fegroup : ClassRefSpec_template
    {
        public ClassRefSpec_powerup_fegroup(VltClass @class, VltClassField field, VltCollection collection) : base(@class, field, collection, "powerup_fegroup")
        {
        }

        public ClassRefSpec_powerup_fegroup(VltClass @class, VltClassField field) : base(@class, field, "powerup_fegroup")
        {
        }
    }
}