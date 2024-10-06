// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityResourceDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE3")]
  [Serializable]
  public sealed class GuildFacilityResourceDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F83")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F84")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int resourceSetId;
    [Token(Token = "0x4004F85")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public PaymentTypeEnum resourceType;
    [Token(Token = "0x4004F86")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int resourceId;
    [Token(Token = "0x4004F87")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int quantity;

    [Token(Token = "0x17000DB1")]
    public int Key
    {
      [Token(Token = "0x6005CD2"), Address(RVA = "0x278EA90", Offset = "0x278EA90", VA = "0x278EA90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CD3")]
    [Address(RVA = "0x278EA98", Offset = "0x278EA98", VA = "0x278EA98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CD4")]
    [Address(RVA = "0x278ECC4", Offset = "0x278ECC4", VA = "0x278ECC4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CD5")]
    [Address(RVA = "0x278ED78", Offset = "0x278ED78", VA = "0x278ED78")]
    public GuildFacilityResourceDescriptionData()
    {
    }
  }
}
