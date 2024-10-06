// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialQuestStageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200114B")]
  [Serializable]
  public sealed class SpecialQuestStageData : IMasterDataEntity, IQuestStage
  {
    [Token(Token = "0x40053F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string questName;
    [Token(Token = "0x40053F6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string questSummary;
    [Token(Token = "0x40053F7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int consumeCost;
    [Token(Token = "0x40053F8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public BattleComsumeCostTypeEnum consumeCostType;
    [Token(Token = "0x40053F9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int limitWeaponProficiency;
    [Token(Token = "0x40053FA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int mapPosition;
    [Token(Token = "0x40053FB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int fieldImageResourceID;
    [Token(Token = "0x40053FC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int battleID;
    [Token(Token = "0x40053FD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public bool isAllowMultipleSameCharacters;

    [Token(Token = "0x17000EEC")]
    public int Key
    {
      [Token(Token = "0x600636B"), Address(RVA = "0x4AE85C4", Offset = "0x4AE85C4", VA = "0x4AE85C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600636C")]
    [Address(RVA = "0x4AE85CC", Offset = "0x4AE85CC", VA = "0x4AE85CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600636D")]
    [Address(RVA = "0x4AE89DC", Offset = "0x4AE89DC", VA = "0x4AE89DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EED")]
    public string QuestName
    {
      [Token(Token = "0x600636E"), Address(RVA = "0x4AE8AE8", Offset = "0x4AE8AE8", VA = "0x4AE8AE8", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EEE")]
    public string QuestSummary
    {
      [Token(Token = "0x600636F"), Address(RVA = "0x4AE8AF0", Offset = "0x4AE8AF0", VA = "0x4AE8AF0", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EEF")]
    public int ConsumeCost
    {
      [Token(Token = "0x6006370"), Address(RVA = "0x4AE8AF8", Offset = "0x4AE8AF8", VA = "0x4AE8AF8", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF0")]
    public BattleComsumeCostTypeEnum ConsumeCostType
    {
      [Token(Token = "0x6006371"), Address(RVA = "0x4AE8B00", Offset = "0x4AE8B00", VA = "0x4AE8B00", Slot = "10")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x17000EF1")]
    public int LimitWeaponProficiency
    {
      [Token(Token = "0x6006372"), Address(RVA = "0x4AE8B08", Offset = "0x4AE8B08", VA = "0x4AE8B08", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF2")]
    public int BattleId
    {
      [Token(Token = "0x6006373"), Address(RVA = "0x4AE8B10", Offset = "0x4AE8B10", VA = "0x4AE8B10", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF3")]
    public int GetApCost
    {
      [Token(Token = "0x6006374"), Address(RVA = "0x4AE8B18", Offset = "0x4AE8B18", VA = "0x4AE8B18", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF4")]
    public int FieldImageResourceID
    {
      [Token(Token = "0x6006375"), Address(RVA = "0x4AE8B34", Offset = "0x4AE8B34", VA = "0x4AE8B34", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006376")]
    [Address(RVA = "0x4AE8B3C", Offset = "0x4AE8B3C", VA = "0x4AE8B3C")]
    public SpecialQuestStageData()
    {
    }
  }
}
