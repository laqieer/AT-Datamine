// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapFastTravelPointUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x200186B")]
  public class FreeMapFastTravelPointUIParam : FreeMapUIParamBase, ITransitionEvent
  {
    [Token(Token = "0x4006A5C")]
    [FieldOffset(Offset = "0x60")]
    private string title;

    [Token(Token = "0x170015F9")]
    public override bool IsActionIcon
    {
      [Token(Token = "0x6008A50"), Address(RVA = "0x45213A0", Offset = "0x45213A0", VA = "0x45213A0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015FA")]
    public override bool IsShowMap
    {
      [Token(Token = "0x6008A51"), Address(RVA = "0x45213A8", Offset = "0x45213A8", VA = "0x45213A8", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015FB")]
    public int ToAreaID
    {
      [Token(Token = "0x6008A52"), Address(RVA = "0x4521400", Offset = "0x4521400", VA = "0x4521400", Slot = "15")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A53"), Address(RVA = "0x4521408", Offset = "0x4521408", VA = "0x4521408")] private set
      {
      }
    }

    [Token(Token = "0x170015FC")]
    public string ToStartAnchor
    {
      [Token(Token = "0x6008A54"), Address(RVA = "0x4521410", Offset = "0x4521410", VA = "0x4521410", Slot = "16")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015FD")]
    public string Anchor
    {
      [Token(Token = "0x6008A55"), Address(RVA = "0x4521418", Offset = "0x4521418", VA = "0x4521418")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A56"), Address(RVA = "0x4521420", Offset = "0x4521420", VA = "0x4521420")] private set
      {
      }
    }

    [Token(Token = "0x170015FE")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A57"), Address(RVA = "0x4521428", Offset = "0x4521428", VA = "0x4521428", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008A58")]
    [Address(RVA = "0x4521430", Offset = "0x4521430", VA = "0x4521430")]
    public FreeMapFastTravelPointUIParam(StoryFreeActionAreaFastTravelData data)
    {
    }

    [Token(Token = "0x6008A59")]
    [Address(RVA = "0x4521530", Offset = "0x4521530", VA = "0x4521530")]
    public FreeMapFastTravelPointUIParam(int toAreaID, string anchor, string title)
    {
    }

    [Token(Token = "0x6008A5A")]
    [Address(RVA = "0x4521624", Offset = "0x4521624", VA = "0x4521624", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A5B")]
    [Address(RVA = "0x452162C", Offset = "0x452162C", VA = "0x452162C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A5C")]
    [Address(RVA = "0x45216E8", Offset = "0x45216E8", VA = "0x45216E8", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A5D")]
    [Address(RVA = "0x45216F0", Offset = "0x45216F0", VA = "0x45216F0", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A5E")]
    [Address(RVA = "0x4521754", Offset = "0x4521754", VA = "0x4521754", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x6008A5F")]
    [Address(RVA = "0x452175C", Offset = "0x452175C", VA = "0x452175C", Slot = "10")]
    public override string GetTitle() => (string) null;
  }
}
