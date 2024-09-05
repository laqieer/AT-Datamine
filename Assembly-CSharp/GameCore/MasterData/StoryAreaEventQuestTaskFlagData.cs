// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskFlagData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E1")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskFlagData : IMasterDataEntity
  {
    [Token(Token = "0x40055CB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40055CD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value;

    [Token(Token = "0x17000F6C")]
    public int Key
    {
      [Token(Token = "0x6006636"), Address(RVA = "0x4D23370", Offset = "0x4D23370", VA = "0x4D23370", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006637")]
    [Address(RVA = "0x4D23378", Offset = "0x4D23378", VA = "0x4D23378", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006638")]
    [Address(RVA = "0x4D234E4", Offset = "0x4D234E4", VA = "0x4D234E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006639")]
    [Address(RVA = "0x4D2357C", Offset = "0x4D2357C", VA = "0x4D2357C")]
    public StoryAreaEventQuestTaskFlagData()
    {
    }
  }
}
