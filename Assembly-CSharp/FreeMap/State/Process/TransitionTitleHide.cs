// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.TransitionTitleHide
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017F7")]
  public class TransitionTitleHide : FreeMapProcess
  {
    [Token(Token = "0x17001577")]
    private TransitionViewStateHandler.Type TransType
    {
      [Token(Token = "0x60087A0"), Address(RVA = "0x43D8298", Offset = "0x43D8298", VA = "0x43D8298")] get
      {
        return new TransitionViewStateHandler.Type();
      }
      [Token(Token = "0x60087A1"), Address(RVA = "0x43D82A0", Offset = "0x43D82A0", VA = "0x43D82A0")] set
      {
      }
    }

    [Token(Token = "0x17001578")]
    private bool IsWaitHide
    {
      [Token(Token = "0x60087A2"), Address(RVA = "0x43D82A8", Offset = "0x43D82A8", VA = "0x43D82A8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60087A3"), Address(RVA = "0x43D82B0", Offset = "0x43D82B0", VA = "0x43D82B0")] set
      {
      }
    }

    [Token(Token = "0x17001579")]
    private int ToAreaID
    {
      [Token(Token = "0x60087A4"), Address(RVA = "0x43D82BC", Offset = "0x43D82BC", VA = "0x43D82BC")] get
      {
        return new int();
      }
      [Token(Token = "0x60087A5"), Address(RVA = "0x43D82C4", Offset = "0x43D82C4", VA = "0x43D82C4")] set
      {
      }
    }

    [Token(Token = "0x60087A6")]
    [Address(RVA = "0x43D04F4", Offset = "0x43D04F4", VA = "0x43D04F4")]
    public TransitionTitleHide(
      FreeMapStateManager entity,
      int toAreaId,
      TransitionViewStateHandler.Type type,
      bool isWaitHide = false)
    {
    }

    [Token(Token = "0x60087A7")]
    [Address(RVA = "0x43D82CC", Offset = "0x43D82CC", VA = "0x43D82CC", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x60087A8")]
    [Address(RVA = "0x43D8514", Offset = "0x43D8514", VA = "0x43D8514")]
    private void OnFinishedFade()
    {
    }

    [Token(Token = "0x60087A9")]
    [Address(RVA = "0x43D8608", Offset = "0x43D8608", VA = "0x43D8608")]
    private void OnFinishedFastTravelFade()
    {
    }
  }
}
