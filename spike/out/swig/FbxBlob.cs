//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FbxSdk {

public class FbxBlob : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxBlob(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxBlob obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxBlob() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxBlob(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxBlob() : this(examplePINVOKE.new_FbxBlob__SWIG_0(), true) {
  }

  public FbxBlob(int pSize) : this(examplePINVOKE.new_FbxBlob__SWIG_1(pSize), true) {
  }

  public FbxBlob(FbxBlob pRHS) : this(examplePINVOKE.new_FbxBlob__SWIG_2(FbxBlob.getCPtr(pRHS)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxBlob(SWIGTYPE_p_void pData, int pSize) : this(examplePINVOKE.new_FbxBlob__SWIG_3(SWIGTYPE_p_void.getCPtr(pData), pSize), true) {
  }

  public void Assign(SWIGTYPE_p_void pData, int pSize) {
    examplePINVOKE.FbxBlob_Assign(swigCPtr, SWIGTYPE_p_void.getCPtr(pData), pSize);
  }

  public SWIGTYPE_p_void Modify() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxBlob_Modify(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void Access() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxBlob_Access(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public int Size() {
    int ret = examplePINVOKE.FbxBlob_Size(swigCPtr);
    return ret;
  }

  public void Clear() {
    examplePINVOKE.FbxBlob_Clear(swigCPtr);
  }

}

}