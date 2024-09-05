// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFaclityInvestRateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FED")]
  [Serializable]
  public sealed class GuildFaclityInvestRateData : IMasterDataEntity
  {
    [Token(Token = "0x4004F98")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F99")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004F9A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int investRate;

    [Token(Token = "0x17000DB7")]
    public int Key
    {
      [Token(Token = "0x6005CFC"), Address(RVA = "0x278FEE0", Offset = "0x278FEE0", VA = "0x278FEE0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CFD")]
    [Address(RVA = "0x278FEE8", Offset = "0x278FEE8", VA = "0x278FEE8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CFE")]
    [Address(RVA = "0x2790054", Offset = "0x2790054", VA = "0x2790054", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CFF")]
    [Address(RVA = "0x27900EC", Offset = "0x27900EC", VA = "0x27900EC")]
    public GuildFaclityInvestRateData()
    {
    }
  }
}
