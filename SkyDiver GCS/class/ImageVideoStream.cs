using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;

namespace SkyDiver_GCS
{
    public static class ImageVideoStream
    {
        public static String[] screenRatioCollection { set; get; } = { "1:1", "4:3", "16:9" };
        public static String[] sourceCollection { set; get; } = { "Picture Source", "Video Source", "Video Stream" };

        private static FileVideoSource _FileVideo;
        private static VideoCaptureDevice _CaptureDevice;
        private static FilterInfoCollection _device;

        //public static event EventHandler SourceChanged;
       // public static event EventHandler StartStreamVar;
       // public static event EventHandler CloseStreamVar;

        public static void InitializeComboBoxLoadSource(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(sourceCollection);
            comboBox.SelectedIndex = 0;
        }
        public static void InitializeComboBoxScreenRatio(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(screenRatioCollection);
            comboBox.SelectedIndex = 2;
        }
        public static void RefreshComboBoxCamId(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            _device = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;
            for (var i = 0; i < _device.Count; i++)
            {
                comboBox.Items.Add(_device[i].Name);
            }
            comboBox.SelectedIndex = 0;
        }
     /*   public static void openImageSource()
        {
            OpenFileDialog OFdialog = new OpenFileDialog();
            OFdialog.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif|*.jpg;*.jpeg;*.jpe;*.jfif;|*.png|*.png|All Files|*.*";
            if (OFdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string directory = OFdialog.FileName;
                    start_Frame();
                    if (StreamVar.frame != null)
                        StreamVar.frame.Dispose();
                    StreamVar.frame = (Bitmap)Bitmap.FromFile(directory);
                    end_Frame();
                    LogPrint.message = ("Opening " + directory + " was successful");
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
            else
            {
                LogPrint.message = "Image opening canceled";
            }
        }*/
        public static void openVideoSource( )
        {
            if (!StreamVar.frameIsBusy)
            {
                OpenFileDialog OFdialog = new OpenFileDialog();
                OFdialog.Filter = "Media Files *.avi| *.avi; | All Files|*.*";
                if (OFdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        string directory = OFdialog.FileName;
                        StreamVar.VideoDirectory= directory;
                        LogPrint.message = ("Opening " + directory + " was successful");
                    }
                    catch (Exception ex)
                    {
                        LogPrint.message = ex.Message;
                    }
                }
                else
                {
                    LogPrint.message = "Video opening canceled";
                }
            }
          /*  else
            {
                StopVid();
                end_Frame();
            }*/
        }
     /*   public static void openCamSource(ComboBox cbCamName)
        {
            if (!StreamVar.frameIsBusy)
            {
                try
                {
                    _CaptureDevice = new VideoCaptureDevice(_device[cbCamName.SelectedIndex].MonikerString);
                    _CaptureDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                    start_Frame();
                    _CaptureDevice.Start();
                    LogPrint.message = ("Connecting ti " + cbCamName.Text + " {" + _device[cbCamName.SelectedIndex].MonikerString + "} was successful");
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
            else
            {
                StopCam();
                end_Frame();
            }
        }

     /*   private static void LoadVideo(string directory)
        {
            _FileVideo = new FileVideoSource(directory);
            _FileVideo.VideoSourceError += new VideoSourceErrorEventHandler(videoSource_Error);
            _FileVideo.NewFrame += new NewFrameEventHandler(get_Frame);
            start_Frame();
            _FileVideo.Start();
        }*/
        private static void videoSource_Error(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            LogPrint.message = eventArgs.Description.ToString();
        }
      /*  public static void StopVid()
        {
            if (_FileVideo != null)
            {
                try
                {
                    if (_FileVideo.IsRunning)
                    {
                        _FileVideo.SignalToStop();
                        _FileVideo.VideoSourceError -= new VideoSourceErrorEventHandler(videoSource_Error);
                        _FileVideo.NewFrame -= new NewFrameEventHandler(get_Frame);
                        _FileVideo = null;
                        LogPrint.message = ("Video was stoped");
                    }
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
        }
        public static void CloseVid()
        {
            if (_FileVideo != null)
            {
                try
                {
                    if (_FileVideo.IsRunning)
                    {
                      end_Frame();
                        _FileVideo.SignalToStop();
                        _FileVideo.VideoSourceError -= new VideoSourceErrorEventHandler(videoSource_Error);
                        _FileVideo.NewFrame -= new NewFrameEventHandler(get_Frame);
                        _FileVideo = null;
                        LogPrint.message = ("Video was stoped");
                    }
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
        }
     /*   public static void StopCam()
        {
            if (_CaptureDevice != null)
            {
                try
                {
                    if (_CaptureDevice.IsRunning)
                    {
                        _CaptureDevice.SignalToStop();
                        _CaptureDevice.NewFrame -= new NewFrameEventHandler(get_Frame);
                        _CaptureDevice = null;
                        LogPrint.message = ("Cam was disconected");
                    }
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
        }
      /*  public static void ClosepCam()
        {
            if (_CaptureDevice != null)
            {
                try
                {

                    if (_CaptureDevice.IsRunning)
                    {
                        end_Frame();
                        _CaptureDevice.SignalToStop();
                        _CaptureDevice.NewFrame -= new NewFrameEventHandler(get_Frame);
                        _CaptureDevice = null;
                        LogPrint.message = ("Cam was disconected");
                    }
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
        }
      /*  public static void start_Frame()
        {
            EventStartStreamVar(null);
        }
        public static void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            if (StreamVar.frame != null)
                StreamVar.frame.Dispose();
            StreamVar.frame = (Bitmap)eventArgs.Frame.Clone();
        }
      /*  public static void end_Frame()
        {
            EventCloseStreamVar(null);
        }

        //EventArgs
      /*  public static void EventStartStreamVar(EventArgs e)
        {
            EventHandler handler = StartStreamVar;
            if (handler != null)// Raise the event
                handler(StartStreamVar, e);
        }
        public static void EventCloseStreamVar(EventArgs e)
        {
            EventHandler handler = CloseStreamVar;
            if (handler != null)// Raise the event
                handler(CloseStreamVar, e);
        }
        public static void OnSourceChanged(EventArgs e)
        {
            EventHandler handler = SourceChanged;
            if (handler != null)// Raise the event
                handler(SourceChanged, e);
        }*/
    }
}