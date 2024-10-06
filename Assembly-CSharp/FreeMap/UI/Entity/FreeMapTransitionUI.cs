// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapTransitionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Element;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x200169B")]
  public class FreeMapTransitionUI : FreeMapDistanceUIBase, IFreeMapIconButtonHandler
  {
    [Token(Token = "0x400657F")]
    [FieldOffset(Offset = "0x0")]
    private static readonly UIShowTweenNameList TransitionShowTweenNameList;
    [Token(Token = "0x4006580")]
    [FieldOffset(Offset = "0x8")]
    private static readonly UIRotationTweenNameList TransitionRotationTweenNameList;
    [Token(Token = "0x4006581")]
    [FieldOffset(Offset = "0x60")]
    protected FreeMapActionIconUIControllElement defaultUIElement;
    [Token(Token = "0x4006582")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapButtonUIControllElement nearUIElement;
    [Token(Token = "0x4006583")]
    [FieldOffset(Offset = "0x70")]
    private string toAreaName;
    [Token(Token = "0x4006584")]
    [FieldOffset(Offset = "0x78")]
    private FreeMapUIParamBase uiParam;
    [Token(Token = "0x4006585")]
    [FieldOffset(Offset = "0x80")]
    private bool purposeMarkEnable;

    [Token(Token = "0x170013BC")]
    public override FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x6007FA2"), Address(RVA = "0x41EF4EC", Offset = "0x41EF4EC", VA = "0x41EF4EC", Slot = "6")] get
      {
        return new FreeMapUIDirection();
      }
    }

    [Token(Token = "0x170013BD")]
    public override bool IsValid
    {
      [Token(Token = "0x6007FA3"), Address(RVA = "0x41EF5A4", Offset = "0x41EF5A4", VA = "0x41EF5A4", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007FA4")]
    [Address(RVA = "0x41EF61C", Offset = "0x41EF61C", VA = "0x41EF61C")]
    public bool IsUIActiveShow() => new bool();

    [Token(Token = "0x6007FA5")]
    [Address(RVA = "0x41EF714", Offset = "0x41EF714", VA = "0x41EF714")]
    public void TransitionInitialize(string toAreaName, float thresholdDistance)
    {
    }

    [Token(Token = "0x6007FA6")]
    [Address(RVA = "0x41EF720", Offset = "0x41EF720", VA = "0x41EF720")]
    public void TransitionInitialize(
      FreeMapUIParamBase param,
      string toAreaName,
      float thresholdDistance,
      FreeMapActionIconUIControllElement defaultElm,
      FreeMapButtonUIControllElement nearElm,
      UITransformIconAvoidElement avoidElm)
    {
    }

    [Token(Token = "0x6007FA7")]
    [Address(RVA = "0x41EF7F0", Offset = "0x41EF7F0", VA = "0x41EF7F0", Slot = "13")]
    protected override void OnDestroyUI()
    {
    }

    [Token(Token = "0x6007FA8")]
    [Address(RVA = "0x41EF878", Offset = "0x41EF878", VA = "0x41EF878", Slot = "9")]
    protected override void OnUpdate(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      FreeMapPlayerInstance player,
      bool isUpdateCilp)
    {
    }

    [Token(Token = "0x6007FA9")]
    [Address(RVA = "0x41EFC18", Offset = "0x41EFC18", VA = "0x41EFC18", Slot = "17")]
    protected override void ChangeDefaultDisplayUI()
    {
    }

    [Token(Token = "0x6007FAA")]
    [Address(RVA = "0x41EFCAC", Offset = "0x41EFCAC", VA = "0x41EFCAC", Slot = "18")]
    protected override void ChangeNearDisplayUI()
    {
    }

    [Token(Token = "0x6007FAB")]
    [Address(RVA = "0x41EFCE0", Offset = "0x41EFCE0", VA = "0x41EFCE0", Slot = "10")]
    public override void ShowUI()
    {
    }

    [Token(Token = "0x6007FAC")]
    [Address(RVA = "0x41EFD0C", Offset = "0x41EFD0C", VA = "0x41EFD0C", Slot = "11")]
    public override void HideUI()
    {
    }

    [Token(Token = "0x6007FAD")]
    [Address(RVA = "0x41EFD48", Offset = "0x41EFD48", VA = "0x41EFD48", Slot = "19")]
    protected override void ChangeTransparentAlphaUI(float toAlpha)
    {
    }

    [Token(Token = "0x6007FAE")]
    [Address(RVA = "0x41EFD70", Offset = "0x41EFD70", VA = "0x41EFD70", Slot = "14")]
    public override void ChangeSprite(
      FreeMapUIParamBase targetParam,
      string targetObjectName,
      Sprite sprite)
    {
    }

    [Token(Token = "0x6007FAF")]
    [Address(RVA = "0x41EFF40", Offset = "0x41EFF40", VA = "0x41EFF40", Slot = "12")]
    public override void ChangeUI(
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam,
      Sprite sprite,
      UnityAction buttonAction,
      string buttonObjectName)
    {
    }

    [Token(Token = "0x6007FB0")]
    [Address(RVA = "0x41EFDDC", Offset = "0x41EFDDC", VA = "0x41EFDDC", Slot = "20")]
    public bool IsHoldUIParam(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6007FB1")]
    [Address(RVA = "0x41EFF44", Offset = "0x41EFF44", VA = "0x41EFF44", Slot = "21")]
    public void InvokeButtonAction(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007FB2")]
    [Address(RVA = "0x41F000C", Offset = "0x41F000C", VA = "0x41F000C", Slot = "8")]
    public override void SetAsLastSibling()
    {
    }

    [Token(Token = "0x6007FB3")]
    [Address(RVA = "0x41F0100", Offset = "0x41F0100", VA = "0x41F0100")]
    public void EnablePurposeMark(bool enable)
    {
    }

    [Token(Token = "0x6007FB4")]
    [Address(RVA = "0x41F0244", Offset = "0x41F0244", VA = "0x41F0244")]
    public FreeMapTransitionUI()
    {
    }

    [Token(Token = "0x6007FB5")]
    [Address(RVA = "0x41F024C", Offset = "0x41F024C", VA = "0x41F024C")]
    static FreeMapTransitionUI()
    {
    }
  }
}
