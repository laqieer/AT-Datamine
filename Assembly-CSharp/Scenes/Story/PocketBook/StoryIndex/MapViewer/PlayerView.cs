// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.PlayerView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E26")]
  public class PlayerView
  {
    [Token(Token = "0x400C613")]
    [FieldOffset(Offset = "0x10")]
    private View view;
    [Token(Token = "0x400C614")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 playerPosition;

    [Token(Token = "0x17003D66")]
    private CurrentFreeActionParam CurrentFreeActionParam
    {
      [Token(Token = "0x6012074"), Address(RVA = "0x437CA38", Offset = "0x437CA38", VA = "0x437CA38")] get
      {
        return (CurrentFreeActionParam) null;
      }
    }

    [Token(Token = "0x17003D67")]
    private RectTransform currentLocation
    {
      [Token(Token = "0x6012075"), Address(RVA = "0x437CA54", Offset = "0x437CA54", VA = "0x437CA54")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6012076")]
    [Address(RVA = "0x437CA78", Offset = "0x437CA78", VA = "0x437CA78")]
    public PlayerView(View view)
    {
    }

    [Token(Token = "0x6012077")]
    [Address(RVA = "0x437CAA0", Offset = "0x437CAA0", VA = "0x437CAA0")]
    public void Show()
    {
    }

    [Token(Token = "0x6012078")]
    [Address(RVA = "0x437CBC0", Offset = "0x437CBC0", VA = "0x437CBC0")]
    public void Hide()
    {
    }

    [Token(Token = "0x6012079")]
    [Address(RVA = "0x437CBEC", Offset = "0x437CBEC", VA = "0x437CBEC")]
    public void OnMove(Vector2 delta)
    {
    }

    [Token(Token = "0x601207A")]
    [Address(RVA = "0x437CC30", Offset = "0x437CC30", VA = "0x437CC30")]
    public void OnScale()
    {
    }

    [Token(Token = "0x601207B")]
    [Address(RVA = "0x437CB08", Offset = "0x437CB08", VA = "0x437CB08")]
    private void OnUpdate()
    {
    }

    [Token(Token = "0x601207C")]
    [Address(RVA = "0x437CC34", Offset = "0x437CC34", VA = "0x437CC34")]
    public void ResetPosition()
    {
    }
  }
}
