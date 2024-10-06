// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.Bounds2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E17")]
  public class Bounds2D
  {
    [Token(Token = "0x400C5CF")]
    [FieldOffset(Offset = "0x10")]
    private RectTransform rect;
    [Token(Token = "0x400C5D0")]
    [FieldOffset(Offset = "0x18")]
    private Camera camera;

    [Token(Token = "0x601200E")]
    [Address(RVA = "0x437920C", Offset = "0x437920C", VA = "0x437920C")]
    public Bounds2D(RectTransform rect, Camera camera)
    {
    }

    [Token(Token = "0x601200F")]
    [Address(RVA = "0x4379238", Offset = "0x4379238", VA = "0x4379238")]
    public bool Contains(Vector2 position) => new bool();

    [Token(Token = "0x6012010")]
    [Address(RVA = "0x43792B0", Offset = "0x43792B0", VA = "0x43792B0")]
    public static bool Contains(RectTransform rect, Vector3 position, Camera camera) => new bool();
  }
}
