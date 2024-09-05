// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryUnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C1")]
  [Serializable]
  public sealed class StoryReplayEntryUnlockData : IMasterDataEntity
  {
    [Token(Token = "0x4005927")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005928")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int storyReplayEntry;
    [Token(Token = "0x4005929")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int requiredSequenceId;

    [Token(Token = "0x17001012")]
    public int Key
    {
      [Token(Token = "0x6006A61"), Address(RVA = "0x48D888C", Offset = "0x48D888C", VA = "0x48D888C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A62")]
    [Address(RVA = "0x48D8894", Offset = "0x48D8894", VA = "0x48D8894", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A63")]
    [Address(RVA = "0x48D8A00", Offset = "0x48D8A00", VA = "0x48D8A00", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A64")]
    [Address(RVA = "0x48D8A94", Offset = "0x48D8A94", VA = "0x48D8A94")]
    public StoryReplayEntryUnlockData()
    {
    }
  }
}
