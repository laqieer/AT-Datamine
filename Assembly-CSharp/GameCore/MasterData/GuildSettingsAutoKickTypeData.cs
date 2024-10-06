// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsAutoKickTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC6")]
  [Serializable]
  public sealed class GuildSettingsAutoKickTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F46")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000DA3")]
    public int Key
    {
      [Token(Token = "0x6005C68"), Address(RVA = "0x278BA54", Offset = "0x278BA54", VA = "0x278BA54", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C69")]
    [Address(RVA = "0x278BA5C", Offset = "0x278BA5C", VA = "0x278BA5C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C6A")]
    [Address(RVA = "0x278BB08", Offset = "0x278BB08", VA = "0x278BB08", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DA4")]
    public string Name
    {
      [Token(Token = "0x6005C6B"), Address(RVA = "0x278BB74", Offset = "0x278BB74", VA = "0x278BB74")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C6C")]
    [Address(RVA = "0x278BC50", Offset = "0x278BC50", VA = "0x278BC50")]
    public GuildSettingsAutoKickTypeData()
    {
    }
  }
}
