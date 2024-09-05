// Decompiled with JetBrains decompiler
// Type: ExampleGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using com.adjust.sdk;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200000D")]
public class ExampleGUI : MonoBehaviour
{
  [Token(Token = "0x4000016")]
  [FieldOffset(Offset = "0x18")]
  private int numberOfButtons;
  [Token(Token = "0x4000017")]
  [FieldOffset(Offset = "0x1C")]
  private bool isEnabled;
  [Token(Token = "0x4000018")]
  [FieldOffset(Offset = "0x1D")]
  private bool showPopUp;
  [Token(Token = "0x4000019")]
  [FieldOffset(Offset = "0x20")]
  private string txtSetEnabled;
  [Token(Token = "0x400001A")]
  [FieldOffset(Offset = "0x28")]
  private string txtManualLaunch;
  [Token(Token = "0x400001B")]
  [FieldOffset(Offset = "0x30")]
  private string txtSetOfflineMode;

  [Token(Token = "0x600003C")]
  [Address(RVA = "0x203C434", Offset = "0x203C434", VA = "0x203C434")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x600003D")]
  [Address(RVA = "0x203CFDC", Offset = "0x203CFDC", VA = "0x203CFDC")]
  private void ShowGUI(int windowID)
  {
  }

  [Token(Token = "0x600003E")]
  [Address(RVA = "0x203D160", Offset = "0x203D160", VA = "0x203D160")]
  public void HandleGooglePlayId(string adId)
  {
  }

  [Token(Token = "0x600003F")]
  [Address(RVA = "0x203D1EC", Offset = "0x203D1EC", VA = "0x203D1EC")]
  public void AttributionChangedCallback(AdjustAttribution attributionData)
  {
  }

  [Token(Token = "0x6000040")]
  [Address(RVA = "0x203D4CC", Offset = "0x203D4CC", VA = "0x203D4CC")]
  public void EventSuccessCallback(AdjustEventSuccess eventSuccessData)
  {
  }

  [Token(Token = "0x6000041")]
  [Address(RVA = "0x203D728", Offset = "0x203D728", VA = "0x203D728")]
  public void EventFailureCallback(AdjustEventFailure eventFailureData)
  {
  }

  [Token(Token = "0x6000042")]
  [Address(RVA = "0x203DA0C", Offset = "0x203DA0C", VA = "0x203DA0C")]
  public void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData)
  {
  }

  [Token(Token = "0x6000043")]
  [Address(RVA = "0x203DBD0", Offset = "0x203DBD0", VA = "0x203DBD0")]
  public void SessionFailureCallback(AdjustSessionFailure sessionFailureData)
  {
  }

  [Token(Token = "0x6000044")]
  [Address(RVA = "0x203DE1C", Offset = "0x203DE1C", VA = "0x203DE1C")]
  private void DeferredDeeplinkCallback(string deeplinkURL)
  {
  }

  [Token(Token = "0x6000045")]
  [Address(RVA = "0x203DF00", Offset = "0x203DF00", VA = "0x203DF00")]
  public ExampleGUI()
  {
  }
}
