// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopGrowthTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200119A")]
  [Serializable]
  public sealed class StoryShopGrowthTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40054E1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000F43")]
    public int Key
    {
      [Token(Token = "0x60064FD"), Address(RVA = "0x4AF4AC4", Offset = "0x4AF4AC4", VA = "0x4AF4AC4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064FE")]
    [Address(RVA = "0x4AF4ACC", Offset = "0x4AF4ACC", VA = "0x4AF4ACC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064FF")]
    [Address(RVA = "0x4AF4BD8", Offset = "0x4AF4BD8", VA = "0x4AF4BD8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006500")]
    [Address(RVA = "0x4AF4C60", Offset = "0x4AF4C60", VA = "0x4AF4C60")]
    public StoryShopGrowthTypeData()
    {
    }
  }
}
