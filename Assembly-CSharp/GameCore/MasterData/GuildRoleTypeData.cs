// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRoleTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC0")]
  [Serializable]
  public sealed class GuildRoleTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F3B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F3C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D9F")]
    public int Key
    {
      [Token(Token = "0x6005C56"), Address(RVA = "0x278B3C0", Offset = "0x278B3C0", VA = "0x278B3C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C57")]
    [Address(RVA = "0x278B3C8", Offset = "0x278B3C8", VA = "0x278B3C8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C58")]
    [Address(RVA = "0x278B4D4", Offset = "0x278B4D4", VA = "0x278B4D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DA0")]
    public string Name
    {
      [Token(Token = "0x6005C59"), Address(RVA = "0x278B55C", Offset = "0x278B55C", VA = "0x278B55C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C5A")]
    [Address(RVA = "0x278B638", Offset = "0x278B638", VA = "0x278B638")]
    public GuildRoleTypeData()
    {
    }
  }
}
