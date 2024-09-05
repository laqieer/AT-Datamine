// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleRetreatLostUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002377")]
  public class BattleRetreatLostUI : MonoBehaviour
  {
    [Token(Token = "0x40096FA")]
    private const string LostTrackName = "Lost";
    [Token(Token = "0x40096FB")]
    private const string RetreatTrackName = "Retreat";
    [Token(Token = "0x40096FC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image charaTexture;
    [Token(Token = "0x40096FD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController lostEffectController;
    [Token(Token = "0x40096FE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup canvas;
    [Token(Token = "0x40096FF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CapturedBlurTexture capture;
    [Token(Token = "0x4009700")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private IllustLayoutComponent layoutComponent;
    [Token(Token = "0x4009701")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject LpObject;
    [Token(Token = "0x4009702")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image glowEff;
    [Token(Token = "0x4009703")]
    private const string ABTag = "RetreatLostChara";
    [Token(Token = "0x4009704")]
    [FieldOffset(Offset = "0x50")]
    private Color glowEffColor;

    [Token(Token = "0x17002E94")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D89F"), Address(RVA = "0x1B97BE8", Offset = "0x1B97BE8", VA = "0x1B97BE8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D8A0")]
    [Address(RVA = "0x1B97C04", Offset = "0x1B97C04", VA = "0x1B97C04")]
    public IEnumerator InitializeCoroutine() => (IEnumerator) null;

    [Token(Token = "0x600D8A1")]
    [Address(RVA = "0x1B97C94", Offset = "0x1B97C94", VA = "0x1B97C94")]
    public IEnumerator SetUpPlay(
      UnitParameterData unit,
      bool isAutoBattlePauseUnitLost,
      bool enableLost,
      UIManager uIManager,
      UnityAction onCompleted = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D8A2")]
    [Address(RVA = "0x1B97D64", Offset = "0x1B97D64", VA = "0x1B97D64")]
    public void SetCharaImage(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D8A3")]
    [Address(RVA = "0x1B97E44", Offset = "0x1B97E44", VA = "0x1B97E44")]
    private void OnCompleted(UnityAction action)
    {
    }

    [Token(Token = "0x600D8A4")]
    [Address(RVA = "0x1B97F14", Offset = "0x1B97F14", VA = "0x1B97F14")]
    private void OnClick(UnityAction action)
    {
    }

    [Token(Token = "0x600D8A5")]
    [Address(RVA = "0x1B97F18", Offset = "0x1B97F18", VA = "0x1B97F18")]
    public BattleRetreatLostUI()
    {
    }
  }
}
