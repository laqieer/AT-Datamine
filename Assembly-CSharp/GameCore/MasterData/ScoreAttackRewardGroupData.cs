// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRewardGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200110E")]
  [Serializable]
  public sealed class ScoreAttackRewardGroupData : IMasterDataEntity
  {
    [Token(Token = "0x400532D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400532E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000EA8")]
    public int Key
    {
      [Token(Token = "0x6006240"), Address(RVA = "0x4ADDD28", Offset = "0x4ADDD28", VA = "0x4ADDD28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006241")]
    [Address(RVA = "0x4ADDD30", Offset = "0x4ADDD30", VA = "0x4ADDD30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006242")]
    [Address(RVA = "0x4ADDE3C", Offset = "0x4ADDE3C", VA = "0x4ADDE3C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006243")]
    [Address(RVA = "0x4ADDEC4", Offset = "0x4ADDEC4", VA = "0x4ADDEC4")]
    public ScoreAttackRewardGroupData()
    {
    }
  }
}
