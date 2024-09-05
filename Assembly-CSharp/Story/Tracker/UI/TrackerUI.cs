// Decompiled with JetBrains decompiler
// Type: Story.Tracker.UI.TrackerUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using GameCore.Tween;
using Il2CppDummyDll;
using Story.Tracker.Logic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Tracker.UI
{
  [Token(Token = "0x20005E0")]
  public class TrackerUI : MonoBehaviour
  {
    [Token(Token = "0x4001D3C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001D3D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TrackerMainSectionUI mainSectionUI;
    [Token(Token = "0x4001D3E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TrackerSubSectionUI[] subSectionUIs;
    [Token(Token = "0x4001D3F")]
    [FieldOffset(Offset = "0x30")]
    [Range(0.0f, 2f)]
    [SerializeField]
    private float waitsec;
    [Token(Token = "0x4001D40")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITransfromAvoidElementBase[] transformAvoidElements;
    [Token(Token = "0x4001D41")]
    [FieldOffset(Offset = "0x40")]
    private bool showed;

    [Token(Token = "0x170004C4")]
    public IEnumerable<UITransfromAvoidElementBase> TransformAvoidElements
    {
      [Token(Token = "0x60021F8"), Address(RVA = "0x2D9D588", Offset = "0x2D9D588", VA = "0x2D9D588")] get
      {
        return (IEnumerable<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x170004C5")]
    public float WaitSec
    {
      [Token(Token = "0x60021F9"), Address(RVA = "0x2D9D590", Offset = "0x2D9D590", VA = "0x2D9D590")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60021FA")]
    [Address(RVA = "0x2D9D598", Offset = "0x2D9D598", VA = "0x2D9D598")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60021FB")]
    [Address(RVA = "0x2D9D628", Offset = "0x2D9D628", VA = "0x2D9D628")]
    public void In()
    {
    }

    [Token(Token = "0x60021FC")]
    [Address(RVA = "0x2D9D6CC", Offset = "0x2D9D6CC", VA = "0x2D9D6CC")]
    public void Out()
    {
    }

    [Token(Token = "0x60021FD")]
    [Address(RVA = "0x2D9D658", Offset = "0x2D9D658", VA = "0x2D9D658")]
    private void PlayIn()
    {
    }

    [Token(Token = "0x60021FE")]
    [Address(RVA = "0x2D9D6D0", Offset = "0x2D9D6D0", VA = "0x2D9D6D0")]
    private void PlayOut()
    {
    }

    [Token(Token = "0x60021FF")]
    [Address(RVA = "0x2D9D740", Offset = "0x2D9D740", VA = "0x2D9D740")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x6002200")]
    [Address(RVA = "0x2D9D750", Offset = "0x2D9D750", VA = "0x2D9D750")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x6002201")]
    [Address(RVA = "0x2D9AA18", Offset = "0x2D9AA18", VA = "0x2D9AA18")]
    public TrackerView CreateView() => (TrackerView) null;

    [Token(Token = "0x6002202")]
    [Address(RVA = "0x2D9D770", Offset = "0x2D9D770", VA = "0x2D9D770")]
    public TrackerUI()
    {
    }

    [Token(Token = "0x20005E1")]
    private static class GroupIDs
    {
      [Token(Token = "0x4001D42")]
      public const string In = "Tracker_In";
      [Token(Token = "0x4001D43")]
      public const string Out = "Tracker_Out";
    }
  }
}
