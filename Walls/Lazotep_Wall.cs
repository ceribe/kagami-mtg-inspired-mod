using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Walls
{
	public class Lazotep_Wall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("Lazotep_Wall");
			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
            r = 0.0f;
            g = 0.2f;
            b = 0.4f;
        }
	}
}