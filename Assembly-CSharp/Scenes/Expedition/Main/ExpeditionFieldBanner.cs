// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionFieldBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.Popup;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CB8")]
  public class ExpeditionFieldBanner : MonoBehaviour
  {
    [Token(Token = "0x400BF23")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400BF24")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image bannerImage;
    [Token(Token = "0x400BF25")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI stageLvText;
    [Token(Token = "0x400BF26")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI stageInfoText;
    [Token(Token = "0x400BF27")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI stageNameText;
    [Token(Token = "0x400BF28")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject lockObj;
    [Token(Token = "0x400BF29")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject objDestinationInfoIcon;
    [Token(Token = "0x400BF2A")]
    [FieldOffset(Offset = "0x50")]
    private ExpeditionStageSelectPopup stageSelectPrefab;
    [Token(Token = "0x400BF2B")]
    [FieldOffset(Offset = "0x58")]
    private ExpeditionStageSelectPopup stageSelectPopup;
    [Token(Token = "0x400BF2C")]
    [FieldOffset(Offset = "0x60")]
    private Action<string> OnChangeStageId;
    [Token(Token = "0x400BF2D")]
    [FieldOffset(Offset = "0x68")]
    public Action OnCloseAction;
    [Token(Token = "0x400BF2E")]
    [FieldOffset(Offset = "0x70")]
    private PlayerExpeditionStageType stageType;
    [Token(Token = "0x400BF2F")]
    [FieldOffset(Offset = "0x78")]
    private bool isStageSelect;
    [Token(Token = "0x400BF30")]
    [FieldOffset(Offset = "0x79")]
    private bool isSelect;
    [Token(Token = "0x400BF31")]
    [FieldOffset(Offset = "0x7A")]
    private bool isEmpty;
    [Token(Token = "0x400BF32")]
    [FieldOffset(Offset = "0x7B")]
    private bool isButtonInteractable;
    [Token(Token = "0x400BF33")]
    [FieldOffset(Offset = "0x7C")]
    private bool isBoss;
    [Token(Token = "0x400BF34")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17003C2E")]
    public int StageId
    {
      [Token(Token = "0x60117D8"), Address(RVA = "0x4942B00", Offset = "0x4942B00", VA = "0x4942B00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60117D9")]
    [Address(RVA = "0x49414B4", Offset = "0x49414B4", VA = "0x49414B4")]
    public void Initialize(
      Action<string> onChangeStageId,
      bool isStageSelect,
      bool isButtonInteractable,
      bool isBoss,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60117DA")]
    [Address(RVA = "0x493A28C", Offset = "0x493A28C", VA = "0x493A28C")]
    public void SetData(PlayerExpeditionStageType stageType)
    {
    }

    [Token(Token = "0x60117DB")]
    [Address(RVA = "0x4942B1C", Offset = "0x4942B1C", VA = "0x4942B1C")]
    public void ChangeSelect(bool isSelect)
    {
    }

    [Token(Token = "0x60117DC")]
    [Address(RVA = "0x493A884", Offset = "0x493A884", VA = "0x493A884")]
    public void ShowEmpty()
    {
    }

    [Token(Token = "0x60117DD")]
    [Address(RVA = "0x493EFB4", Offset = "0x493EFB4", VA = "0x493EFB4")]
    public void OnBannerButton()
    {
    }

    [Token(Token = "0x60117DE")]
    [Address(RVA = "0x4942C14", Offset = "0x4942C14", VA = "0x4942C14")]
    public ExpeditionFieldBanner()
    {
    }
  }
}
