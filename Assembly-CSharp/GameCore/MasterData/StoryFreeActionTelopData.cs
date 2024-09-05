// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTelopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128B")]
  [Serializable]
  public sealed class StoryFreeActionTelopData : IMasterDataEntity
  {
    [Token(Token = "0x4005893")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005894")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x4005895")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int adv;

    [Token(Token = "0x17000FF0")]
    public int Key
    {
      [Token(Token = "0x6006965"), Address(RVA = "0x48CFD60", Offset = "0x48CFD60", VA = "0x48CFD60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006966")]
    [Address(RVA = "0x48CFD68", Offset = "0x48CFD68", VA = "0x48CFD68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006967")]
    [Address(RVA = "0x48CFED4", Offset = "0x48CFED4", VA = "0x48CFED4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006968")]
    [Address(RVA = "0x48CFF6C", Offset = "0x48CFF6C", VA = "0x48CFF6C")]
    public StoryFreeActionTelopData()
    {
    }
  }
}
