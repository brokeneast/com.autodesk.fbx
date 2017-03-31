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

public class FbxTexture : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxTexture_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTexture obj) {
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
      examplePINVOKE.FbxTexture_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxTexture_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxTexture Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTexture(cPtr, false);
    return ret;
  }

  public new static FbxTexture Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTexture(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTexture__ETextureUse6_t TextureTypeUse {
    set {
      examplePINVOKE.FbxTexture_TextureTypeUse_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTexture__ETextureUse6_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_TextureTypeUse_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTexture__ETextureUse6_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTexture__ETextureUse6_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t Alpha {
    set {
      examplePINVOKE.FbxTexture_Alpha_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Alpha_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTexture__EUnifiedMappingType_t CurrentMappingType {
    set {
      examplePINVOKE.FbxTexture_CurrentMappingType_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTexture__EUnifiedMappingType_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_CurrentMappingType_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTexture__EUnifiedMappingType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTexture__EUnifiedMappingType_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t WrapModeU {
    set {
      examplePINVOKE.FbxTexture_WrapModeU_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_WrapModeU_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t WrapModeV {
    set {
      examplePINVOKE.FbxTexture_WrapModeV_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_WrapModeV_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTexture__EWrapMode_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t UVSwap {
    set {
      examplePINVOKE.FbxTexture_UVSwap_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_UVSwap_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t PremultiplyAlpha {
    set {
      examplePINVOKE.FbxTexture_PremultiplyAlpha_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_PremultiplyAlpha_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Translation {
    set {
      examplePINVOKE.FbxTexture_Translation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Translation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Rotation {
    set {
      examplePINVOKE.FbxTexture_Rotation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Rotation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Scaling {
    set {
      examplePINVOKE.FbxTexture_Scaling_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_Scaling_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t RotationPivot {
    set {
      examplePINVOKE.FbxTexture_RotationPivot_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_RotationPivot_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ScalingPivot {
    set {
      examplePINVOKE.FbxTexture_ScalingPivot_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_ScalingPivot_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTexture__EBlendMode_t CurrentTextureBlendMode {
    set {
      examplePINVOKE.FbxTexture_CurrentTextureBlendMode_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTexture__EBlendMode_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_CurrentTextureBlendMode_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTexture__EBlendMode_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTexture__EBlendMode_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t UVSet {
    set {
      examplePINVOKE.FbxTexture_UVSet_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxTexture_UVSet_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public static string sVectorSpace {
    set {
      examplePINVOKE.FbxTexture_sVectorSpace_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorSpace_get();
      return ret;
    } 
  }

  public static string sVectorSpaceWorld {
    set {
      examplePINVOKE.FbxTexture_sVectorSpaceWorld_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorSpaceWorld_get();
      return ret;
    } 
  }

  public static string sVectorSpaceObject {
    set {
      examplePINVOKE.FbxTexture_sVectorSpaceObject_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorSpaceObject_get();
      return ret;
    } 
  }

  public static string sVectorSpaceTangent {
    set {
      examplePINVOKE.FbxTexture_sVectorSpaceTangent_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorSpaceTangent_get();
      return ret;
    } 
  }

  public static string sVectorEncoding {
    set {
      examplePINVOKE.FbxTexture_sVectorEncoding_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorEncoding_get();
      return ret;
    } 
  }

  public static string sVectorEncodingFP {
    set {
      examplePINVOKE.FbxTexture_sVectorEncodingFP_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorEncodingFP_get();
      return ret;
    } 
  }

  public static string sVectorEncodingSE {
    set {
      examplePINVOKE.FbxTexture_sVectorEncodingSE_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxTexture_sVectorEncodingSE_get();
      return ret;
    } 
  }

  public virtual void Reset() {
    examplePINVOKE.FbxTexture_Reset(swigCPtr);
  }

  public void SetSwapUV(bool pSwapUV) {
    examplePINVOKE.FbxTexture_SetSwapUV(swigCPtr, pSwapUV);
  }

  public bool GetSwapUV() {
    bool ret = examplePINVOKE.FbxTexture_GetSwapUV(swigCPtr);
    return ret;
  }

  public void SetPremultiplyAlpha(bool pPremultiplyAlpha) {
    examplePINVOKE.FbxTexture_SetPremultiplyAlpha(swigCPtr, pPremultiplyAlpha);
  }

  public bool GetPremultiplyAlpha() {
    bool ret = examplePINVOKE.FbxTexture_GetPremultiplyAlpha(swigCPtr);
    return ret;
  }

  public void SetAlphaSource(FbxTexture.EAlphaSource pAlphaSource) {
    examplePINVOKE.FbxTexture_SetAlphaSource(swigCPtr, (int)pAlphaSource);
  }

  public FbxTexture.EAlphaSource GetAlphaSource() {
    FbxTexture.EAlphaSource ret = (FbxTexture.EAlphaSource)examplePINVOKE.FbxTexture_GetAlphaSource(swigCPtr);
    return ret;
  }

  public void SetCropping(int pLeft, int pTop, int pRight, int pBottom) {
    examplePINVOKE.FbxTexture_SetCropping(swigCPtr, pLeft, pTop, pRight, pBottom);
  }

  public int GetCroppingLeft() {
    int ret = examplePINVOKE.FbxTexture_GetCroppingLeft(swigCPtr);
    return ret;
  }

  public int GetCroppingTop() {
    int ret = examplePINVOKE.FbxTexture_GetCroppingTop(swigCPtr);
    return ret;
  }

  public int GetCroppingRight() {
    int ret = examplePINVOKE.FbxTexture_GetCroppingRight(swigCPtr);
    return ret;
  }

  public int GetCroppingBottom() {
    int ret = examplePINVOKE.FbxTexture_GetCroppingBottom(swigCPtr);
    return ret;
  }

  public void SetMappingType(FbxTexture.EMappingType pMappingType) {
    examplePINVOKE.FbxTexture_SetMappingType(swigCPtr, (int)pMappingType);
  }

  public FbxTexture.EMappingType GetMappingType() {
    FbxTexture.EMappingType ret = (FbxTexture.EMappingType)examplePINVOKE.FbxTexture_GetMappingType(swigCPtr);
    return ret;
  }

  public void SetPlanarMappingNormal(FbxTexture.EPlanarMappingNormal pPlanarMappingNormal) {
    examplePINVOKE.FbxTexture_SetPlanarMappingNormal(swigCPtr, (int)pPlanarMappingNormal);
  }

  public FbxTexture.EPlanarMappingNormal GetPlanarMappingNormal() {
    FbxTexture.EPlanarMappingNormal ret = (FbxTexture.EPlanarMappingNormal)examplePINVOKE.FbxTexture_GetPlanarMappingNormal(swigCPtr);
    return ret;
  }

  public void SetTextureUse(FbxTexture.ETextureUse pTextureUse) {
    examplePINVOKE.FbxTexture_SetTextureUse(swigCPtr, (int)pTextureUse);
  }

  public FbxTexture.ETextureUse GetTextureUse() {
    FbxTexture.ETextureUse ret = (FbxTexture.ETextureUse)examplePINVOKE.FbxTexture_GetTextureUse(swigCPtr);
    return ret;
  }

  public void SetWrapMode(FbxTexture.EWrapMode pWrapU, FbxTexture.EWrapMode pWrapV) {
    examplePINVOKE.FbxTexture_SetWrapMode(swigCPtr, (int)pWrapU, (int)pWrapV);
  }

  public FbxTexture.EWrapMode GetWrapModeU() {
    FbxTexture.EWrapMode ret = (FbxTexture.EWrapMode)examplePINVOKE.FbxTexture_GetWrapModeU(swigCPtr);
    return ret;
  }

  public FbxTexture.EWrapMode GetWrapModeV() {
    FbxTexture.EWrapMode ret = (FbxTexture.EWrapMode)examplePINVOKE.FbxTexture_GetWrapModeV(swigCPtr);
    return ret;
  }

  public void SetBlendMode(FbxTexture.EBlendMode pBlendMode) {
    examplePINVOKE.FbxTexture_SetBlendMode(swigCPtr, (int)pBlendMode);
  }

  public FbxTexture.EBlendMode GetBlendMode() {
    FbxTexture.EBlendMode ret = (FbxTexture.EBlendMode)examplePINVOKE.FbxTexture_GetBlendMode(swigCPtr);
    return ret;
  }

  public void SetDefaultT(FbxVector4 pT) {
    examplePINVOKE.FbxTexture_SetDefaultT(swigCPtr, FbxVector4.getCPtr(pT));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetDefaultT(FbxVector4 pT) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxTexture_GetDefaultT(swigCPtr, FbxVector4.getCPtr(pT)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefaultR(FbxVector4 pR) {
    examplePINVOKE.FbxTexture_SetDefaultR(swigCPtr, FbxVector4.getCPtr(pR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetDefaultR(FbxVector4 pR) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxTexture_GetDefaultR(swigCPtr, FbxVector4.getCPtr(pR)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefaultS(FbxVector4 pS) {
    examplePINVOKE.FbxTexture_SetDefaultS(swigCPtr, FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetDefaultS(FbxVector4 pS) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxTexture_GetDefaultS(swigCPtr, FbxVector4.getCPtr(pS)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefaultAlpha(double pAlpha) {
    examplePINVOKE.FbxTexture_SetDefaultAlpha(swigCPtr, pAlpha);
  }

  public double GetDefaultAlpha() {
    double ret = examplePINVOKE.FbxTexture_GetDefaultAlpha(swigCPtr);
    return ret;
  }

  public void SetTranslation(double pU, double pV) {
    examplePINVOKE.FbxTexture_SetTranslation(swigCPtr, pU, pV);
  }

  public double GetTranslationU() {
    double ret = examplePINVOKE.FbxTexture_GetTranslationU(swigCPtr);
    return ret;
  }

  public double GetTranslationV() {
    double ret = examplePINVOKE.FbxTexture_GetTranslationV(swigCPtr);
    return ret;
  }

  public void SetRotation(double pU, double pV, double pW) {
    examplePINVOKE.FbxTexture_SetRotation__SWIG_0(swigCPtr, pU, pV, pW);
  }

  public void SetRotation(double pU, double pV) {
    examplePINVOKE.FbxTexture_SetRotation__SWIG_1(swigCPtr, pU, pV);
  }

  public double GetRotationU() {
    double ret = examplePINVOKE.FbxTexture_GetRotationU(swigCPtr);
    return ret;
  }

  public double GetRotationV() {
    double ret = examplePINVOKE.FbxTexture_GetRotationV(swigCPtr);
    return ret;
  }

  public double GetRotationW() {
    double ret = examplePINVOKE.FbxTexture_GetRotationW(swigCPtr);
    return ret;
  }

  public void SetScale(double pU, double pV) {
    examplePINVOKE.FbxTexture_SetScale(swigCPtr, pU, pV);
  }

  public double GetScaleU() {
    double ret = examplePINVOKE.FbxTexture_GetScaleU(swigCPtr);
    return ret;
  }

  public double GetScaleV() {
    double ret = examplePINVOKE.FbxTexture_GetScaleV(swigCPtr);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(examplePINVOKE.FbxTexture_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetUVTranslation(FbxVector2 pT) {
    examplePINVOKE.FbxTexture_SetUVTranslation(swigCPtr, FbxVector2.getCPtr(pT));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector2 GetUVTranslation() {
    FbxVector2 ret = new FbxVector2(examplePINVOKE.FbxTexture_GetUVTranslation(swigCPtr), false);
    return ret;
  }

  public void SetUVScaling(FbxVector2 pS) {
    examplePINVOKE.FbxTexture_SetUVScaling(swigCPtr, FbxVector2.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector2 GetUVScaling() {
    FbxVector2 ret = new FbxVector2(examplePINVOKE.FbxTexture_GetUVScaling(swigCPtr), false);
    return ret;
  }

  public FbxString GetTextureType() {
    FbxString ret = new FbxString(examplePINVOKE.FbxTexture_GetTextureType(swigCPtr), true);
    return ret;
  }

  public enum EUnifiedMappingType {
    eUMT_UV,
    eUMT_XY,
    eUMT_YZ,
    eUMT_XZ,
    eUMT_SPHERICAL,
    eUMT_CYLINDRICAL,
    eUMT_ENVIRONMENT,
    eUMT_PROJECTION,
    eUMT_BOX,
    eUMT_FACE,
    eUMT_NO_MAPPING
  }

  public enum ETextureUse6 {
    eTEXTURE_USE_6_STANDARD,
    eTEXTURE_USE_6_SPHERICAL_REFLEXION_MAP,
    eTEXTURE_USE_6_SPHERE_REFLEXION_MAP,
    eTEXTURE_USE_6_SHADOW_MAP,
    eTEXTURE_USE_6_LIGHT_MAP,
    eTEXTURE_USE_6_BUMP_NORMAL_MAP
  }

  public enum EWrapMode {
    eRepeat,
    eClamp
  }

  public enum EBlendMode {
    eTranslucent,
    eAdditive,
    eModulate,
    eModulate2,
    eOver
  }

  public enum EAlignMode {
    eLeft,
    eRight,
    eTop,
    eBottom
  }

  public enum ECoordinates {
    eU,
    eV,
    eW
  }

  public enum EAlphaSource {
    eNone,
    eRGBIntensity,
    eBlack
  }

  public enum EMappingType {
    eNull,
    ePlanar,
    eSpherical,
    eCylindrical,
    eBox,
    eFace,
    eUV,
    eEnvironment
  }

  public enum EPlanarMappingNormal {
    ePlanarNormalX,
    ePlanarNormalY,
    ePlanarNormalZ
  }

  public enum ETextureUse {
    eStandard,
    eShadowMap,
    eLightMap,
    eSphericalReflectionMap,
    eSphereReflectionMap,
    eBumpNormalMap
  }

}

}