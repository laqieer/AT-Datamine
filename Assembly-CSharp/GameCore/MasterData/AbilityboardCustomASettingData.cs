// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomASettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001341")]
  [Serializable]
  public sealed class AbilityboardCustomASettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005AB2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AB3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int customAId;
    [Token(Token = "0x4005AB4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int lotteryWeight;
    [Token(Token = "0x4005AB5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int lotteryWeitghtByCost;
    [Token(Token = "0x4005AB6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int frameGroupId;
    [Token(Token = "0x4005AB7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int duplicateBonusValue;
    [Token(Token = "0x4005AB8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int allDuplicateBonusValue;

    [Token(Token = "0x17001064")]
    public int Key
    {
      [Token(Token = "0x6006C98"), Address(RVA = "0x46F51A0", Offset = "0x46F51A0", VA = "0x46F51A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C99")]
    [Address(RVA = "0x46F51A8", Offset = "0x46F51A8", VA = "0x46F51A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C9A")]
    [Address(RVA = "0x46F5494", Offset = "0x46F5494", VA = "0x46F5494", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C9B")]
    [Address(RVA = "0x46F5568", Offset = "0x46F5568", VA = "0x46F5568")]
    public AbilityboardCustomASettingData()
    {
    }
  }
}
