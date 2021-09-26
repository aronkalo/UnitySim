using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Car
{
    public class MovementInfo
    {
        public MovementInfo(IEnumerable<AxleTorque> axleTorques, float steering)
        {
            this.AxleTorques = axleTorques;
            this.Steering = steering;
        }

        public  IEnumerable<AxleTorque> AxleTorques { get; }

        public float Steering { get; }
    }

    public struct AxleTorque
    {
        public AxleTorque(float right, float left, bool braking = false)
        {
            this.Right = right;
            this.Left = left;
            this.Braking = braking;
        }

        public float Right { get; }

        public float Left { get; }

        public bool Braking { get; }

    }
}
