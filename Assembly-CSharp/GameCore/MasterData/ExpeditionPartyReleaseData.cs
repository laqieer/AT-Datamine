// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionPartyReleaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA2")]
  [Serializable]
  public sealed class ExpeditionPartyReleaseData : IMasterDataEntity
  {
    [Token(Token = "0x4004ECF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004ED0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int releasePartyNo;
    [Token(Token = "0x4004ED1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int playerRank;

    [Token(Token = "0x17000D8F")]
    public int Key
    {
      [Token(Token = "0x6005BCE"), Address(RVA = "0x2786630", Offset = "0x2786630", VA = "0x2786630", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BCF")]
    [Address(RVA = "0x2786638", Offset = "0x2786638", VA = "0x2786638", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BD0")]
    [Address(RVA = "0x27867A4", Offset = "0x27867A4", VA = "0x27867A4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BD1")]
    [Address(RVA = "0x2786838", Offset = "0x2786838", VA = "0x2786838")]
    public ExpeditionPartyReleaseData()
    {
    }
  }
}
