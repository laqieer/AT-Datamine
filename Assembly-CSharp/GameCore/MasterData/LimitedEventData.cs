// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitedEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001125")]
  [Serializable]
  public sealed class LimitedEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005366")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005367")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005368")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x4005369")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x400536A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x400536B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int exchangeId;
    [Token(Token = "0x400536C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int missionId;
    [Token(Token = "0x400536D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int shopId;
    [Token(Token = "0x400536E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public BattleComsumeCostTypeEnum consumeCostType;
    [Token(Token = "0x400536F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int consumeCostItemId;
    [Token(Token = "0x4005370")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public bool replenishmentFlag;
    [Token(Token = "0x4005371")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int replenishmentCount;
    [Token(Token = "0x4005372")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int replenishmentMax;
    [Token(Token = "0x4005373")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int LimitedWeaponProficiency;
    [Token(Token = "0x4005374")]
    [FieldOffset(Offset = "0x0")]
    private static readonly DateTime DefaultStartAt;
    [Token(Token = "0x4005375")]
    [FieldOffset(Offset = "0x8")]
    private static readonly DateTime DefaultEndAt;

    [Token(Token = "0x17000EC1")]
    public int Key
    {
      [Token(Token = "0x60062AF"), Address(RVA = "0x4AE0E94", Offset = "0x4AE0E94", VA = "0x4AE0E94", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062B0")]
    [Address(RVA = "0x4AE0E9C", Offset = "0x4AE0E9C", VA = "0x4AE0E9C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062B1")]
    [Address(RVA = "0x4AE142C", Offset = "0x4AE142C", VA = "0x4AE142C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EC2")]
    public bool IsDefaultStartAt
    {
      [Token(Token = "0x60062B2"), Address(RVA = "0x4AE15C8", Offset = "0x4AE15C8", VA = "0x4AE15C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC3")]
    public bool IsDefaultEndAt
    {
      [Token(Token = "0x60062B3"), Address(RVA = "0x4AE165C", Offset = "0x4AE165C", VA = "0x4AE165C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60062B4")]
    [Address(RVA = "0x4AE16F0", Offset = "0x4AE16F0", VA = "0x4AE16F0")]
    public LimitedEventData()
    {
    }

    [Token(Token = "0x60062B5")]
    [Address(RVA = "0x4AE16F8", Offset = "0x4AE16F8", VA = "0x4AE16F8")]
    static LimitedEventData()
    {
    }
  }
}
