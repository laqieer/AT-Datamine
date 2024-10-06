// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ResourceItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001067")]
  [Serializable]
  public sealed class ResourceItemData : IMasterDataEntity
  {
    [Token(Token = "0x400512D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400512E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400512F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005130")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005131")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005132")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005133")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x4005134")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x17000E1C")]
    public int Key
    {
      [Token(Token = "0x6005F2E"), Address(RVA = "0x28CB7E4", Offset = "0x28CB7E4", VA = "0x28CB7E4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F2F")]
    [Address(RVA = "0x28CB7EC", Offset = "0x28CB7EC", VA = "0x28CB7EC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F30")]
    [Address(RVA = "0x28CBADC", Offset = "0x28CBADC", VA = "0x28CBADC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E1D")]
    public string Name
    {
      [Token(Token = "0x6005F31"), Address(RVA = "0x28CBBB8", Offset = "0x28CBBB8", VA = "0x28CBBB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E1E")]
    public string Flavor
    {
      [Token(Token = "0x6005F32"), Address(RVA = "0x28CBC94", Offset = "0x28CBC94", VA = "0x28CBC94")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F33")]
    [Address(RVA = "0x28CBD70", Offset = "0x28CBD70", VA = "0x28CBD70")]
    public ResourceItemData()
    {
    }
  }
}
