// Decompiled with JetBrains decompiler
// Type: ISAdQualityInitCallbackWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200008D")]
public class ISAdQualityInitCallbackWrapper : MonoBehaviour
{
  [Token(Token = "0x4000257")]
  [FieldOffset(Offset = "0x18")]
  private ISAdQualityInitCallback mCallback;
  [Token(Token = "0x4000258")]
  [FieldOffset(Offset = "0x20")]
  private ISAdQualityAndroidInitHandler adQualityAndroidInitHandler;

  [Token(Token = "0x17000030")]
  public ISAdQualityInitCallback AdQualityInitCallback
  {
    [Token(Token = "0x60004F4"), Address(RVA = "0x44B008C", Offset = "0x44B008C", VA = "0x44B008C")] set
    {
    }
    [Token(Token = "0x60004F5"), Address(RVA = "0x44B0094", Offset = "0x44B0094", VA = "0x44B0094")] get
    {
      return (ISAdQualityInitCallback) null;
    }
  }

  [Token(Token = "0x60004F6")]
  [Address(RVA = "0x44B009C", Offset = "0x44B009C", VA = "0x44B009C")]
  private void Awake()
  {
  }

  [Token(Token = "0x60004F7")]
  [Address(RVA = "0x44B022C", Offset = "0x44B022C", VA = "0x44B022C")]
  private void adQualitySdkInitSuccess()
  {
  }

  [Token(Token = "0x60004F8")]
  [Address(RVA = "0x44B02D4", Offset = "0x44B02D4", VA = "0x44B02D4")]
  private void onAdQualitySdkInitFailed(ISAdQualityInitError sdkInitError, string errorMsg)
  {
  }

  [Token(Token = "0x60004F9")]
  [Address(RVA = "0x44B0140", Offset = "0x44B0140", VA = "0x44B0140")]
  private void registerAdQualityAndroidInitEvents()
  {
  }

  [Token(Token = "0x60004FA")]
  [Address(RVA = "0x44B039C", Offset = "0x44B039C", VA = "0x44B039C")]
  public ISAdQualityInitCallbackWrapper()
  {
  }
}
