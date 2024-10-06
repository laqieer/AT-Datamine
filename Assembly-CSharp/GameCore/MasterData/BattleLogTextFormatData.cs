// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLogTextFormatData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1D")]
  [Serializable]
  public sealed class BattleLogTextFormatData : IMasterDataEntity
  {
    [Token(Token = "0x4004343")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004344")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public BattleLogTextTypeEnum logTextType;
    [Token(Token = "0x4004345")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int param;
    [Token(Token = "0x4004346")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string text;

    [Token(Token = "0x17000C56")]
    public int Key
    {
      [Token(Token = "0x60055FF"), Address(RVA = "0x3E30A8C", Offset = "0x3E30A8C", VA = "0x3E30A8C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005600")]
    [Address(RVA = "0x3E30A94", Offset = "0x3E30A94", VA = "0x3E30A94", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005601")]
    [Address(RVA = "0x3E30C60", Offset = "0x3E30C60", VA = "0x3E30C60", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005602")]
    [Address(RVA = "0x3E30D08", Offset = "0x3E30D08", VA = "0x3E30D08")]
    public BattleLogTextFormatData()
    {
    }
  }
}
