using System;

namespace Measurement
{
    public class Measure
    {
        public DateTime MeasureTime;
        public string Location;
        public string SensorType;
        public double MeasurmentValue;
        public string DeviceIp;
        public string DeviceName;
        public int DevicePort;

        public Measure()
        {
               
        }
        public Measure(DateTime measureTime,string location,string sensorType,double measurmentValue,string deviceIp,string deviceName,int devicePort)
        {
            measureTime = MeasureTime;location = Location;sensorType = SensorType;measurmentValue = MeasurmentValue;deviceIp = DeviceIp;deviceName = DeviceName;devicePort = DevicePort;
            Measure mea = new Measure();
            mea.ToString();
        }
        public override string ToString()
        {
            return base.ToString() + " " + MeasureTime.ToString() + " " + Location.ToString() + " " + SensorType.ToString() + " " + MeasurmentValue.ToString() + " " + DeviceIp.ToString() + " " + DeviceName.ToString()+ " " + DevicePort.ToString();
        }
    }
}
