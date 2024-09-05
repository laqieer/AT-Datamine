// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryHumanParameterLevelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E2")]
  [Serializable]
  public sealed class StoryHumanParameterLevelData : IMasterDataEntity
  {
    [Token(Token = "0x4005994")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005995")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int parameterID;
    [Token(Token = "0x4005996")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005997")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int exp;
    [Token(Token = "0x4005998")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int text;

    [Token(Token = "0x17001029")]
    public int Key
    {
      [Token(Token = "0x6006AE9"), Address(RVA = "0x48DD8E0", Offset = "0x48DD8E0", VA = "0x48DD8E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AEA")]
    [Address(RVA = "0x48DD8E8", Offset = "0x48DD8E8", VA = "0x48DD8E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006AEB")]
    [Address(RVA = "0x48DDB14", Offset = "0x48DDB14", VA = "0x48DDB14", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006AEC")]
    [Address(RVA = "0x48DDBC8", Offset = "0x48DDBC8", VA = "0x48DDBC8")]
    public StoryHumanParameterLevelData()
    {
    }
  }
}
