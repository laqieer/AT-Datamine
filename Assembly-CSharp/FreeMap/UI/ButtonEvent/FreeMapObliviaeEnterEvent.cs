// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapObliviaeEnterEvent
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
  [Token(Token = "0x2001709")]
  public class FreeMapObliviaeEnterEvent : FreeMapIconButtonEventBase<FreeMapObliviaeEnterUIParam>
  {
    [Token(Token = "0x40066CA")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapObliviaeEnterUIParam obliviae;
    [Token(Token = "0x40066CB")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapIconEventAdvStage adv;

    [Token(Token = "0x1700145E")]
    private bool hasAdv
    {
      [Token(Token = "0x6008260"), Address(RVA = "0x41FFA98", Offset = "0x41FFA98", VA = "0x41FFA98")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008261")]
    [Address(RVA = "0x41FFAC0", Offset = "0x41FFAC0", VA = "0x41FFAC0")]
    public FreeMapObliviaeEnterEvent(
      FreeMapObliviaeEnterUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008262")]
    [Address(RVA = "0x41FFB28", Offset = "0x41FFB28", VA = "0x41FFB28", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008263")]
    [Address(RVA = "0x41FFC48", Offset = "0x41FFC48", VA = "0x41FFC48", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008264")]
    [Address(RVA = "0x41FFC68", Offset = "0x41FFC68", VA = "0x41FFC68", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
