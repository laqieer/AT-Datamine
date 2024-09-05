// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD7")]
  [Serializable]
  public sealed class GuildFacilityExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004F6D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F6E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004F6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int fromExp;
    [Token(Token = "0x4004F70")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int toExp;

    [Token(Token = "0x17000DAE")]
    public int Key
    {
      [Token(Token = "0x6005CA8"), Address(RVA = "0x278D73C", Offset = "0x278D73C", VA = "0x278D73C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CA9")]
    [Address(RVA = "0x278D744", Offset = "0x278D744", VA = "0x278D744", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CAA")]
    [Address(RVA = "0x278D910", Offset = "0x278D910", VA = "0x278D910", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CAB")]
    [Address(RVA = "0x278D9B4", Offset = "0x278D9B4", VA = "0x278D9B4")]
    public GuildFacilityExpData()
    {
    }
  }
}
