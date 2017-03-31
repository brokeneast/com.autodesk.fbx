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

public class FbxDocumentInfo : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxDocumentInfo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxDocumentInfo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxDocumentInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxDocumentInfo_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxDocumentInfo_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxDocumentInfo Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    return ret;
  }

  public new static FbxDocumentInfo Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t LastSavedUrl {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSavedUrl_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSavedUrl_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Url {
    set {
      examplePINVOKE.FbxDocumentInfo_Url_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Url_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty Original {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Original_ApplicationVendor {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_ApplicationVendor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_ApplicationVendor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Original_ApplicationName {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_ApplicationName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_ApplicationName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Original_ApplicationVersion {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_ApplicationVersion_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_ApplicationVersion_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Original_FileName {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_FileName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_FileName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t Original_DateTime_GMT {
    set {
      examplePINVOKE.FbxDocumentInfo_Original_DateTime_GMT_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_Original_DateTime_GMT_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty LastSaved {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSaved_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSaved_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t LastSaved_ApplicationVendor {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationVendor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationVendor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t LastSaved_ApplicationName {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t LastSaved_ApplicationVersion {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationVersion_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSaved_ApplicationVersion_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t LastSaved_DateTime_GMT {
    set {
      examplePINVOKE.FbxDocumentInfo_LastSaved_DateTime_GMT_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_LastSaved_DateTime_GMT_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxDateTime_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t EmbeddedUrl {
    set {
      examplePINVOKE.FbxDocumentInfo_EmbeddedUrl_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_EmbeddedUrl_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public FbxString mTitle {
    set {
      examplePINVOKE.FbxDocumentInfo_mTitle_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mTitle_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mSubject {
    set {
      examplePINVOKE.FbxDocumentInfo_mSubject_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mSubject_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mAuthor {
    set {
      examplePINVOKE.FbxDocumentInfo_mAuthor_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mAuthor_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mKeywords {
    set {
      examplePINVOKE.FbxDocumentInfo_mKeywords_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mKeywords_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mRevision {
    set {
      examplePINVOKE.FbxDocumentInfo_mRevision_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mRevision_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mComment {
    set {
      examplePINVOKE.FbxDocumentInfo_mComment_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_mComment_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxThumbnail GetSceneThumbnail() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxDocumentInfo_GetSceneThumbnail(swigCPtr);
    FbxThumbnail ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxThumbnail(cPtr, false);
    return ret;
  }

  public void SetSceneThumbnail(FbxThumbnail pSceneThumbnail) {
    examplePINVOKE.FbxDocumentInfo_SetSceneThumbnail(swigCPtr, FbxThumbnail.getCPtr(pSceneThumbnail));
  }

  public void Clear() {
    examplePINVOKE.FbxDocumentInfo_Clear(swigCPtr);
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(examplePINVOKE.FbxDocumentInfo_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}