// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldPredictionUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic.Prediction;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023F9")]
  public class FieldPredictionUnit : MonoBehaviour
  {
    [Token(Token = "0x40099A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40099A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FieldUnitStatusBase frontUnitStatus;
    [Token(Token = "0x40099A7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private FieldUnitStatusBase backUnitStatus;
    [Token(Token = "0x40099A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40099A9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ToasterUI skillWarningToaster;
    [Token(Token = "0x40099AA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton skillWarningToasterButton;
    [Token(Token = "0x40099AB")]
    [FieldOffset(Offset = "0x48")]
    private string prevViewElementType;
    [Token(Token = "0x40099AC")]
    [FieldOffset(Offset = "0x50")]
    private UnityAction tweenCallback;
    [Token(Token = "0x40099AD")]
    [FieldOffset(Offset = "0x58")]
    private int viewBadStatusIndex;
    [Token(Token = "0x40099AE")]
    [FieldOffset(Offset = "0x60")]
    private List<string> tweenPlayList;

    [Token(Token = "0x17002F63")]
    public UITimelineController TimelineController
    {
      [Token(Token = "0x600DC68"), Address(RVA = "0x21581E0", Offset = "0x21581E0", VA = "0x21581E0")] get
      {
        return (UITimelineController) null;
      }
    }

    [Token(Token = "0x600DC69")]
    [Address(RVA = "0x21573A8", Offset = "0x21573A8", VA = "0x21573A8")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x600DC6A")]
    [Address(RVA = "0x2158210", Offset = "0x2158210", VA = "0x2158210")]
    private void SetUpWarningToaster()
    {
    }

    [Token(Token = "0x600DC6B")]
    [Address(RVA = "0x2156150", Offset = "0x2156150", VA = "0x2156150")]
    public void SetMainAsPrediction(UnitParameterData unit, PredictionUnitResult predictionResult)
    {
    }

    [Token(Token = "0x600DC6C")]
    [Address(RVA = "0x2156D50", Offset = "0x2156D50", VA = "0x2156D50")]
    public void SetItemAsPrediction(
      UnitParameterData unit,
      ItemParameterData battleItem,
      PredictionUnitResult predictionResult)
    {
    }

    [Token(Token = "0x600DC6D")]
    [Address(RVA = "0x21582FC", Offset = "0x21582FC", VA = "0x21582FC")]
    public void SetMainAsDetail(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DC6E")]
    [Address(RVA = "0x215659C", Offset = "0x215659C", VA = "0x215659C")]
    public void ShowFrontUnit()
    {
    }

    [Token(Token = "0x600DC6F")]
    [Address(RVA = "0x2156A38", Offset = "0x2156A38", VA = "0x2156A38")]
    public void HideFrontUnit()
    {
    }

    [Token(Token = "0x600DC70")]
    [Address(RVA = "0x21582DC", Offset = "0x21582DC", VA = "0x21582DC")]
    public void ShowSupportUnit()
    {
    }

    [Token(Token = "0x600DC71")]
    [Address(RVA = "0x2156A58", Offset = "0x2156A58", VA = "0x2156A58")]
    public void HideSupportUnit()
    {
    }

    [Token(Token = "0x600DC72")]
    [Address(RVA = "0x21565BC", Offset = "0x21565BC", VA = "0x21565BC")]
    public void SetUpTweenToUpdatePredictionPanel(
      PredictionUnitResult simulateData,
      ForceTypeEnum force = ForceTypeEnum.Ally)
    {
    }

    [Token(Token = "0x600DC73")]
    [Address(RVA = "0x2155700", Offset = "0x2155700", VA = "0x2155700")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x600DC74")]
    [Address(RVA = "0x2158300", Offset = "0x2158300", VA = "0x2158300")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x600DC75")]
    [Address(RVA = "0x2156954", Offset = "0x2156954", VA = "0x2156954")]
    public void PlayTweenPlayList()
    {
    }

    [Token(Token = "0x600DC76")]
    [Address(RVA = "0x2157788", Offset = "0x2157788", VA = "0x2157788")]
    public void StopTween()
    {
    }

    [Token(Token = "0x600DC77")]
    [Address(RVA = "0x21569E0", Offset = "0x21569E0", VA = "0x21569E0")]
    public void ShowWarningToasterButton()
    {
    }

    [Token(Token = "0x600DC78")]
    [Address(RVA = "0x21554D0", Offset = "0x21554D0", VA = "0x21554D0")]
    public void HideWarningToasterButton()
    {
    }

    [Token(Token = "0x600DC79")]
    [Address(RVA = "0x21583A8", Offset = "0x21583A8", VA = "0x21583A8")]
    public FieldPredictionUnit()
    {
    }
  }
}
