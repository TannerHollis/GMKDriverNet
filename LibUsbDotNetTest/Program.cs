using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using LibUsbDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GMKDriverNET;
using System.Runtime.InteropServices;
using System.IO;

namespace LibUsbDotNetTest
{
    internal class Program
    {
        public static List<List<float>> Values = new List<List<float>>();
        public static void Main(string[] args)
        {
            float deltaAngle = 5.0f;

            for(float angle = 0.0f; angle < 360.0f; angle += deltaAngle)
            {
                for (float rotate = 0.0f; rotate < 360.0f; rotate += deltaAngle)
                {
                    float x = 1.0f * (float)Math.Cos(angle / 180.0f * (float)Math.PI);
                    float y = 1.0f * (float)Math.Sin(angle / 180.0f * (float)Math.PI);
                    MapJoystick(x, y, rotate, true);
                }
            }

            List<string> strings = new List<string>();

            foreach(List<float> value in Values)
            {
                string newString = "";
                foreach(float v in value)
                {
                    newString += v.ToString() + ",";
                }
                strings.Add(newString);
            }

            File.WriteAllLines("output.csv", strings.ToArray());
        }

        private static void RunDriver()
        {
            GMKDriver.Loop();
        }

        private static void MapJoystick(float x, float y, float rotate, bool snapMode)
        {
            List<float> values = new List<float>();

            values.Add(rotate);

            float snapIntensity = Deg2Rad(20.0f);

            float snapRightZone = Deg2Rad(10.0f);
            float snapLeftZone = Deg2Rad(170.0f);

            float snapRightAngle = Deg2Rad(14.0f);
            float snapLeftAngle = Deg2Rad(166.0f);

            double angle = Math.Atan2(y, x);
            values.Add((float)angle * 180.0f / ((float)Math.PI));
            double mag = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            double rotateRadians = Deg2Rad(rotate);

            angle += rotateRadians;

            angle = (angle + Deg2Rad(540.0f)) % Deg2Rad(360.0f) - Deg2Rad(180.0f);

            values.Add(Rad2Deg((float)angle));
            double newX = mag * Math.Cos(angle);
            double newY = mag * Math.Sin(angle);

            float isSnap = 0.0f;

            if (snapMode)
            {
                float angleRight = Deg2Rad(90.0f) - snapIntensity;
                float angleLeft = Deg2Rad(90.0f) + snapIntensity;

                if ((angle > snapRightZone && angle < angleRight))
                {
                    newX = mag * Math.Cos(snapRightAngle);
                    newY = mag * Math.Sin(snapRightAngle);
                    isSnap = 1.0f;
                }

                if ((angle < snapLeftZone && angle > angleLeft))
                {
                    newX = mag * Math.Cos(snapLeftAngle);
                    newY = mag * Math.Sin(snapLeftAngle);
                    isSnap = 1.0f;
                }
            }
            values.Add(isSnap);
            Values.Add(values);
        }

        private static float Deg2Rad(float deg)
        {
            return deg / 180.0f * (float)Math.PI;
        }

        private static float Rad2Deg(float rad)
        {
            return rad * 180.0f / (float)Math.PI;
        }
    }
}
