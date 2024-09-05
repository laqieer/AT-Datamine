// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012CA")]
  [Serializable]
  public sealed class StoryObliviaeDetailData : IMasterDataEntity
  {
    [Token(Token = "0x400593D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400593E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400593F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int obliviaeId;
    [Token(Token = "0x4005940")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int styleID;
    [Token(Token = "0x4005941")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseStoryAbility;

    [Token(Token = "0x17001015")]
    public int Key
    {
      [Token(Token = "0x6006A7C"), Address(RVA = "0x48D9324", Offset = "0x48D9324", VA = "0x48D9324", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A7D")]
    [Address(RVA = "0x48D932C", Offset = "0x48D932C", VA = "0x48D932C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A7E")]
    [Address(RVA = "0x48D9558", Offset = "0x48D9558", VA = "0x48D9558", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A7F")]
    [Address(RVA = "0x48D9610", Offset = "0x48D9610", VA = "0x48D9610")]
    public StoryObliviaeDetailData()
    {
    }
  }
}
