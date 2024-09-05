// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmoryCommonThumbBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003806")]
  [Serializable]
  internal class ArmoryCommonThumbBase
  {
    [Token(Token = "0x400F4B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F4B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400F4B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400F4B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400F4BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400F4BB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400F4BC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image selectedImage;
    [Token(Token = "0x400F4BD")]
    [FieldOffset(Offset = "0x48")]
    private AssetSpawnOperationBase thumbOperation;
    [Token(Token = "0x400F4BE")]
    [FieldOffset(Offset = "0x50")]
    private AssetSpawnOperationBase rarityBaseOperation;
    [Token(Token = "0x400F4BF")]
    [FieldOffset(Offset = "0x58")]
    private AssetSpawnOperationBase rarityOperation;
    [Token(Token = "0x400F4C0")]
    [FieldOffset(Offset = "0x60")]
    private IArmouryResourceProvider resourceProvider;

    [Token(Token = "0x60160B3")]
    [Address(RVA = "0x20ED97C", Offset = "0x20ED97C", VA = "0x20ED97C")]
    public void LoadAsset(IArmouryResourceProvider resourceProvider)
    {
    }

    [Token(Token = "0x60160B4")]
    [Address(RVA = "0x20EDBE4", Offset = "0x20EDBE4", VA = "0x20EDBE4")]
    public void LoadCancel()
    {
    }

    [Token(Token = "0x60160B5")]
    [Address(RVA = "0x20EDDD0", Offset = "0x20EDDD0", VA = "0x20EDDD0")]
    public void SetActiveNewIcon(bool isActive)
    {
    }

    [Token(Token = "0x60160B6")]
    [Address(RVA = "0x20EDDF0", Offset = "0x20EDDF0", VA = "0x20EDDF0")]
    public void AddThumbClickListener(UnityAction call)
    {
    }

    [Token(Token = "0x60160B7")]
    [Address(RVA = "0x20EDE24", Offset = "0x20EDE24", VA = "0x20EDE24")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x60160B8")]
    [Address(RVA = "0x20EDF9C", Offset = "0x20EDF9C", VA = "0x20EDF9C")]
    public ArmoryCommonThumbBase()
    {
    }
  }
}
