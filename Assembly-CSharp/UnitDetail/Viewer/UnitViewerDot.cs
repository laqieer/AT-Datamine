// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewerDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004B8")]
  [Serializable]
  public class UnitViewerDot : UnitViewerBase
  {
    [Token(Token = "0x40018F5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CameraController cameraController;
    [Token(Token = "0x40018F6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitModelController modelController;
    [Token(Token = "0x40018F7")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine motionCoroutine;

    [Token(Token = "0x17000346")]
    private string IdleStateName
    {
      [Token(Token = "0x6001AB2"), Address(RVA = "0x2C27EA8", Offset = "0x2C27EA8", VA = "0x2C27EA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6001AB3")]
    [Address(RVA = "0x2C27F80", Offset = "0x2C27F80", VA = "0x2C27F80", Slot = "4")]
    protected override void InitializeImpl()
    {
    }

    [Token(Token = "0x6001AB4")]
    [Address(RVA = "0x2C27FA4", Offset = "0x2C27FA4", VA = "0x2C27FA4", Slot = "14")]
    public override void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001AB5")]
    [Address(RVA = "0x2C281C8", Offset = "0x2C281C8", VA = "0x2C281C8", Slot = "15")]
    public override void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001AB6")]
    [Address(RVA = "0x2C282EC", Offset = "0x2C282EC", VA = "0x2C282EC", Slot = "17")]
    public override void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001AB7")]
    [Address(RVA = "0x2C283E4", Offset = "0x2C283E4", VA = "0x2C283E4", Slot = "12")]
    public override void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001AB8")]
    [Address(RVA = "0x2C2845C", Offset = "0x2C2845C", VA = "0x2C2845C", Slot = "13")]
    public override void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001AB9")]
    [Address(RVA = "0x2C284D4", Offset = "0x2C284D4", VA = "0x2C284D4", Slot = "22")]
    protected override void HideTransition()
    {
    }

    [Token(Token = "0x6001ABA")]
    [Address(RVA = "0x2C284EC", Offset = "0x2C284EC", VA = "0x2C284EC", Slot = "21")]
    protected override void ShowTransition()
    {
    }

    [Token(Token = "0x6001ABB")]
    [Address(RVA = "0x2C28504", Offset = "0x2C28504", VA = "0x2C28504")]
    public void InstantiateModel(GameObject dotModelAsset)
    {
    }

    [Token(Token = "0x6001ABC")]
    [Address(RVA = "0x2C2851C", Offset = "0x2C2851C", VA = "0x2C2851C")]
    public void DestroyModel()
    {
    }

    [Token(Token = "0x6001ABD")]
    [Address(RVA = "0x2C28534", Offset = "0x2C28534", VA = "0x2C28534")]
    public void PlayAnimation(string stateName, Action endAnimationCallback)
    {
    }

    [Token(Token = "0x6001ABE")]
    [Address(RVA = "0x2C285C4", Offset = "0x2C285C4", VA = "0x2C285C4")]
    public void CrossFade(string stateName)
    {
    }

    [Token(Token = "0x6001ABF")]
    [Address(RVA = "0x2C28270", Offset = "0x2C28270", VA = "0x2C28270")]
    private IEnumerator AdjustZoomCoroutine(float zoom, float duration) => (IEnumerator) null;

    [Token(Token = "0x6001AC0")]
    [Address(RVA = "0x2C2813C", Offset = "0x2C2813C", VA = "0x2C2813C")]
    private IEnumerator AdjustTranslateCoroutine(Vector2 translate, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001AC1")]
    [Address(RVA = "0x2C2862C", Offset = "0x2C2862C", VA = "0x2C2862C")]
    public UnitViewerDot()
    {
    }
  }
}
