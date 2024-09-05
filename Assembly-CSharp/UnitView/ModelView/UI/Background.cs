// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.UI.Background
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.ModelView.UI
{
  [Token(Token = "0x20003D5")]
  [Serializable]
  public class Background
  {
    [Token(Token = "0x4001679")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x400167A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x400167B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image unit;
    [Token(Token = "0x400167C")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform controllRectTransform;
    [Token(Token = "0x400167D")]
    [FieldOffset(Offset = "0x30")]
    private Vector2 startPinchCenter;
    [Token(Token = "0x400167E")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 touchPosition;

    [Token(Token = "0x17000265")]
    public Viewer2DSetting Setting
    {
      [Token(Token = "0x6001633"), Address(RVA = "0x2485D44", Offset = "0x2485D44", VA = "0x2485D44")] private get
      {
        return (Viewer2DSetting) null;
      }
      [Token(Token = "0x6001634"), Address(RVA = "0x2485D4C", Offset = "0x2485D4C", VA = "0x2485D4C")] set
      {
      }
    }

    [Token(Token = "0x17000266")]
    public float Scale
    {
      [Token(Token = "0x6001635"), Address(RVA = "0x2485D54", Offset = "0x2485D54", VA = "0x2485D54")] get
      {
        return new float();
      }
      [Token(Token = "0x6001636"), Address(RVA = "0x2485D5C", Offset = "0x2485D5C", VA = "0x2485D5C")] private set
      {
      }
    }

    [Token(Token = "0x17000267")]
    public Vector2 XYTranslate
    {
      [Token(Token = "0x6001637"), Address(RVA = "0x2485D64", Offset = "0x2485D64", VA = "0x2485D64")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001638"), Address(RVA = "0x2485D6C", Offset = "0x2485D6C", VA = "0x2485D6C")] private set
      {
      }
    }

    [Token(Token = "0x6001639")]
    [Address(RVA = "0x2485D74", Offset = "0x2485D74", VA = "0x2485D74")]
    public void Update(Sprite sprite)
    {
    }

    [Token(Token = "0x600163A")]
    [Address(RVA = "0x2485D90", Offset = "0x2485D90", VA = "0x2485D90")]
    public void AdjustScaling(Vector2 startPinchCenter, float value)
    {
    }

    [Token(Token = "0x600163B")]
    [Address(RVA = "0x2486004", Offset = "0x2486004", VA = "0x2486004")]
    public void Translate(Vector2 direction)
    {
    }

    [Token(Token = "0x600163C")]
    [Address(RVA = "0x2486064", Offset = "0x2486064", VA = "0x2486064")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x600163D")]
    [Address(RVA = "0x2486104", Offset = "0x2486104", VA = "0x2486104")]
    public Background()
    {
    }
  }
}
