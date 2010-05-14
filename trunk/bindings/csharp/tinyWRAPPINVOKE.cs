/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

class tinyWRAPPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterExceptionCallbacks_tinyWRAP")]
    public static extern void SWIGRegisterExceptionCallbacks_tinyWRAP(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_tinyWRAP")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_tinyWRAP(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_tinyWRAP(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_tinyWRAP(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(tinyWRAPPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(tinyWRAPPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("tinyWRAP", EntryPoint="SWIGRegisterStringCallback_tinyWRAP")]
    public static extern void SWIGRegisterStringCallback_tinyWRAP(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_tinyWRAP(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipEvent__SWIG_0")]
  public static extern IntPtr new_SipEvent__SWIG_0();

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipEvent__SWIG_1")]
  public static extern IntPtr new_SipEvent__SWIG_1(short jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipEvent")]
  public static extern void delete_SipEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getCode")]
  public static extern short SipEvent_getCode(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getPhrase")]
  public static extern string SipEvent_getPhrase(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getType")]
  public static extern int SipEvent_getType(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipEvent_getSession")]
  public static extern IntPtr SipEvent_getSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipSession")]
  public static extern IntPtr new_SipSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipSession")]
  public static extern void delete_SipSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addHeader")]
  public static extern bool SipSession_addHeader(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_removeHeader")]
  public static extern bool SipSession_removeHeader(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addCaps__SWIG_0")]
  public static extern bool SipSession_addCaps__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_addCaps__SWIG_1")]
  public static extern bool SipSession_addCaps__SWIG_1(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_removeCaps")]
  public static extern bool SipSession_removeCaps(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setExpires")]
  public static extern bool SipSession_setExpires(HandleRef jarg1, uint jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setFromUri")]
  public static extern bool SipSession_setFromUri(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipSession_setToUri")]
  public static extern bool SipSession_setToUri(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_RegistrationEvent")]
  public static extern IntPtr new_RegistrationEvent();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_RegistrationEvent")]
  public static extern void delete_RegistrationEvent(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationEvent_getSession2")]
  public static extern IntPtr RegistrationEvent_getSession2(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_RegistrationSession")]
  public static extern IntPtr new_RegistrationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_RegistrationSession")]
  public static extern void delete_RegistrationSession(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSession_Register")]
  public static extern bool RegistrationSession_Register(HandleRef jarg1, uint jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSession_UnRegister")]
  public static extern bool RegistrationSession_UnRegister(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipCallback")]
  public static extern IntPtr new_SipCallback();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipCallback")]
  public static extern void delete_SipCallback(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnRegistrationChanged")]
  public static extern int SipCallback_OnRegistrationChanged(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_OnRegistrationChangedSwigExplicitSipCallback")]
  public static extern int SipCallback_OnRegistrationChangedSwigExplicitSipCallback(HandleRef jarg1, HandleRef jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipCallback_director_connect")]
  public static extern void SipCallback_director_connect(HandleRef jarg1, SipCallback.SwigDelegateSipCallback_0 delegate0);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SafeObject")]
  public static extern IntPtr new_SafeObject();

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SafeObject")]
  public static extern void delete_SafeObject(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SafeObject_Lock")]
  public static extern int SafeObject_Lock(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SafeObject_UnLock")]
  public static extern int SafeObject_UnLock(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_new_SipStack")]
  public static extern IntPtr new_SipStack(HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [DllImport("tinyWRAP", EntryPoint="CSharp_delete_SipStack")]
  public static extern void delete_SipStack(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_Start")]
  public static extern bool SipStack_Start(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setProxyCSCF")]
  public static extern bool SipStack_setProxyCSCF(HandleRef jarg1, string jarg2, uint jarg3, string jarg4, string jarg5);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setLocalIP")]
  public static extern bool SipStack_setLocalIP(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_setLocalPort")]
  public static extern bool SipStack_setLocalPort(HandleRef jarg1, uint jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_addHeader")]
  public static extern bool SipStack_addHeader(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_removeHeader")]
  public static extern bool SipStack_removeHeader(HandleRef jarg1, string jarg2);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStack_Stop")]
  public static extern bool SipStack_Stop(HandleRef jarg1);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationEventUpcast")]
  public static extern IntPtr RegistrationEventUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_RegistrationSessionUpcast")]
  public static extern IntPtr RegistrationSessionUpcast(IntPtr objectRef);

  [DllImport("tinyWRAP", EntryPoint="CSharp_SipStackUpcast")]
  public static extern IntPtr SipStackUpcast(IntPtr objectRef);
}
