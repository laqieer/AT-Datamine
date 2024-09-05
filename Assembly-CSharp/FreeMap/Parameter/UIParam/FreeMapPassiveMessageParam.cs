// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapPassiveMessageParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x200186E")]
  public class FreeMapPassiveMessageParam : FreeMapUIParamBase
  {
    [Token(Token = "0x17001606")]
    public int MessageID
    {
      [Token(Token = "0x6008A74"), Address(RVA = "0x4521FEC", Offset = "0x4521FEC", VA = "0x4521FEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A75"), Address(RVA = "0x4521FF4", Offset = "0x4521FF4", VA = "0x4521FF4")] private set
      {
      }
    }

    [Token(Token = "0x17001607")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A76"), Address(RVA = "0x4521FFC", Offset = "0x4521FFC", VA = "0x4521FFC", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x17001608")]
    public override bool IsActionIcon
    {
      [Token(Token = "0x6008A77"), Address(RVA = "0x4522004", Offset = "0x4522004", VA = "0x4522004", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001609")]
    public override bool IsShowMap
    {
      [Token(Token = "0x6008A78"), Address(RVA = "0x452200C", Offset = "0x452200C", VA = "0x452200C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008A79")]
    [Address(RVA = "0x4522014", Offset = "0x4522014", VA = "0x4522014")]
    public FreeMapPassiveMessageParam(int objectID, Vector3 iconOffset, int messageID)
    {
    }

    [Token(Token = "0x6008A7A")]
    [Address(RVA = "0x452208C", Offset = "0x452208C", VA = "0x452208C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A7B")]
    [Address(RVA = "0x4522134", Offset = "0x4522134", VA = "0x4522134", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A7C")]
    [Address(RVA = "0x452213C", Offset = "0x452213C", VA = "0x452213C", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A7D")]
    [Address(RVA = "0x4522144", Offset = "0x4522144", VA = "0x4522144", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A7E")]
    [Address(RVA = "0x45221DC", Offset = "0x45221DC", VA = "0x45221DC", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
