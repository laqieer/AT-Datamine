// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvOptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DBC")]
  [Serializable]
  public sealed class AdvOptionData : IMasterDataEntity
  {
    [Token(Token = "0x40041BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17000BFE")]
    public int Key
    {
      [Token(Token = "0x6005401"), Address(RVA = "0x3AA02F0", Offset = "0x3AA02F0", VA = "0x3AA02F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005402")]
    [Address(RVA = "0x3AA02F8", Offset = "0x3AA02F8", VA = "0x3AA02F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005403")]
    [Address(RVA = "0x3AA0404", Offset = "0x3AA0404", VA = "0x3AA0404", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005404")]
    [Address(RVA = "0x3AA048C", Offset = "0x3AA048C", VA = "0x3AA048C")]
    public AdvOptionData()
    {
    }
  }
}
