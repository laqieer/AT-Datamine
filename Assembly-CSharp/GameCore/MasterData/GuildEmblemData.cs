// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildEmblemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF0")]
  [Serializable]
  public sealed class GuildEmblemData : IMasterDataEntity
  {
    [Token(Token = "0x4004FA0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FA1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public bool availableOnBuild;

    [Token(Token = "0x17000DBA")]
    public int Key
    {
      [Token(Token = "0x6005D0D"), Address(RVA = "0x27905D0", Offset = "0x27905D0", VA = "0x27905D0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D0E")]
    [Address(RVA = "0x27905D8", Offset = "0x27905D8", VA = "0x27905D8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D0F")]
    [Address(RVA = "0x27906E8", Offset = "0x27906E8", VA = "0x27906E8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D10")]
    [Address(RVA = "0x279076C", Offset = "0x279076C", VA = "0x279076C")]
    public GuildEmblemData()
    {
    }
  }
}
