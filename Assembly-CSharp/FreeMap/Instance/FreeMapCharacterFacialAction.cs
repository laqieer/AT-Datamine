// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCharacterFacialAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018B8")]
  public class FreeMapCharacterFacialAction
  {
    [Token(Token = "0x4006B3C")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<FreeMapCharacterFacialAction.FacialType, string> nameFacialFlags;
    [Token(Token = "0x4006B3D")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapSideRuntimeAnimatorControl myAnimator;
    [Token(Token = "0x4006B3E")]
    [FieldOffset(Offset = "0x18")]
    protected float eyesIntervalMin;
    [Token(Token = "0x4006B3F")]
    [FieldOffset(Offset = "0x1C")]
    protected float eyesIntervalMax;
    [Token(Token = "0x4006B40")]
    [FieldOffset(Offset = "0x20")]
    private bool existFace;
    [Token(Token = "0x4006B41")]
    [FieldOffset(Offset = "0x21")]
    private bool existEyes;
    [Token(Token = "0x4006B42")]
    [FieldOffset(Offset = "0x22")]
    private bool existMouth;
    [Token(Token = "0x4006B43")]
    [FieldOffset(Offset = "0x24")]
    private FreeMapCharacterFacialAction.FacialType activeFacialType;
    [Token(Token = "0x4006B44")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapCharacterFacialAction.FacialType beforeFacialType;
    [Token(Token = "0x4006B45")]
    [FieldOffset(Offset = "0x2C")]
    private float faceChangeSpeed;
    [Token(Token = "0x4006B46")]
    [FieldOffset(Offset = "0x30")]
    private float eyesInterval;
    [Token(Token = "0x4006B47")]
    [FieldOffset(Offset = "0x34")]
    private bool activeLipSync;
    [Token(Token = "0x4006B48")]
    [FieldOffset(Offset = "0x38")]
    private float mouthInterval;

    [Token(Token = "0x6008C6A")]
    [Address(RVA = "0x452C680", Offset = "0x452C680", VA = "0x452C680")]
    public FreeMapCharacterFacialAction(
      FreeMapSideRuntimeAnimatorControl animator,
      float intervalMin,
      float intervalMax)
    {
    }

    [Token(Token = "0x6008C6B")]
    [Address(RVA = "0x452C9C0", Offset = "0x452C9C0", VA = "0x452C9C0")]
    public void FacialUpdate()
    {
    }

    [Token(Token = "0x6008C6C")]
    [Address(RVA = "0x452CBFC", Offset = "0x452CBFC", VA = "0x452CBFC")]
    public void ReleaseFacial()
    {
    }

    [Token(Token = "0x6008C6D")]
    [Address(RVA = "0x452CC0C", Offset = "0x452CC0C", VA = "0x452CC0C")]
    static FreeMapCharacterFacialAction()
    {
    }

    [Token(Token = "0x20018B9")]
    public enum FacialType
    {
      [Token(Token = "0x4006B4A")] Default,
      [Token(Token = "0x4006B4B")] Angry,
      [Token(Token = "0x4006B4C")] Disgust,
      [Token(Token = "0x4006B4D")] Pain,
      [Token(Token = "0x4006B4E")] Sad,
      [Token(Token = "0x4006B4F")] Serious,
      [Token(Token = "0x4006B50")] Smile,
      [Token(Token = "0x4006B51")] Surprise,
      [Token(Token = "0x4006B52")] Shy,
    }
  }
}
