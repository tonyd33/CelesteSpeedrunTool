using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Celeste.Mod.SpeedrunTool.SaveLoad.Component;
using Microsoft.Xna.Framework;
using Monocle;
using On.Celeste.Pico8;
using On.FMOD;

namespace Celeste.Mod.SpeedrunTool.SaveLoad.Actions
{
    public class FinalBossAction : AbstractEntityAction
    {
        private Dictionary<EntityID, FinalBoss> _savedFinalBosses = new Dictionary<EntityID, FinalBoss>();

        public override void OnQuickSave(Level level)
        {
            _savedFinalBosses = level.Tracker.GetDictionary<FinalBoss>();
        }

        private void RestoreFinalBossState(On.Celeste.FinalBoss.orig_ctor_EntityData_Vector2 orig, FinalBoss self,
            EntityData data,
            Vector2 offset)
        {
            orig(self, data, offset);
            EntityID entityId = data.ToEntityId();
            self.SetEntityId(entityId);

            if (IsLoadStart && _savedFinalBosses.ContainsKey(entityId))
            {
                FinalBoss savedFinalBoss = _savedFinalBosses[entityId];

                int nodeIndex = (int) savedFinalBoss.GetPrivateField("nodeIndex");
                Vector2[] nodes = (Vector2[]) savedFinalBoss.GetPrivateField("nodes");
                bool startHit = (bool) savedFinalBoss.GetPrivateField("startHit");

                self.Position = nodes[nodeIndex];

                if (data.Int("patternIndex") == 0 && nodeIndex >= 1)
                {
                    self.SetPrivateField("patternIndex", 1);
                }

                if (startHit)
                {
                    nodeIndex--;
                }

                self.SetPrivateField("nodeIndex", nodeIndex);
                self.Add(new RestoreFinalBossStateComponent(savedFinalBoss));
            }
        }

        public override void OnClear()
        {
            _savedFinalBosses.Clear();
        }

        public override void OnLoad()
        {
            On.Celeste.FinalBoss.ctor_EntityData_Vector2 += RestoreFinalBossState;
        }

        public override void OnUnload()
        {
            On.Celeste.FinalBoss.ctor_EntityData_Vector2 -= RestoreFinalBossState;
        }

        private class RestoreFinalBossStateComponent : Monocle.Component
        {
            private readonly FinalBoss _savedFinalBoss;

            public RestoreFinalBossStateComponent(FinalBoss savedFinalBoss) : base(true, false)
            {
                _savedFinalBoss = savedFinalBoss;
            }

            public override void Update()
            {
                List<Entity> fallingBlocks = Entity.GetPrivateField("fallingBlocks") as List<Entity>;
                List<Entity> savedFallingBlocks = _savedFinalBoss.GetPrivateField("fallingBlocks") as List<Entity>;

                if (fallingBlocks == null || savedFallingBlocks == null)
                {
                    RemoveSelf();
                    return;
                }

                if (fallingBlocks.Count == 0)
                {
                    RemoveSelf();
                    return;
                }
                
                if (fallingBlocks.Count != savedFallingBlocks.Count)
                {
                    fallingBlocks.RemoveAll(entity =>
                        savedFallingBlocks.All(savedEntity => savedEntity.Position != entity.Position));
                    RemoveSelf();
                }
            }
        }
    }
}