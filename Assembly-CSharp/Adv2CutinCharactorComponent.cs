// Decompiled with JetBrains decompiler
// Type: Adv2CutinCharactorComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using Il2CppDummyDll;
using System.Collections;
using UI.Utilities;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E4")]
public class Adv2CutinCharactorComponent : MonoBehaviour
{
  [Token(Token = "0x4000409")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private DicingImage dicingImage;
  [Token(Token = "0x400040A")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private DicingImage shadowDicingImage;
  [Token(Token = "0x400040B")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private EyeMotionController eyeMotionController;
  [Token(Token = "0x400040C")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Vector2 eyeMotionDurationMinMax;
  [Token(Token = "0x400040D")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Vector2 eyeMotionSpaceDurationMinMax;
  [Token(Token = "0x400040E")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private ImageAdjustController imageAdjustController;
  [Token(Token = "0x400040F")]
  [FieldOffset(Offset = "0x48")]
  private string patternName;
  [Token(Token = "0x4000410")]
  [FieldOffset(Offset = "0x50")]
  private int patternBit;
  [Token(Token = "0x4000411")]
  [FieldOffset(Offset = "0x54")]
  protected EyeMotion eyeMotion;
  [Token(Token = "0x4000412")]
  [FieldOffset(Offset = "0x58")]
  protected MouthMotion mouthMotion;
  [Token(Token = "0x4000413")]
  [FieldOffset(Offset = "0x60")]
  protected string characterFaceName;
  [Token(Token = "0x4000414")]
  [FieldOffset(Offset = "0x68")]
  private Coroutine eyeBlinkCoroutine;

  [Token(Token = "0x600069D")]
  [Address(RVA = "0x4185CA0", Offset = "0x4185CA0", VA = "0x4185CA0")]
  private void Awake()
  {
  }

  [Token(Token = "0x600069E")]
  [Address(RVA = "0x4185D24", Offset = "0x4185D24", VA = "0x4185D24")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600069F")]
  [Address(RVA = "0x4185D6C", Offset = "0x4185D6C", VA = "0x4185D6C")]
  public void SetCharactorImage(
    CharaImage baseImage,
    string facial2DTag,
    bool mouthOpen,
    IllustLayoutInfo illustLayoutInfo,
    bool opened)
  {
  }

  [Token(Token = "0x60006A0")]
  [Address(RVA = "0x4185E5C", Offset = "0x4185E5C", VA = "0x4185E5C")]
  public void StartEyeMotion(float transitionTime = -1f)
  {
  }

  [Token(Token = "0x60006A1")]
  [Address(RVA = "0x4185EC0", Offset = "0x4185EC0", VA = "0x4185EC0")]
  public void FixedEyeClose(float transitionTime = -1f)
  {
  }

  [Token(Token = "0x60006A2")]
  [Address(RVA = "0x4185EE0", Offset = "0x4185EE0", VA = "0x4185EE0")]
  public void FixedEyeOpen(float transitionTime = -1f)
  {
  }

  [Token(Token = "0x60006A3")]
  [Address(RVA = "0x4185F00", Offset = "0x4185F00", VA = "0x4185F00")]
  public void StartLoopEye(float transitionTime = -1f)
  {
  }

  [Token(Token = "0x60006A4")]
  [Address(RVA = "0x4185D48", Offset = "0x4185D48", VA = "0x4185D48")]
  public void StopLoopEye()
  {
  }

  [Token(Token = "0x60006A5")]
  [Address(RVA = "0x4185FCC", Offset = "0x4185FCC", VA = "0x4185FCC")]
  private string GetPattern() => (string) null;

  [Token(Token = "0x60006A6")]
  [Address(RVA = "0x4185F54", Offset = "0x4185F54", VA = "0x4185F54")]
  private IEnumerator LoopEyeCore(float transitionTime) => (IEnumerator) null;

  [Token(Token = "0x60006A7")]
  [Address(RVA = "0x4185E54", Offset = "0x4185E54", VA = "0x4185E54")]
  public void ChangeFaceType(string characterFaceName)
  {
  }

  [Token(Token = "0x60006A8")]
  [Address(RVA = "0x4186214", Offset = "0x4186214", VA = "0x4186214")]
  public void UpdateEyeMotion(EyeMotion eyeMotion)
  {
  }

  [Token(Token = "0x60006A9")]
  [Address(RVA = "0x41861A8", Offset = "0x41861A8", VA = "0x41861A8")]
  private void ChangeFacePattern()
  {
  }

  [Token(Token = "0x60006AA")]
  [Address(RVA = "0x418621C", Offset = "0x418621C", VA = "0x418621C")]
  public Adv2CutinCharactorComponent()
  {
  }
}
