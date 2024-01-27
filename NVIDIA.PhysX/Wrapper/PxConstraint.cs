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

public partial class PxConstraint : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxConstraint getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxConstraint)) {
          wrapper = new PxConstraint(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxConstraint;
  }

  public PxScene getScene() {
    global::System.IntPtr cPtr = NativePINVOKE.PxConstraint_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : PxScene.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxRigidActor getActor0() {
    global::System.IntPtr cPtr = NativePINVOKE.PxConstraint_getActor0(swigCPtr);
    PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxRigidActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxRigidActor getActor1() {
    global::System.IntPtr cPtr = NativePINVOKE.PxConstraint_getActor1(swigCPtr);
    PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : PxRigidActor.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setActor0(PxRigidActor actor) {
    NativePINVOKE.PxConstraint_setActor0(swigCPtr, PxRigidActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setActor1(PxRigidActor actor) {
    NativePINVOKE.PxConstraint_setActor1(swigCPtr, PxRigidActor.getCPtr(actor));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void markDirty() {
    NativePINVOKE.PxConstraint_markDirty(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFlags(PxConstraintFlag flags) {
    NativePINVOKE.PxConstraint_setFlags(swigCPtr, (int)flags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxConstraintFlag getFlags() {
    PxConstraintFlag ret = (PxConstraintFlag)NativePINVOKE.PxConstraint_getFlags(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFlag(PxConstraintFlag flag, bool value) {
    NativePINVOKE.PxConstraint_setFlag(swigCPtr, (int)flag, value);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getForce( ref PxVec3  linear,  ref PxVec3  angular) {
    NativePINVOKE.PxConstraint_getForce(swigCPtr,  linear.swigCPtr ,  angular.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = NativePINVOKE.PxConstraint_isValid(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBreakForce(float linear, float angular) {
    NativePINVOKE.PxConstraint_setBreakForce(swigCPtr, linear, angular);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getBreakForce(out float linear, out float angular) {
    NativePINVOKE.PxConstraint_getBreakForce(swigCPtr, out linear, out angular);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMinResponseThreshold(float threshold) {
    NativePINVOKE.PxConstraint_setMinResponseThreshold(swigCPtr, threshold);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMinResponseThreshold() {
    float ret = NativePINVOKE.PxConstraint_getMinResponseThreshold(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setConstraintFunctions(PxConstraintConnector connector, PxConstraintShaderTable shaders) {
    NativePINVOKE.PxConstraint_setConstraintFunctions(swigCPtr, PxConstraintConnector.getCPtr(connector), PxConstraintShaderTable.getCPtr(shaders));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
