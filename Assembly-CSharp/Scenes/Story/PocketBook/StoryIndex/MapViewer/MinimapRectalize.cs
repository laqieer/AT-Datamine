// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.MinimapRectalize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E23")]
  public class MinimapRectalize
  {
    [Token(Token = "0x400C5FD")]
    [FieldOffset(Offset = "0x10")]
    private Vector2 worldPosition;
    [Token(Token = "0x400C5FE")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 worldMin;
    [Token(Token = "0x400C5FF")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 worldMax;
    [Token(Token = "0x400C600")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 worldCenter;
    [Token(Token = "0x400C601")]
    [FieldOffset(Offset = "0x30")]
    private Vector2 worldSize;
    [Token(Token = "0x400C602")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 deltaPosition;
    [Token(Token = "0x400C603")]
    [FieldOffset(Offset = "0x40")]
    private float angle;
    [Token(Token = "0x400C604")]
    [FieldOffset(Offset = "0x44")]
    private float scale;
    [Token(Token = "0x400C607")]
    private const float PERCENT = 100f;
    [Token(Token = "0x400C608")]
    [FieldOffset(Offset = "0x50")]
    private Matrix4x4 rotateMatrix;
    [Token(Token = "0x400C609")]
    [FieldOffset(Offset = "0x90")]
    private Matrix4x4 scaleMatrix;

    [Token(Token = "0x17003D64")]
    public float ScaleMin
    {
      [Token(Token = "0x601205F"), Address(RVA = "0x437C0F4", Offset = "0x437C0F4", VA = "0x437C0F4")] get
      {
        return new float();
      }
      [Token(Token = "0x6012060"), Address(RVA = "0x437C0FC", Offset = "0x437C0FC", VA = "0x437C0FC")] private set
      {
      }
    }

    [Token(Token = "0x17003D65")]
    public float ScaleMax
    {
      [Token(Token = "0x6012061"), Address(RVA = "0x437C104", Offset = "0x437C104", VA = "0x437C104")] get
      {
        return new float();
      }
      [Token(Token = "0x6012062"), Address(RVA = "0x437C10C", Offset = "0x437C10C", VA = "0x437C10C")] private set
      {
      }
    }

    [Token(Token = "0x6012063")]
    [Address(RVA = "0x437C114", Offset = "0x437C114", VA = "0x437C114")]
    public static MinimapRectalize Calculate(
      Image image,
      StoryFreeActionMinimapData minimap,
      int init)
    {
      return (MinimapRectalize) null;
    }

    [Token(Token = "0x6012064")]
    [Address(RVA = "0x437C388", Offset = "0x437C388", VA = "0x437C388")]
    public void Reset()
    {
    }

    [Token(Token = "0x6012065")]
    [Address(RVA = "0x437C34C", Offset = "0x437C34C", VA = "0x437C34C")]
    public void CalculateMatrix()
    {
    }

    [Token(Token = "0x6012066")]
    [Address(RVA = "0x437C3D8", Offset = "0x437C3D8", VA = "0x437C3D8")]
    private void CalculateRotateMatrix()
    {
    }

    [Token(Token = "0x6012067")]
    [Address(RVA = "0x437C5D0", Offset = "0x437C5D0", VA = "0x437C5D0")]
    private void CalculateScaleMatrix()
    {
    }

    [Token(Token = "0x6012068")]
    [Address(RVA = "0x437C7BC", Offset = "0x437C7BC", VA = "0x437C7BC")]
    public void SetTranslate(Vector2 move)
    {
    }

    [Token(Token = "0x6012069")]
    [Address(RVA = "0x437C7D0", Offset = "0x437C7D0", VA = "0x437C7D0")]
    public void SetScaleMinMax(int min, int max)
    {
    }

    [Token(Token = "0x601206A")]
    [Address(RVA = "0x437C7F0", Offset = "0x437C7F0", VA = "0x437C7F0")]
    public float SetScale(float scale) => new float();

    [Token(Token = "0x601206B")]
    [Address(RVA = "0x437C83C", Offset = "0x437C83C", VA = "0x437C83C")]
    public float GetScale() => new float();

    [Token(Token = "0x601206C")]
    [Address(RVA = "0x437C364", Offset = "0x437C364", VA = "0x437C364")]
    public void CauculateWorldScale()
    {
    }

    [Token(Token = "0x601206D")]
    [Address(RVA = "0x437C844", Offset = "0x437C844", VA = "0x437C844")]
    public Vector2 MultiplyPosition(Vector2 position) => new Vector2();

    [Token(Token = "0x601206E")]
    [Address(RVA = "0x4379B08", Offset = "0x4379B08", VA = "0x4379B08")]
    public Vector2 PositionAt(Vector2 position, Rect rect) => new Vector2();

    [Token(Token = "0x601206F")]
    [Address(RVA = "0x437C86C", Offset = "0x437C86C", VA = "0x437C86C")]
    private Vector2 Normalize(Vector2 position, Rect rect) => new Vector2();

    [Token(Token = "0x6012070")]
    [Address(RVA = "0x437C2BC", Offset = "0x437C2BC", VA = "0x437C2BC")]
    public MinimapRectalize()
    {
    }

    [Token(Token = "0x2002E24")]
    private static class Calculator
    {
      [Token(Token = "0x6012071")]
      [Address(RVA = "0x437C90C", Offset = "0x437C90C", VA = "0x437C90C")]
      public static Vector2 Rotate(Vector3 pivot, Vector3 pos, float angle) => new Vector2();

      [Token(Token = "0x6012072")]
      [Address(RVA = "0x437C8FC", Offset = "0x437C8FC", VA = "0x437C8FC")]
      public static float NormalizeMinMax(float value, float min, float max) => new float();
    }
  }
}
