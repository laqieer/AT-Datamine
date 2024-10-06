// Decompiled with JetBrains decompiler
// Type: UI.RarityStarObjectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI
{
  [Token(Token = "0x2000881")]
  internal class RarityStarObjectView : RarityView
  {
    [Token(Token = "0x4002820")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    [SerializeField]
    private RarityStarObjectView.RarityObject[] rarityObjects;

    [Token(Token = "0x60030A6")]
    [Address(RVA = "0x3E7A6E0", Offset = "0x3E7A6E0", VA = "0x3E7A6E0", Slot = "4")]
    public override void SetRarity(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x60030A7")]
    [Address(RVA = "0x3E7A7C0", Offset = "0x3E7A7C0", VA = "0x3E7A7C0")]
    public RarityStarObjectView()
    {
    }

    [Token(Token = "0x2000882")]
    [Serializable]
    public struct RarityObject
    {
      [Token(Token = "0x4002821")]
      [FieldOffset(Offset = "0x0")]
      public RarityTypeEnum RarityType;
      [Token(Token = "0x4002822")]
      [FieldOffset(Offset = "0x8")]
      public GameObject EnableStar;
      [Token(Token = "0x4002823")]
      [FieldOffset(Offset = "0x10")]
      public GameObject DisableStar;
    }
  }
}
