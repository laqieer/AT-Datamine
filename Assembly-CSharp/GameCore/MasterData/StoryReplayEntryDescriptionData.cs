// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BD")]
  [Serializable]
  public sealed class StoryReplayEntryDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x400591D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400591E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400591F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyReplayEntry;
    [Token(Token = "0x4005920")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int advId;

    [Token(Token = "0x17001010")]
    public int Key
    {
      [Token(Token = "0x6006A51"), Address(RVA = "0x48D8094", Offset = "0x48D8094", VA = "0x48D8094", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A52")]
    [Address(RVA = "0x48D809C", Offset = "0x48D809C", VA = "0x48D809C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A53")]
    [Address(RVA = "0x48D8268", Offset = "0x48D8268", VA = "0x48D8268", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A54")]
    [Address(RVA = "0x48D8310", Offset = "0x48D8310", VA = "0x48D8310")]
    public StoryReplayEntryDescriptionData()
    {
    }
  }
}
