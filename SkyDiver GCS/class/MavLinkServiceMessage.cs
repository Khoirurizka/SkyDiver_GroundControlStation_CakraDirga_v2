using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MavLink;

namespace SkyDiver_GCS
{
    public static class MavLinkServiceMessage
    {
        public static byte[] BitReceived;

        public static bool lastStepCallibration;

        private static Msg_heartbeat msg_heartbeat = new Msg_heartbeat();
        private static Msg_sys_status msg_sys_status = new Msg_sys_status();
        private static Msg_vfr_hud msg_vfr_hud = new Msg_vfr_hud();
        private static Msg_altitude msg_altitude = new Msg_altitude();
        private static Msg_servo_output_raw msg_servo_output_raw = new Msg_servo_output_raw();
        private static Msg_attitude msg_attitude = new Msg_attitude();

        public static Msg_command_ack msg_command_ack = new Msg_command_ack();
        public static Msg_statustext msg_statustext = new Msg_statustext();

        private static Msg_power_status msg_power_status = new Msg_power_status();
        private static Msg_gps_raw_int msg_gps_raw_int = new Msg_gps_raw_int();
        private static Msg_data_stream msg_data_stream = new Msg_data_stream();
        private static Msg_raw_pressure msg_raw_pressure = new Msg_raw_pressure();
        private static Msg_scaled_pressure msg_scaled_pressure = new Msg_scaled_pressure();
        private static Msg_mission_count msg_mission_count = new Msg_mission_count();
        private static Msg_high_latency2 msg_high_latency2 = new Msg_high_latency2();

        private static Filters blinkFilterEngine = new Filters();
        private static BlinkFilterBool blinkFilterComponentEngine = new BlinkFilterBool();
        private static Filters blinkFilterFailsafe = new Filters();
        private static BlinkFilterEnum blinkFilterComponentFailsafe = new BlinkFilterEnum();
        private static Filters blinkFilterFlightMode = new Filters();
        private static BlinkFilterEnum blinkFilterComponentFlightMode = new BlinkFilterEnum();

        public static event EventHandler AckRecived;
        public static event EventHandler MsgRecived;

        public static void InitializeMavlink()
        {
            lastStepCallibration = false;
            // Ack.result = (byte)255;

        }

        public static void Mv_PacketReceived(object sender, MavlinkPacket e)
        {
            uint x = MavlinkComVar.Mv.PacketsReceived;
            MavlinkComVar.Systemid = e.SystemId;
            MavlinkComVar.Componentid = e.ComponentId;
            MavlinkComVar.Sequence = e.SequenceNumber;
            //RequestDataSteam;
            MavlinkMessage m = e.Message;
            if (m.GetType() == msg_command_ack.GetType())
            {
                msg_command_ack = (Msg_command_ack)e.Message;
                Console.WriteLine((ushort)MavlinkServiceCommand.lastMsg_command_long.command + "(cmd_in) : (cmd_out)" + msg_command_ack.command);
                OnAckRecived(null);
            }
            if (m.GetType() == msg_heartbeat.GetType())
            {
                msg_heartbeat = (Msg_heartbeat)e.Message;
                bool tempEngineOn = (msg_heartbeat.base_mode & (byte)MAV_MODE_FLAG.MAV_MODE_FLAG_SAFETY_ARMED) == 0b10000000;
                PlaneModeVar.engineOn = blinkFilterEngine.blinkFilter(tempEngineOn, blinkFilterComponentEngine);
                PlaneModeVar.failsafeMode = blinkFilterFailsafe.blinkFilter((UInt16)msg_heartbeat.system_status, blinkFilterComponentFailsafe, false);
                PlaneModeVar.flightMode = blinkFilterFlightMode.blinkFilter((UInt16)msg_heartbeat.custom_mode, blinkFilterComponentFlightMode);
            }
            if (m.GetType() == msg_sys_status.GetType())
            {
                msg_sys_status = (Msg_sys_status)e.Message;
                BatteryVar.voltage = msg_sys_status.voltage_battery / 1000.0f;
                BatteryVar.ampere = msg_sys_status.current_battery / 1000.0f;
                BatteryVar.stateOfCharge = msg_sys_status.battery_remaining / 1000.0f;
            }
            if (m.GetType() == msg_vfr_hud.GetType())
            {
                msg_vfr_hud = (Msg_vfr_hud)e.Message;
                //PlaneLocationVar.altitude = msg_vfr_hud.alt;
                PlaneLocationVar.heading = msg_vfr_hud.heading;
                SpeedVar.airSpeed = msg_vfr_hud.airspeed;
                SpeedVar.climbRate = msg_vfr_hud.climb;
                SpeedVar.groundSpeed = msg_vfr_hud.groundspeed;
                SpeedVar.throttle = msg_vfr_hud.throttle;
            }

            if (m.GetType() == msg_power_status.GetType())
            {
                msg_power_status = (Msg_power_status)e.Message;
            }
            if (m.GetType() == msg_attitude.GetType())
            {
                msg_attitude = (Msg_attitude)e.Message;
                GyroVar.compass = msg_attitude.yaw * 57.2958f;
                GyroVar.roll = msg_attitude.roll * 57.2958f;//57.2958f=180/pi
                GyroVar.pitch = msg_attitude.pitch * 57.2958f;
                GyroVar.yaw = msg_attitude.yaw * 57.2958f;
            }
            if (m.GetType() == msg_altitude.GetType())
            {
                msg_altitude = (Msg_altitude)e.Message;
                PlaneLocationVar.altitude = msg_altitude.altitude_local;

            }
            if (m.GetType() == msg_gps_raw_int.GetType())
            {
                msg_gps_raw_int = (Msg_gps_raw_int)e.Message;
            }
            if (m.GetType() == msg_statustext.GetType())
            {
                msg_statustext = (Msg_statustext)e.Message;
                if (msg_statustext.text != null)
                {
                    char[] c = new char[msg_statustext.text.Length];
                    for (int i = 0; i < msg_statustext.text.Length; i++)
                        c[i] = (char)msg_statustext.text[i];
                    MassageAndCommandVar.massageReceived = new string(c);
                    MavLinkServiceMessage.OnMsgRecived(null);

                    Console.WriteLine(MassageAndCommandVar.massageReceived);
                }
            }
            if (m.GetType() == msg_servo_output_raw.GetType())
            {
                msg_servo_output_raw = (Msg_servo_output_raw)e.Message;
                PlaneControlVar.servo1 = msg_servo_output_raw.servo1_raw;
                PlaneControlVar.servo2 = msg_servo_output_raw.servo2_raw;
                PlaneControlVar.servo3 = msg_servo_output_raw.servo3_raw;
                PlaneControlVar.servo4 = msg_servo_output_raw.servo4_raw;
                PlaneControlVar.servo5 = msg_servo_output_raw.servo5_raw;
                PlaneControlVar.servo6 = msg_servo_output_raw.servo6_raw;
                PlaneControlVar.servo7 = msg_servo_output_raw.servo7_raw;
                PlaneControlVar.servo8 = msg_servo_output_raw.servo8_raw;
            }
        }

        private static void OnAckRecived(EventArgs e)
        {
            EventHandler handler = AckRecived;
            if (handler != null)// Raise the event
                handler(AckRecived, e);
        }
        public static void OnMsgRecived(EventArgs e)
        {
            EventHandler handler = MsgRecived;
            if (handler != null)// Raise the event
                handler(MsgRecived, e);
        }
    }
}

/*//old Filtering
private bool BlinkGenerator;
private DateTime refreshTime = DateTime.MinValue;

public void InitializeMavlink()
{
// Ack.result = (byte)255;
//    refreshTime = DateTime.Now;

}
void hanlerfunction(){
bool tempFailsafe = ((UInt16)msg_heartbeat.system_status != 0);
if (blinkFilterFailsafe.filter(tempFailsafe, blinkFilterComponentFailsafe))
    PlaneModeVar.failsafeMode = (UInt16)msg_heartbeat.system_status;
else
    PlaneModeVar.failsafeMode = 0;

if ((refreshTime.AddMilliseconds(3000) > DateTime.Now))
    BlinkGenerator = false;
else if (refreshTime.AddMilliseconds(3000) < DateTime.Now & (refreshTime.AddMilliseconds(10000) > DateTime.Now))
    BlinkGenerator = !BlinkGenerator;
else if (refreshTime.AddMilliseconds(10000) < DateTime.Now)
    BlinkGenerator = false;
*/

/* bool tempFlightMode = ((UInt16)msg_heartbeat.custom_mode != 0);
UInt16 tempFlightMode=(UInt16)msg_heartbeat.custom_mode;
if (blinkFilterFlightMode.filter(tempFlightMode, blinkFilterComponentFlightMode,true))
    PlaneModeVar.flightMode = (UInt16)msg_heartbeat.custom_mode;
else
    PlaneModeVar.flightMode = 0;
}
}
}
}
*/
