// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ContentRecommendSubView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008C2")]
  public class ContentRecommendSubView : MonoBehaviour
  {
    [Token(Token = "0x4002904")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x4002905")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _lockObj;
    [Token(Token = "0x4002906")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI _apText;
    [Token(Token = "0x4002907")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI _epText;
    [Token(Token = "0x4002908")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI _difficultyText;
    [Token(Token = "0x4002909")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image _difficultyBase;
    [Token(Token = "0x400290A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Color _normalColor;
    [Token(Token = "0x400290B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Color _hardColor;
    [Token(Token = "0x400290C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Color _veryhardColor;
    [Token(Token = "0x400290D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject _difficulty;
    [Token(Token = "0x400290E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject _campaign;
    [Token(Token = "0x400290F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ContentRecommendSubView.ContainerInfos _infos;
    [Token(Token = "0x4002910")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton _button;
    [Token(Token = "0x4002911")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("ロック時操作用")]
    private CanvasGroup _canvas;
    [Token(Token = "0x4002912")]
    [FieldOffset(Offset = "0xA0")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x4002913")]
    [FieldOffset(Offset = "0xA8")]
    private Queue<Action> _loadAssetQueue;

    [Token(Token = "0x60031A9")]
    [Address(RVA = "0x3C1A7CC", Offset = "0x3C1A7CC", VA = "0x3C1A7CC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60031AA")]
    [Address(RVA = "0x3C1A858", Offset = "0x3C1A858", VA = "0x3C1A858")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60031AB")]
    [Address(RVA = "0x3C1A860", Offset = "0x3C1A860", VA = "0x3C1A860")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60031AC")]
    [Address(RVA = "0x3C1A8FC", Offset = "0x3C1A8FC", VA = "0x3C1A8FC")]
    public void SetIsLock(bool isLock)
    {
    }

    [Token(Token = "0x60031AD")]
    [Address(RVA = "0x3C1AA3C", Offset = "0x3C1AA3C", VA = "0x3C1AA3C")]
    public void SetInfos(bool isEnabled)
    {
    }

    [Token(Token = "0x60031AE")]
    [Address(RVA = "0x3C1AA64", Offset = "0x3C1AA64", VA = "0x3C1AA64")]
    public void SetDropRewards(bool isDrop)
    {
    }

    [Token(Token = "0x60031AF")]
    [Address(RVA = "0x3C1AB24", Offset = "0x3C1AB24", VA = "0x3C1AB24")]
    public void SetClearRewards(bool isClear)
    {
    }

    [Token(Token = "0x60031B0")]
    [Address(RVA = "0x3C1AB48", Offset = "0x3C1AB48", VA = "0x3C1AB48")]
    public void SetCanSkip(bool canSkip)
    {
    }

    [Token(Token = "0x60031B1")]
    [Address(RVA = "0x3C1AB6C", Offset = "0x3C1AB6C", VA = "0x3C1AB6C")]
    public void SetConsume(int? ap, int? ep)
    {
    }

    [Token(Token = "0x60031B2")]
    [Address(RVA = "0x3C1AD30", Offset = "0x3C1AD30", VA = "0x3C1AD30")]
    public void SetDifficulty(QuestDifficultyTypeEnum? difficultyType = null)
    {
    }

    [Token(Token = "0x60031B3")]
    [Address(RVA = "0x3C1AEE4", Offset = "0x3C1AEE4", VA = "0x3C1AEE4")]
    public void SetButton(Action eventClicked)
    {
    }

    [Token(Token = "0x60031B4")]
    private void LoadAsset<T>(string abName, string assetName, Action<T> callback) where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x60031B5")]
    [Address(RVA = "0x3C1B024", Offset = "0x3C1B024", VA = "0x3C1B024")]
    public ContentRecommendSubView()
    {
    }

    [Token(Token = "0x20008C3")]
    [Serializable]
    private class ContainerInfo
    {
      [Token(Token = "0x4002914")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject leftBar;
      [Token(Token = "0x4002915")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject body;

      [Token(Token = "0x60031B6")]
      [Address(RVA = "0x3C1AA88", Offset = "0x3C1AA88", VA = "0x3C1AA88")]
      public void SetActive(bool isEnabled)
      {
      }

      [Token(Token = "0x60031B7")]
      [Address(RVA = "0x3C1B0B0", Offset = "0x3C1B0B0", VA = "0x3C1B0B0")]
      public ContainerInfo()
      {
      }
    }

    [Token(Token = "0x20008C4")]
    [Serializable]
    private class ContainerInfos
    {
      [Token(Token = "0x4002916")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x4002917")]
      [FieldOffset(Offset = "0x18")]
      public ContentRecommendSubView.ContainerInfo dropRewards;
      [Token(Token = "0x4002918")]
      [FieldOffset(Offset = "0x20")]
      public ContentRecommendSubView.ContainerInfo clearRewards;
      [Token(Token = "0x4002919")]
      [FieldOffset(Offset = "0x28")]
      public ContentRecommendSubView.ContainerInfo canSkip;
      [Token(Token = "0x400291A")]
      [FieldOffset(Offset = "0x30")]
      public ContentRecommendSubView.ContainerInfo consumeAp;
      [Token(Token = "0x400291B")]
      [FieldOffset(Offset = "0x38")]
      public ContentRecommendSubView.ContainerInfo consumeEp;

      [Token(Token = "0x60031B8")]
      [Address(RVA = "0x3C1B0B8", Offset = "0x3C1B0B8", VA = "0x3C1B0B8")]
      public ContainerInfos()
      {
      }
    }
  }
}
