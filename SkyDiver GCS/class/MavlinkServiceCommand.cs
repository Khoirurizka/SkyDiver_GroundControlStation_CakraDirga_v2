using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using MavLink;

namespace SkyDiver_GCS
{
    public static class MavlinkServiceCommand
    {
        public static Msg_command_long _lastMsg_command_long { set; get; }
        public static Msg_command_long lastMsg_command_long
        {
            get { return _lastMsg_command_long; }
            set
            {
                _lastMsg_command_long = value;
            }
        }

        private static bool SendPacket(SerialPort serialPort, Msg_command_long m)
        {
            if (!serialPort.IsOpen)
                return false;
            try
            {
                MavlinkPacket p = new MavlinkPacket();
                p.Message = m;
                p.SequenceNumber = (byte)MavlinkComVar.Sequence;
                p.SystemId = 255;
                p.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
                byte[] b = MavlinkComVar.Mv.Send(p);

                lastMsg_command_long = new Msg_command_long
                {
                    target_system = m.target_system,
                    target_component = m.target_component,
                    command = m.command,
                    confirmation = m.confirmation,
                    param1 = m.param1,
                    param2 = m.param2,
                    param3 = m.param3,
                    param4 = m.param4,
                    param5 = m.param5,
                    param6 = m.param6,
                    param7 = m.param7
                };
                serialPort.Write(b, 0, b.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private static bool SendPacket(SerialPort serialPort, MavlinkMessage m)
        {
            if (!serialPort.IsOpen)
                return false;
            try
            {
                MavlinkPacket p = new MavlinkPacket();
                p.Message = m;
                p.SequenceNumber = (byte)MavlinkComVar.Sequence;
                p.SystemId = 255;
                p.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
                byte[] b = MavlinkComVar.Mv.Send(p);

                serialPort.Write(b, 0, b.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///  Replaced by SET_MESSAGE_INTERVAL
        /// </summary>
        /// <param name="serialPort"></param>
        public static void RequestDataSteam(SerialPort serialPort,byte RequestData)
        {
            Msg_request_data_stream ds = new Msg_request_data_stream();
            ds.req_message_rate = 2;
            ds.req_stream_id = (byte)MAV_DATA_STREAM.MAV_DATA_STREAM_ALL;
            ds.start_stop = RequestData;
            ds.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
            ds.target_system = (byte)MavlinkComVar.Systemid;

            SendPacket(serialPort, ds);
        }

        public static void SetMessageInterval(SerialPort serialPort, ushort MessageID,uint MessageInterval, uint ResponseTarget)
        {
            try
            {
                if (!serialPort.IsOpen)
                    return;

                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_SET_MESSAGE_INTERVAL;
                m_cmd.param1 = MessageID;
                m_cmd.param2 = MessageInterval;
                m_cmd.param7 = ResponseTarget;

                SendPacket(serialPort, m_cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Send packet failed : " + ex);
            }
        }
        public static void SwitchEngine(SerialPort serialPort, bool currentStatus)
        {
            try
            {
                if (!serialPort.IsOpen)
                    return;

                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_COMPONENT_ARM_DISARM;

                if (currentStatus)
                {
                    m_cmd.param1 = 0;
                }
                else
                {
                    m_cmd.param1 = 1;
                }
                m_cmd.param2 = (ushort)0;

                SendPacket(serialPort, m_cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Send packet failed : " + ex);
            }
        }

        public static void SwitchServo(SerialPort serialPort, SPayloadBay payloadBay, int minDiff, int maxDiff)
        {
            try
            {
                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.target_system = (byte)MavlinkComVar.Systemid;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_DO_SET_SERVO;
                m_cmd.param1 = (byte)payloadBay.servoId;
                if (payloadBay.status)
                {
                    m_cmd.param2 = (ushort)(payloadBay.servoValue - minDiff);
                }
                else
                {
                    m_cmd.param2 = (ushort)(payloadBay.servoValue + maxDiff);
                }

                SendPacket(serialPort, m_cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Send packet failed : " + ex);
            }
        }
        public static void CalibrateAccel(SerialPort serialPort)
        {
            try
            {
                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.target_system = (byte)MavlinkComVar.Systemid;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION;
                m_cmd.param1 = (byte)0;
                m_cmd.param2 = (byte)0;
                m_cmd.param3 = (byte)0;
                m_cmd.param4 = (byte)0;
                m_cmd.param5 = (byte)1;
                m_cmd.param6 = (byte)0;
                m_cmd.param7 = (byte)0;

                SendPacket(serialPort, m_cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Send packet failed : " + ex);
            }
        }
        public static string CalibrateLavel(SerialPort serialPort)
        {
            try
            {
                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.target_system = (byte)MavlinkComVar.Systemid;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION;
                m_cmd.param1 = (byte)0;
                m_cmd.param2 = (byte)0;
                m_cmd.param3 = (byte)0;
                m_cmd.param4 = (byte)0;
                m_cmd.param5 = (byte)2;
                m_cmd.param6 = (byte)0;
                m_cmd.param7 = (byte)0;

                SendPacket(serialPort, m_cmd);
                return "Level is calibrating...";
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Send packet failed : " + ex);
                return "Level calibration failed";
            }
        }

    }
}
/*
  public static async Task<bool> SendPacketRequireAckAsync(SerialPort serialPort, Msg_command_long m, bool requireack = true)
        {
        //   bool giveComport = false;

            MavlinkPacket ptx = new MavlinkPacket();
            ptx.Message = m;
            ptx.SequenceNumber = (byte)MavlinkComVar.Sequence;
            ptx.SystemId = 255;
            ptx.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
            byte[] b = MavlinkComVar.Mv.Send(ptx);

            MavlinkComVar.lastMavCmd =(MAV_CMD) m.command;
            serialPort.Write(b, 0, b.Length);

            DateTime ackTime = DateTime.Now;
            int ackRetrys = 3;
            int ackTimeout = 3000;

            if (!requireack)
            {
                return true;
            }

            DateTime retryTime = DateTime.Now;
            int retrys = 3;
            int retryTimeout = 2000;

            // imu calib take a little while
            if (m.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION && m.param5 == 1)
            {
                // this is for advanced accel offsets, and blocks execution
                return true;
            }
            else if (m.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION && m.param6 == 1)
            {
                // compassmot
                // send again just incase
                serialPort.Write(b, 0, b.Length);
                return true;
            }
            else if (m.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_REBOOT_SHUTDOWN)
            {
                serialPort.Write(b, 0, b.Length);
                return true;
            }
            else if (m.command == (ushort)MAV_CMD.MAV_CMD_GET_HOME_POSITION)
            {
                return true;
            }
            else if (m.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION)
            {
                retrys = 1;
                retryTimeout = 25000;
            }
            else if (m.command == (ushort)MAV_CMD.MAV_CMD_COMPONENT_ARM_DISARM)
            {
                // 10 seconds as may need an imu calib
                retryTimeout = 10000;
            }


            while (true)
            {
                if (!(retryTime.AddMilliseconds(retryTimeout) > DateTime.Now))
                {
                    if (retrys > 0)
                    {
                        serialPort.Write(b, 0, b.Length);
                        retryTime = DateTime.Now;
                        retrys--;
                        continue;
                    }

                    throw new TimeoutException("Timeout on read - doCommand");
                }
                if ((ackTime.AddMilliseconds(ackTimeout) < DateTime.Now))
                {
                    Msg_command_ack msg_command_ack = await MavLinkServiceMessage.msg_command_ack;
                    Console.WriteLine(msg_command_ack.command + " : " + (ushort)MavlinkComVar.lastMavCmd);
                    if (msg_command_ack.command == (ushort)MavlinkComVar.lastMavCmd &&
                        msg_command_ack.result == (byte)MAV_RESULT.MAV_RESULT_ACCEPTED)
                    {
                        return true;
                    }
                    else
                    {
                        if (ackRetrys > 0)
                        {
                            ackRetrys--;
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
*/
