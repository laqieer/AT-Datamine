// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidStageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200111B")]
  [Serializable]
  public sealed class GuildRaidStageData : IMasterDataEntity, IQuestStage
  {
    [Token(Token = "0x4005347")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005348")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string questName;
    [Token(Token = "0x4005349")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string questSummary;
    [Token(Token = "0x400534A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int limitWeaponProficiency;
    [Token(Token = "0x400534B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int mapPosition;
    [Token(Token = "0x400534C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int fieldImageResourceID;
    [Token(Token = "0x400534D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int battleID;

    [Token(Token = "0x17000EAE")]
    public int Key
    {
      [Token(Token = "0x6006274"), Address(RVA = "0x4ADF51C", Offset = "0x4ADF51C", VA = "0x4ADF51C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006275")]
    [Address(RVA = "0x4ADF524", Offset = "0x4ADF524", VA = "0x4ADF524", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006276")]
    [Address(RVA = "0x4ADF810", Offset = "0x4ADF810", VA = "0x4ADF810", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EAF")]
    public string QuestName
    {
      [Token(Token = "0x6006277"), Address(RVA = "0x4ADF8EC", Offset = "0x4ADF8EC", VA = "0x4ADF8EC", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EB0")]
    public string QuestSummary
    {
      [Token(Token = "0x6006278"), Address(RVA = "0x4ADF8F4", Offset = "0x4ADF8F4", VA = "0x4ADF8F4", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EB1")]
    public int ConsumeCost
    {
      [Token(Token = "0x6006279"), Address(RVA = "0x4ADF8FC", Offset = "0x4ADF8FC", VA = "0x4ADF8FC", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EB2")]
    public BattleComsumeCostTypeEnum ConsumeCostType
    {
      [Token(Token = "0x600627A"), Address(RVA = "0x4ADF904", Offset = "0x4ADF904", VA = "0x4ADF904", Slot = "10")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x17000EB3")]
    public int LimitWeaponProficiency
    {
      [Token(Token = "0x600627B"), Address(RVA = "0x4ADF90C", Offset = "0x4ADF90C", VA = "0x4ADF90C", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EB4")]
    public int BattleId
    {
      [Token(Token = "0x600627C"), Address(RVA = "0x4ADF914", Offset = "0x4ADF914", VA = "0x4ADF914", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EB5")]
    public int GetApCost
    {
      [Token(Token = "0x600627D"), Address(RVA = "0x4ADF91C", Offset = "0x4ADF91C", VA = "0x4ADF91C", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EB6")]
    public int FieldImageResourceID
    {
      [Token(Token = "0x600627E"), Address(RVA = "0x4ADF924", Offset = "0x4ADF924", VA = "0x4ADF924", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600627F")]
    [Address(RVA = "0x4ADF92C", Offset = "0x4ADF92C", VA = "0x4ADF92C")]
    public GuildRaidStageData()
    {
    }
  }
}
