// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestStageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200112B")]
  [Serializable]
  public sealed class QuestStageData : IMasterDataEntity, IQuestStage
  {
    [Token(Token = "0x4005397")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005398")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string questName;
    [Token(Token = "0x4005399")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string questSummary;
    [Token(Token = "0x400539A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int consumeCost;
    [Token(Token = "0x400539B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public BattleComsumeCostTypeEnum consumeCostType;
    [Token(Token = "0x400539C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int limitWeaponProficiency;
    [Token(Token = "0x400539D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int mapPosition;
    [Token(Token = "0x400539E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int fieldImageResourceID;
    [Token(Token = "0x400539F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int battleID;
    [Token(Token = "0x40053A0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public bool isAllowMultipleSameCharacters;

    [Token(Token = "0x17000EC7")]
    public int Key
    {
      [Token(Token = "0x60062CE"), Address(RVA = "0x4AE2D70", Offset = "0x4AE2D70", VA = "0x4AE2D70", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062CF")]
    [Address(RVA = "0x4AE2D78", Offset = "0x4AE2D78", VA = "0x4AE2D78", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062D0")]
    [Address(RVA = "0x4AE3188", Offset = "0x4AE3188", VA = "0x4AE3188", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EC8")]
    public string QuestName
    {
      [Token(Token = "0x60062D1"), Address(RVA = "0x4AE3294", Offset = "0x4AE3294", VA = "0x4AE3294", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EC9")]
    public string QuestSummary
    {
      [Token(Token = "0x60062D2"), Address(RVA = "0x4AE329C", Offset = "0x4AE329C", VA = "0x4AE329C", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000ECA")]
    public int ConsumeCost
    {
      [Token(Token = "0x60062D3"), Address(RVA = "0x4AE32A4", Offset = "0x4AE32A4", VA = "0x4AE32A4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ECB")]
    public BattleComsumeCostTypeEnum ConsumeCostType
    {
      [Token(Token = "0x60062D4"), Address(RVA = "0x4AE32AC", Offset = "0x4AE32AC", VA = "0x4AE32AC", Slot = "10")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x17000ECC")]
    public int LimitWeaponProficiency
    {
      [Token(Token = "0x60062D5"), Address(RVA = "0x4AE32B4", Offset = "0x4AE32B4", VA = "0x4AE32B4", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ECD")]
    public int BattleId
    {
      [Token(Token = "0x60062D6"), Address(RVA = "0x4AE32BC", Offset = "0x4AE32BC", VA = "0x4AE32BC", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ECE")]
    public int GetApCost
    {
      [Token(Token = "0x60062D7"), Address(RVA = "0x4AE32C4", Offset = "0x4AE32C4", VA = "0x4AE32C4", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ECF")]
    public int FieldImageResourceID
    {
      [Token(Token = "0x60062D8"), Address(RVA = "0x4AE32FC", Offset = "0x4AE32FC", VA = "0x4AE32FC", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062D9")]
    [Address(RVA = "0x4AE32E0", Offset = "0x4AE32E0", VA = "0x4AE32E0")]
    public int GetAp() => new int();

    [Token(Token = "0x60062DA")]
    [Address(RVA = "0x4AE3304", Offset = "0x4AE3304", VA = "0x4AE3304")]
    public QuestStageData()
    {
    }
  }
}
