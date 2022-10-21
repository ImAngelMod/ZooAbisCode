﻿using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria;
using Terraria.ID;
using ZooAbis.ButterFlyWeapons;

namespace ZooAbis.Edits
{
    public class QueenBee : GlobalNPC
        {
            public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
            {
                if (npc.type == NPCID.QueenBee)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BuzzerFly>(), 2));
                }
            }
        }
    }
