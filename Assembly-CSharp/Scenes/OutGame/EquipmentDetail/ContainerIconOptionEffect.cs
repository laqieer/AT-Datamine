// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.ContainerIconOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003679")]
  public class ContainerIconOptionEffect : MonoBehaviour
  {
    [Token(Token = "0x400ECFB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image baseImage;
    [Token(Token = "0x400ECFC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x400ECFD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton lockButton;
    [Token(Token = "0x400ECFE")]
    [FieldOffset(Offset = "0x30")]
    private string baseType;

    [Token(Token = "0x60156F9")]
    [Address(RVA = "0x18E2F10", Offset = "0x18E2F10", VA = "0x18E2F10")]
    public void SetWeaponOptionEffect(
      AssetCachedSpawner assetCachedSpawner,
      PlayerGearOptionType playerGearOptionType)
    {
    }

    [Token(Token = "0x60156FA")]
    [Address(RVA = "0x18E3214", Offset = "0x18E3214", VA = "0x18E3214")]
    public void SetAccessoryOptionEffect(
      AssetCachedSpawner assetCachedSpawner,
      PlayerGearOptionType playerGearOptionType)
    {
    }

    [Token(Token = "0x60156FB")]
    [Address(RVA = "0x18E2F8C", Offset = "0x18E2F8C", VA = "0x18E2F8C")]
    public void SetData(AssetCachedSpawner assetCachedSpawner, IOptionEffect effect)
    {
    }

    [Token(Token = "0x60156FC")]
    [Address(RVA = "0x18E3290", Offset = "0x18E3290", VA = "0x18E3290")]
    public void SetBaseSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x60156FD")]
    [Address(RVA = "0x18E3334", Offset = "0x18E3334", VA = "0x18E3334")]
    public void SetIconSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x60156FE")]
    [Address(RVA = "0x18E33D8", Offset = "0x18E33D8", VA = "0x18E33D8")]
    public void Lock(Action onClick = null)
    {
    }

    [Token(Token = "0x60156FF")]
    [Address(RVA = "0x18E3528", Offset = "0x18E3528", VA = "0x18E3528")]
    public ContainerIconOptionEffect()
    {
    }
  }
}
