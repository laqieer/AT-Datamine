// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityMenuData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001227")]
  [Serializable]
  public sealed class StoryFacilityMenuData : IMasterDataEntity
  {
    [Token(Token = "0x40056CB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056CC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facility;
    [Token(Token = "0x40056CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x40056CE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int conditionStoryAbility;
    [Token(Token = "0x40056CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int seasonBegin;
    [Token(Token = "0x40056D0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int seasonEnd;
    [Token(Token = "0x40056D1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int costs;
    [Token(Token = "0x40056D2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int rewards;
    [Token(Token = "0x40056D3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public bool islottery;
    [Token(Token = "0x40056D4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int lottery;
    [Token(Token = "0x40056D5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool isSelectCharacter;
    [Token(Token = "0x40056D6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int relationshipPoint;

    [Token(Token = "0x17000F92")]
    public int Key
    {
      [Token(Token = "0x600676B"), Address(RVA = "0x4D2F414", Offset = "0x4D2F414", VA = "0x4D2F414", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600676C")]
    [Address(RVA = "0x4D2F41C", Offset = "0x4D2F41C", VA = "0x4D2F41C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600676D")]
    [Address(RVA = "0x4D2F8F0", Offset = "0x4D2F8F0", VA = "0x4D2F8F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F93")]
    public string Text
    {
      [Token(Token = "0x600676E"), Address(RVA = "0x4D2FA14", Offset = "0x4D2FA14", VA = "0x4D2FA14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600676F")]
    [Address(RVA = "0x4D2FAF0", Offset = "0x4D2FAF0", VA = "0x4D2FAF0")]
    public StoryFacilityMenuData()
    {
    }
  }
}
