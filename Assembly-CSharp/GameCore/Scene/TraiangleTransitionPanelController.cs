// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.TraiangleTransitionPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C9B")]
  public class TraiangleTransitionPanelController : LoadingPanelController
  {
    [Token(Token = "0x40038CD")]
    private const string TWEEN_IN_KEY = "In";
    [Token(Token = "0x40038CE")]
    private const string TWEEN_OUT_KEY = "Out";
    [Token(Token = "0x40038CF")]
    private const string MATERIAL_LABEL = "materials";
    [Token(Token = "0x40038D0")]
    private const string SPRITE_ATLAS_LABEL = "2dassets_ui_transition_common";
    [Token(Token = "0x40038D1")]
    private const string MATERIAL_OPEN_NAME = "Com_Transition_open";
    [Token(Token = "0x40038D2")]
    private const string MATERIAL_CLOSE_NAME = "Com_Transition_close";
    [Token(Token = "0x40038D3")]
    private const string MATERIAL_OPEN_LINE_NAME = "Com_TransitionLine_open";
    [Token(Token = "0x40038D4")]
    private const string MATERIAL_CLOSE_LINE_NAME = "Com_TransitionLine_close";
    [Token(Token = "0x40038D5")]
    private const string SPRITE_TRANSITION_PATTERN_NAME = "Cmn_Transition_Pattern";
    [Token(Token = "0x40038D6")]
    private const string SPRITE_TRANSITION_LINE_NAME = "Cmn_Transition_Line";
    [Token(Token = "0x40038D7")]
    private const string SPRITE_ATLAS_NAME = "transition";
    [Token(Token = "0x40038D8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40038D9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image transitionLineOpenImage;
    [Token(Token = "0x40038DA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image transitionPatternOpenImage;
    [Token(Token = "0x40038DB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image transitionLineCloseImage;
    [Token(Token = "0x40038DC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image transitionPatternCloseImage;

    [Token(Token = "0x60048C5")]
    [Address(RVA = "0x3132D54", Offset = "0x3132D54", VA = "0x3132D54", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60048C6")]
    [Address(RVA = "0x3132D58", Offset = "0x3132D58", VA = "0x3132D58", Slot = "5")]
    public override IEnumerator SetAssetData(AssetBundleManager manager) => (IEnumerator) null;

    [Token(Token = "0x60048C7")]
    [Address(RVA = "0x3132DF4", Offset = "0x3132DF4", VA = "0x3132DF4", Slot = "7")]
    protected override IEnumerator Show() => (IEnumerator) null;

    [Token(Token = "0x60048C8")]
    [Address(RVA = "0x3132E84", Offset = "0x3132E84", VA = "0x3132E84", Slot = "8")]
    protected override void ShowImpl()
    {
    }

    [Token(Token = "0x60048C9")]
    [Address(RVA = "0x3132E88", Offset = "0x3132E88", VA = "0x3132E88", Slot = "9")]
    protected override IEnumerator Hide() => (IEnumerator) null;

    [Token(Token = "0x60048CA")]
    [Address(RVA = "0x3132F18", Offset = "0x3132F18", VA = "0x3132F18", Slot = "10")]
    protected override void HideImpl()
    {
    }

    [Token(Token = "0x60048CB")]
    [Address(RVA = "0x3132F1C", Offset = "0x3132F1C", VA = "0x3132F1C")]
    public TraiangleTransitionPanelController()
    {
    }
  }
}
