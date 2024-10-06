// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FAC")]
  [ImageEffectAllowedInSceneView]
  [RequireComponent(typeof (Camera))]
  [AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
  [ExecuteInEditMode]
  [DisallowMultipleComponent]
  public class PostProcessingBehaviour : MonoBehaviour
  {
    [Token(Token = "0x40116D5")]
    [FieldOffset(Offset = "0x18")]
    public PostProcessingProfile profile;
    [Token(Token = "0x40116D6")]
    [FieldOffset(Offset = "0x20")]
    public Func<Vector2, Matrix4x4> jitteredMatrixFunc;
    [Token(Token = "0x40116D7")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<System.Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;
    [Token(Token = "0x40116D8")]
    [FieldOffset(Offset = "0x30")]
    private List<PostProcessingComponentBase> m_Components;
    [Token(Token = "0x40116D9")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;
    [Token(Token = "0x40116DA")]
    [FieldOffset(Offset = "0x40")]
    private MaterialFactory m_MaterialFactory;
    [Token(Token = "0x40116DB")]
    [FieldOffset(Offset = "0x48")]
    private RenderTextureFactory m_RenderTextureFactory;
    [Token(Token = "0x40116DC")]
    [FieldOffset(Offset = "0x50")]
    private PostProcessingContext m_Context;
    [Token(Token = "0x40116DD")]
    [FieldOffset(Offset = "0x58")]
    private Camera m_Camera;
    [Token(Token = "0x40116DE")]
    [FieldOffset(Offset = "0x60")]
    private PostProcessingProfile m_PreviousProfile;
    [Token(Token = "0x40116DF")]
    [FieldOffset(Offset = "0x68")]
    private bool m_RenderingInSceneView;
    [Token(Token = "0x40116E0")]
    [FieldOffset(Offset = "0x70")]
    private BuiltinDebugViewsComponent m_DebugViews;
    [Token(Token = "0x40116E1")]
    [FieldOffset(Offset = "0x78")]
    private AmbientOcclusionComponent m_AmbientOcclusion;
    [Token(Token = "0x40116E2")]
    [FieldOffset(Offset = "0x80")]
    private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;
    [Token(Token = "0x40116E3")]
    [FieldOffset(Offset = "0x88")]
    private FogComponent m_FogComponent;
    [Token(Token = "0x40116E4")]
    [FieldOffset(Offset = "0x90")]
    private MotionBlurComponent m_MotionBlur;
    [Token(Token = "0x40116E5")]
    [FieldOffset(Offset = "0x98")]
    private TaaComponent m_Taa;
    [Token(Token = "0x40116E6")]
    [FieldOffset(Offset = "0xA0")]
    private EyeAdaptationComponent m_EyeAdaptation;
    [Token(Token = "0x40116E7")]
    [FieldOffset(Offset = "0xA8")]
    private DepthOfFieldComponent m_DepthOfField;
    [Token(Token = "0x40116E8")]
    [FieldOffset(Offset = "0xB0")]
    private BloomComponent m_Bloom;
    [Token(Token = "0x40116E9")]
    [FieldOffset(Offset = "0xB8")]
    private ChromaticAberrationComponent m_ChromaticAberration;
    [Token(Token = "0x40116EA")]
    [FieldOffset(Offset = "0xC0")]
    private ColorGradingComponent m_ColorGrading;
    [Token(Token = "0x40116EB")]
    [FieldOffset(Offset = "0xC8")]
    private UserLutComponent m_UserLut;
    [Token(Token = "0x40116EC")]
    [FieldOffset(Offset = "0xD0")]
    private GrainComponent m_Grain;
    [Token(Token = "0x40116ED")]
    [FieldOffset(Offset = "0xD8")]
    private VignetteComponent m_Vignette;
    [Token(Token = "0x40116EE")]
    [FieldOffset(Offset = "0xE0")]
    private DitheringComponent m_Dithering;
    [Token(Token = "0x40116EF")]
    [FieldOffset(Offset = "0xE8")]
    private FxaaComponent m_Fxaa;
    [Token(Token = "0x40116F0")]
    [FieldOffset(Offset = "0xF0")]
    private List<PostProcessingComponentBase> m_ComponentsToEnable;
    [Token(Token = "0x40116F1")]
    [FieldOffset(Offset = "0xF8")]
    private List<PostProcessingComponentBase> m_ComponentsToDisable;

    [Token(Token = "0x60199C0")]
    [Address(RVA = "0x343C4C8", Offset = "0x343C4C8", VA = "0x343C4C8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60199C1")]
    [Address(RVA = "0x343CCB0", Offset = "0x343CCB0", VA = "0x343CCB0")]
    private void OnPreCull()
    {
    }

    [Token(Token = "0x60199C2")]
    [Address(RVA = "0x343D78C", Offset = "0x343D78C", VA = "0x343D78C")]
    private void OnPreRender()
    {
    }

    [Token(Token = "0x60199C3")]
    [Address(RVA = "0x343D8C4", Offset = "0x343D8C4", VA = "0x343D8C4")]
    private void OnPostRender()
    {
    }

    [Token(Token = "0x60199C4")]
    [Address(RVA = "0x343D9C8", Offset = "0x343D9C8", VA = "0x343D9C8")]
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
    }

    [Token(Token = "0x60199C5")]
    [Address(RVA = "0x343E050", Offset = "0x343E050", VA = "0x343E050")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x60199C6")]
    [Address(RVA = "0x343E1D8", Offset = "0x343E1D8", VA = "0x343E1D8")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60199C7")]
    [Address(RVA = "0x343E4A8", Offset = "0x343E4A8", VA = "0x343E4A8")]
    public void ResetTemporalEffects()
    {
    }

    [Token(Token = "0x60199C8")]
    [Address(RVA = "0x343D374", Offset = "0x343D374", VA = "0x343D374")]
    private void CheckObservers()
    {
    }

    [Token(Token = "0x60199C9")]
    [Address(RVA = "0x343D200", Offset = "0x343D200", VA = "0x343D200")]
    private void DisableComponents()
    {
    }

    [Token(Token = "0x60199CA")]
    private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
    {
      return (CommandBuffer) null;
    }

    [Token(Token = "0x60199CB")]
    private void RemoveCommandBuffer<T>() where T : PostProcessingModel
    {
    }

    [Token(Token = "0x60199CC")]
    private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
    {
      return (CommandBuffer) null;
    }

    [Token(Token = "0x60199CD")]
    private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
    {
    }

    [Token(Token = "0x60199CE")]
    private bool TryPrepareUberImageEffect<T>(
      PostProcessingComponentRenderTexture<T> component,
      Material material)
      where T : PostProcessingModel
    {
      return new bool();
    }

    [Token(Token = "0x60199CF")]
    private T AddComponent<T>(T component) where T : PostProcessingComponentBase => (T) null;

    [Token(Token = "0x60199D0")]
    [Address(RVA = "0x343E4FC", Offset = "0x343E4FC", VA = "0x343E4FC")]
    public PostProcessingBehaviour()
    {
    }
  }
}
