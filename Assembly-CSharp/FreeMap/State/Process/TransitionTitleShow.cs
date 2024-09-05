// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.TransitionTitleShow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017F9")]
  public class TransitionTitleShow : FreeMapProcess
  {
    [Token(Token = "0x1700157A")]
    private TransitionViewStateHandler.Type TransType
    {
      [Token(Token = "0x60087AD"), Address(RVA = "0x43D8784", Offset = "0x43D8784", VA = "0x43D8784")] get
      {
        return new TransitionViewStateHandler.Type();
      }
      [Token(Token = "0x60087AE"), Address(RVA = "0x43D878C", Offset = "0x43D878C", VA = "0x43D878C")] set
      {
      }
    }

    [Token(Token = "0x1700157B")]
    private int ToAreaID
    {
      [Token(Token = "0x60087AF"), Address(RVA = "0x43D8794", Offset = "0x43D8794", VA = "0x43D8794")] get
      {
        return new int();
      }
      [Token(Token = "0x60087B0"), Address(RVA = "0x43D879C", Offset = "0x43D879C", VA = "0x43D879C")] set
      {
      }
    }

    [Token(Token = "0x60087B1")]
    [Address(RVA = "0x43D0480", Offset = "0x43D0480", VA = "0x43D0480")]
    public TransitionTitleShow(
      FreeMapStateManager entity,
      int toAreaId,
      TransitionViewStateHandler.Type type)
    {
    }

    [Token(Token = "0x60087B2")]
    [Address(RVA = "0x43D87A4", Offset = "0x43D87A4", VA = "0x43D87A4", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x60087B3")]
    [Address(RVA = "0x43D8884", Offset = "0x43D8884", VA = "0x43D8884")]
    private void OnFinishedFade()
    {
    }
  }
}
