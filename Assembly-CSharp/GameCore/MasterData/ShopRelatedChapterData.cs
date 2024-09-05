// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopRelatedChapterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200118D")]
  [Serializable]
  public sealed class ShopRelatedChapterData : IMasterDataEntity
  {
    [Token(Token = "0x40054BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054C0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ShopTypeEnum shopTypeID;

    [Token(Token = "0x17000F40")]
    public int Key
    {
      [Token(Token = "0x60064D2"), Address(RVA = "0x4AF2D3C", Offset = "0x4AF2D3C", VA = "0x4AF2D3C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064D3")]
    [Address(RVA = "0x4AF2D44", Offset = "0x4AF2D44", VA = "0x4AF2D44", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064D4")]
    [Address(RVA = "0x4AF2E50", Offset = "0x4AF2E50", VA = "0x4AF2E50", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064D5")]
    [Address(RVA = "0x4AF2ED4", Offset = "0x4AF2ED4", VA = "0x4AF2ED4")]
    public ShopRelatedChapterData()
    {
    }
  }
}
