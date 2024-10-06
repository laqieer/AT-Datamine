// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.Reading
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Facility.Types
{
  [Token(Token = "0x2001764")]
  public class Reading : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067C4")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;

    [Token(Token = "0x6008472")]
    [Address(RVA = "0x4066290", Offset = "0x4066290", VA = "0x4066290")]
    public Reading(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008473")]
    [Address(RVA = "0x4066298", Offset = "0x4066298", VA = "0x4066298", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008474")]
    [Address(RVA = "0x40662EC", Offset = "0x40662EC", VA = "0x40662EC", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008475")]
    [Address(RVA = "0x406630C", Offset = "0x406630C", VA = "0x406630C", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008476")]
    [Address(RVA = "0x406639C", Offset = "0x406639C", VA = "0x406639C")]
    private IEnumerator Play(int advID) => (IEnumerator) null;

    [Token(Token = "0x6008477")]
    [Address(RVA = "0x406643C", Offset = "0x406643C", VA = "0x406643C")]
    private IEnumerator ExecuteAPI(int chapterItemBookID) => (IEnumerator) null;
  }
}
