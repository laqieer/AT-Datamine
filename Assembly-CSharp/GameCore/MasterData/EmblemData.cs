// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EmblemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138E")]
  [Serializable]
  public sealed class EmblemData : IMasterDataEntity
  {
    [Token(Token = "0x4005B62")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x1700108C")]
    public int Key
    {
      [Token(Token = "0x6006DF3"), Address(RVA = "0x4700F18", Offset = "0x4700F18", VA = "0x4700F18", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DF4")]
    [Address(RVA = "0x4700F20", Offset = "0x4700F20", VA = "0x4700F20", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DF5")]
    [Address(RVA = "0x4700FCC", Offset = "0x4700FCC", VA = "0x4700FCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700108D")]
    public string Name
    {
      [Token(Token = "0x6006DF6"), Address(RVA = "0x4701038", Offset = "0x4701038", VA = "0x4701038")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006DF7")]
    [Address(RVA = "0x4701114", Offset = "0x4701114", VA = "0x4701114")]
    public EmblemData()
    {
    }
  }
}
