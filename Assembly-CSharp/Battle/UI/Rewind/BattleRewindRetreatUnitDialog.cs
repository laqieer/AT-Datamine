// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindRetreatUnitDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002460")]
  public class BattleRewindRetreatUnitDialog : MonoBehaviour
  {
    [Token(Token = "0x4009C06")]
    private const int InformationTextLineMax = 5;
    [Token(Token = "0x4009C07")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect unitThumbnailScrollRect;
    [Token(Token = "0x4009C08")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleRewindRetreatUnitThumbnail unitThumbnailOrigin;
    [Token(Token = "0x4009C09")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController fadeController;
    [Token(Token = "0x4009C0A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<TextContainer> playerPhaseMessages;
    [Token(Token = "0x4009C0B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x4009C0C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4009C0D")]
    [FieldOffset(Offset = "0x48")]
    private List<BattleRewindRetreatUnitThumbnail> activeDeadUnitThumbnails;
    [Token(Token = "0x4009C0E")]
    [FieldOffset(Offset = "0x50")]
    private IObjectPool<BattleRewindRetreatUnitThumbnail> unitThumbnailPool;
    [Token(Token = "0x4009C0F")]
    [FieldOffset(Offset = "0x58")]
    private UnitParameterData activeUnitParameterData;
    [Token(Token = "0x4009C10")]
    [FieldOffset(Offset = "0x60")]
    private BattleRewindUnitMessageAsset meesageAsset;
    [Token(Token = "0x4009C11")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, Sprite> unitThumbnailSprites;

    [Token(Token = "0x600DF22")]
    [Address(RVA = "0x2016DC4", Offset = "0x2016DC4", VA = "0x2016DC4")]
    public IEnumerator Initialize(Dictionary<int, Sprite> unitThumbnailSprites)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DF23")]
    [Address(RVA = "0x2017674", Offset = "0x2017674", VA = "0x2017674")]
    private void InitializeUnitThumbnail(
      BattleRewindRetreatUnitThumbnail thumbnail,
      Dictionary<int, Sprite> unitThumbnailSprites)
    {
    }

    [Token(Token = "0x600DF24")]
    [Address(RVA = "0x2014680", Offset = "0x2014680", VA = "0x2014680")]
    public void Release()
    {
    }

    [Token(Token = "0x600DF25")]
    [Address(RVA = "0x201507C", Offset = "0x201507C", VA = "0x201507C")]
    public void Show(Action callback = null)
    {
    }

    [Token(Token = "0x600DF26")]
    [Address(RVA = "0x20154DC", Offset = "0x20154DC", VA = "0x20154DC")]
    public void Hide(Action beginCallback = null, Action finishCallback = null)
    {
    }

    [Token(Token = "0x600DF27")]
    [Address(RVA = "0x2014C70", Offset = "0x2014C70", VA = "0x2014C70")]
    public void SetButtonEvent(
      Action decideBeginFunction,
      Action decideFinishFunction,
      Action closeBeginFunction,
      Action closeFinishFunction)
    {
    }

    [Token(Token = "0x600DF28")]
    [Address(RVA = "0x2017974", Offset = "0x2017974", VA = "0x2017974")]
    public void SetUp(List<UnitParameterData> dieUnits)
    {
    }

    [Token(Token = "0x600DF29")]
    [Address(RVA = "0x20185B4", Offset = "0x20185B4", VA = "0x20185B4")]
    private string GetDeadUnitMessage(
      BattleRewindUnitMessageData.MessageType type,
      string unitName = "",
      int unitNumber = 0,
      int beforeFP = 0,
      int afterFP = 0)
    {
      return (string) null;
    }

    [Token(Token = "0x600DF2A")]
    [Address(RVA = "0x2018768", Offset = "0x2018768", VA = "0x2018768")]
    public BattleRewindRetreatUnitDialog()
    {
    }
  }
}
