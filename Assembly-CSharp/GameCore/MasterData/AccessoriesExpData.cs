// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F3C")]
  [Serializable]
  public sealed class AccessoriesExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004C44")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004C45")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004C46")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004C47")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000D55")]
    public int Key
    {
      [Token(Token = "0x60059C8"), Address(RVA = "0x3C345E8", Offset = "0x3C345E8", VA = "0x3C345E8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059C9")]
    [Address(RVA = "0x3C345F0", Offset = "0x3C345F0", VA = "0x3C345F0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059CA")]
    [Address(RVA = "0x3C347BC", Offset = "0x3C347BC", VA = "0x3C347BC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60059CB")]
    [Address(RVA = "0x3C3407C", Offset = "0x3C3407C", VA = "0x3C3407C")]
    public AccessoriesExpData()
    {
    }
  }
}
