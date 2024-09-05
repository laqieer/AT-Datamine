// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200135B")]
  [Serializable]
  public sealed class AbilityBoardRewardPatternData : IMasterDataEntity
  {
    [Token(Token = "0x4005AEF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AF0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005AF1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4005AF2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public ParameterTypeEnum parameterType;
    [Token(Token = "0x4005AF3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x4005AF4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int iconId;

    [Token(Token = "0x1700106F")]
    public int Key
    {
      [Token(Token = "0x6006D0C"), Address(RVA = "0x46F92FC", Offset = "0x46F92FC", VA = "0x46F92FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D0D")]
    [Address(RVA = "0x46F9304", Offset = "0x46F9304", VA = "0x46F9304", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D0E")]
    [Address(RVA = "0x46F9590", Offset = "0x46F9590", VA = "0x46F9590", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D0F")]
    [Address(RVA = "0x46F9654", Offset = "0x46F9654", VA = "0x46F9654")]
    public AbilityBoardRewardPatternData()
    {
    }
  }
}
