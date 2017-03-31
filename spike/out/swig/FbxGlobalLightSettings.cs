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

public class FbxGlobalLightSettings : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxGlobalLightSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxGlobalLightSettings obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void SetAmbientColor(FbxColor pAmbientColor) {
    examplePINVOKE.FbxGlobalLightSettings_SetAmbientColor(swigCPtr, FbxColor.getCPtr(pAmbientColor));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxColor GetAmbientColor() {
    FbxColor ret = new FbxColor(examplePINVOKE.FbxGlobalLightSettings_GetAmbientColor(swigCPtr), true);
    return ret;
  }

  public void SetFogEnable(bool pEnable) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogEnable(swigCPtr, pEnable);
  }

  public bool GetFogEnable() {
    bool ret = examplePINVOKE.FbxGlobalLightSettings_GetFogEnable(swigCPtr);
    return ret;
  }

  public void SetFogColor(FbxColor pColor) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogColor(swigCPtr, FbxColor.getCPtr(pColor));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxColor GetFogColor() {
    FbxColor ret = new FbxColor(examplePINVOKE.FbxGlobalLightSettings_GetFogColor(swigCPtr), true);
    return ret;
  }

  public void SetFogMode(FbxGlobalLightSettings.EFogMode pMode) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogMode(swigCPtr, (int)pMode);
  }

  public FbxGlobalLightSettings.EFogMode GetFogMode() {
    FbxGlobalLightSettings.EFogMode ret = (FbxGlobalLightSettings.EFogMode)examplePINVOKE.FbxGlobalLightSettings_GetFogMode(swigCPtr);
    return ret;
  }

  public void SetFogDensity(double pDensity) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogDensity(swigCPtr, pDensity);
  }

  public double GetFogDensity() {
    double ret = examplePINVOKE.FbxGlobalLightSettings_GetFogDensity(swigCPtr);
    return ret;
  }

  public void SetFogStart(double pStart) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogStart(swigCPtr, pStart);
  }

  public double GetFogStart() {
    double ret = examplePINVOKE.FbxGlobalLightSettings_GetFogStart(swigCPtr);
    return ret;
  }

  public void SetFogEnd(double pEnd) {
    examplePINVOKE.FbxGlobalLightSettings_SetFogEnd(swigCPtr, pEnd);
  }

  public double GetFogEnd() {
    double ret = examplePINVOKE.FbxGlobalLightSettings_GetFogEnd(swigCPtr);
    return ret;
  }

  public class ShadowPlane : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ShadowPlane(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ShadowPlane obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ShadowPlane() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            examplePINVOKE.delete_FbxGlobalLightSettings_ShadowPlane(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ShadowPlane() : this(examplePINVOKE.new_FbxGlobalLightSettings_ShadowPlane(), true) {
    }
  
    public bool mEnable {
      set {
        examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mEnable_set(swigCPtr, value);
      } 
      get {
        bool ret = examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mEnable_get(swigCPtr);
        return ret;
      } 
    }
  
    public FbxVector4 mOrigin {
      set {
        examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mOrigin_set(swigCPtr, FbxVector4.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mOrigin_get(swigCPtr);
        FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
        return ret;
      } 
    }
  
    public FbxVector4 mNormal {
      set {
        examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mNormal_set(swigCPtr, FbxVector4.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = examplePINVOKE.FbxGlobalLightSettings_ShadowPlane_mNormal_get(swigCPtr);
        FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
        return ret;
      } 
    }
  
  }

  public void SetShadowEnable(bool pShadowEnable) {
    examplePINVOKE.FbxGlobalLightSettings_SetShadowEnable(swigCPtr, pShadowEnable);
  }

  public bool GetShadowEnable() {
    bool ret = examplePINVOKE.FbxGlobalLightSettings_GetShadowEnable(swigCPtr);
    return ret;
  }

  public void SetShadowIntensity(double pShadowIntensity) {
    examplePINVOKE.FbxGlobalLightSettings_SetShadowIntensity(swigCPtr, pShadowIntensity);
  }

  public double GetShadowIntensity() {
    double ret = examplePINVOKE.FbxGlobalLightSettings_GetShadowIntensity(swigCPtr);
    return ret;
  }

  public int GetShadowPlaneCount() {
    int ret = examplePINVOKE.FbxGlobalLightSettings_GetShadowPlaneCount(swigCPtr);
    return ret;
  }

  public FbxGlobalLightSettings.ShadowPlane GetShadowPlane(int pIndex, FbxStatus pStatus) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxGlobalLightSettings_GetShadowPlane__SWIG_0(swigCPtr, pIndex, FbxStatus.getCPtr(pStatus));
    FbxGlobalLightSettings.ShadowPlane ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGlobalLightSettings.ShadowPlane(cPtr, false);
    return ret;
  }

  public FbxGlobalLightSettings.ShadowPlane GetShadowPlane(int pIndex) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxGlobalLightSettings_GetShadowPlane__SWIG_1(swigCPtr, pIndex);
    FbxGlobalLightSettings.ShadowPlane ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGlobalLightSettings.ShadowPlane(cPtr, false);
    return ret;
  }

  public void AddShadowPlane(FbxGlobalLightSettings.ShadowPlane pShadowPlane) {
    examplePINVOKE.FbxGlobalLightSettings_AddShadowPlane(swigCPtr, FbxGlobalLightSettings.ShadowPlane.getCPtr(pShadowPlane));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllShadowPlanes() {
    examplePINVOKE.FbxGlobalLightSettings_RemoveAllShadowPlanes(swigCPtr);
  }

  public void RestoreDefaultSettings() {
    examplePINVOKE.FbxGlobalLightSettings_RestoreDefaultSettings(swigCPtr);
  }

  public enum EFogMode {
    eLinear,
    eExponential,
    eExponentialSquareRoot
  }

}

}