// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FootstepsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E93")]
  [Serializable]
  public sealed class FootstepsData : IMasterDataEntity
  {
    [Token(Token = "0x4004689")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400468A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400468B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string seName;

    [Token(Token = "0x17000D2C")]
    public int Key
    {
      [Token(Token = "0x60058A9"), Address(RVA = "0x3C2CB7C", Offset = "0x3C2CB7C", VA = "0x3C2CB7C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058AA")]
    [Address(RVA = "0x3C2CB84", Offset = "0x3C2CB84", VA = "0x3C2CB84", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058AB")]
    [Address(RVA = "0x3C2CCF0", Offset = "0x3C2CCF0", VA = "0x3C2CCF0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058AC")]
    [Address(RVA = "0x3C2CD8C", Offset = "0x3C2CD8C", VA = "0x3C2CD8C")]
    public FootstepsData()
    {
    }
  }
}
