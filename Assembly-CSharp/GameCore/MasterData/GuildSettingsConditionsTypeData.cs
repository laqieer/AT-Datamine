// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsConditionsTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC9")]
  [Serializable]
  public sealed class GuildSettingsConditionsTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F4F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F50")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int conditionsLevel;

    [Token(Token = "0x17000DA5")]
    public int Key
    {
      [Token(Token = "0x6005C71"), Address(RVA = "0x278BD60", Offset = "0x278BD60", VA = "0x278BD60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C72")]
    [Address(RVA = "0x278BD68", Offset = "0x278BD68", VA = "0x278BD68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C73")]
    [Address(RVA = "0x278BE74", Offset = "0x278BE74", VA = "0x278BE74", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DA6")]
    public string Name
    {
      [Token(Token = "0x6005C74"), Address(RVA = "0x278BEF8", Offset = "0x278BEF8", VA = "0x278BEF8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C75")]
    [Address(RVA = "0x278BFD4", Offset = "0x278BFD4", VA = "0x278BFD4")]
    public GuildSettingsConditionsTypeData()
    {
    }
  }
}
