// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001328")]
  [Serializable]
  public sealed class AbilityBoardBoardListSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005A75")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A76")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int boardListId;
    [Token(Token = "0x4005A77")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4005A78")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int beforeNumber;
    [Token(Token = "0x4005A79")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int unlockNodeNumber;
    [Token(Token = "0x4005A7A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int startNumber;
    [Token(Token = "0x4005A7B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int boardId;
    [Token(Token = "0x4005A7C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int completeBonus;

    [Token(Token = "0x1700105A")]
    public int Key
    {
      [Token(Token = "0x6006C21"), Address(RVA = "0x48E89EC", Offset = "0x48E89EC", VA = "0x48E89EC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C22")]
    [Address(RVA = "0x48E89F4", Offset = "0x48E89F4", VA = "0x48E89F4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C23")]
    [Address(RVA = "0x48E8D40", Offset = "0x48E8D40", VA = "0x48E8D40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C24")]
    [Address(RVA = "0x48E8E24", Offset = "0x48E8E24", VA = "0x48E8E24")]
    public AbilityBoardBoardListSettingData()
    {
    }
  }
}
