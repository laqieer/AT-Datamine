// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE7")]
  [Serializable]
  public sealed class ArenaDailyRewardGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004284")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004285")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C33")]
    public int Key
    {
      [Token(Token = "0x60054E2"), Address(RVA = "0x3AA92B8", Offset = "0x3AA92B8", VA = "0x3AA92B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054E3")]
    [Address(RVA = "0x3AA92C0", Offset = "0x3AA92C0", VA = "0x3AA92C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054E4")]
    [Address(RVA = "0x3AA93CC", Offset = "0x3AA93CC", VA = "0x3AA93CC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054E5")]
    [Address(RVA = "0x3AA9454", Offset = "0x3AA9454", VA = "0x3AA9454")]
    public ArenaDailyRewardGroupData()
    {
    }
  }
}
