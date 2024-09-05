// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvLockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB8")]
  [Serializable]
  public sealed class AdvLockData : IMasterDataEntity
  {
    [Token(Token = "0x40041AD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40041AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int Operator;

    [Token(Token = "0x17000BFC")]
    public int Key
    {
      [Token(Token = "0x60053EB"), Address(RVA = "0x3A9F124", Offset = "0x3A9F124", VA = "0x3A9F124", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053EC")]
    [Address(RVA = "0x3A9F12C", Offset = "0x3A9F12C", VA = "0x3A9F12C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053ED")]
    [Address(RVA = "0x3A9F298", Offset = "0x3A9F298", VA = "0x3A9F298", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053EE")]
    [Address(RVA = "0x3A9F330", Offset = "0x3A9F330", VA = "0x3A9F330")]
    public AdvLockData()
    {
    }
  }
}
