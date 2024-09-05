// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.UI.SnapScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.UI
{
  [Token(Token = "0x2002C51")]
  public class SnapScrollRect : ScrollRect
  {
    [Token(Token = "0x400BCC6")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private int horizontalIndex;
    [Token(Token = "0x400BCC7")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    private int verticalIndex;
    [Token(Token = "0x400BCC8")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private int horizontalMaxPages;
    [Token(Token = "0x400BCC9")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    private int verticalMaxPages;
    [Token(Token = "0x400BCCA")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private float smooth;
    [Token(Token = "0x400BCCB")]
    [FieldOffset(Offset = "0x13C")]
    private Vector2 targetPosition;
    [Token(Token = "0x400BCCC")]
    [FieldOffset(Offset = "0x144")]
    private float horizontalPerPage;
    [Token(Token = "0x400BCCD")]
    [FieldOffset(Offset = "0x148")]
    private float verticalPerPage;
    [Token(Token = "0x400BCCE")]
    [FieldOffset(Offset = "0x14C")]
    private bool forcePositionUpdate;
    [Token(Token = "0x400BCCF")]
    [FieldOffset(Offset = "0x150")]
    private Action<int, int> callback;

    [Token(Token = "0x60115C2")]
    [Address(RVA = "0x4E18F18", Offset = "0x4E18F18", VA = "0x4E18F18", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60115C3")]
    [Address(RVA = "0x4E18F20", Offset = "0x4E18F20", VA = "0x4E18F20", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60115C4")]
    [Address(RVA = "0x4E18F28", Offset = "0x4E18F28", VA = "0x4E18F28")]
    public void Initialize(int horizontalPages, int verticalPages, Action<int, int> cb = null)
    {
    }

    [Token(Token = "0x60115C5")]
    [Address(RVA = "0x4E1900C", Offset = "0x4E1900C", VA = "0x4E1900C")]
    public void ScrollTo(int h, int v)
    {
    }

    [Token(Token = "0x60115C6")]
    [Address(RVA = "0x4E19020", Offset = "0x4E19020", VA = "0x4E19020")]
    public void ScrollUp()
    {
    }

    [Token(Token = "0x60115C7")]
    [Address(RVA = "0x4E1903C", Offset = "0x4E1903C", VA = "0x4E1903C")]
    public void ScrollDown()
    {
    }

    [Token(Token = "0x60115C8")]
    [Address(RVA = "0x4E19064", Offset = "0x4E19064", VA = "0x4E19064")]
    public void ScrollLeft()
    {
    }

    [Token(Token = "0x60115C9")]
    [Address(RVA = "0x4E1908C", Offset = "0x4E1908C", VA = "0x4E1908C")]
    public void ScrollRight()
    {
    }

    [Token(Token = "0x60115CA")]
    [Address(RVA = "0x4E190A8", Offset = "0x4E190A8", VA = "0x4E190A8")]
    private void Update()
    {
    }

    [Token(Token = "0x60115CB")]
    [Address(RVA = "0x4E18F84", Offset = "0x4E18F84", VA = "0x4E18F84")]
    private Vector2 GetSnapPosition() => new Vector2();

    [Token(Token = "0x60115CC")]
    [Address(RVA = "0x4E1923C", Offset = "0x4E1923C", VA = "0x4E1923C")]
    public SnapScrollRect()
    {
    }
  }
}
