// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySceneTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C6")]
  [Serializable]
  public sealed class StorySceneTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4005936")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005937")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17001014")]
    public int Key
    {
      [Token(Token = "0x6006A71"), Address(RVA = "0x48D8F30", Offset = "0x48D8F30", VA = "0x48D8F30", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A72")]
    [Address(RVA = "0x48D8F38", Offset = "0x48D8F38", VA = "0x48D8F38", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A73")]
    [Address(RVA = "0x48D9044", Offset = "0x48D9044", VA = "0x48D9044", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A74")]
    [Address(RVA = "0x48D90CC", Offset = "0x48D90CC", VA = "0x48D90CC")]
    public StorySceneTypeData()
    {
    }
  }
}
