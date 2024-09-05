// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopGrowthData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001198")]
  [Serializable]
  public sealed class StoryShopGrowthData : IMasterDataEntity
  {
    [Token(Token = "0x40054DC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054DD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int articleID;
    [Token(Token = "0x40054DE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int storyAbilityID;
    [Token(Token = "0x40054DF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public StoryShopUpdateTypeEnum StoryShopUpdateTypeID;
    [Token(Token = "0x40054E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value;

    [Token(Token = "0x17000F42")]
    public int Key
    {
      [Token(Token = "0x60064F5"), Address(RVA = "0x4AF46CC", Offset = "0x4AF46CC", VA = "0x4AF46CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064F6")]
    [Address(RVA = "0x4AF46D4", Offset = "0x4AF46D4", VA = "0x4AF46D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064F7")]
    [Address(RVA = "0x4AF4900", Offset = "0x4AF4900", VA = "0x4AF4900", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064F8")]
    [Address(RVA = "0x4AF49B4", Offset = "0x4AF49B4", VA = "0x4AF49B4")]
    public StoryShopGrowthData()
    {
    }
  }
}
