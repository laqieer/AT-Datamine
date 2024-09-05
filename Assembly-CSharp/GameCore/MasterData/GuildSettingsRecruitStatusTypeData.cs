// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsRecruitStatusTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FCF")]
  [Serializable]
  public sealed class GuildSettingsRecruitStatusTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F5D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000DA9")]
    public int Key
    {
      [Token(Token = "0x6005C83"), Address(RVA = "0x278C3F0", Offset = "0x278C3F0", VA = "0x278C3F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C84")]
    [Address(RVA = "0x278C3F8", Offset = "0x278C3F8", VA = "0x278C3F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C85")]
    [Address(RVA = "0x278C4A4", Offset = "0x278C4A4", VA = "0x278C4A4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DAA")]
    public string Name
    {
      [Token(Token = "0x6005C86"), Address(RVA = "0x278C510", Offset = "0x278C510", VA = "0x278C510")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C87")]
    [Address(RVA = "0x278C5EC", Offset = "0x278C5EC", VA = "0x278C5EC")]
    public GuildSettingsRecruitStatusTypeData()
    {
    }
  }
}
