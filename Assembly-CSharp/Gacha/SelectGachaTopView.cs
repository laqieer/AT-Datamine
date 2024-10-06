// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGachaTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200156B")]
  internal class SelectGachaTopView : GachaTopView
  {
    [Token(Token = "0x400623B")]
    private const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x400623C")]
    private const string AssetName = "Container_SelectGachaTop";
    [Token(Token = "0x400623D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("スタイル")]
    [Space(10f)]
    private GameObject styleNameRoot;
    [Token(Token = "0x400623E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject styleImageRoot;
    [Token(Token = "0x400623F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI characterName;
    [Token(Token = "0x4006240")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x4006241")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Image styleImage;
    [Token(Token = "0x4006242")]
    [FieldOffset(Offset = "0x80")]
    [Header("念装")]
    [SerializeField]
    [Space(10f)]
    private GameObject mnemnographNameRoot;
    [Token(Token = "0x4006243")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject mnemnographImageRoot;
    [Token(Token = "0x4006244")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI mnemnographName;
    [Token(Token = "0x4006245")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private MnemnographDetailCenter mnemnographImage;
    [Token(Token = "0x4006246")]
    [FieldOffset(Offset = "0xA0")]
    [Header("現在回数")]
    [Space(10f)]
    [SerializeField]
    private SelectGachaCountView selectGachaCount;
    [Token(Token = "0x4006247")]
    [FieldOffset(Offset = "0xA8")]
    [Space(10f)]
    [Header("選択ボタン")]
    [SerializeField]
    private CommonButton selectButton;
    [Token(Token = "0x4006248")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4006249")]
    [FieldOffset(Offset = "0xB8")]
    public Action OnSelectButtonClicked;

    [Token(Token = "0x600793B")]
    [Address(RVA = "0x2294DF0", Offset = "0x2294DF0", VA = "0x2294DF0")]
    public new static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600793C")]
    [Address(RVA = "0x2294E70", Offset = "0x2294E70", VA = "0x2294E70")]
    public static IEnumerator Create(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<SelectGachaTopView> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600793D")]
    [Address(RVA = "0x2294F14", Offset = "0x2294F14", VA = "0x2294F14", Slot = "10")]
    public override IEnumerator Initialize(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x600793E")]
    [Address(RVA = "0x2294CF4", Offset = "0x2294CF4", VA = "0x2294CF4")]
    public void Hide()
    {
    }

    [Token(Token = "0x600793F")]
    [Address(RVA = "0x2294FB0", Offset = "0x2294FB0", VA = "0x2294FB0")]
    private void SetActiveViewType(SelectGachaTopView.ViewType viewType)
    {
    }

    [Token(Token = "0x6007940")]
    [Address(RVA = "0x2294CC4", Offset = "0x2294CC4", VA = "0x2294CC4")]
    public void SetSelectGachaCount(int count)
    {
    }

    [Token(Token = "0x6007941")]
    [Address(RVA = "0x2294C54", Offset = "0x2294C54", VA = "0x2294C54")]
    public void SetupStyle(int id)
    {
    }

    [Token(Token = "0x6007942")]
    [Address(RVA = "0x2295044", Offset = "0x2295044", VA = "0x2295044")]
    private void SetStyleName(int styleId)
    {
    }

    [Token(Token = "0x6007943")]
    [Address(RVA = "0x22951B0", Offset = "0x22951B0", VA = "0x22951B0")]
    private void SetStyleImage(int id)
    {
    }

    [Token(Token = "0x6007944")]
    [Address(RVA = "0x229524C", Offset = "0x229524C", VA = "0x229524C")]
    private IEnumerator SetStyleImageAsync(int id) => (IEnumerator) null;

    [Token(Token = "0x6007945")]
    [Address(RVA = "0x2294C8C", Offset = "0x2294C8C", VA = "0x2294C8C")]
    public void SetupMnemnograph(int id)
    {
    }

    [Token(Token = "0x6007946")]
    [Address(RVA = "0x22952EC", Offset = "0x22952EC", VA = "0x22952EC")]
    private void SetMnemnographName(int id)
    {
    }

    [Token(Token = "0x6007947")]
    [Address(RVA = "0x22953C0", Offset = "0x22953C0", VA = "0x22953C0")]
    private void SetMnemnographImage(int id)
    {
    }

    [Token(Token = "0x6007948")]
    [Address(RVA = "0x2295414", Offset = "0x2295414", VA = "0x2295414")]
    public SelectGachaTopView()
    {
    }

    [Token(Token = "0x200156C")]
    private enum ViewType
    {
      [Token(Token = "0x400624B")] Style,
      [Token(Token = "0x400624C")] Mnemnograph,
    }
  }
}
