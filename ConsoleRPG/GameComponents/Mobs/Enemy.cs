﻿namespace ConsoleRPG.Mobs
{
    internal enum Enemys
    { Zombie, Skeleton, Slime, Dragon, Burned, Iceman }

    internal class Enemy : Mob
    {
        public Enemy(float xp, int coins, string name, int level, int strengthPoints, int resistencePoints, int speedPoints) : base(level, name, strengthPoints, resistencePoints, speedPoints)
        {
            this.coins = coins;
            this.xp = xp;
        }

        public override float Xp { get => xp; set => xp = value; }

        // I know this isn't an AI.
        public void AI(Player player)
        {
            Attack(player, GameComponents.GameManager.rand.Next(AttackDamage, AttackDamage + 10));
            System.Console.WriteLine($"{name} attacks {player.name}");
            System.Console.ReadLine();
        }
    }
}