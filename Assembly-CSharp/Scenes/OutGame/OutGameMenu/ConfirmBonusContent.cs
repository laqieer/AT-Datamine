// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConfirmBonusContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A57")]
  public class ConfirmBonusContent : MonoBehaviour
  {
    [Token(Token = "0x400FFB8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject limitBreakParent;
    [Token(Token = "0x400FFB9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject rarityParent;
    [Token(Token = "0x400FFBA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image[] rarityIconBefore;
    [Token(Token = "0x400FFBB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image[] rarityIconAfter;
    [Token(Token = "0x400FFBC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text bonusText;
    [Token(Token = "0x400FFBD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private DetailSkillListThumb skillListThumb;

    [Token(Token = "0x6016EE8")]
    [Address(RVA = "0x29BF7C8", Offset = "0x29BF7C8", VA = "0x29BF7C8")]
    public void SetLimitBreakData(
      Style style,
      RarityStyleData before,
      RarityStyleData after,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6016EE9")]
    [Address(RVA = "0x29BFCC8", Offset = "0x29BFCC8", VA = "0x29BFCC8")]
    public void SetRarityUpData(
      Style style,
      RarityStyleData before,
      RarityStyleData after,
      Sprite blueStar,
      Sprite blackStar)
    {
    }

    [Token(Token = "0x6016EEA")]
    [Address(RVA = "0x29BFFE0", Offset = "0x29BFFE0", VA = "0x29BFFE0")]
    private void SetRarityStar(Image[] array, int rarity, Sprite blue, Sprite black)
    {
    }

    [Token(Token = "0x6016EEB")]
    [Address(RVA = "0x29C0098", Offset = "0x29C0098", VA = "0x29C0098")]
    public ConfirmBonusContent()
    {
    }
  }
}
