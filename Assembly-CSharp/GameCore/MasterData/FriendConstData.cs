// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FriendConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB8")]
  [Serializable]
  public sealed class FriendConstData : IMasterDataEntity
  {
    [Token(Token = "0x4004F14")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F15")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int friendMaxAdjustValue1;
    [Token(Token = "0x4004F16")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int friendMaxAdjustValue2;
    [Token(Token = "0x4004F17")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int friendMaxLimit;
    [Token(Token = "0x4004F18")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int receivedFriendApplicationMaxLimit;
    [Token(Token = "0x4004F19")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int friendGiftMedalId;

    [Token(Token = "0x17000D9B")]
    public int Key
    {
      [Token(Token = "0x6005C3B"), Address(RVA = "0x278A3C8", Offset = "0x278A3C8", VA = "0x278A3C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C3C")]
    [Address(RVA = "0x278A3D0", Offset = "0x278A3D0", VA = "0x278A3D0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C3D")]
    [Address(RVA = "0x278A65C", Offset = "0x278A65C", VA = "0x278A65C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C3E")]
    [Address(RVA = "0x278A720", Offset = "0x278A720", VA = "0x278A720")]
    public FriendConstData()
    {
    }
  }
}
