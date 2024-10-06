// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapTransitionEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001875")]
  public class FreeMapTransitionEventUIParam : FreeMapUIParamBase, ITransitionEvent
  {
    [Token(Token = "0x17001612")]
    public int ToAreaID
    {
      [Token(Token = "0x6008AA4"), Address(RVA = "0x4522DE4", Offset = "0x4522DE4", VA = "0x4522DE4", Slot = "15")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AA5"), Address(RVA = "0x4522DEC", Offset = "0x4522DEC", VA = "0x4522DEC")] private set
      {
      }
    }

    [Token(Token = "0x17001613")]
    public string ToStartAnchor
    {
      [Token(Token = "0x6008AA6"), Address(RVA = "0x4522DF4", Offset = "0x4522DF4", VA = "0x4522DF4", Slot = "16")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008AA7"), Address(RVA = "0x4522DFC", Offset = "0x4522DFC", VA = "0x4522DFC")] private set
      {
      }
    }

    [Token(Token = "0x17001614")]
    public string Anchor
    {
      [Token(Token = "0x6008AA8"), Address(RVA = "0x4522E04", Offset = "0x4522E04", VA = "0x4522E04")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008AA9"), Address(RVA = "0x4522E0C", Offset = "0x4522E0C", VA = "0x4522E0C")] private set
      {
      }
    }

    [Token(Token = "0x17001615")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008AAA"), Address(RVA = "0x4522E14", Offset = "0x4522E14", VA = "0x4522E14", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008AAB")]
    [Address(RVA = "0x4522E1C", Offset = "0x4522E1C", VA = "0x4522E1C")]
    public FreeMapTransitionEventUIParam(
      Vector3 iconOffset,
      int toAreaID,
      string toStartAnchor,
      int fromAreaID,
      string anchor)
    {
    }

    [Token(Token = "0x6008AAC")]
    [Address(RVA = "0x4522EE0", Offset = "0x4522EE0", VA = "0x4522EE0", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008AAD")]
    [Address(RVA = "0x4522EE8", Offset = "0x4522EE8", VA = "0x4522EE8", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008AAE")]
    [Address(RVA = "0x4522FA4", Offset = "0x4522FA4", VA = "0x4522FA4", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008AAF")]
    [Address(RVA = "0x4522FAC", Offset = "0x4522FAC", VA = "0x4522FAC", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008AB0")]
    [Address(RVA = "0x4523010", Offset = "0x4523010", VA = "0x4523010", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
