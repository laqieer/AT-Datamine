// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF3")]
  [Serializable]
  public sealed class GuildExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004FB2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FB3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004FB4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int fromExp;
    [Token(Token = "0x4004FB5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int toExp;

    [Token(Token = "0x17000DBB")]
    public int Key
    {
      [Token(Token = "0x6005D1B"), Address(RVA = "0x2790E30", Offset = "0x2790E30", VA = "0x2790E30", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D1C")]
    [Address(RVA = "0x2790E38", Offset = "0x2790E38", VA = "0x2790E38", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D1D")]
    [Address(RVA = "0x2791004", Offset = "0x2791004", VA = "0x2791004", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D1E")]
    [Address(RVA = "0x27910A8", Offset = "0x27910A8", VA = "0x27910A8")]
    public GuildExpData()
    {
    }
  }
}
