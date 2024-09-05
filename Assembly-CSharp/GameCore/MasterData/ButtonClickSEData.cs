// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ButtonClickSEData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E82")]
  [Serializable]
  public sealed class ButtonClickSEData : IMasterDataEntity
  {
    [Token(Token = "0x4004605")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004606")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ButtonClickSETypeEnum ButtonClickSEType;
    [Token(Token = "0x4004607")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string SEName;

    [Token(Token = "0x17000D21")]
    public int Key
    {
      [Token(Token = "0x6005861"), Address(RVA = "0x3E48678", Offset = "0x3E48678", VA = "0x3E48678", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005862")]
    [Address(RVA = "0x3E48680", Offset = "0x3E48680", VA = "0x3E48680", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005863")]
    [Address(RVA = "0x3E488BC", Offset = "0x3E488BC", VA = "0x3E488BC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005864")]
    [Address(RVA = "0x3E48954", Offset = "0x3E48954", VA = "0x3E48954")]
    public ButtonClickSEData()
    {
    }
  }
}
