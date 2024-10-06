// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitImageController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004AE")]
  [Serializable]
  public class UnitImageController
  {
    [Token(Token = "0x40018B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x40018B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x40018B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x40018B5")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 startPinchCenter;
    [Token(Token = "0x40018B6")]
    [FieldOffset(Offset = "0x30")]
    private Vector2 startPinchCenterLocal;
    [Token(Token = "0x40018B7")]
    [FieldOffset(Offset = "0x38")]
    private Viewer2DSetting setting;

    [Token(Token = "0x17000333")]
    public float Scale
    {
      [Token(Token = "0x6001A46"), Address(RVA = "0x2C25B18", Offset = "0x2C25B18", VA = "0x2C25B18")] get
      {
        return new float();
      }
      [Token(Token = "0x6001A47"), Address(RVA = "0x2C25B20", Offset = "0x2C25B20", VA = "0x2C25B20")] private set
      {
      }
    }

    [Token(Token = "0x17000334")]
    public Vector2 XYTranslate
    {
      [Token(Token = "0x6001A48"), Address(RVA = "0x2C25B28", Offset = "0x2C25B28", VA = "0x2C25B28")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001A49"), Address(RVA = "0x2C25B30", Offset = "0x2C25B30", VA = "0x2C25B30")] private set
      {
      }
    }

    [Token(Token = "0x6001A4A")]
    [Address(RVA = "0x2C25B38", Offset = "0x2C25B38", VA = "0x2C25B38")]
    public void Initialize(Viewer2DSetting setting)
    {
    }

    [Token(Token = "0x6001A4B")]
    [Address(RVA = "0x2C25B40", Offset = "0x2C25B40", VA = "0x2C25B40")]
    public void Update(Sprite sprite)
    {
    }

    [Token(Token = "0x6001A4C")]
    [Address(RVA = "0x2C25B5C", Offset = "0x2C25B5C", VA = "0x2C25B5C")]
    public void DestroyImage()
    {
    }

    [Token(Token = "0x6001A4D")]
    [Address(RVA = "0x2C25B7C", Offset = "0x2C25B7C", VA = "0x2C25B7C")]
    public void Show()
    {
    }

    [Token(Token = "0x6001A4E")]
    [Address(RVA = "0x2C25BA8", Offset = "0x2C25BA8", VA = "0x2C25BA8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6001A4F")]
    [Address(RVA = "0x2C25BD4", Offset = "0x2C25BD4", VA = "0x2C25BD4")]
    public void AdjustScaling(Vector2 startPinchCenter, float value)
    {
    }

    [Token(Token = "0x6001A50")]
    [Address(RVA = "0x2C25E24", Offset = "0x2C25E24", VA = "0x2C25E24")]
    public void Translate(Vector2 position)
    {
    }

    [Token(Token = "0x6001A51")]
    [Address(RVA = "0x2C25E84", Offset = "0x2C25E84", VA = "0x2C25E84")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x6001A52")]
    [Address(RVA = "0x2C25D64", Offset = "0x2C25D64", VA = "0x2C25D64")]
    public bool GetLocalPositionFromScreenPos(Vector2 screenPos, out Vector2 localPosition)
    {
      return new bool();
    }

    [Token(Token = "0x6001A53")]
    [Address(RVA = "0x2C25F24", Offset = "0x2C25F24", VA = "0x2C25F24")]
    public UnitImageController()
    {
    }
  }
}
