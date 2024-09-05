// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UsageItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106D")]
  [Serializable]
  public sealed class UsageItemData : IMasterDataEntity
  {
    [Token(Token = "0x4005143")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005144")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int itemID;
    [Token(Token = "0x4005145")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005146")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int usageNameID1;
    [Token(Token = "0x4005147")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int usageNameID2;
    [Token(Token = "0x4005148")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int usageNameID3;
    [Token(Token = "0x4005149")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int usageNameID4;
    [Token(Token = "0x400514A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int usageNameID5;
    [Token(Token = "0x400514B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int usageNameID6;

    [Token(Token = "0x17000E25")]
    public int Key
    {
      [Token(Token = "0x6005F4C"), Address(RVA = "0x28CCAD0", Offset = "0x28CCAD0", VA = "0x28CCAD0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F4D")]
    [Address(RVA = "0x28CCAD8", Offset = "0x28CCAD8", VA = "0x28CCAD8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F4E")]
    [Address(RVA = "0x28CCE84", Offset = "0x28CCE84", VA = "0x28CCE84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F4F")]
    [Address(RVA = "0x28CCF78", Offset = "0x28CCF78", VA = "0x28CCF78")]
    public UsageItemData()
    {
    }
  }
}
