// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.AreaMapView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E15")]
  public class AreaMapView
  {
    [Token(Token = "0x400C5C6")]
    [FieldOffset(Offset = "0x10")]
    private View view;
    [Token(Token = "0x400C5C7")]
    [FieldOffset(Offset = "0x18")]
    private RectTransform control;
    [Token(Token = "0x400C5C8")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 initPosition;
    [Token(Token = "0x400C5C9")]
    [FieldOffset(Offset = "0x28")]
    private readonly Dictionary<int, Sprite> bgImageCaches;

    [Token(Token = "0x6011FFF")]
    [Address(RVA = "0x4378B34", Offset = "0x4378B34", VA = "0x4378B34")]
    public AreaMapView(View view)
    {
    }

    [Token(Token = "0x17003D54")]
    private CurrentFreeActionParam currentFreeActionParam
    {
      [Token(Token = "0x6012000"), Address(RVA = "0x4378D04", Offset = "0x4378D04", VA = "0x4378D04")] get
      {
        return (CurrentFreeActionParam) null;
      }
    }

    [Token(Token = "0x17003D55")]
    private Image mapImage
    {
      [Token(Token = "0x6012001"), Address(RVA = "0x4378C64", Offset = "0x4378C64", VA = "0x4378C64")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x6012002")]
    [Address(RVA = "0x4378D3C", Offset = "0x4378D3C", VA = "0x4378D3C")]
    public void PositionReset()
    {
    }

    [Token(Token = "0x6012003")]
    [Address(RVA = "0x4378D68", Offset = "0x4378D68", VA = "0x4378D68")]
    public void ScaleReset()
    {
    }

    [Token(Token = "0x6012004")]
    [Address(RVA = "0x4378DCC", Offset = "0x4378DCC", VA = "0x4378DCC")]
    public IEnumerator LoadAreaMap(int areaID) => (IEnumerator) null;

    [Token(Token = "0x6012005")]
    [Address(RVA = "0x4378E6C", Offset = "0x4378E6C", VA = "0x4378E6C")]
    public void OnMove(Vector2 delta)
    {
    }

    [Token(Token = "0x6012006")]
    [Address(RVA = "0x4378EB0", Offset = "0x4378EB0", VA = "0x4378EB0")]
    public void OnScale()
    {
    }
  }
}
