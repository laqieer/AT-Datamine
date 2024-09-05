// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.TestFreeMapIconEventCommunicationAdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Loader;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001703")]
  public class TestFreeMapIconEventCommunicationAdvStage : FreeMapIconEventCommunicationAdvStage
  {
    [Token(Token = "0x6008246")]
    [Address(RVA = "0x41FF1CC", Offset = "0x41FF1CC", VA = "0x41FF1CC")]
    public TestFreeMapIconEventCommunicationAdvStage(
      int advId,
      IFreeMapAdvControl advControllMethod,
      int commuId,
      int locationID,
      IFreeMapTemporarySceneLoader sceneHandler)
    {
    }

    [Token(Token = "0x6008247")]
    [Address(RVA = "0x41FF228", Offset = "0x41FF228", VA = "0x41FF228", Slot = "7")]
    public override IEnumerator SequenceAfterAdv() => (IEnumerator) null;
  }
}
