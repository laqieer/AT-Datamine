// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C3")]
  [Serializable]
  public sealed class PlayerExpData : IMasterDataEntity
  {
    [Token(Token = "0x4005250")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005251")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005252")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int fromExp;
    [Token(Token = "0x4005253")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int toExp;

    [Token(Token = "0x17000E6D")]
    public int Key
    {
      [Token(Token = "0x60060E5"), Address(RVA = "0x28DB624", Offset = "0x28DB624", VA = "0x28DB624", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060E6")]
    [Address(RVA = "0x28DB62C", Offset = "0x28DB62C", VA = "0x28DB62C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060E7")]
    [Address(RVA = "0x28DB7F8", Offset = "0x28DB7F8", VA = "0x28DB7F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60060E8")]
    [Address(RVA = "0x28DB89C", Offset = "0x28DB89C", VA = "0x28DB89C")]
    public PlayerExpData()
    {
    }
  }
}
