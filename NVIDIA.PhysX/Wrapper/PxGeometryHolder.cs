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

public partial class PxGeometryHolder {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxGeometryHolder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxGeometryHolder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxGeometryHolder() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxGeometryHolder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxGeometryType getType() {
    PxGeometryType ret = (PxGeometryType)NativePINVOKE.PxGeometryHolder_getType(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxGeometry any() {
    PxGeometry ret = new PxGeometry(NativePINVOKE.PxGeometryHolder_any(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxSphereGeometry sphere() {
    PxSphereGeometry ret = new PxSphereGeometry(NativePINVOKE.PxGeometryHolder_sphere(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPlaneGeometry plane() {
    PxPlaneGeometry ret = new PxPlaneGeometry(NativePINVOKE.PxGeometryHolder_plane(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxCapsuleGeometry capsule() {
    PxCapsuleGeometry ret = new PxCapsuleGeometry(NativePINVOKE.PxGeometryHolder_capsule(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxBoxGeometry box() {
    PxBoxGeometry ret = new PxBoxGeometry(NativePINVOKE.PxGeometryHolder_box(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxConvexMeshGeometry convexMesh() {
    PxConvexMeshGeometry ret = new PxConvexMeshGeometry(NativePINVOKE.PxGeometryHolder_convexMesh(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxTriangleMeshGeometry triangleMesh() {
    PxTriangleMeshGeometry ret = new PxTriangleMeshGeometry(NativePINVOKE.PxGeometryHolder_triangleMesh(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxHeightFieldGeometry heightField() {
    PxHeightFieldGeometry ret = new PxHeightFieldGeometry(NativePINVOKE.PxGeometryHolder_heightField(swigCPtr), false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void storeAny(PxGeometry geometry) {
    NativePINVOKE.PxGeometryHolder_storeAny(swigCPtr, PxGeometry.getCPtr(geometry));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxGeometryHolder() : this(NativePINVOKE.new_PxGeometryHolder__SWIG_0(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxGeometryHolder(PxGeometry geometry) : this(NativePINVOKE.new_PxGeometryHolder__SWIG_1(PxGeometry.getCPtr(geometry)), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
