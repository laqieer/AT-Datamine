// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD5")]
  [Serializable]
  public sealed class GuildFacilityEffectData : IMasterDataEntity
  {
    [Token(Token = "0x4004F69")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F6A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facilityId;
    [Token(Token = "0x4004F6B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004F6C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int effectLevel;

    [Token(Token = "0x17000DAD")]
    public int Key
    {
      [Token(Token = "0x6005C99"), Address(RVA = "0x278CC38", Offset = "0x278CC38", VA = "0x278CC38", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C9A")]
    [Address(RVA = "0x278CC40", Offset = "0x278CC40", VA = "0x278CC40", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C9B")]
    [Address(RVA = "0x278CE0C", Offset = "0x278CE0C", VA = "0x278CE0C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C9C")]
    [Address(RVA = "0x278CEB0", Offset = "0x278CEB0", VA = "0x278CEB0")]
    public GuildFacilityEffectData()
    {
    }
  }
}
