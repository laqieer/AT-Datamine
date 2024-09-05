﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAF")]
  [Serializable]
  public sealed class AdvExpandedLockData : IMasterDataEntity
  {
    [Token(Token = "0x4004192")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004193")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004194")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool fallbackOpenFlag;
    [Token(Token = "0x4004195")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int expandedlockGroupId;

    [Token(Token = "0x17000BF8")]
    public int Key
    {
      [Token(Token = "0x60053C1"), Address(RVA = "0x3A9D2B0", Offset = "0x3A9D2B0", VA = "0x3A9D2B0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053C2")]
    [Address(RVA = "0x3A9D2B8", Offset = "0x3A9D2B8", VA = "0x3A9D2B8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053C3")]
    [Address(RVA = "0x3A9D488", Offset = "0x3A9D488", VA = "0x3A9D488", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053C4")]
    [Address(RVA = "0x3A9D530", Offset = "0x3A9D530", VA = "0x3A9D530")]
    public AdvExpandedLockData()
    {
    }
  }
}
