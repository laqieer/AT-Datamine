// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200132D")]
  [Serializable]
  public sealed class AbilityBoardBoardSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005A82")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A83")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int boardId;
    [Token(Token = "0x4005A84")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4005A85")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int beforeNumber;
    [Token(Token = "0x4005A86")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int nodeId;
    [Token(Token = "0x4005A87")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int needRarity;

    [Token(Token = "0x1700105C")]
    public int Key
    {
      [Token(Token = "0x6006C39"), Address(RVA = "0x46F1854", Offset = "0x46F1854", VA = "0x46F1854", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C3A")]
    [Address(RVA = "0x46F185C", Offset = "0x46F185C", VA = "0x46F185C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C3B")]
    [Address(RVA = "0x46F1AE8", Offset = "0x46F1AE8", VA = "0x46F1AE8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C3C")]
    [Address(RVA = "0x46F1BAC", Offset = "0x46F1BAC", VA = "0x46F1BAC")]
    public AbilityBoardBoardSettingData()
    {
    }
  }
}
