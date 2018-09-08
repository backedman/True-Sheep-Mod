using Terraria.ModLoader;

namespace Sheep
{
    class Sheep : Mod
    {
        public Sheep()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
