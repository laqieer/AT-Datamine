// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskFlagData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001317")]
  [Serializable]
  public sealed class StorySubquestTaskFlagData : IMasterDataEntity
  {
    [Token(Token = "0x4005A46")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A47")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005A48")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int Value;

    [Token(Token = "0x1700104B")]
    public int Key
    {
      [Token(Token = "0x6006BD3"), Address(RVA = "0x48E5E60", Offset = "0x48E5E60", VA = "0x48E5E60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BD4")]
    [Address(RVA = "0x48E5E68", Offset = "0x48E5E68", VA = "0x48E5E68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BD5")]
    [Address(RVA = "0x48E5FD4", Offset = "0x48E5FD4", VA = "0x48E5FD4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006BD6")]
    [Address(RVA = "0x48E606C", Offset = "0x48E606C", VA = "0x48E606C")]
    public StorySubquestTaskFlagData()
    {
    }
  }
}
