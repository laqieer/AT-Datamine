// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesLimitBreakData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F4F")]
  [Serializable]
  public sealed class AccessoriesLimitBreakData : IMasterDataEntity
  {
    [Token(Token = "0x4004D00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D61")]
    public int Key
    {
      [Token(Token = "0x6005A26"), Address(RVA = "0x3C3BC80", Offset = "0x3C3BC80", VA = "0x3C3BC80", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A27")]
    [Address(RVA = "0x3C3BC88", Offset = "0x3C3BC88", VA = "0x3C3BC88", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A28")]
    [Address(RVA = "0x3C3BD94", Offset = "0x3C3BD94", VA = "0x3C3BD94", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A29")]
    [Address(RVA = "0x3C3BE1C", Offset = "0x3C3BE1C", VA = "0x3C3BE1C")]
    public AccessoriesLimitBreakData()
    {
    }
  }
}
