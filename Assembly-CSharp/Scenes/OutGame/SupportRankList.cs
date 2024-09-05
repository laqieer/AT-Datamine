// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SupportRankList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003272")]
  public class SupportRankList : MonoBehaviour
  {
    [Token(Token = "0x400D7EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400D7EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400D7F0")]
    private const string inoutTimeLineAssetbundleName = "ui_page_outgame_supportlist_timeline";
    [Token(Token = "0x400D7F1")]
    private const string inoutTimeLineAssetName = "Support_List";
    [Token(Token = "0x400D7F2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400D7F3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI charaNameText;
    [Token(Token = "0x400D7F4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image targetCharaImage;
    [Token(Token = "0x400D7F5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI targetCharaNameText;
    [Token(Token = "0x400D7F6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI supportValueText;
    [Token(Token = "0x400D7F7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform supportValueGauge;
    [Token(Token = "0x400D7F8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI supportRankText;
    [Token(Token = "0x400D7F9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI supportRankMark;
    [Token(Token = "0x400D7FA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SupportThumbColum srcListItem;
    [Token(Token = "0x400D7FB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400D7FC")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D7FD")]
    [FieldOffset(Offset = "0x80")]
    private int character1ID;
    [Token(Token = "0x400D7FE")]
    [FieldOffset(Offset = "0x84")]
    private int character2ID;
    [Token(Token = "0x400D7FF")]
    [FieldOffset(Offset = "0x88")]
    private List<UnitSupportData> supportDataList;
    [Token(Token = "0x400D800")]
    [FieldOffset(Offset = "0x90")]
    private List<SupportThumbColum.stSupportThumb> supportThumbList;
    [Token(Token = "0x400D801")]
    [FieldOffset(Offset = "0x98")]
    private int currentSelectIndex;
    [Token(Token = "0x400D802")]
    [FieldOffset(Offset = "0x9C")]
    private bool isLoadAssetBundle;
    [Token(Token = "0x400D803")]
    [FieldOffset(Offset = "0x9D")]
    private bool isTimelineDirection;
    [Token(Token = "0x400D804")]
    [FieldOffset(Offset = "0xA0")]
    private readonly Func<string>[] rankText;
    [Token(Token = "0x400D805")]
    [FieldOffset(Offset = "0xA8")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6013AE7")]
    [Address(RVA = "0x18530F0", Offset = "0x18530F0", VA = "0x18530F0")]
    private void Update()
    {
    }

    [Token(Token = "0x6013AE8")]
    [Address(RVA = "0x185310C", Offset = "0x185310C", VA = "0x185310C")]
    public void Initialize(int characterID)
    {
    }

    [Token(Token = "0x6013AE9")]
    [Address(RVA = "0x185472C", Offset = "0x185472C", VA = "0x185472C")]
    private void Close()
    {
    }

    [Token(Token = "0x6013AEA")]
    [Address(RVA = "0x18541FC", Offset = "0x18541FC", VA = "0x18541FC")]
    private void SetCharacter2(UnitSupportData supportData)
    {
    }

    [Token(Token = "0x6013AEB")]
    [Address(RVA = "0x18544B0", Offset = "0x18544B0", VA = "0x18544B0")]
    private bool GetRunkPlusMark(SupportRankTypeEnum rank) => new bool();

    [Token(Token = "0x6013AEC")]
    [Address(RVA = "0x18544D0", Offset = "0x18544D0", VA = "0x18544D0")]
    private IEnumerator SetLoadAssetBndle(bool first) => (IEnumerator) null;

    [Token(Token = "0x6013AED")]
    [Address(RVA = "0x185454C", Offset = "0x185454C", VA = "0x185454C")]
    private void SetChatacter1FullImage()
    {
    }

    [Token(Token = "0x6013AEE")]
    [Address(RVA = "0x18545FC", Offset = "0x18545FC", VA = "0x18545FC")]
    private void SetChatacter2FullImage()
    {
    }

    [Token(Token = "0x6013AEF")]
    [Address(RVA = "0x18547FC", Offset = "0x18547FC", VA = "0x18547FC")]
    private void SetCharacterFullImage(Image image, int styleId)
    {
    }

    [Token(Token = "0x6013AF0")]
    [Address(RVA = "0x18546AC", Offset = "0x18546AC", VA = "0x18546AC")]
    private IEnumerator playTimeline(UITimelineController.DirectionType inout, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013AF1")]
    [Address(RVA = "0x1854958", Offset = "0x1854958", VA = "0x1854958")]
    public SupportRankList()
    {
    }
  }
}
