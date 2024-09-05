// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcDeckGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDD")]
  [Serializable]
  public sealed class ArenaNpcDeckGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004264")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004265")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int deckGroup;
    [Token(Token = "0x4004266")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int npcUnitId;

    [Token(Token = "0x17000C2E")]
    public int Key
    {
      [Token(Token = "0x60054B5"), Address(RVA = "0x3AA7554", Offset = "0x3AA7554", VA = "0x3AA7554", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054B6")]
    [Address(RVA = "0x3AA755C", Offset = "0x3AA755C", VA = "0x3AA755C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054B7")]
    [Address(RVA = "0x3AA76C8", Offset = "0x3AA76C8", VA = "0x3AA76C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054B8")]
    [Address(RVA = "0x3AA775C", Offset = "0x3AA775C", VA = "0x3AA775C")]
    public ArenaNpcDeckGroupData()
    {
    }
  }
}
