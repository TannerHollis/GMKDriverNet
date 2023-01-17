using Nefarius.ViGEm.Client.Targets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nefarius.ViGEm.Client.Targets.Xbox360;

namespace GMKDriverNET
{
    public class XInputController
    {
        bool up;
        bool down;
        bool left;
        bool right;
        bool start;
        bool back;
        bool lth;
        bool rth;
        bool lb;
        bool rb;
        bool xbox;
        bool _reserved;
        bool a;
        bool b;
        bool x;
        bool y;
        Int16 leftX;
        Int16 leftY;
        Int16 rightX;
        Int16 rightY;
        char triggerLeft;
        char triggerRight;

        UInt16 buttons;

        private bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber - 1)) != 0;
        }

        public void Map(byte[] bytes)
        {
            buttons = (UInt16)(bytes[1] << 8 | bytes[0]);
            up = GetBit(bytes[0], 0);
            down = GetBit(bytes[0], 1);
            left = GetBit(bytes[0], 2);
            right = GetBit(bytes[0], 3);
            start = GetBit(bytes[0], 4);
            back = GetBit(bytes[0], 5);
            lth = GetBit(bytes[0], 6);
            rth = GetBit(bytes[0], 7);
            lb = GetBit(bytes[1], 0);
            rb = GetBit(bytes[1], 1);
            xbox = GetBit(bytes[1], 2);
            _reserved = GetBit(bytes[1], 3);
            a = GetBit(bytes[1], 4);
            b = GetBit(bytes[1], 5);
            x = GetBit(bytes[1], 6);
            y = GetBit(bytes[1], 7);

            leftX = (Int16)(bytes[3] << 8 | bytes[2]);
            leftY = (Int16)(-1 * (bytes[5] << 8 | bytes[4]));

            rightX = (Int16)(bytes[7] << 8 | bytes[6]);
            rightY = (Int16)(bytes[9] << 8 | bytes[8]);

            triggerLeft = (char)bytes[10];
            triggerRight = (char)bytes[11];
        }

        public void SetController(in IXbox360Controller controller)
        {
            controller.SetButtonsFull(buttons);
            controller.SetAxisValue(Xbox360Axis.LeftThumbX, leftX);
            controller.SetAxisValue(Xbox360Axis.LeftThumbY, leftY);
            controller.SetAxisValue(Xbox360Axis.RightThumbX, rightX);
            controller.SetAxisValue(Xbox360Axis.RightThumbY, rightY);
            controller.SetSliderValue(Xbox360Slider.LeftTrigger, Convert.ToByte(triggerLeft));
            controller.SetSliderValue(Xbox360Slider.RightTrigger, Convert.ToByte(triggerRight));
        }
    }
}
