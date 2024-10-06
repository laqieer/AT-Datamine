// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001096")]
  [Serializable]
  public sealed class LoginBonusData : IMasterDataEntity
  {
    [Token(Token = "0x40051DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051DB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051DC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public LoginBonusTypeEnum loginBonusType;
    [Token(Token = "0x40051DD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool isLoop;
    [Token(Token = "0x40051DE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40051DF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x40051E0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int periodDays;
    [Token(Token = "0x40051E1")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int spriteId;
    [Token(Token = "0x40051E2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string voiceBankId;
    [Token(Token = "0x40051E3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string voiceId;
    [Token(Token = "0x40051E4")]
    [FieldOffset(Offset = "0x50")]
    public bool hasEndAt;

    [Token(Token = "0x17000E53")]
    public int Key
    {
      [Token(Token = "0x6006014"), Address(RVA = "0x28D4398", Offset = "0x28D4398", VA = "0x28D4398", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006015")]
    [Address(RVA = "0x28D43A0", Offset = "0x28D43A0", VA = "0x28D43A0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006016")]
    [Address(RVA = "0x28D47B0", Offset = "0x28D47B0", VA = "0x28D47B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006017")]
    [Address(RVA = "0x28D4918", Offset = "0x28D4918", VA = "0x28D4918")]
    public LoginBonusData()
    {
    }
  }
}
