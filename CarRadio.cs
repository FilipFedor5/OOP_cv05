using System;
using System.Collections.Generic;
using System.Text;

namespace cv5
{
    public class CarRadio
    {
        public double frequency { get;  protected set; }
        public bool radioOn { get; protected set; }

        public Dictionary<int, double> presets { get; protected set; }

        public CarRadio()
        {
            presets = new Dictionary<int, double>();
            radioOn = false;
            frequency = 88.5;
        }

        public void SetPreset(double frequency, int presetNumber)
        {
            if (radioOn) throw new Exception("Radio is not on");
            else {
                if (frequency > 108 && frequency < 87) throw new Exception("Not valid frequency");
                else
                    presets.Add(presetNumber, frequency);
            }
        }

        public void TunePreset(int preset)
        {
            if (radioOn) throw new Exception("Radio is not on");

            else
            {
                if (!presets.ContainsKey(preset)) throw new Exception("Preset not found");

                else frequency = presets[preset];
            }
        }
        public void TurnOn()
        {
            radioOn = true;
        }

        public void TurnOff()
        {
            radioOn = false;
        }
        public string Tostring()
        {
            return string.Format("Radio is {0}, frequency is {1} ", (radioOn ? "on" : "off"),frequency);
        }




    }
}
