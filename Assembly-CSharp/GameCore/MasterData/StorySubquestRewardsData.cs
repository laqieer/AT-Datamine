// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001311")]
  [Serializable]
  public sealed class StorySubquestRewardsData : IMasterDataEntity
  {
    [Token(Token = "0x4005A2A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A2B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int subquestID;
    [Token(Token = "0x4005A2C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int beginClearCount;
    [Token(Token = "0x4005A2D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int endClearCount;
    [Token(Token = "0x4005A2E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardSetLabel;

    [Token(Token = "0x17001047")]
    public int Key
    {
      [Token(Token = "0x6006BB4"), Address(RVA = "0x48E47C8", Offset = "0x48E47C8", VA = "0x48E47C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BB5")]
    [Address(RVA = "0x48E47D0", Offset = "0x48E47D0", VA = "0x48E47D0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BB6")]
    [Address(RVA = "0x48E49FC", Offset = "0x48E49FC", VA = "0x48E49FC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006BB7")]
    [Address(RVA = "0x48E4AB0", Offset = "0x48E4AB0", VA = "0x48E4AB0")]
    public StorySubquestRewardsData()
    {
    }
  }
}
