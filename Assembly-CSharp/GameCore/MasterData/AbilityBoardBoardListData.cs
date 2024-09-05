// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200132A")]
  [Serializable]
  public sealed class AbilityBoardBoardListData : IMasterDataEntity
  {
    [Token(Token = "0x4005A7D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A7E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int listId;

    [Token(Token = "0x1700105B")]
    public int Key
    {
      [Token(Token = "0x6006C29"), Address(RVA = "0x46F0E34", Offset = "0x46F0E34", VA = "0x46F0E34", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C2A")]
    [Address(RVA = "0x46F0E3C", Offset = "0x46F0E3C", VA = "0x46F0E3C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C2B")]
    [Address(RVA = "0x46F0F48", Offset = "0x46F0F48", VA = "0x46F0F48", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C2C")]
    [Address(RVA = "0x46F0FCC", Offset = "0x46F0FCC", VA = "0x46F0FCC")]
    public AbilityBoardBoardListData()
    {
    }
  }
}
