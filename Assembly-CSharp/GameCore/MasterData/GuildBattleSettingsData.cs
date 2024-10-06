// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildBattleSettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001012")]
  [Serializable]
  public sealed class GuildBattleSettingsData : IMasterDataEntity
  {
    [Token(Token = "0x4004FF9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FFA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004FFB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int attackMemberMax;
    [Token(Token = "0x4004FFC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int attackTeamMax;
    [Token(Token = "0x4004FFD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int defenseMemberMax;

    [Token(Token = "0x17000DD0")]
    public int Key
    {
      [Token(Token = "0x6005DA1"), Address(RVA = "0x2795434", Offset = "0x2795434", VA = "0x2795434", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DA2")]
    [Address(RVA = "0x279543C", Offset = "0x279543C", VA = "0x279543C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DA3")]
    [Address(RVA = "0x2795668", Offset = "0x2795668", VA = "0x2795668", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DA4")]
    [Address(RVA = "0x2795720", Offset = "0x2795720", VA = "0x2795720")]
    public GuildBattleSettingsData()
    {
    }
  }
}
