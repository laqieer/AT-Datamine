// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopPurchaseLimitTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A0")]
  [Serializable]
  public sealed class StoryShopPurchaseLimitTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40054EA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000F45")]
    public int Key
    {
      [Token(Token = "0x6006510"), Address(RVA = "0x4AF50B8", Offset = "0x4AF50B8", VA = "0x4AF50B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006511")]
    [Address(RVA = "0x4AF50C0", Offset = "0x4AF50C0", VA = "0x4AF50C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006512")]
    [Address(RVA = "0x4AF51CC", Offset = "0x4AF51CC", VA = "0x4AF51CC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006513")]
    [Address(RVA = "0x4AF5254", Offset = "0x4AF5254", VA = "0x4AF5254")]
    public StoryShopPurchaseLimitTypeData()
    {
    }
  }
}
