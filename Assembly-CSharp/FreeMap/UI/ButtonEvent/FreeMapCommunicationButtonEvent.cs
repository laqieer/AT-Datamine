// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapCommunicationButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016DF")]
  public class FreeMapCommunicationButtonEvent : 
    FreeMapIconButtonEventBase<FreeMapCommunicationEventUIParam>
  {
    [Token(Token = "0x4006635")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapIconEventCommunicationAdvStage executionAdv;

    [Token(Token = "0x600813F")]
    [Address(RVA = "0x41FA2D0", Offset = "0x41FA2D0", VA = "0x41FA2D0")]
    public FreeMapCommunicationButtonEvent(
      FreeMapCommunicationEventUIParam eventUIParam,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008140")]
    [Address(RVA = "0x41FA330", Offset = "0x41FA330", VA = "0x41FA330", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008141")]
    [Address(RVA = "0x41FA4D0", Offset = "0x41FA4D0", VA = "0x41FA4D0", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008142")]
    [Address(RVA = "0x41FA4F0", Offset = "0x41FA4F0", VA = "0x41FA4F0", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008143")]
    [Address(RVA = "0x41FA580", Offset = "0x41FA580", VA = "0x41FA580")]
    private IEnumerator NormalCommu() => (IEnumerator) null;

    [Token(Token = "0x6008144")]
    [Address(RVA = "0x41FA610", Offset = "0x41FA610", VA = "0x41FA610")]
    private IEnumerator RankupCommu() => (IEnumerator) null;

    [Token(Token = "0x6008145")]
    [Address(RVA = "0x41FA6A0", Offset = "0x41FA6A0", VA = "0x41FA6A0")]
    private IEnumerator OnConnect(APIStoryMainquestCommunicationRequest request, bool isRankup)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008146")]
    [Address(RVA = "0x41FA730", Offset = "0x41FA730", VA = "0x41FA730")]
    private IEnumerator OnCancel() => (IEnumerator) null;
  }
}
