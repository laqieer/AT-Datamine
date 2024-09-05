// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.Input
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E22")]
  public class Input
  {
    [Token(Token = "0x400C5F5")]
    [FieldOffset(Offset = "0x10")]
    public Action<Vector2> OnDrag;
    [Token(Token = "0x400C5F6")]
    [FieldOffset(Offset = "0x18")]
    public Action<float> OnPinch;
    [Token(Token = "0x400C5F7")]
    [FieldOffset(Offset = "0x20")]
    private Action<Vector2> onDrag;
    [Token(Token = "0x400C5F8")]
    [FieldOffset(Offset = "0x28")]
    private Action<float> onPinch;
    [Token(Token = "0x400C5F9")]
    [FieldOffset(Offset = "0x30")]
    private readonly GameCore.Input.Input input;
    [Token(Token = "0x400C5FA")]
    [FieldOffset(Offset = "0x38")]
    private Bounds2D bounds;

    [Token(Token = "0x601204F")]
    [Address(RVA = "0x437BD4C", Offset = "0x437BD4C", VA = "0x437BD4C")]
    public void Initialize(Bounds2D bounds)
    {
    }

    [Token(Token = "0x6012050")]
    [Address(RVA = "0x437BED8", Offset = "0x437BED8", VA = "0x437BED8")]
    public void Update()
    {
    }

    [Token(Token = "0x6012051")]
    [Address(RVA = "0x437BF1C", Offset = "0x437BF1C", VA = "0x437BF1C")]
    public bool NoTouch() => new bool();

    [Token(Token = "0x6012052")]
    [Address(RVA = "0x437BF40", Offset = "0x437BF40", VA = "0x437BF40")]
    private void DragBegin(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6012053")]
    [Address(RVA = "0x437BF38", Offset = "0x437BF38", VA = "0x437BF38")]
    private void DragEnd()
    {
    }

    [Token(Token = "0x6012054")]
    [Address(RVA = "0x437BF74", Offset = "0x437BF74", VA = "0x437BF74")]
    private void Drag(Vector2 begin, Vector2 delta)
    {
    }

    [Token(Token = "0x6012055")]
    [Address(RVA = "0x437BF98", Offset = "0x437BF98", VA = "0x437BF98")]
    public void DragStop()
    {
    }

    [Token(Token = "0x17003D62")]
    public float PinchInSensitibility
    {
      [Token(Token = "0x6012056"), Address(RVA = "0x437BFA0", Offset = "0x437BFA0", VA = "0x437BFA0")] get
      {
        return new float();
      }
      [Token(Token = "0x6012057"), Address(RVA = "0x437BFA8", Offset = "0x437BFA8", VA = "0x437BFA8")] set
      {
      }
    }

    [Token(Token = "0x17003D63")]
    public float PinchOutSensitibility
    {
      [Token(Token = "0x6012058"), Address(RVA = "0x437BFB0", Offset = "0x437BFB0", VA = "0x437BFB0")] get
      {
        return new float();
      }
      [Token(Token = "0x6012059"), Address(RVA = "0x437BFB8", Offset = "0x437BFB8", VA = "0x437BFB8")] set
      {
      }
    }

    [Token(Token = "0x601205A")]
    [Address(RVA = "0x437BFC0", Offset = "0x437BFC0", VA = "0x437BFC0")]
    private void Pinch(PinchEventData pinch)
    {
    }

    [Token(Token = "0x601205B")]
    [Address(RVA = "0x437C070", Offset = "0x437C070", VA = "0x437C070")]
    private void OnPinchBegin(PinchEventData pinch)
    {
    }

    [Token(Token = "0x601205C")]
    [Address(RVA = "0x437C068", Offset = "0x437C068", VA = "0x437C068")]
    private void OnPinchEnd()
    {
    }

    [Token(Token = "0x601205D")]
    [Address(RVA = "0x437C07C", Offset = "0x437C07C", VA = "0x437C07C")]
    public Input()
    {
    }
  }
}
