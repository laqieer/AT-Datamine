﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001353")]
  [Serializable]
  public sealed class AbilityBoardNodeData : IMasterDataEntity
  {
    [Token(Token = "0x4005ADB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005ADC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x4005ADD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int consumeGroupTypeId;

    [Token(Token = "0x1700106C")]
    public int Key
    {
      [Token(Token = "0x6006CE6"), Address(RVA = "0x46F7AE8", Offset = "0x46F7AE8", VA = "0x46F7AE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CE7")]
    [Address(RVA = "0x46F7AF0", Offset = "0x46F7AF0", VA = "0x46F7AF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CE8")]
    [Address(RVA = "0x46F7C5C", Offset = "0x46F7C5C", VA = "0x46F7C5C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CE9")]
    [Address(RVA = "0x46F7CF0", Offset = "0x46F7CF0", VA = "0x46F7CF0")]
    public AbilityBoardNodeData()
    {
    }
  }
}
