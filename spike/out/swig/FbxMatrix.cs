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

public class FbxMatrix : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxMatrix(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxMatrix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxMatrix() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxMatrix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxMatrix() : this(examplePINVOKE.new_FbxMatrix__SWIG_0(), true) {
  }

  public FbxMatrix(FbxMatrix pM) : this(examplePINVOKE.new_FbxMatrix__SWIG_1(FbxMatrix.getCPtr(pM)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxMatrix(FbxAMatrix pM) : this(examplePINVOKE.new_FbxMatrix__SWIG_2(FbxAMatrix.getCPtr(pM)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxMatrix(FbxVector4 pT, FbxVector4 pR, FbxVector4 pS) : this(examplePINVOKE.new_FbxMatrix__SWIG_3(FbxVector4.getCPtr(pT), FbxVector4.getCPtr(pR), FbxVector4.getCPtr(pS)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxMatrix(FbxVector4 pT, FbxQuaternion pQ, FbxVector4 pS) : this(examplePINVOKE.new_FbxMatrix__SWIG_4(FbxVector4.getCPtr(pT), FbxQuaternion.getCPtr(pQ), FbxVector4.getCPtr(pS)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxMatrix(double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33) : this(examplePINVOKE.new_FbxMatrix__SWIG_5(p00, p10, p20, p30, p01, p11, p21, p31, p02, p12, p22, p32, p03, p13, p23, p33), true) {
  }

  public double Get(int pY, int pX) {
    double ret = examplePINVOKE.FbxMatrix_Get(swigCPtr, pY, pX);
    return ret;
  }

  public FbxVector4 GetRow(int pY) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxMatrix_GetRow(swigCPtr, pY), true);
    return ret;
  }

  public FbxVector4 GetColumn(int pX) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxMatrix_GetColumn(swigCPtr, pX), true);
    return ret;
  }

  public void Set(int pY, int pX, double pValue) {
    examplePINVOKE.FbxMatrix_Set(swigCPtr, pY, pX, pValue);
  }

  public void SetTRS(FbxVector4 pT, FbxVector4 pR, FbxVector4 pS) {
    examplePINVOKE.FbxMatrix_SetTRS(swigCPtr, FbxVector4.getCPtr(pT), FbxVector4.getCPtr(pR), FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTQS(FbxVector4 pT, FbxQuaternion pQ, FbxVector4 pS) {
    examplePINVOKE.FbxMatrix_SetTQS(swigCPtr, FbxVector4.getCPtr(pT), FbxQuaternion.getCPtr(pQ), FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(int pY, FbxVector4 pRow) {
    examplePINVOKE.FbxMatrix_SetRow(swigCPtr, pY, FbxVector4.getCPtr(pRow));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColumn(int pX, FbxVector4 pColumn) {
    examplePINVOKE.FbxMatrix_SetColumn(swigCPtr, pX, FbxVector4.getCPtr(pColumn));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetElements(FbxVector4 pTranslation, FbxQuaternion pRotation, FbxVector4 pShearing, FbxVector4 pScaling, SWIGTYPE_p_double pSign) {
    examplePINVOKE.FbxMatrix_GetElements__SWIG_0(swigCPtr, FbxVector4.getCPtr(pTranslation), FbxQuaternion.getCPtr(pRotation), FbxVector4.getCPtr(pShearing), FbxVector4.getCPtr(pScaling), SWIGTYPE_p_double.getCPtr(pSign));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetElements(FbxVector4 pTranslation, FbxVector4 pRotation, FbxVector4 pShearing, FbxVector4 pScaling, SWIGTYPE_p_double pSign) {
    examplePINVOKE.FbxMatrix_GetElements__SWIG_1(swigCPtr, FbxVector4.getCPtr(pTranslation), FbxVector4.getCPtr(pRotation), FbxVector4.getCPtr(pShearing), FbxVector4.getCPtr(pScaling), SWIGTYPE_p_double.getCPtr(pSign));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_a_4__a_4__double Double44() {
    SWIGTYPE_p_a_4__a_4__double ret = new SWIGTYPE_p_a_4__a_4__double(examplePINVOKE.FbxMatrix_Double44(swigCPtr), false);
    return ret;
  }

  public FbxMatrix Inverse() {
    FbxMatrix ret = new FbxMatrix(examplePINVOKE.FbxMatrix_Inverse(swigCPtr), true);
    return ret;
  }

  public FbxMatrix Transpose() {
    FbxMatrix ret = new FbxMatrix(examplePINVOKE.FbxMatrix_Transpose(swigCPtr), true);
    return ret;
  }

  public void SetIdentity() {
    examplePINVOKE.FbxMatrix_SetIdentity(swigCPtr);
  }

  public void SetLookToLH(FbxVector4 pEyePosition, FbxVector4 pEyeDirection, FbxVector4 pUpDirection) {
    examplePINVOKE.FbxMatrix_SetLookToLH(swigCPtr, FbxVector4.getCPtr(pEyePosition), FbxVector4.getCPtr(pEyeDirection), FbxVector4.getCPtr(pUpDirection));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLookToRH(FbxVector4 pEyePosition, FbxVector4 pEyeDirection, FbxVector4 pUpDirection) {
    examplePINVOKE.FbxMatrix_SetLookToRH(swigCPtr, FbxVector4.getCPtr(pEyePosition), FbxVector4.getCPtr(pEyeDirection), FbxVector4.getCPtr(pUpDirection));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLookAtLH(FbxVector4 pEyePosition, FbxVector4 pLookAt, FbxVector4 pUpDirection) {
    examplePINVOKE.FbxMatrix_SetLookAtLH(swigCPtr, FbxVector4.getCPtr(pEyePosition), FbxVector4.getCPtr(pLookAt), FbxVector4.getCPtr(pUpDirection));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLookAtRH(FbxVector4 pEyePosition, FbxVector4 pLookAt, FbxVector4 pUpDirection) {
    examplePINVOKE.FbxMatrix_SetLookAtRH(swigCPtr, FbxVector4.getCPtr(pEyePosition), FbxVector4.getCPtr(pLookAt), FbxVector4.getCPtr(pUpDirection));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 MultNormalize(FbxVector4 pVector) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxMatrix_MultNormalize(swigCPtr, FbxVector4.getCPtr(pVector)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxMatrix pM, double pThreshold) {
    int ret = examplePINVOKE.FbxMatrix_Compare__SWIG_0(swigCPtr, FbxMatrix.getCPtr(pM), pThreshold);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxMatrix pM) {
    int ret = examplePINVOKE.FbxMatrix_Compare__SWIG_1(swigCPtr, FbxMatrix.getCPtr(pM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxAMatrix pM, double pThreshold) {
    int ret = examplePINVOKE.FbxMatrix_Compare__SWIG_2(swigCPtr, FbxAMatrix.getCPtr(pM), pThreshold);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxAMatrix pM) {
    int ret = examplePINVOKE.FbxMatrix_Compare__SWIG_3(swigCPtr, FbxAMatrix.getCPtr(pM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double LUDecomposition(FbxVector4 pVector) {
    double ret = examplePINVOKE.FbxMatrix_LUDecomposition(swigCPtr, FbxVector4.getCPtr(pVector));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxMatrix LUMult(FbxMatrix pM, FbxVector4 pVector) {
    FbxMatrix ret = new FbxMatrix(examplePINVOKE.FbxMatrix_LUMult(swigCPtr, FbxMatrix.getCPtr(pM), FbxVector4.getCPtr(pVector)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Determinant() {
    double ret = examplePINVOKE.FbxMatrix_Determinant(swigCPtr);
    return ret;
  }

}

}