// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DEF")]
  [Serializable]
  public sealed class ArenaWeeklyRewardGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004297")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004298")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C37")]
    public int Key
    {
      [Token(Token = "0x6005502"), Address(RVA = "0x3AAA28C", Offset = "0x3AAA28C", VA = "0x3AAA28C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005503")]
    [Address(RVA = "0x3AAA294", Offset = "0x3AAA294", VA = "0x3AAA294", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005504")]
    [Address(RVA = "0x3AAA3A0", Offset = "0x3AAA3A0", VA = "0x3AAA3A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005505")]
    [Address(RVA = "0x3AAA428", Offset = "0x3AAA428", VA = "0x3AAA428")]
    public ArenaWeeklyRewardGroupData()
    {
    }
  }
}
