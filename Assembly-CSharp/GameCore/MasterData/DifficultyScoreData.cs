// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DifficultyScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001111")]
  [Serializable]
  public sealed class DifficultyScoreData : IMasterDataEntity
  {
    [Token(Token = "0x4005331")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005332")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005333")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int difficulty;
    [Token(Token = "0x4005334")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int baseScore;
    [Token(Token = "0x4005335")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int killedScore;

    [Token(Token = "0x17000EA9")]
    public int Key
    {
      [Token(Token = "0x600624B"), Address(RVA = "0x4ADE11C", Offset = "0x4ADE11C", VA = "0x4ADE11C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600624C")]
    [Address(RVA = "0x4ADE124", Offset = "0x4ADE124", VA = "0x4ADE124", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600624D")]
    [Address(RVA = "0x4ADE350", Offset = "0x4ADE350", VA = "0x4ADE350", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600624E")]
    [Address(RVA = "0x4ADE404", Offset = "0x4ADE404", VA = "0x4ADE404")]
    public DifficultyScoreData()
    {
    }
  }
}
