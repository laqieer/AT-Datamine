// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB3")]
  public class PostProcessingProfile : ScriptableObject
  {
    [Token(Token = "0x40116FA")]
    [FieldOffset(Offset = "0x18")]
    public BuiltinDebugViewsModel debugViews;
    [Token(Token = "0x40116FB")]
    [FieldOffset(Offset = "0x20")]
    public FogModel fog;
    [Token(Token = "0x40116FC")]
    [FieldOffset(Offset = "0x28")]
    public AntialiasingModel antialiasing;
    [Token(Token = "0x40116FD")]
    [FieldOffset(Offset = "0x30")]
    public AmbientOcclusionModel ambientOcclusion;
    [Token(Token = "0x40116FE")]
    [FieldOffset(Offset = "0x38")]
    public ScreenSpaceReflectionModel screenSpaceReflection;
    [Token(Token = "0x40116FF")]
    [FieldOffset(Offset = "0x40")]
    public DepthOfFieldModel depthOfField;
    [Token(Token = "0x4011700")]
    [FieldOffset(Offset = "0x48")]
    public MotionBlurModel motionBlur;
    [Token(Token = "0x4011701")]
    [FieldOffset(Offset = "0x50")]
    public EyeAdaptationModel eyeAdaptation;
    [Token(Token = "0x4011702")]
    [FieldOffset(Offset = "0x58")]
    public BloomModel bloom;
    [Token(Token = "0x4011703")]
    [FieldOffset(Offset = "0x60")]
    public ColorGradingModel colorGrading;
    [Token(Token = "0x4011704")]
    [FieldOffset(Offset = "0x68")]
    public UserLutModel userLut;
    [Token(Token = "0x4011705")]
    [FieldOffset(Offset = "0x70")]
    public ChromaticAberrationModel chromaticAberration;
    [Token(Token = "0x4011706")]
    [FieldOffset(Offset = "0x78")]
    public GrainModel grain;
    [Token(Token = "0x4011707")]
    [FieldOffset(Offset = "0x80")]
    public VignetteModel vignette;
    [Token(Token = "0x4011708")]
    [FieldOffset(Offset = "0x88")]
    public DitheringModel dithering;

    [Token(Token = "0x60199F1")]
    [Address(RVA = "0x343E5F0", Offset = "0x343E5F0", VA = "0x343E5F0")]
    public PostProcessingProfile()
    {
    }
  }
}
