// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FEB")]
  [Serializable]
  public sealed class GuildFacilityData : IMasterDataEntity
  {
    [Token(Token = "0x4004F94")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F95")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int resourceTableId;
    [Token(Token = "0x4004F96")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int spriteId;
    [Token(Token = "0x4004F97")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime enableTime;

    [Token(Token = "0x17000DB4")]
    public int Key
    {
      [Token(Token = "0x6005CF1"), Address(RVA = "0x278F904", Offset = "0x278F904", VA = "0x278F904", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CF2")]
    [Address(RVA = "0x278F90C", Offset = "0x278F90C", VA = "0x278F90C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CF3")]
    [Address(RVA = "0x278FAD8", Offset = "0x278FAD8", VA = "0x278FAD8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DB5")]
    public string Name
    {
      [Token(Token = "0x6005CF4"), Address(RVA = "0x278FBAC", Offset = "0x278FBAC", VA = "0x278FBAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DB6")]
    public string Description
    {
      [Token(Token = "0x6005CF5"), Address(RVA = "0x278FC88", Offset = "0x278FC88", VA = "0x278FC88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005CF6")]
    [Address(RVA = "0x278FD64", Offset = "0x278FD64", VA = "0x278FD64")]
    public GuildFacilityData()
    {
    }
  }
}
