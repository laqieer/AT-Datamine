// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ItemPossessionLimitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105E")]
  [Serializable]
  public sealed class ItemPossessionLimitData : IMasterDataEntity, IPossessionLimitData
  {
    [Token(Token = "0x4005111")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005112")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int itemTypeID;
    [Token(Token = "0x4005113")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int itemID;
    [Token(Token = "0x4005114")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int showLimitNumber;
    [Token(Token = "0x4005115")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int possessionLimitNumber;
    [Token(Token = "0x4005116")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool sendPresent;

    [Token(Token = "0x17000E12")]
    public int Key
    {
      [Token(Token = "0x6005F05"), Address(RVA = "0x28CA220", Offset = "0x28CA220", VA = "0x28CA220", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F06")]
    [Address(RVA = "0x28CA228", Offset = "0x28CA228", VA = "0x28CA228", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F07")]
    [Address(RVA = "0x28CA4B8", Offset = "0x28CA4B8", VA = "0x28CA4B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E13")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x6005F08"), Address(RVA = "0x28CA57C", Offset = "0x28CA57C", VA = "0x28CA57C", Slot = "7")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17000E14")]
    public int ShowLimitNumber
    {
      [Token(Token = "0x6005F09"), Address(RVA = "0x28CA584", Offset = "0x28CA584", VA = "0x28CA584", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E15")]
    public int PossessionLimitNumber
    {
      [Token(Token = "0x6005F0A"), Address(RVA = "0x28CA58C", Offset = "0x28CA58C", VA = "0x28CA58C", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E16")]
    public bool SendPresent
    {
      [Token(Token = "0x6005F0B"), Address(RVA = "0x28CA594", Offset = "0x28CA594", VA = "0x28CA594", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005F0C")]
    [Address(RVA = "0x28CA59C", Offset = "0x28CA59C", VA = "0x28CA59C")]
    public ItemPossessionLimitData()
    {
    }
  }
}
