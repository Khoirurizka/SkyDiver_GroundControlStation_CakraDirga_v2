using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkyDiver_GCS
{
    static class PanelAndSpliterModify
    {
        public static Size InitializePanelSize(int Width, int Height)
        {
            Size temp = new Size();
            temp.Width = Width;
            temp.Height = Height;
            return temp;
        }

        public static PanelRangeSize InitializePanelRangeSize(int initSize, PanelRangeSize panelRangeSize)
        {
            PanelRangeSize temp = new PanelRangeSize()
            {
                Size = initSize,
                MinSF = panelRangeSize.MinSF,
                MaxSF = panelRangeSize.MaxSF,
                MinSize = (int)(panelRangeSize.MinSF * initSize),
                MaxSize = (int)(panelRangeSize.MaxSF * initSize),
            };
            return temp;
        }
        public static PanelScaller ScalerConstByWindow(int WidthScreenSize, int HeightScreenSize, int initWidthScreenSize, int initHeightScreenSize)
        {
            PanelScaller panelScaller = new PanelScaller();
            panelScaller.HeightScaller = (float)HeightScreenSize / (float) initHeightScreenSize;
            panelScaller.WidthScaller = (float)WidthScreenSize / (float)initWidthScreenSize;
            return panelScaller;
        }
        public static int ScalerPaneltBySpliter(SplitContainer splitContainer, int initpanelWidthOrHeight,  int initSpilterPosition)
        {
            int WidthOrHeight = 0;
            WidthOrHeight = (int)(initpanelWidthOrHeight * ((float)(splitContainer.SplitterDistance) / (float)(initSpilterPosition)));
            return WidthOrHeight;
        }
        public static PanelSizeAndPosition scalerArraybyPanelSize(Panel motherPanel, int arrayRow, int arrayColumn, int thisRowId, int thisColumnId)
        {
            PanelSizeAndPosition panelSize = new PanelSizeAndPosition();
            Size size = new Size();
            Point position = new Point();
            size.Height = motherPanel.Height / arrayColumn;
            size.Width = motherPanel.Width / arrayRow;
            position.X = (motherPanel.Width / arrayRow) * thisRowId;
            position.Y = (motherPanel.Height / arrayColumn) * thisColumnId;
            panelSize.panelSize = size;
            panelSize.panelPosition = position;
            return panelSize;
        }
        public static int scaledPanelByResizeWindow(PanelScaller panelScaller, PanelRangeSize varPanelSize, short HeightRef)//HeightRef=0 --> Using WidthScaller,HeightRef=1 --> Using HeightScaller
        {
            PanelRangeSize scaledPanel = new PanelRangeSize();

            if (HeightRef == 0)
            {
                scaledPanel.Size = (int)(varPanelSize.Size * panelScaller.WidthScaller);//Width_Window/Default_Width_Window*Default_Size
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.WidthScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.WidthScaller);
            }
            else
            {
                scaledPanel.Size = (int)(varPanelSize.Size * panelScaller.HeightScaller);
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.HeightScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.HeightScaller);
            }
            if (scaledPanel.Size < varPanelSize.MinSize)
                return varPanelSize.MinSize;
            else if (varPanelSize.MaxSize < scaledPanel.Size)
                return varPanelSize.MaxSize;
            else
                return scaledPanel.Size;
        }
        public static int scaledSpliterDistanceByResizeWindow(int thisSize, PanelRangeSize varPanelSize, PanelScaller panelScaller, short HeightRef=1) {
            PanelRangeSize scaledPanel = new PanelRangeSize();

            if (HeightRef == 0)
            {
                scaledPanel.Size = (int)(thisSize * panelScaller.WidthScaller);//Width_Window/Default_Width_Window*Default_Size
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.WidthScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.WidthScaller);
            }
            else
            {
                scaledPanel.Size = (int)(thisSize * panelScaller.HeightScaller );//Height_Window/Default_Height_Window*Default_Size
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.HeightScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.HeightScaller);
            }
            if (scaledPanel.Size < scaledPanel.MinSize)
                return scaledPanel.MinSize;
            else if (scaledPanel.MaxSize < scaledPanel.Size)
                return scaledPanel.MaxSize;
            else
                return scaledPanel.Size;
        }

        public static int scaledSpliterDistanceByMoved(int thisSize, PanelRangeSize varPanelSize, PanelScaller panelScaller, short HeightRef = 1)
        {
            PanelRangeSize scaledPanel = new PanelRangeSize();
            scaledPanel.Size = (int)(thisSize);

            if (HeightRef == 0)
            {
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.WidthScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.WidthScaller);
            }
            else
            {
                scaledPanel.MinSize = (int)(varPanelSize.MinSize * panelScaller.HeightScaller);
                scaledPanel.MaxSize = (int)(varPanelSize.MaxSize * panelScaller.HeightScaller);
            }

            if (scaledPanel.Size < scaledPanel.MinSize)
                return scaledPanel.MinSize;
            else if (scaledPanel.MaxSize < scaledPanel.Size)
                return scaledPanel.MaxSize;
            else
                return scaledPanel.Size;
        }
        public static SplitContainer HoldSpliterDistanceByResizeWindowPanel(SplitContainer splitterPanel, int HoldDistance, int ScreenRef, bool inverted=false)
        {
            SplitContainer tempSplitterPanel = splitterPanel;
            if (!inverted)
            {
                tempSplitterPanel.SplitterDistance = HoldDistance;
            }
            else
            {
                tempSplitterPanel.SplitterDistance = ScreenRef - HoldDistance;
            }
            return tempSplitterPanel;
        }
        public static int scaledByRatio(int initResizeVal, int curVal, int initVal)
        {
            int temp = temp = (int)(((float)curVal / (float)initVal) * (float)initResizeVal);
            return temp;
        }

       public static void showFormOnPanel(Form form,Panel panel)
        {
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
