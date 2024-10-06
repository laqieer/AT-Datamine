// Decompiled with JetBrains decompiler
// Type: Dicing.CharaImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F2A")]
  public class CharaImage : MonoBehaviour
  {
    [Token(Token = "0x40085A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private DicingImage dicingImage;
    [Token(Token = "0x40085A8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected EyeMotionController eyeMotionController;
    [Token(Token = "0x40085A9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected MouthMotionController mouthMotionController;
    [Token(Token = "0x40085AA")]
    [FieldOffset(Offset = "0x30")]
    protected EyeMotion eyeMotion;
    [Token(Token = "0x40085AB")]
    [FieldOffset(Offset = "0x34")]
    protected MouthMotion mouthMotion;
    [Token(Token = "0x40085AC")]
    [FieldOffset(Offset = "0x38")]
    protected string characterFaceName;
    [Token(Token = "0x40085AD")]
    [FieldOffset(Offset = "0x40")]
    private string patternName;
    [Token(Token = "0x40085AE")]
    [FieldOffset(Offset = "0x48")]
    private int patternBit;

    [Token(Token = "0x17002672")]
    public DicingImage charactorImage
    {
      [Token(Token = "0x600B918"), Address(RVA = "0x213904C", Offset = "0x213904C", VA = "0x213904C")] get
      {
        return (DicingImage) null;
      }
    }

    [Token(Token = "0x17002673")]
    public string PatternName
    {
      [Token(Token = "0x600B919"), Address(RVA = "0x2139054", Offset = "0x2139054", VA = "0x2139054")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002674")]
    public int PatternBit
    {
      [Token(Token = "0x600B91A"), Address(RVA = "0x213905C", Offset = "0x213905C", VA = "0x213905C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B91B")]
    [Address(RVA = "0x2139064", Offset = "0x2139064", VA = "0x2139064")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B91C")]
    [Address(RVA = "0x213913C", Offset = "0x213913C", VA = "0x213913C")]
    [Conditional("UNITY_EDITOR")]
    public void SetDicingImage(DicingImage dicingImage)
    {
    }

    [Token(Token = "0x600B91D")]
    [Address(RVA = "0x2139144", Offset = "0x2139144", VA = "0x2139144")]
    [Conditional("UNITY_EDITOR")]
    public void SetMotionController(
      EyeMotionController eyeMotionController,
      MouthMotionController mouthMotionController)
    {
    }

    [Token(Token = "0x600B91E")]
    [Address(RVA = "0x213914C", Offset = "0x213914C", VA = "0x213914C")]
    public List<string> GetPatternList() => (List<string>) null;

    [Token(Token = "0x600B91F")]
    [Address(RVA = "0x21391E8", Offset = "0x21391E8", VA = "0x21391E8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600B920")]
    [Address(RVA = "0x21391EC", Offset = "0x21391EC", VA = "0x21391EC")]
    public void CreatePatten()
    {
    }

    [Token(Token = "0x600B921")]
    [Address(RVA = "0x21395E0", Offset = "0x21395E0", VA = "0x21395E0")]
    private string GetPattern() => (string) null;

    [Token(Token = "0x600B922")]
    [Address(RVA = "0x2139794", Offset = "0x2139794", VA = "0x2139794")]
    public void ChangeAllPattern(
      string characterFaceName,
      EyeMotion eyeMotion,
      MouthMotion mouthMotion)
    {
    }

    [Token(Token = "0x600B923")]
    [Address(RVA = "0x21397E8", Offset = "0x21397E8", VA = "0x21397E8")]
    public void ChangeFaceType(string characterFaceName)
    {
    }

    [Token(Token = "0x600B924")]
    [Address(RVA = "0x21397F0", Offset = "0x21397F0", VA = "0x21397F0")]
    public void UpdateEyeMotion(EyeMotion eyeMotion)
    {
    }

    [Token(Token = "0x600B925")]
    [Address(RVA = "0x21397A0", Offset = "0x21397A0", VA = "0x21397A0")]
    private void ChangeFacePattern()
    {
    }

    [Token(Token = "0x600B926")]
    [Address(RVA = "0x2139800", Offset = "0x2139800", VA = "0x2139800")]
    public void UpdateMouthMotion(MouthMotion mouthMotion)
    {
    }

    [Token(Token = "0x600B927")]
    [Address(RVA = "0x2139808", Offset = "0x2139808", VA = "0x2139808")]
    public void ChangeCharaId(string characterFaceName = "")
    {
    }

    [Token(Token = "0x600B928")]
    [Address(RVA = "0x213981C", Offset = "0x213981C", VA = "0x213981C")]
    protected void ChangeDicingTextures(DicingTextures nextDicingTexture)
    {
    }

    [Token(Token = "0x600B929")]
    [Address(RVA = "0x21398C0", Offset = "0x21398C0", VA = "0x21398C0")]
    public void ChangeCharacter(DicingTextures dicingTextures, string characterFaceName = "")
    {
    }

    [Token(Token = "0x600B92A")]
    [Address(RVA = "0x21398D4", Offset = "0x21398D4", VA = "0x21398D4")]
    public void StartEyeMotion(float transitionTime = -1f, bool debugflag = false)
    {
    }

    [Token(Token = "0x600B92B")]
    [Address(RVA = "0x213993C", Offset = "0x213993C", VA = "0x213993C")]
    public void FixedEyeClose(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B92C")]
    [Address(RVA = "0x213995C", Offset = "0x213995C", VA = "0x213995C")]
    public void FixedEyeOpen(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B92D")]
    [Address(RVA = "0x213997C", Offset = "0x213997C", VA = "0x213997C")]
    public void StartMouthMotion(float transitionTime = -1f, bool debugflag = false)
    {
    }

    [Token(Token = "0x600B92E")]
    [Address(RVA = "0x21399E4", Offset = "0x21399E4", VA = "0x21399E4")]
    public void FixedMouthClose(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B92F")]
    [Address(RVA = "0x2139A04", Offset = "0x2139A04", VA = "0x2139A04")]
    public void FixedMouthOpen(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B930")]
    [Address(RVA = "0x2139A24", Offset = "0x2139A24", VA = "0x2139A24")]
    public void ChangeAlpha(float alpha)
    {
    }

    [Token(Token = "0x600B931")]
    [Address(RVA = "0x2139ABC", Offset = "0x2139ABC", VA = "0x2139ABC")]
    public void TestLoopEye()
    {
    }

    [Token(Token = "0x600B932")]
    [Address(RVA = "0x2139B0C", Offset = "0x2139B0C", VA = "0x2139B0C")]
    public void StopLoopEye()
    {
    }

    [Token(Token = "0x600B933")]
    [Address(RVA = "0x2139B5C", Offset = "0x2139B5C", VA = "0x2139B5C")]
    public void TestLoopMouth()
    {
    }

    [Token(Token = "0x600B934")]
    [Address(RVA = "0x2139BAC", Offset = "0x2139BAC", VA = "0x2139BAC")]
    public void StopLoopMouth()
    {
    }

    [Token(Token = "0x600B935")]
    [Address(RVA = "0x2139BFC", Offset = "0x2139BFC", VA = "0x2139BFC")]
    public float GetMouthAnimTotalTime() => new float();

    [Token(Token = "0x600B936")]
    [Address(RVA = "0x2139C18", Offset = "0x2139C18", VA = "0x2139C18")]
    public void SetImageAnchoredPosition(Vector2 position)
    {
    }

    [Token(Token = "0x600B937")]
    [Address(RVA = "0x2139C58", Offset = "0x2139C58", VA = "0x2139C58")]
    public CharaImage()
    {
    }

    [Token(Token = "0x2001F2B")]
    public enum UsePattern
    {
      [Token(Token = "0x40085B0")] FacePattern = 1,
      [Token(Token = "0x40085B1")] EyePattern = 2,
      [Token(Token = "0x40085B4")] FE = 3,
      [Token(Token = "0x40085B2")] MouthPattern = 4,
      [Token(Token = "0x40085B5")] FM = 5,
      [Token(Token = "0x40085B3")] EM = 6,
      [Token(Token = "0x40085B6")] All = 7,
    }
  }
}
