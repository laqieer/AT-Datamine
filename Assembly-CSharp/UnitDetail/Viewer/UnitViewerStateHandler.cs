// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewerStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame;
using System.Collections.Generic;
using UnitDetail.State;
using UnitDetail.Viewer.State;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004BC")]
  public class UnitViewerStateHandler : UnitDetailStateHandlerBase
  {
    [Token(Token = "0x4001906")]
    [FieldOffset(Offset = "0x0")]
    private static string OpenViewerUIAnimation;
    [Token(Token = "0x4001907")]
    [FieldOffset(Offset = "0x8")]
    private static string CloseViewerUIAnimation;
    [Token(Token = "0x4001908")]
    [FieldOffset(Offset = "0x10")]
    private static string OpenProfileAnimation;
    [Token(Token = "0x4001909")]
    [FieldOffset(Offset = "0x18")]
    private static string CloseProfileAnimation;
    [Token(Token = "0x400190A")]
    [FieldOffset(Offset = "0x20")]
    private static string OpenMotionListAnimation;
    [Token(Token = "0x400190B")]
    [FieldOffset(Offset = "0x28")]
    private static string CloseMotionListAnimation;
    [Token(Token = "0x400190C")]
    [FieldOffset(Offset = "0x30")]
    private static string OpenVoiceListAnimation;
    [Token(Token = "0x400190D")]
    [FieldOffset(Offset = "0x38")]
    private static string CloseVoiceListAnimation;
    [Token(Token = "0x400190E")]
    [FieldOffset(Offset = "0x28")]
    private string[] sexStrings;
    [Token(Token = "0x400190F")]
    [FieldOffset(Offset = "0x40")]
    public static IReadOnlyDictionary<UnitViewerStateHandler.SubStateIndices, string> SwitchOverViewerTextDic;
    [Token(Token = "0x4001910")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001911")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text switchOverViewerText;
    [Token(Token = "0x4001912")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text birthPlace;
    [Token(Token = "0x4001913")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text sex;
    [Token(Token = "0x4001914")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text birthDay;
    [Token(Token = "0x4001915")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text favorite;
    [Token(Token = "0x4001916")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text dislike;
    [Token(Token = "0x4001917")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text height;
    [Token(Token = "0x4001918")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text weight;
    [Token(Token = "0x4001919")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text bustSize;
    [Token(Token = "0x400191A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text waistSize;
    [Token(Token = "0x400191B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text hipSize;
    [Token(Token = "0x400191C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text profile;
    [Token(Token = "0x400191D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private MotionScrollListPane motionScrollListPane;
    [Token(Token = "0x400191E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private VoiceScrollListPane voiceScrollListPane;
    [Token(Token = "0x400191F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4001920")]
    [FieldOffset(Offset = "0xB0")]
    private UnitViewerStateHandler.UnitViewerSubStateMachine subStateMachine;
    [Token(Token = "0x4001921")]
    [FieldOffset(Offset = "0xB8")]
    private UnitViewerStateHandler.Orientation orientation;
    [Token(Token = "0x4001922")]
    [FieldOffset(Offset = "0xBC")]
    private UnitViewerStateHandler.SelectionIndices selection;
    [Token(Token = "0x4001923")]
    [FieldOffset(Offset = "0xC0")]
    private Dictionary<UnitViewerStateHandler.SubStateIndices, ViewerSubState> subStateDic;
    [Token(Token = "0x4001924")]
    [FieldOffset(Offset = "0xC8")]
    private bool isAr;
    [Token(Token = "0x4001925")]
    [FieldOffset(Offset = "0xD0")]
    private UIAnimationController animationController;
    [Token(Token = "0x4001926")]
    [FieldOffset(Offset = "0xD8")]
    private HashSet<string> playAnimationList;

    [Token(Token = "0x1700034B")]
    public UnitViewerController UnitViewerController
    {
      [Token(Token = "0x6001AD0"), Address(RVA = "0x2C288AC", Offset = "0x2C288AC", VA = "0x2C288AC")] get
      {
        return (UnitViewerController) null;
      }
      [Token(Token = "0x6001AD1"), Address(RVA = "0x2C288B4", Offset = "0x2C288B4", VA = "0x2C288B4")] private set
      {
      }
    }

    [Token(Token = "0x1700034C")]
    public MotionScrollListPane MotionScrollListPane
    {
      [Token(Token = "0x6001AD2"), Address(RVA = "0x2C288BC", Offset = "0x2C288BC", VA = "0x2C288BC")] get
      {
        return (MotionScrollListPane) null;
      }
    }

    [Token(Token = "0x6001AD3")]
    [Address(RVA = "0x2C288C4", Offset = "0x2C288C4", VA = "0x2C288C4")]
    public void Initialize(UnitDetailSubScene subScene, UnitViewerController unitViewerController)
    {
    }

    [Token(Token = "0x6001AD4")]
    [Address(RVA = "0x2C288DC", Offset = "0x2C288DC", VA = "0x2C288DC", Slot = "18")]
    protected override void InitializeImpl()
    {
    }

    [Token(Token = "0x6001AD5")]
    [Address(RVA = "0x2C28A6C", Offset = "0x2C28A6C", VA = "0x2C28A6C", Slot = "4")]
    public override void Show()
    {
    }

    [Token(Token = "0x6001AD6")]
    [Address(RVA = "0x2C28D5C", Offset = "0x2C28D5C", VA = "0x2C28D5C", Slot = "5")]
    public override void Hide()
    {
    }

    [Token(Token = "0x6001AD7")]
    [Address(RVA = "0x2C28F58", Offset = "0x2C28F58", VA = "0x2C28F58")]
    public void ChangeSubState(
      UnitViewerStateHandler.SubStateIndices subStateIndex)
    {
    }

    [Token(Token = "0x6001AD8")]
    [Address(RVA = "0x2C28960", Offset = "0x2C28960", VA = "0x2C28960")]
    private void SetupStateMachine()
    {
    }

    [Token(Token = "0x6001AD9")]
    [Address(RVA = "0x2C2909C", Offset = "0x2C2909C", VA = "0x2C2909C", Slot = "19")]
    protected override void UpdateUnitImpl()
    {
    }

    [Token(Token = "0x6001ADA")]
    [Address(RVA = "0x2C292F8", Offset = "0x2C292F8", VA = "0x2C292F8")]
    private void ClearUnitAsset()
    {
    }

    [Token(Token = "0x6001ADB")]
    [Address(RVA = "0x2C29338", Offset = "0x2C29338", VA = "0x2C29338")]
    public void CloseSelection()
    {
    }

    [Token(Token = "0x6001ADC")]
    [Address(RVA = "0x2C293C0", Offset = "0x2C293C0", VA = "0x2C293C0")]
    public void SwitchOverCustomize()
    {
    }

    [Token(Token = "0x6001ADD")]
    [Address(RVA = "0x2C293DC", Offset = "0x2C293DC", VA = "0x2C293DC")]
    public Vector2 ChangeVectorAccordingToOrientation(Vector2 src) => new Vector2();

    [Token(Token = "0x6001ADE")]
    [Address(RVA = "0x2C293F8", Offset = "0x2C293F8", VA = "0x2C293F8")]
    public void SetSwitchOverViewerText(
      UnitViewerStateHandler.SubStateIndices subStateIndex)
    {
    }

    [Token(Token = "0x6001ADF")]
    [Address(RVA = "0x2C294F8", Offset = "0x2C294F8", VA = "0x2C294F8")]
    private void SwitchOrientation()
    {
    }

    [Token(Token = "0x6001AE0")]
    [Address(RVA = "0x2C29540", Offset = "0x2C29540", VA = "0x2C29540")]
    private void UpdateProfile()
    {
    }

    [Token(Token = "0x6001AE1")]
    [Address(RVA = "0x2C296D8", Offset = "0x2C296D8", VA = "0x2C296D8")]
    public void UpdateMotionList(
      IReadOnlyList<UnitViewerUtility.MotionInfo> motionList)
    {
    }

    [Token(Token = "0x6001AE2")]
    [Address(RVA = "0x2C25A50", Offset = "0x2C25A50", VA = "0x2C25A50")]
    public void OnPlayMotion(string stateName, string soundName)
    {
    }

    [Token(Token = "0x6001AE3")]
    [Address(RVA = "0x2C29780", Offset = "0x2C29780", VA = "0x2C29780")]
    private void UpdateVoiceList()
    {
    }

    [Token(Token = "0x6001AE4")]
    [Address(RVA = "0x2C298A0", Offset = "0x2C298A0", VA = "0x2C298A0")]
    public void OnPlayVoice(string soundName)
    {
    }

    [Token(Token = "0x6001AE5")]
    [Address(RVA = "0x2C29928", Offset = "0x2C29928", VA = "0x2C29928")]
    private void ChangeSelection(UnitViewerStateHandler.SelectionIndices selection)
    {
    }

    [Token(Token = "0x6001AE6")]
    [Address(RVA = "0x2C29970", Offset = "0x2C29970", VA = "0x2C29970")]
    private void UpdateSelectionContent(UnitViewerStateHandler.SelectionIndices selection)
    {
    }

    [Token(Token = "0x6001AE7")]
    [Address(RVA = "0x2C29A1C", Offset = "0x2C29A1C", VA = "0x2C29A1C")]
    private void AddOpenSelectionAnimation(UnitViewerStateHandler.SelectionIndices selection)
    {
    }

    [Token(Token = "0x6001AE8")]
    [Address(RVA = "0x2C28E40", Offset = "0x2C28E40", VA = "0x2C28E40")]
    private void AddCloseSelectionAnimation()
    {
    }

    [Token(Token = "0x6001AE9")]
    [Address(RVA = "0x2C28AFC", Offset = "0x2C28AFC", VA = "0x2C28AFC")]
    public void PlayAnimation(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6001AEA")]
    [Address(RVA = "0x2C29B3C", Offset = "0x2C29B3C", VA = "0x2C29B3C", Slot = "7")]
    public override void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001AEB")]
    [Address(RVA = "0x2C29BB4", Offset = "0x2C29BB4", VA = "0x2C29BB4", Slot = "8")]
    public override void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001AEC")]
    [Address(RVA = "0x2C29C44", Offset = "0x2C29C44", VA = "0x2C29C44", Slot = "9")]
    public override void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001AED")]
    [Address(RVA = "0x2C29CC0", Offset = "0x2C29CC0", VA = "0x2C29CC0", Slot = "10")]
    public override void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001AEE")]
    [Address(RVA = "0x2C29D3C", Offset = "0x2C29D3C", VA = "0x2C29D3C", Slot = "11")]
    public override void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001AEF")]
    [Address(RVA = "0x2C29DB8", Offset = "0x2C29DB8", VA = "0x2C29DB8", Slot = "12")]
    public override void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001AF0")]
    [Address(RVA = "0x2C29E34", Offset = "0x2C29E34", VA = "0x2C29E34", Slot = "13")]
    public override void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001AF1")]
    [Address(RVA = "0x2C29EA8", Offset = "0x2C29EA8", VA = "0x2C29EA8", Slot = "14")]
    public override void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001AF2")]
    [Address(RVA = "0x2C29F24", Offset = "0x2C29F24", VA = "0x2C29F24", Slot = "15")]
    public override void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001AF3")]
    [Address(RVA = "0x2C29FA0", Offset = "0x2C29FA0", VA = "0x2C29FA0", Slot = "16")]
    public override void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001AF4")]
    [Address(RVA = "0x2C2A01C", Offset = "0x2C2A01C", VA = "0x2C2A01C")]
    private void Update()
    {
    }

    [Token(Token = "0x6001AF5")]
    [Address(RVA = "0x2C2A030", Offset = "0x2C2A030", VA = "0x2C2A030")]
    private void UpdateCloseSelectionButton()
    {
    }

    [Token(Token = "0x6001AF6")]
    [Address(RVA = "0x2C2A068", Offset = "0x2C2A068", VA = "0x2C2A068")]
    public void OnClickMotionListButton()
    {
    }

    [Token(Token = "0x6001AF7")]
    [Address(RVA = "0x2C2A0F4", Offset = "0x2C2A0F4", VA = "0x2C2A0F4")]
    public void OnClickViewerSwitchOverButton()
    {
    }

    [Token(Token = "0x6001AF8")]
    [Address(RVA = "0x2C2A1E4", Offset = "0x2C2A1E4", VA = "0x2C2A1E4")]
    public void OnClickVoiceListButton()
    {
    }

    [Token(Token = "0x6001AF9")]
    [Address(RVA = "0x2C2A270", Offset = "0x2C2A270", VA = "0x2C2A270")]
    public void OnClickCloseButton()
    {
    }

    [Token(Token = "0x6001AFA")]
    [Address(RVA = "0x2C2A2F8", Offset = "0x2C2A2F8", VA = "0x2C2A2F8", Slot = "22")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001AFB")]
    [Address(RVA = "0x2C2A358", Offset = "0x2C2A358", VA = "0x2C2A358")]
    public void OnClickOrientationSwitchingButton()
    {
    }

    [Token(Token = "0x6001AFC")]
    [Address(RVA = "0x2C2A35C", Offset = "0x2C2A35C", VA = "0x2C2A35C")]
    public void OnClickProfileButton()
    {
    }

    [Token(Token = "0x6001AFD")]
    [Address(RVA = "0x2C2A3E8", Offset = "0x2C2A3E8", VA = "0x2C2A3E8")]
    public UnitViewerStateHandler()
    {
    }

    [Token(Token = "0x6001AFE")]
    [Address(RVA = "0x2C2A5A0", Offset = "0x2C2A5A0", VA = "0x2C2A5A0")]
    static UnitViewerStateHandler()
    {
    }

    [Token(Token = "0x20004BD")]
    public enum SubStateIndices
    {
      [Token(Token = "0x4001929")] Viewer2D,
      [Token(Token = "0x400192A")] ViewerDot,
    }

    [Token(Token = "0x20004BE")]
    public enum Orientation
    {
      [Token(Token = "0x400192C")] Landscape,
      [Token(Token = "0x400192D")] Portrait,
      [Token(Token = "0x400192E")] OrientationMax,
    }

    [Token(Token = "0x20004BF")]
    public enum SelectionIndices
    {
      [Token(Token = "0x4001930")] Idle,
      [Token(Token = "0x4001931")] MotionSelect,
      [Token(Token = "0x4001932")] VoiceSelect,
      [Token(Token = "0x4001933")] Profile,
    }

    [Token(Token = "0x20004C0")]
    public class UnitViewerSubStateMachine : 
      UnitDetailSubStateMachine<UnitViewerStateHandler, ViewerSubState>
    {
      [Token(Token = "0x6001B01")]
      [Address(RVA = "0x2C2903C", Offset = "0x2C2903C", VA = "0x2C2903C")]
      public UnitViewerSubStateMachine(UnitViewerStateHandler handler)
      {
      }
    }
  }
}
