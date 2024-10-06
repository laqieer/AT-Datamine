// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerApData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BB")]
  [Serializable]
  public sealed class PlayerApData : IMasterDataEntity
  {
    [Token(Token = "0x400523A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400523B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int recoveryCount;
    [Token(Token = "0x400523C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int coinPrice;

    [Token(Token = "0x17000E68")]
    public int Key
    {
      [Token(Token = "0x60060BE"), Address(RVA = "0x28DA1E0", Offset = "0x28DA1E0", VA = "0x28DA1E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060BF")]
    [Address(RVA = "0x28DA1E8", Offset = "0x28DA1E8", VA = "0x28DA1E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060C0")]
    [Address(RVA = "0x28DA354", Offset = "0x28DA354", VA = "0x28DA354", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60060C1")]
    [Address(RVA = "0x28DA3E8", Offset = "0x28DA3E8", VA = "0x28DA3E8")]
    public PlayerApData()
    {
    }
  }
}
