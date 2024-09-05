// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryPieceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103D")]
  [Serializable]
  public sealed class AccessoryPieceData : IMasterDataEntity
  {
    [Token(Token = "0x400507D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400507E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400507F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005080")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005081")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DE9")]
    public int Key
    {
      [Token(Token = "0x6005E5B"), Address(RVA = "0x28C2A90", Offset = "0x28C2A90", VA = "0x28C2A90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E5C")]
    [Address(RVA = "0x28C2A98", Offset = "0x28C2A98", VA = "0x28C2A98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E5D")]
    [Address(RVA = "0x28C2CC8", Offset = "0x28C2CC8", VA = "0x28C2CC8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DEA")]
    public string Name
    {
      [Token(Token = "0x6005E5E"), Address(RVA = "0x28C2D80", Offset = "0x28C2D80", VA = "0x28C2D80")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DEB")]
    public string Flavor
    {
      [Token(Token = "0x6005E5F"), Address(RVA = "0x28C2E5C", Offset = "0x28C2E5C", VA = "0x28C2E5C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005E60")]
    [Address(RVA = "0x28C2F38", Offset = "0x28C2F38", VA = "0x28C2F38")]
    public AccessoryPieceData()
    {
    }
  }
}
