using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkyDiver_GCS
{
    public partial class HomePanel : Form
    {
        public bool dynamicDysplay { set; get; } = true;

        PanelScaller panelScaller = new PanelScaller();//Scaller
        //Screen
        private Size initScreenSize = new Size();
        //Panel Size
        private PanelRangeSize distancePanelMapCam = new PanelRangeSize() { MinSF = 0.8f, MaxSF = 1.2f };

        private int initSpilterPosition;
        private Size initpanelSensorBarNameSize = new Size();
        private Size initpanelSensorBarValSize = new Size();

        public void InitializePanelSpliter() //Initialize value
        {

            distancePanelMapCam = PanelAndSpliterModify.InitializePanelRangeSize(splitMapCam.SplitterDistance, distancePanelMapCam);
            initScreenSize = PanelAndSpliterModify.InitializePanelSize(this.Width, this.Height);

            initSpilterPosition = splitMapCam.SplitterDistance;
            initpanelSensorBarNameSize = panelSensorBarName.Size;
            initpanelSensorBarValSize = panelSensorBarVal.Size;
        }
        private void HomePanel_Resize(object sender, EventArgs e)
        {
            ResizeSensorBarComponents();
            panelScaller = PanelAndSpliterModify.ScalerConstByWindow(this.Size.Width, this.Size.Height, initScreenSize.Width, initScreenSize.Height);

            streamVideo.Height = (int)(streamVideo.Width * GCSSettingVar.streamScreenRatio);
            streamVideo.Location = new Point(0, (int)((initializeStreamScreenPosition.Y * panelScaller.WidthScaller) + ((initializeStreamScreenSize.Y * panelScaller.WidthScaller) - streamVideo.Height) / 2));
        }
        private void splitContainerDC_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (dynamicDysplay)
            {

                panelScaller = PanelAndSpliterModify.ScalerConstByWindow(this.Size.Width, this.Size.Height, initScreenSize.Width, initScreenSize.Height);
                splitMapCam.SplitterDistance = PanelAndSpliterModify.scaledSpliterDistanceByMoved(splitMapCam.SplitterDistance, distancePanelMapCam, panelScaller, 0);

                panelSensorBarName.Width = PanelAndSpliterModify.ScalerPaneltBySpliter(splitMapCam,initpanelSensorBarNameSize.Width,initSpilterPosition);
                panelSensorBarVal.Width = PanelAndSpliterModify.ScalerPaneltBySpliter(splitMapCam,initpanelSensorBarValSize.Width,initSpilterPosition);
                ResizeSensorBarComponents();
            }
        }
        private void ResizeSensorBarComponents()
        {
            PanelSizeAndPosition tempPSP = new PanelSizeAndPosition();

            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 0, 0);
            labelRoll.Size = tempPSP.panelSize;
            labelRoll.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 1, 0);
            labelPitch.Size = tempPSP.panelSize;
            labelPitch.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 2, 0);
            labelYaw.Size = tempPSP.panelSize;
            labelYaw.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 3, 0);
            labelAltitude.Size = tempPSP.panelSize;
            labelAltitude.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 4, 0);
            labelGroundSpeed.Size = tempPSP.panelSize;
            labelGroundSpeed.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarName, 6, 1, 5, 0);
            labelAirSpeed.Size = tempPSP.panelSize;
            labelAirSpeed.Location = tempPSP.panelPosition;

            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 0, 0);
            rollVal.Size = tempPSP.panelSize;
            rollVal.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 1, 0);
            pitchVal.Size = tempPSP.panelSize;
            pitchVal.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 2, 0);
            yawVal.Size = tempPSP.panelSize;
            yawVal.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 3, 0);
            altitudeVal.Size = tempPSP.panelSize;
            altitudeVal.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 4, 0);
            groundSpeedVal.Size = tempPSP.panelSize;
            groundSpeedVal.Location = tempPSP.panelPosition;
            tempPSP = PanelAndSpliterModify.scalerArraybyPanelSize(panelSensorBarVal, 6, 1, 5, 0);
            airSpeedVal.Size = tempPSP.panelSize;
            airSpeedVal.Location = tempPSP.panelPosition;
        }

        private void streamVideo_Resize(object sender, EventArgs e)
        {
            streamVideo.Width = this.Width - splitMapCam.SplitterDistance;
            streamVideo.Height = (int)(streamVideo.Width * GCSSettingVar.streamScreenRatio);
            streamVideo.Location = new Point(0, (int)((initializeStreamScreenPosition.Y * panelScaller.WidthScaller) + ((initializeStreamScreenSize.Y * panelScaller.WidthScaller) - streamVideo.Height) / 2));
        }
    }
}
