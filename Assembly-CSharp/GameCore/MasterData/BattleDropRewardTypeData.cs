﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropRewardTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EC2")]
  [Serializable]
  public sealed class BattleDropRewardTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40047DC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40047DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D42")]
    public int Key
    {
      [Token(Token = "0x6005935"), Address(RVA = "0x3C30D48", Offset = "0x3C30D48", VA = "0x3C30D48", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005936")]
    [Address(RVA = "0x3C30D50", Offset = "0x3C30D50", VA = "0x3C30D50", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005937")]
    [Address(RVA = "0x3C30E5C", Offset = "0x3C30E5C", VA = "0x3C30E5C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005938")]
    [Address(RVA = "0x3C30EE4", Offset = "0x3C30EE4", VA = "0x3C30EE4")]
    public BattleDropRewardTypeData()
    {
    }
  }
}
