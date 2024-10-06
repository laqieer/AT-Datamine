// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopLevelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200119D")]
  [Serializable]
  public sealed class StoryShopLevelData : IMasterDataEntity
  {
    [Token(Token = "0x40054E4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40054E6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyAbilityID;

    [Token(Token = "0x17000F44")]
    public int Key
    {
      [Token(Token = "0x6006508"), Address(RVA = "0x4AF4D9C", Offset = "0x4AF4D9C", VA = "0x4AF4D9C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006509")]
    [Address(RVA = "0x4AF4DA4", Offset = "0x4AF4DA4", VA = "0x4AF4DA4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600650A")]
    [Address(RVA = "0x4AF4F10", Offset = "0x4AF4F10", VA = "0x4AF4F10", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600650B")]
    [Address(RVA = "0x4AF4FA8", Offset = "0x4AF4FA8", VA = "0x4AF4FA8")]
    public StoryShopLevelData()
    {
    }
  }
}
