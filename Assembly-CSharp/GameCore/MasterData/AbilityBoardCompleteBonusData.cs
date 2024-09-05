// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCompleteBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200132F")]
  [Serializable]
  public sealed class AbilityBoardCompleteBonusData : IMasterDataEntity
  {
    [Token(Token = "0x4005A88")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A89")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardTypeID;
    [Token(Token = "0x4005A8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005A8B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x1700105D")]
    public int Key
    {
      [Token(Token = "0x6006C41"), Address(RVA = "0x46F1CBC", Offset = "0x46F1CBC", VA = "0x46F1CBC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C42")]
    [Address(RVA = "0x46F1CC4", Offset = "0x46F1CC4", VA = "0x46F1CC4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C43")]
    [Address(RVA = "0x46F1E90", Offset = "0x46F1E90", VA = "0x46F1E90", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C44")]
    [Address(RVA = "0x46F1F34", Offset = "0x46F1F34", VA = "0x46F1F34")]
    public AbilityBoardCompleteBonusData()
    {
    }
  }
}
