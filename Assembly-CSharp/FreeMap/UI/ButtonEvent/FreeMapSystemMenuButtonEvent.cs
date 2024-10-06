// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapSystemMenuButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001711")]
  public class FreeMapSystemMenuButtonEvent : 
    FreeMapIconButtonEventBase<FreeMapSystemMenuEventUIParam>
  {
    [Token(Token = "0x40066DE")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapIconEventAdvStage adv;

    [Token(Token = "0x6008285")]
    [Address(RVA = "0x4200DBC", Offset = "0x4200DBC", VA = "0x4200DBC")]
    public FreeMapSystemMenuButtonEvent(
      FreeMapSystemMenuEventUIParam advParam,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008286")]
    [Address(RVA = "0x4200E1C", Offset = "0x4200E1C", VA = "0x4200E1C", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008287")]
    [Address(RVA = "0x4200F14", Offset = "0x4200F14", VA = "0x4200F14", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008288")]
    [Address(RVA = "0x4200F34", Offset = "0x4200F34", VA = "0x4200F34", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
