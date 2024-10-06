// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsAutoApproveTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC3")]
  [Serializable]
  public sealed class GuildSettingsAutoApproveTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F41")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000DA1")]
    public int Key
    {
      [Token(Token = "0x6005C5F"), Address(RVA = "0x278B748", Offset = "0x278B748", VA = "0x278B748", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C60")]
    [Address(RVA = "0x278B750", Offset = "0x278B750", VA = "0x278B750", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C61")]
    [Address(RVA = "0x278B7FC", Offset = "0x278B7FC", VA = "0x278B7FC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DA2")]
    public string Name
    {
      [Token(Token = "0x6005C62"), Address(RVA = "0x278B868", Offset = "0x278B868", VA = "0x278B868")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C63")]
    [Address(RVA = "0x278B944", Offset = "0x278B944", VA = "0x278B944")]
    public GuildSettingsAutoApproveTypeData()
    {
    }
  }
}
