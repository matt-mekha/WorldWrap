using Terraria;
using Terraria.ModLoader;

namespace WorldWrap
{
	public class WorldWrapPlayer : ModPlayer
	{

		private const float worldEdge = 800;

		public override void PostUpdate()
		{
			float x = player.position.X;
			if (x <= worldEdge)
			{
				x += Main.rightWorld - 2 * worldEdge;
			}
			else if (x >= Main.rightWorld - worldEdge)
			{
				x += -Main.rightWorld + 2 * worldEdge;
			}
			player.position.X = x;
		}
	}
}

