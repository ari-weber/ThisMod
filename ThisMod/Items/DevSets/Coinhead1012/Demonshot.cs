using System;

using Microsoft.Xna.Framework;

using Microsoft.Xna.Framework.Graphics;

using Terraria;

using Terraria.ModLoader;


namespace ThisMod.Items.DevSets.Coinhead1012 //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly

{    

    public class Demonshot : ModProjectile 

    {

        public override void SetDefaults()

        {

            

            projectile.width = 6; //Set the hitbox width

            projectile.height = 6; //Set the hitbox height

            projectile.timeLeft = 2000; //The amount of time the projectile is alive for

            projectile.penetrate = 20; //Tells the game how many enemies it can hit before being destroyed

            projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not

            projectile.hostile = false; //Tells the game whether it is hostile to players or not

            projectile.tileCollide = false; //Tells the game whether or not it can collide with a tile

            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water

            projectile.magic = true; //Tells the game whether it is a ranged projectile or not

            projectile.aiStyle = 1; //How the projectile works, this is no AI, it just goes a straight path

        }

    }

}