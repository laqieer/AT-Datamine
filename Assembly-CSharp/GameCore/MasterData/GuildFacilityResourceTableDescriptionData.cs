// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityResourceTableDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE6")]
  [Serializable]
  public sealed class GuildFacilityResourceTableDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F89")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F8A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int tableId;
    [Token(Token = "0x4004F8B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int resourceSetId;
    [Token(Token = "0x4004F8C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardSetId;
    [Token(Token = "0x4004F8D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int addExperience;

    [Token(Token = "0x17000DB2")]
    public int Key
    {
      [Token(Token = "0x6005CDD"), Address(RVA = "0x278EFD0", Offset = "0x278EFD0", VA = "0x278EFD0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CDE")]
    [Address(RVA = "0x278EFD8", Offset = "0x278EFD8", VA = "0x278EFD8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CDF")]
    [Address(RVA = "0x278F204", Offset = "0x278F204", VA = "0x278F204", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CE0")]
    [Address(RVA = "0x278F2B8", Offset = "0x278F2B8", VA = "0x278F2B8")]
    public GuildFacilityResourceTableDescriptionData()
    {
    }
  }
}
