// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapChestUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001866")]
  public class FreeMapChestUIParam : FreeMapRewardUIParam
  {
    [Token(Token = "0x4006A48")]
    [FieldOffset(Offset = "0x48")]
    public Action OnOpen;
    [Token(Token = "0x4006A4C")]
    [FieldOffset(Offset = "0x60")]
    private FreeMapChestUIParam.ShowMapCondition showMapCondition;

    [Token(Token = "0x170015E6")]
    public override bool IsShowMap
    {
      [Token(Token = "0x6008A14"), Address(RVA = "0x45201B4", Offset = "0x45201B4", VA = "0x45201B4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015E7")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A15"), Address(RVA = "0x45202DC", Offset = "0x45202DC", VA = "0x45202DC", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x170015E8")]
    public ChestKeyData KeyData
    {
      [Token(Token = "0x6008A16"), Address(RVA = "0x45202F8", Offset = "0x45202F8", VA = "0x45202F8")] get
      {
        return (ChestKeyData) null;
      }
      [Token(Token = "0x6008A17"), Address(RVA = "0x4520300", Offset = "0x4520300", VA = "0x4520300")] private set
      {
      }
    }

    [Token(Token = "0x170015E9")]
    public int ChestID
    {
      [Token(Token = "0x6008A18"), Address(RVA = "0x4520308", Offset = "0x4520308", VA = "0x4520308")] private set
      {
      }
      [Token(Token = "0x6008A19"), Address(RVA = "0x4520310", Offset = "0x4520310", VA = "0x4520310")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015EA")]
    public int ChapterID
    {
      [Token(Token = "0x6008A1A"), Address(RVA = "0x4520318", Offset = "0x4520318", VA = "0x4520318")] private set
      {
      }
      [Token(Token = "0x6008A1B"), Address(RVA = "0x4520320", Offset = "0x4520320", VA = "0x4520320")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008A1C")]
    [Address(RVA = "0x45201E4", Offset = "0x45201E4", VA = "0x45201E4")]
    public bool IsOpened() => new bool();

    [Token(Token = "0x6008A1D")]
    [Address(RVA = "0x4520328", Offset = "0x4520328", VA = "0x4520328")]
    public FreeMapChestUIParam(
      int rewardLayoutID,
      int chestID,
      int chapterID,
      Vector3 iconOffset,
      int playerMoveLabel)
    {
    }

    [Token(Token = "0x6008A1E")]
    [Address(RVA = "0x4520514", Offset = "0x4520514", VA = "0x4520514")]
    private ChestKeyData CreateKeyData(int label) => (ChestKeyData) null;

    [Token(Token = "0x6008A1F")]
    [Address(RVA = "0x45205F0", Offset = "0x45205F0", VA = "0x45205F0", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A20")]
    [Address(RVA = "0x4520688", Offset = "0x4520688", VA = "0x4520688", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A21")]
    [Address(RVA = "0x4520690", Offset = "0x4520690", VA = "0x4520690", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A22")]
    [Address(RVA = "0x452071C", Offset = "0x452071C", VA = "0x452071C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A23")]
    [Address(RVA = "0x4520724", Offset = "0x4520724", VA = "0x4520724", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x2001867")]
    private class ShowMapCondition
    {
      [Token(Token = "0x4006A4D")]
      [FieldOffset(Offset = "0x10")]
      private int conditionAbility;

      [Token(Token = "0x6008A24")]
      [Address(RVA = "0x4520798", Offset = "0x4520798", VA = "0x4520798")]
      public void SetConditionAbility(int conditionAbility)
      {
      }

      [Token(Token = "0x6008A25")]
      [Address(RVA = "0x4520254", Offset = "0x4520254", VA = "0x4520254")]
      public bool IsComplete() => new bool();

      [Token(Token = "0x6008A26")]
      [Address(RVA = "0x452050C", Offset = "0x452050C", VA = "0x452050C")]
      public ShowMapCondition()
      {
      }
    }
  }
}
