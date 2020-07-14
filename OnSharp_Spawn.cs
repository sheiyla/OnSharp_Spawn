using Onsharp.Entities;
using Onsharp.Events;
using Onsharp.Plugins;
using Onsharp.Threading;

namespace OnSharp_Chat
{

    [PluginMeta("onsharp-spawn", "Spawn Plugin", "1.0", "Codeskull", IsDebug = true)]
    public class OnSharp_Spawn : Plugin
    {

        public override void OnStart() { }
        public override void OnStop() { }

        [ServerEvent(EventType.PlayerSpawn)]
        public void OnPlayerSpawn(Player player)
        {
            Timer.Delay(1000, () =>
            {
                player.SetPosition(125773.000000, 80246.000000, 1645.000000);
                player.Heading = 0;
            });
        }

    }

}