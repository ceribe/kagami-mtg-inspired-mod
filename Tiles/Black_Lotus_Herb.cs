using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;

namespace KagamiMod.Tiles
{
	public class Black_Lotus_Herb : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = true;
			//Main.tileAlch[Type] = true;
			Main.tileNoFail[Type] = true;
            Main.tileBlockLight[Type] = true; // Emits Light
            Main.tileLighted[Type] = true; // ???

            //Main.tileLavaDeath[Type] = true;
            //dustType = -1;
            //disableSmartCursor = true;
            //AddMapEntry(new Color(13, 88, 130), "Banner");
            //TileObjectData.newTile.Width = 1;
            //TileObjectData.newTile.Height = 1;
            //TileObjectData.newTile.Origin = Point16.Zero;
            //TileObjectData.newTile.UsesCustomCanPlace = true;
            //TileObjectData.newTile.CoordinateHeights = new int[]
            //{
            //	20
            //};
            //TileObjectData.newTile.CoordinateWidth = 16;
            //TileObjectData.newTile.CoordinatePadding = 2;
            //TileObjectData.newTile.DrawYOffset = -1;
            //TileObjectData.newTile.StyleHorizontal = true;
            //TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.AlternateTile, TileObjectData.newTile.Width, 0);
            //TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
            //TileObjectData.newTile.LavaDeath = true;
            //TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
            //TileObjectData.addBaseTile(out TileObjectData.StyleAlch);
            TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
			TileObjectData.newTile.AnchorValidTiles = new int[]
			{
                TileID.Mud,
                TileID.JungleGrass
            };
			TileObjectData.newTile.AnchorAlternateTiles = new int[]
			{
				78, //ClayPot
				TileID.PlanterBox
			};
			TileObjectData.addTile(Type);
			//drop = mod.ItemType()
		}
		//public override bool CanPlace(int i, int j)
		//{
		//	return base.CanPlace(i, j);
		//}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override bool Drop(int i, int j)
		{
			int stage = Main.tile[i, j].frameX / 18;
			if (stage == 2)
			{
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType("Black_Lotus"));
            }
            if (stage != 2)
            {
                Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType("Black_Lotus_Seeds"), 1);
            }
            return false;
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].frameX == 0)
			{
				Main.tile[i, j].frameX += 18;
			}
			else if (Main.tile[i, j].frameX == 18)
			{
				Main.tile[i, j].frameX += 18;
			}
		}

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0.2f;
            b = 0.8f;
        }
        //public override void RightClick(int i, int j)
        //{
        //	base.RightClick(i, j);
        //}
    }
}
