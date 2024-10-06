// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200131F")]
  [Serializable]
  public sealed class StorySubquestTaskTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4005A66")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A67")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public StorySubquestTaskTypeEnum StorySubquestTaskType;

    [Token(Token = "0x17001054")]
    public int Key
    {
      [Token(Token = "0x6006BF9"), Address(RVA = "0x48E75AC", Offset = "0x48E75AC", VA = "0x48E75AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BFA")]
    [Address(RVA = "0x48E75B4", Offset = "0x48E75B4", VA = "0x48E75B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BFB")]
    [Address(RVA = "0x48E7790", Offset = "0x48E7790", VA = "0x48E7790", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006BFC")]
    [Address(RVA = "0x48E7814", Offset = "0x48E7814", VA = "0x48E7814")]
    public StorySubquestTaskTypeData()
    {
    }
  }
}
