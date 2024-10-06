// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionEventCircleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001255")]
  [Serializable]
  public sealed class StoryFreeActionEventCircleData : IMasterDataEntity
  {
    [Token(Token = "0x40057C0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057C1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string assetName;

    [Token(Token = "0x17000FBA")]
    public int Key
    {
      [Token(Token = "0x600683E"), Address(RVA = "0x4D37200", Offset = "0x4D37200", VA = "0x4D37200", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600683F")]
    [Address(RVA = "0x4D37208", Offset = "0x4D37208", VA = "0x4D37208", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006840")]
    [Address(RVA = "0x4D37314", Offset = "0x4D37314", VA = "0x4D37314", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006841")]
    [Address(RVA = "0x4D3739C", Offset = "0x4D3739C", VA = "0x4D3739C")]
    public StoryFreeActionEventCircleData()
    {
    }
  }
}
