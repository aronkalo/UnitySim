using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Car
{
    public class CarRegulator
    {
        private IEnumerable<AxleInfo> _axleInfos;

        private MotorConfiguration _motorConfiguration;

        public CarRegulator(IEnumerable<AxleInfo> axleInfos, MotorConfiguration motorConfiguration)
        {
            this._axleInfos = axleInfos;
            this._motorConfiguration = motorConfiguration;
        }

        public MovementInfo GetInputMovementInfo()
        {
            const string VERTICAL = "Vertical";
            const string HORIZONTAL = "Horizontal";
            float steering = Input.GetAxis(HORIZONTAL);
            float motorInput = Input.GetAxis(VERTICAL);
            float torque = 0;
            return new MovementInfo( new[] {
                    new AxleTorque(torque, torque),
                    new AxleTorque(torque, torque)
                }, steering);
        }

        private Vector3 velocity
        {
            get { return this._motorConfiguration.BodyWork.velocity; }
        }

        private float getSimplifiedVelocity()
        {
            var velocity = this.velocity;
            return Math.Abs(velocity.x) + Math.Abs(velocity.y) + Math.Abs(velocity.z);
        }
    }
}
