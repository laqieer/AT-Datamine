// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MnemnographThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003992")]
  public class MnemnographThumb : MonoBehaviour
  {
    [Token(Token = "0x400FB8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FB8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image baseImage;
    [Token(Token = "0x400FB8C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FB8D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private LongPressButton longPressButton;

    [Token(Token = "0x17004A7B")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x60169F4"), Address(RVA = "0x42F6520", Offset = "0x42F6520", VA = "0x42F6520")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x60169F5")]
    [Address(RVA = "0x42F6528", Offset = "0x42F6528", VA = "0x42F6528")]
    public void LoadItemImage(AssetCachedSpawner assetLoader, ItemTypeEnum itemType, int id)
    {
    }

    [Token(Token = "0x60169F6")]
    [Address(RVA = "0x42E580C", Offset = "0x42E580C", VA = "0x42E580C")]
    public void LoadItemImage(AssetCachedSpawner assetLoader, RewardTypeEnum rewardType, int id)
    {
    }

    [Token(Token = "0x60169F7")]
    [Address(RVA = "0x42F65A0", Offset = "0x42F65A0", VA = "0x42F65A0")]
    public void LoadItemImage(AssetCachedSpawner assetLoader, ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x60169F8")]
    [Address(RVA = "0x42F6690", Offset = "0x42F6690", VA = "0x42F6690")]
    public void SetBaseImage(AssetCachedSpawner assetLoader, RarityTypeEnum rarity)
    {
    }

    [Token(Token = "0x60169F9")]
    [Address(RVA = "0x42F6890", Offset = "0x42F6890", VA = "0x42F6890")]
    public void SetBaseImage(Sprite sprite)
    {
    }

    [Token(Token = "0x60169FA")]
    [Address(RVA = "0x42F6928", Offset = "0x42F6928", VA = "0x42F6928")]
    public void SetIconImage(Sprite sprite)
    {
    }

    [Token(Token = "0x60169FB")]
    [Address(RVA = "0x42F6790", Offset = "0x42F6790", VA = "0x42F6790")]
    public void SetRarityImage(AssetCachedSpawner assetLoader, RarityTypeEnum rarity)
    {
    }

    [Token(Token = "0x60169FC")]
    [Address(RVA = "0x42F69C0", Offset = "0x42F69C0", VA = "0x42F69C0")]
    public void SetRarityImage(Sprite sprite)
    {
    }

    [Token(Token = "0x60169FD")]
    [Address(RVA = "0x42F6A58", Offset = "0x42F6A58", VA = "0x42F6A58")]
    public MnemnographThumb()
    {
    }
  }
}
