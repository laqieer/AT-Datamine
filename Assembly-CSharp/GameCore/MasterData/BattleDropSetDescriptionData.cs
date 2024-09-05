// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropSetDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E35")]
  [Serializable]
  public sealed class BattleDropSetDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40043DB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C74")]
    public int Key
    {
      [Token(Token = "0x6005683"), Address(RVA = "0x3E37478", Offset = "0x3E37478", VA = "0x3E37478", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005684")]
    [Address(RVA = "0x3E37480", Offset = "0x3E37480", VA = "0x3E37480", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005685")]
    [Address(RVA = "0x3E3758C", Offset = "0x3E3758C", VA = "0x3E3758C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005686")]
    [Address(RVA = "0x3E37614", Offset = "0x3E37614", VA = "0x3E37614")]
    public BattleDropSetDescriptionData()
    {
    }
  }
}
