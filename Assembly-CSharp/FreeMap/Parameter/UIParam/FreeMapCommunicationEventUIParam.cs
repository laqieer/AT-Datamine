// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapCommunicationEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001868")]
  public class FreeMapCommunicationEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x4006A51")]
    [FieldOffset(Offset = "0x5C")]
    private ActionIconTypeEnum actionIconType;

    [Token(Token = "0x170015EB")]
    public int PlayCommunicationID
    {
      [Token(Token = "0x6008A27"), Address(RVA = "0x45207A0", Offset = "0x45207A0", VA = "0x45207A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A28"), Address(RVA = "0x45207A8", Offset = "0x45207A8", VA = "0x45207A8")] private set
      {
      }
    }

    [Token(Token = "0x170015EC")]
    public Communication CommunicationData
    {
      [Token(Token = "0x6008A29"), Address(RVA = "0x45207B0", Offset = "0x45207B0", VA = "0x45207B0")] get
      {
        return (Communication) null;
      }
      [Token(Token = "0x6008A2A"), Address(RVA = "0x45207B8", Offset = "0x45207B8", VA = "0x45207B8")] private set
      {
      }
    }

    [Token(Token = "0x170015ED")]
    public int LocationID
    {
      [Token(Token = "0x6008A2B"), Address(RVA = "0x45207C0", Offset = "0x45207C0", VA = "0x45207C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A2C"), Address(RVA = "0x45207C8", Offset = "0x45207C8", VA = "0x45207C8")] private set
      {
      }
    }

    [Token(Token = "0x170015EE")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A2D"), Address(RVA = "0x45207D0", Offset = "0x45207D0", VA = "0x45207D0", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x170015EF")]
    public override string SpriteAssetName
    {
      [Token(Token = "0x6008A2E"), Address(RVA = "0x45207D8", Offset = "0x45207D8", VA = "0x45207D8", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015F0")]
    public string MapSpriteAssetName
    {
      [Token(Token = "0x6008A2F"), Address(RVA = "0x4520838", Offset = "0x4520838", VA = "0x4520838")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6008A30")]
    [Address(RVA = "0x45208D8", Offset = "0x45208D8", VA = "0x45208D8")]
    public FreeMapCommunicationEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int communicationID,
      int cameraMoveID,
      int playerMoveID,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008A31")]
    [Address(RVA = "0x4520A84", Offset = "0x4520A84", VA = "0x4520A84", Slot = "14")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6008A32")]
    [Address(RVA = "0x4520A9C", Offset = "0x4520A9C", VA = "0x4520A9C", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A33")]
    [Address(RVA = "0x4520AA4", Offset = "0x4520AA4", VA = "0x4520AA4", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A34")]
    [Address(RVA = "0x4520B6C", Offset = "0x4520B6C", VA = "0x4520B6C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A35")]
    [Address(RVA = "0x4520B74", Offset = "0x4520B74", VA = "0x4520B74", Slot = "10")]
    public override string GetTitle() => (string) null;

    [Token(Token = "0x6008A36")]
    [Address(RVA = "0x4520B90", Offset = "0x4520B90", VA = "0x4520B90", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A37")]
    [Address(RVA = "0x4520BF4", Offset = "0x4520BF4", VA = "0x4520BF4", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x6008A38")]
    [Address(RVA = "0x45209F4", Offset = "0x45209F4", VA = "0x45209F4")]
    private ActionIconTypeEnum GetActionIconType() => new ActionIconTypeEnum();
  }
}
