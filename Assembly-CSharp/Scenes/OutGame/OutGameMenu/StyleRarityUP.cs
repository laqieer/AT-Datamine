// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleRarityUP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A78")]
  public class StyleRarityUP : MonoBehaviour
  {
    [Token(Token = "0x401005C")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x401005D")]
    private const string PLAY_VOICE_RARITY_UP = "0016";
    [Token(Token = "0x401005E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x401005F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text rewardText;
    [Token(Token = "0x4010060")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image[] iconBefore;
    [Token(Token = "0x4010061")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private LimitBreakIcons beforeGem;
    [Token(Token = "0x4010062")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image[] iconAfter;
    [Token(Token = "0x4010063")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private LimitBreakIcons afterGem;
    [Token(Token = "0x4010064")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject needMaterialLabel;
    [Token(Token = "0x4010065")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ItemIcon needMaterialThumb;
    [Token(Token = "0x4010066")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4010067")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton rarityUPButton;
    [Token(Token = "0x4010068")]
    [FieldOffset(Offset = "0x68")]
    private bool canRarityUp;
    [Token(Token = "0x4010069")]
    [FieldOffset(Offset = "0x70")]
    private string toasterMsg;
    [Token(Token = "0x401006A")]
    [FieldOffset(Offset = "0x78")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x401006B")]
    [FieldOffset(Offset = "0x80")]
    private Style dispStyle;
    [Token(Token = "0x401006C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Color warningColor;
    [Token(Token = "0x401006D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x401006E")]
    [FieldOffset(Offset = "0xA8")]
    private bool isEnoughCost;
    [Token(Token = "0x401006F")]
    [FieldOffset(Offset = "0xA9")]
    private bool isConnect;
    [Token(Token = "0x4010070")]
    [FieldOffset(Offset = "0xAA")]
    private bool isDirection;

    [Token(Token = "0x17004B49")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6016FAC"), Address(RVA = "0x29C5EC4", Offset = "0x29C5EC4", VA = "0x29C5EC4")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6016FAD")]
    [Address(RVA = "0x29C5EE0", Offset = "0x29C5EE0", VA = "0x29C5EE0")]
    public void Initialize(StyleStatusSubScene statusSubScene, Style style)
    {
    }

    [Token(Token = "0x6016FAE")]
    [Address(RVA = "0x29C60D4", Offset = "0x29C60D4", VA = "0x29C60D4")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x6016FAF")]
    [Address(RVA = "0x29C661C", Offset = "0x29C661C", VA = "0x29C661C")]
    private void SetMaterialIcon(
      ItemTypeEnum itemTypeEnum,
      int id,
      int needAMount,
      int possessionAmount)
    {
    }

    [Token(Token = "0x6016FB0")]
    [Address(RVA = "0x29C66FC", Offset = "0x29C66FC", VA = "0x29C66FC")]
    private bool CanRarityUP(out string errorMessage) => new bool();

    [Token(Token = "0x6016FB1")]
    [Address(RVA = "0x29C6864", Offset = "0x29C6864", VA = "0x29C6864")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016FB2")]
    [Address(RVA = "0x29C68FC", Offset = "0x29C68FC", VA = "0x29C68FC")]
    private IEnumerator ConnectToApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6016FB3")]
    [Address(RVA = "0x29C6998", Offset = "0x29C6998", VA = "0x29C6998")]
    private IEnumerator EffectRarityUp() => (IEnumerator) null;

    [Token(Token = "0x6016FB4")]
    [Address(RVA = "0x29C6A28", Offset = "0x29C6A28", VA = "0x29C6A28")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x6016FB5")]
    [Address(RVA = "0x29C6A5C", Offset = "0x29C6A5C", VA = "0x29C6A5C")]
    public StyleRarityUP()
    {
    }
  }
}
