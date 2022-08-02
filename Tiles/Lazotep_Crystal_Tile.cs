using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KagamiMod.Tiles
{
    public class Lazotep_Crystal_Tile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = true; // Emits Light

            drop = mod.ItemType("Lazotep_Crystal"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Lazotep Crystal");
            AddMapEntry(new Color(0, 255, 198), name); // Colour of Tile on Map
            minPick = 210; // What power pick minimum is needed to mine this block.
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.0f;
            g = 0.5f;
            b = 0.7f;
        }
    }
}