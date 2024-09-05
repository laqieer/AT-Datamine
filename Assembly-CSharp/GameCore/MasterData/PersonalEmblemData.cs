// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PersonalEmblemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001065")]
  [Serializable]
  public sealed class PersonalEmblemData : IMasterDataEntity
  {
    [Token(Token = "0x4005124")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005125")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005126")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string description;
    [Token(Token = "0x4005127")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string getDescription;
    [Token(Token = "0x4005128")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int spriteId;
    [Token(Token = "0x4005129")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public EmblemTypeEnum emblemType;
    [Token(Token = "0x400512A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400512B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool isDisplay;
    [Token(Token = "0x400512C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public ItemTypeEnum itemType;

    [Token(Token = "0x17000E1B")]
    public int Key
    {
      [Token(Token = "0x6005F26"), Address(RVA = "0x28CB21C", Offset = "0x28CB21C", VA = "0x28CB21C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F27")]
    [Address(RVA = "0x28CB224", Offset = "0x28CB224", VA = "0x28CB224", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F28")]
    [Address(RVA = "0x28CB5D4", Offset = "0x28CB5D4", VA = "0x28CB5D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F29")]
    [Address(RVA = "0x28CB6D4", Offset = "0x28CB6D4", VA = "0x28CB6D4")]
    public PersonalEmblemData()
    {
    }
  }
}
