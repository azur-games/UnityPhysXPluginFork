//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NVIDIA.PhysX {

[global::System.FlagsAttribute()]
public enum PxPairFlag {
  SOLVE_CONTACT = (1 << 0),
  MODIFY_CONTACTS = (1 << 1),
  NOTIFY_TOUCH_FOUND = (1 << 2),
  NOTIFY_TOUCH_PERSISTS = (1 << 3),
  NOTIFY_TOUCH_LOST = (1 << 4),
  NOTIFY_TOUCH_CCD = (1 << 5),
  NOTIFY_THRESHOLD_FORCE_FOUND = (1 << 6),
  NOTIFY_THRESHOLD_FORCE_PERSISTS = (1 << 7),
  NOTIFY_THRESHOLD_FORCE_LOST = (1 << 8),
  NOTIFY_CONTACT_POINTS = (1 << 9),
  DETECT_DISCRETE_CONTACT = (1 << 10),
  DETECT_CCD_CONTACT = (1 << 11),
  PRE_SOLVER_VELOCITY = (1 << 12),
  POST_SOLVER_VELOCITY = (1 << 13),
  CONTACT_EVENT_POSE = (1 << 14),
  CONTACT_DEFAULT = (1 << 0)|(1 << 10),
  TRIGGER_DEFAULT = (1 << 2)|(1 << 4)|(1 << 10)
}

}
