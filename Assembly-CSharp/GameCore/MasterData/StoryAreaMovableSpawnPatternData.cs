// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSpawnPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D4")]
  [Serializable]
  public sealed class StoryAreaMovableSpawnPatternData : IMasterDataEntity
  {
    [Token(Token = "0x40055B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x40055B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int groupPattern;

    [Token(Token = "0x17000F62")]
    public int Key
    {
      [Token(Token = "0x6006600"), Address(RVA = "0x4D214BC", Offset = "0x4D214BC", VA = "0x4D214BC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006601")]
    [Address(RVA = "0x4D214C4", Offset = "0x4D214C4", VA = "0x4D214C4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006602")]
    [Address(RVA = "0x4D21630", Offset = "0x4D21630", VA = "0x4D21630", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006603")]
    [Address(RVA = "0x4D216C4", Offset = "0x4D216C4", VA = "0x4D216C4")]
    public StoryAreaMovableSpawnPatternData()
    {
    }
  }
}
