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

public class FbxAxisSystem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAxisSystem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAxisSystem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAxisSystem() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxAxisSystem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxAxisSystem() : this(examplePINVOKE.new_FbxAxisSystem__SWIG_0(), true) {
  }

  public FbxAxisSystem(FbxAxisSystem.EUpVector pUpVector, FbxAxisSystem.EFrontVector pFrontVector, FbxAxisSystem.ECoordSystem pCoorSystem) : this(examplePINVOKE.new_FbxAxisSystem__SWIG_1((int)pUpVector, (int)pFrontVector, (int)pCoorSystem), true) {
  }

  public FbxAxisSystem(FbxAxisSystem pAxisSystem) : this(examplePINVOKE.new_FbxAxisSystem__SWIG_2(FbxAxisSystem.getCPtr(pAxisSystem)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxAxisSystem(FbxAxisSystem.EPreDefinedAxisSystem pAxisSystem) : this(examplePINVOKE.new_FbxAxisSystem__SWIG_3((int)pAxisSystem), true) {
  }

  public static FbxAxisSystem MayaZUp {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_MayaZUp_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem MayaYUp {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_MayaYUp_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem Max {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_Max_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem Motionbuilder {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_Motionbuilder_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem OpenGL {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_OpenGL_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem DirectX {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_DirectX_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public static FbxAxisSystem Lightwave {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxAxisSystem_Lightwave_get();
      FbxAxisSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAxisSystem(cPtr, false);
      return ret;
    } 
  }

  public void ConvertScene(FbxScene pScene) {
    examplePINVOKE.FbxAxisSystem_ConvertScene__SWIG_0(swigCPtr, FbxScene.getCPtr(pScene));
  }

  public void ConvertScene(FbxScene pScene, FbxNode pFbxRoot) {
    examplePINVOKE.FbxAxisSystem_ConvertScene__SWIG_1(swigCPtr, FbxScene.getCPtr(pScene), FbxNode.getCPtr(pFbxRoot));
  }

  public FbxAxisSystem.EFrontVector GetFrontVector(SWIGTYPE_p_int pSign) {
    FbxAxisSystem.EFrontVector ret = (FbxAxisSystem.EFrontVector)examplePINVOKE.FbxAxisSystem_GetFrontVector(swigCPtr, SWIGTYPE_p_int.getCPtr(pSign));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxAxisSystem.EUpVector GetUpVector(SWIGTYPE_p_int pSign) {
    FbxAxisSystem.EUpVector ret = (FbxAxisSystem.EUpVector)examplePINVOKE.FbxAxisSystem_GetUpVector(swigCPtr, SWIGTYPE_p_int.getCPtr(pSign));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxAxisSystem.ECoordSystem GetCoorSystem() {
    FbxAxisSystem.ECoordSystem ret = (FbxAxisSystem.ECoordSystem)examplePINVOKE.FbxAxisSystem_GetCoorSystem(swigCPtr);
    return ret;
  }

  public void ConvertChildren(FbxNode pRoot, FbxAxisSystem pSrcSystem) {
    examplePINVOKE.FbxAxisSystem_ConvertChildren(swigCPtr, FbxNode.getCPtr(pRoot), FbxAxisSystem.getCPtr(pSrcSystem));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum EUpVector {
    eXAxis = 1,
    eYAxis = 2,
    eZAxis = 3
  }

  public enum EFrontVector {
    eParityEven = 1,
    eParityOdd = 2
  }

  public enum ECoordSystem {
    eRightHanded,
    eLeftHanded
  }

  public enum EPreDefinedAxisSystem {
    eMayaZUp,
    eMayaYUp,
    eMax,
    eMotionBuilder,
    eOpenGL,
    eDirectX,
    eLightwave
  }

}

}