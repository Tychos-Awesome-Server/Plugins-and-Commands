using System;
using System.Threading;

using MCGalaxy;
using MCGalaxy.Tasks;

namespace MCGalaxy
{
    public class Compass : Plugin
    {
        public override string creator { get { return "Tycho10101"; } }
        public override string MCGalaxy_Version { get { return "1.9.3.8"; } }
        public override string name { get { return "TAS Compass"; } }

        public static SchedulerTask task;

        public override void Load(bool startup)
        {
            task = Server.MainScheduler.QueueRepeat(CheckDirection, null, TimeSpan.FromMilliseconds(50));
        }

        void CheckDirection(SchedulerTask task)
        {
            Player[] players = PlayerInfo.Online.Items;
            foreach (Player p in players)
            {
                if (!p.Supports(CpeExt.MessageTypes)) continue;

                int yaw = Orientation.PackedToDegrees(p.Rot.RotY);

                // If value is the same, don't bother sending status packets to the client
                if (p.Extras.GetInt("COMPASS_VALUE") == yaw) continue;

                // Store yaw in extras values so we can retrieve it above
                p.Extras["COMPASS_VALUE"] = yaw;

                p.SendCpeMessage(CpeMessageType.Status1, "%4TAS %rCompass");

                if (yaw >= 355 || yaw < 5)
                    p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%f|%f..%rN%f..%f|%f..%f|%f..%f]");
		
                if (yaw >= 5 && yaw < 15)
					p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%f|%f..%rN%f..%f|%f..%f|%f..%rE%f]");
				
				if (yaw >= 15 && yaw < 25)
					p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%f|%f..%rN%f..%f|%f..%f|%f..%rE%f.%f]");

				if (yaw >= 25 && yaw < 35)
					p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%rN%f..%f|%f..%f|%f..%rE%f..%f]");

				if (yaw >= 35 && yaw < 45)
					p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%rN%f..%f|%f..%f|%f..%rE%f..%f|%f]");

				if (yaw >= 45 && yaw < 55)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%rN%f..%f|%f..%f|%f..%rE%f..%f|%f.%f]");

				if (yaw >= 55 && yaw < 65)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%rN%f..%f|%f..%f|%f..%rE%f..%f|%f..%f]");

				if (yaw >= 65 && yaw < 75)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%rN%f..%f|%f..%f|%f..%rE%f..%f|%f..%f|%f]");

				if (yaw >= 75 && yaw < 85)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%rN%f..%f|%f..%f|%f..%rE%f..%f|%f..%f|%f.%f]");

				if (yaw >= 85 && yaw < 95)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%f|%f..%rE%f..%f|%f..%f|%f..%f]");

				if (yaw >= 95 && yaw < 105)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%f|%f..%rE%f..%f|%f..%f|%f..%rS%f]");

				if (yaw >= 105 && yaw < 115)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%f|%f..%rE%f..%f|%f..%f|%f..%rS%f.%f]");

				if (yaw >= 115 && yaw < 125)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%rE%f..%f|%f..%f|%f..%rS%f..%f]");

				if (yaw >= 125 && yaw < 135)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%rE%f..%f|%f..%f|%f..%rS%f..%f|%f]");

				if (yaw >= 135 && yaw < 145)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%rE%f..%f|%f..%f|%f..%rS%f..%f|%f.%f]");

				if (yaw >= 145 && yaw < 155)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%rE%f..%f|%f..%f|%f..%rS%f..%f|%f..%f]");

				if (yaw >= 155 && yaw < 165)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%rE%f..%f|%f..%f|%f..%rS%f..%f|%f..%f|%f]");

				if (yaw >= 165 && yaw < 175)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%rE%f..%f|%f..%f|%f..%rS%f..%f|%f..%f|%f.%f]");

				if (yaw >= 175 && yaw < 185)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%f|%f..%rS%f..%f|%f..%f|%f..%f]");

				if (yaw >= 185 && yaw < 195)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%f|%f..%rS%f..%f|%f..%f|%f..%rW%f]");

				if (yaw >= 195 && yaw < 205)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%f|%f..%rS%f..%f|%f..%f|%f..%rW%f.%f]");

				if (yaw >= 205 && yaw < 215)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%rS%f..%f|%f..%f|%f..%rW%f..%f]");

				if (yaw >= 215 && yaw < 225)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%rS%f..%f|%f..%f|%f..%rW%f..%f|%f]");

				if (yaw >= 225 && yaw < 235)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%rS%f..%f|%f..%f|%f..%rW%f..%f|%f.%f]");

				if (yaw >= 235 && yaw < 245)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%rS%f..%f|%f..%f|%f..%rW%f..%f|%f..%f]");

				if (yaw >= 245 && yaw < 255)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%rS%f..%f|%f..%f|%f..%rW%f..%f|%f..%f|%f]");

				if (yaw >= 255 && yaw < 265)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%rS%f..%f|%f..%f|%f..%rW%f..%f|%f..%f|%f.%f]");

				if (yaw >= 265 && yaw < 275)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%f|%f..%rW%f..%f|%f..%f|%f..%f]");

				if (yaw >= 275 && yaw < 285)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%f|%f..%rW%f..%f|%f..%f|%f..%rN%f]");

				if (yaw >= 285 && yaw < 295)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%f|%f..%rW%f..%f|%f..%f|%f..%rN%f.%f]");

				if (yaw >= 295 && yaw < 305)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%f|%f..%rW%f..%f|%f..%f|%f..%rN%f..%f]");

				if (yaw >= 305 && yaw < 315)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%f|%f..%rW%f..%f|%f..%f|%f..%rN%f..%f|%f]");

				if (yaw >= 315 && yaw < 325)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f|%f..%rW%f..%f|%f..%f|%f..%rN%f..%f|%f.%f]");

				if (yaw >= 325 && yaw < 335)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f..%rW%f..%f|%f..%f|%f..%rN%f..%f|%f..%f]");

				if (yaw >= 335 && yaw < 345)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%f.%rW%f..%f|%f..%f|%f..%rN%f..%f|%f..%f|%f]");

				if (yaw >= 345 && yaw < 355)
			        p.SendCpeMessage(CpeMessageType.Status2, "%f[%rW%f..%f|%f..%f|%f..%rN%f..%f|%f..%f|%f.%f]");
				
            }
        }

        public override void Unload(bool shutdown)
        {
            Server.MainScheduler.Cancel(task);
        }
    }
}