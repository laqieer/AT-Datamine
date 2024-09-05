﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionProgressRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A0")]
  [Serializable]
  public sealed class MissionProgressRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40051F7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051F8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x40051F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051FA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int progressPoint;
    [Token(Token = "0x40051FB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public MissionResetTypeEnum resetTypeId;

    [Token(Token = "0x17000E58")]
    public int Key
    {
      [Token(Token = "0x6006043"), Address(RVA = "0x28D5C4C", Offset = "0x28D5C4C", VA = "0x28D5C4C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006044")]
    [Address(RVA = "0x28D5C54", Offset = "0x28D5C54", VA = "0x28D5C54", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006045")]
    [Address(RVA = "0x28D5E80", Offset = "0x28D5E80", VA = "0x28D5E80", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006046")]
    [Address(RVA = "0x28D5F38", Offset = "0x28D5F38", VA = "0x28D5F38")]
    public MissionProgressRewardData()
    {
    }
  }
}
