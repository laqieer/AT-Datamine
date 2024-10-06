// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MaxLimitBreakData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6F")]
  [Serializable]
  public sealed class MaxLimitBreakData : IMasterDataEntity
  {
    [Token(Token = "0x4004DD6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DD7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004DD8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4004DD9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int maxLimitBreakCount;

    [Token(Token = "0x17000D75")]
    public int Key
    {
      [Token(Token = "0x6005AD9"), Address(RVA = "0x277B41C", Offset = "0x277B41C", VA = "0x277B41C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005ADA")]
    [Address(RVA = "0x277B424", Offset = "0x277B424", VA = "0x277B424", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005ADB")]
    [Address(RVA = "0x277B5F0", Offset = "0x277B5F0", VA = "0x277B5F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005ADC")]
    [Address(RVA = "0x277B698", Offset = "0x277B698", VA = "0x277B698")]
    public MaxLimitBreakData()
    {
    }
  }
}
