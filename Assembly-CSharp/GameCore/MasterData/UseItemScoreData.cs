// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UseItemScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001175")]
  [Serializable]
  public sealed class UseItemScoreData : IMasterDataEntity
  {
    [Token(Token = "0x400547F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005480")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005481")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int itemFrom;
    [Token(Token = "0x4005482")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int itemTo;
    [Token(Token = "0x4005483")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int score;

    [Token(Token = "0x17000F35")]
    public int Key
    {
      [Token(Token = "0x600646C"), Address(RVA = "0x4AEF5B4", Offset = "0x4AEF5B4", VA = "0x4AEF5B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600646D")]
    [Address(RVA = "0x4AEF5BC", Offset = "0x4AEF5BC", VA = "0x4AEF5BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600646E")]
    [Address(RVA = "0x4AEF7E8", Offset = "0x4AEF7E8", VA = "0x4AEF7E8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600646F")]
    [Address(RVA = "0x4AEF89C", Offset = "0x4AEF89C", VA = "0x4AEF89C")]
    public UseItemScoreData()
    {
    }
  }
}
