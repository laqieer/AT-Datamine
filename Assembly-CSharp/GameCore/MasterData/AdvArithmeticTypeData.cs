// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvArithmeticTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA4")]
  [Serializable]
  public sealed class AdvArithmeticTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400416F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004170")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4004171")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string oprText;

    [Token(Token = "0x17000BF3")]
    public int Key
    {
      [Token(Token = "0x6005393"), Address(RVA = "0x3A9B564", Offset = "0x3A9B564", VA = "0x3A9B564", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005394")]
    [Address(RVA = "0x3A9B56C", Offset = "0x3A9B56C", VA = "0x3A9B56C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005395")]
    [Address(RVA = "0x3A9B6D8", Offset = "0x3A9B6D8", VA = "0x3A9B6D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005396")]
    [Address(RVA = "0x3A9B774", Offset = "0x3A9B774", VA = "0x3A9B774")]
    public AdvArithmeticTypeData()
    {
    }
  }
}
