using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Simulator.Bridge.Data
{
  public class ComfortData
  {
    public string Name;
    public string Frame;
    public double Time;

    public Vector3 velocity;
    public Vector3 acceleration;
    public Vector3 jerk;
    public float angularVelocity;
    public float angularAcceleration;
    public float roll;
    public float slip;
  }
}
