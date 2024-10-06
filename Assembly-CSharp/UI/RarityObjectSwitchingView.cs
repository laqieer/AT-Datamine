// Decompiled with JetBrains decompiler
// Type: UI.RarityObjectSwitchingView
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
  [Token(Token = "0x200087F")]
  internal class RarityObjectSwitchingView : RarityView
  {
    [Token(Token = "0x400281D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private RarityObjectSwitchingView.RarityObject[] rarityObjects;

    [Token(Token = "0x60030A4")]
    [Address(RVA = "0x3E7A63C", Offset = "0x3E7A63C", VA = "0x3E7A63C", Slot = "4")]
    public override void SetRarity(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x60030A5")]
    [Address(RVA = "0x3E7A6D0", Offset = "0x3E7A6D0", VA = "0x3E7A6D0")]
    public RarityObjectSwitchingView()
    {
    }

    [Token(Token = "0x2000880")]
    [Serializable]
    public struct RarityObject
    {
      [Token(Token = "0x400281E")]
      [FieldOffset(Offset = "0x0")]
      public RarityTypeEnum RarityType;
      [Token(Token = "0x400281F")]
      [FieldOffset(Offset = "0x8")]
      public GameObject ObjectRef;
    }
  }
}
