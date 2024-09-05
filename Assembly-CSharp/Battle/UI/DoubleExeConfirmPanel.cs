// Decompiled with JetBrains decompiler
// Type: Battle.UI.DoubleExeConfirmPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023D7")]
  public class DoubleExeConfirmPanel : MonoBehaviour
  {
    [Token(Token = "0x40098E6")]
    [FieldOffset(Offset = "0x18")]
    private readonly Color ADD_PARAMETER_COLOR_PLUS;
    [Token(Token = "0x40098E7")]
    [FieldOffset(Offset = "0x28")]
    private readonly Color ADD_PARAMETER_COLOR_MINUS;
    [Token(Token = "0x40098E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40098E9")]
    [FieldOffset(Offset = "0x40")]
    [Header("前衛ユニット")]
    [SerializeField]
    private TextMeshProUGUI frontUnitName;
    [Token(Token = "0x40098EA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image frontUnitImage;
    [Token(Token = "0x40098EB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text supportSkillRank;
    [Token(Token = "0x40098EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text frontUnitLevel;
    [Token(Token = "0x40098ED")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text frontUnitSupportSkillName;
    [Token(Token = "0x40098EE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<Text> frontUnitBaseParameter;
    [Token(Token = "0x40098EF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<Text> frontUnitAddParameter;
    [Token(Token = "0x40098F0")]
    [FieldOffset(Offset = "0x78")]
    [Header("後衛ユニット")]
    [SerializeField]
    private TextMeshProUGUI backUnitName;
    [Token(Token = "0x40098F1")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image backUnitImage;
    [Token(Token = "0x40098F2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text backUnitSupportSkillName;
    [Token(Token = "0x40098F3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CanvasGroup releaseUIAnim;
    [Token(Token = "0x40098F4")]
    [FieldOffset(Offset = "0x98")]
    private IEnumerator currentRoutine;
    [Token(Token = "0x40098F5")]
    [FieldOffset(Offset = "0xA0")]
    private bool showDoubleRelease;

    [Token(Token = "0x600DB9A")]
    [Address(RVA = "0x214EDA4", Offset = "0x214EDA4", VA = "0x214EDA4")]
    private new Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600DB9B")]
    [Address(RVA = "0x214EDE8", Offset = "0x214EDE8", VA = "0x214EDE8")]
    public IEnumerator InitializeCoroutine(IDirector director) => (IEnumerator) null;

    [Token(Token = "0x600DB9C")]
    [Address(RVA = "0x214EE78", Offset = "0x214EE78", VA = "0x214EE78")]
    public void ShowRunDoubleConfirm(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BoardData boardData,
      Action finishCallback)
    {
    }

    [Token(Token = "0x600DB9D")]
    [Address(RVA = "0x214EEE4", Offset = "0x214EEE4", VA = "0x214EEE4")]
    private IEnumerator IEShowRunDoubleConfirm(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BoardData boardData,
      Action finishCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DB9E")]
    [Address(RVA = "0x214EF9C", Offset = "0x214EF9C", VA = "0x214EF9C")]
    public void ShowDoubleParam(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BoardData boardData,
      CommandType commandType)
    {
    }

    [Token(Token = "0x600DB9F")]
    [Address(RVA = "0x214F008", Offset = "0x214F008", VA = "0x214F008")]
    private IEnumerator IEShowDoubleParam(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BoardData boardData,
      CommandType commandType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DBA0")]
    [Address(RVA = "0x214F0C0", Offset = "0x214F0C0", VA = "0x214F0C0")]
    private void SetUnitParam(
      UnitParameterData frontUnit,
      UnitParameterData backUnit,
      BoardData boardData,
      bool isReleaseDouble)
    {
    }

    [Token(Token = "0x600DBA1")]
    [Address(RVA = "0x2150598", Offset = "0x2150598", VA = "0x2150598")]
    public void Hide(Action completeAction = null)
    {
    }

    [Token(Token = "0x600DBA2")]
    [Address(RVA = "0x21505F0", Offset = "0x21505F0", VA = "0x21505F0")]
    private IEnumerator IEHide(Action completeAction = null) => (IEnumerator) null;

    [Token(Token = "0x600DBA3")]
    [Address(RVA = "0x21504D4", Offset = "0x21504D4", VA = "0x21504D4")]
    private string GetSupportActionCategoryName(SkillParameterData supportSkill) => (string) null;

    [Token(Token = "0x600DBA4")]
    [Address(RVA = "0x215068C", Offset = "0x215068C", VA = "0x215068C")]
    public DoubleExeConfirmPanel()
    {
    }

    [Token(Token = "0x20023D8")]
    private enum Type
    {
      [Token(Token = "0x40098F7")] PhysicalAttack,
      [Token(Token = "0x40098F8")] MagicalAttack,
      [Token(Token = "0x40098F9")] PhysicalDefence,
      [Token(Token = "0x40098FA")] MagicalDefence,
      [Token(Token = "0x40098FB")] Hit,
      [Token(Token = "0x40098FC")] Avoid,
      [Token(Token = "0x40098FD")] Critical,
      [Token(Token = "0x40098FE")] CriticalAvoid,
    }
  }
}
