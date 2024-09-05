// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Camera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E0B")]
  public class Adv2Camera : Adv2Object
  {
    [Token(Token = "0x401102E")]
    [FieldOffset(Offset = "0xA0")]
    protected CinemachineVirtualCamera core;
    [Token(Token = "0x401102F")]
    [FieldOffset(Offset = "0xA8")]
    private Adv2Camera crossDissolveSource;
    [Token(Token = "0x4011030")]
    [FieldOffset(Offset = "0xB0")]
    private RenderTexture crossDissolveSourceTexture;
    [Token(Token = "0x4011031")]
    [FieldOffset(Offset = "0xB8")]
    private GameObject renderCameraObject;
    [Token(Token = "0x4011032")]
    [FieldOffset(Offset = "0xC0")]
    private Adv2CameraOffset cameraOffset;
    [Token(Token = "0x4011033")]
    [FieldOffset(Offset = "0xC8")]
    private bool skipOffset;
    [Token(Token = "0x4011034")]
    [FieldOffset(Offset = "0xD0")]
    private Adv2Manager.LightEffectParameter lightEffectParameter;
    [Token(Token = "0x4011035")]
    [FieldOffset(Offset = "0xD8")]
    private bool disableSceneVignette;
    [Token(Token = "0x4011036")]
    [FieldOffset(Offset = "0xE0")]
    private AdvSmallManager advSmallManager;
    [Token(Token = "0x4011037")]
    [FieldOffset(Offset = "0xE8")]
    private GameObject focusTarget;
    [Token(Token = "0x4011038")]
    [FieldOffset(Offset = "0xF0")]
    private GameObject targetCamera;
    [Token(Token = "0x4011039")]
    [FieldOffset(Offset = "0xF8")]
    protected Coroutine coWaitShake;
    [Token(Token = "0x401103A")]
    [FieldOffset(Offset = "0x100")]
    private Animation positionAnimation;
    [Token(Token = "0x401103B")]
    [FieldOffset(Offset = "0x108")]
    private string positionAnimationClipName;

    [Token(Token = "0x17005137")]
    public Adv2CameraOffset CameraOffset
    {
      [Token(Token = "0x6018F6E"), Address(RVA = "0x2CB62FC", Offset = "0x2CB62FC", VA = "0x2CB62FC")] get
      {
        return (Adv2CameraOffset) null;
      }
    }

    [Token(Token = "0x17005138")]
    public bool SkipOffset
    {
      [Token(Token = "0x6018F6F"), Address(RVA = "0x2CB6304", Offset = "0x2CB6304", VA = "0x2CB6304")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018F70"), Address(RVA = "0x2CB630C", Offset = "0x2CB630C", VA = "0x2CB630C")] set
      {
      }
    }

    [Token(Token = "0x6018F71")]
    [Address(RVA = "0x2CB6318", Offset = "0x2CB6318", VA = "0x2CB6318")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6018F72")]
    [Address(RVA = "0x2CB64A4", Offset = "0x2CB64A4", VA = "0x2CB64A4")]
    public void SetCamera(Camera camera)
    {
    }

    [Token(Token = "0x6018F73")]
    [Address(RVA = "0x2CB66C4", Offset = "0x2CB66C4", VA = "0x2CB66C4")]
    public void UpdateParam()
    {
    }

    [Token(Token = "0x6018F74")]
    [Address(RVA = "0x2CB66C8", Offset = "0x2CB66C8", VA = "0x2CB66C8", Slot = "8")]
    public override Adv2Manager.OnProccessSignal Move(
      Vector3 targetPosition,
      float duration,
      Adv2Object.RootAnimationType type)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x17005139")]
    public float FieldOfView
    {
      [Token(Token = "0x6018F75"), Address(RVA = "0x2CB678C", Offset = "0x2CB678C", VA = "0x2CB678C")] get
      {
        return new float();
      }
      [Token(Token = "0x6018F76"), Address(RVA = "0x2CB67A8", Offset = "0x2CB67A8", VA = "0x2CB67A8")] set
      {
      }
    }

    [Token(Token = "0x1700513A")]
    public float Dutch
    {
      [Token(Token = "0x6018F77"), Address(RVA = "0x2CB67C4", Offset = "0x2CB67C4", VA = "0x2CB67C4")] get
      {
        return new float();
      }
      [Token(Token = "0x6018F78"), Address(RVA = "0x2CB67E0", Offset = "0x2CB67E0", VA = "0x2CB67E0")] set
      {
      }
    }

    [Token(Token = "0x1700513B")]
    public float NearClip
    {
      [Token(Token = "0x6018F79"), Address(RVA = "0x2CB67FC", Offset = "0x2CB67FC", VA = "0x2CB67FC")] get
      {
        return new float();
      }
      [Token(Token = "0x6018F7A"), Address(RVA = "0x2CB6818", Offset = "0x2CB6818", VA = "0x2CB6818")] set
      {
      }
    }

    [Token(Token = "0x1700513C")]
    public float FarClip
    {
      [Token(Token = "0x6018F7B"), Address(RVA = "0x2CB6834", Offset = "0x2CB6834", VA = "0x2CB6834")] get
      {
        return new float();
      }
      [Token(Token = "0x6018F7C"), Address(RVA = "0x2CB6850", Offset = "0x2CB6850", VA = "0x2CB6850")] set
      {
      }
    }

    [Token(Token = "0x1700513D")]
    public Vector3 LookAt
    {
      [Token(Token = "0x6018F7D"), Address(RVA = "0x2CB686C", Offset = "0x2CB686C", VA = "0x2CB686C")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6018F7E"), Address(RVA = "0x2CB6954", Offset = "0x2CB6954", VA = "0x2CB6954")] set
      {
      }
    }

    [Token(Token = "0x6018F7F")]
    [Address(RVA = "0x2CB6B20", Offset = "0x2CB6B20", VA = "0x2CB6B20")]
    public void ResetLookAt()
    {
    }

    [Token(Token = "0x6018F80")]
    [Address(RVA = "0x2CB6BF8", Offset = "0x2CB6BF8", VA = "0x2CB6BF8")]
    public void StartShake(float amplitude, float duration)
    {
    }

    [Token(Token = "0x6018F81")]
    [Address(RVA = "0x2CB6DF8", Offset = "0x2CB6DF8", VA = "0x2CB6DF8")]
    public void StopShake()
    {
    }

    [Token(Token = "0x6018F82")]
    [Address(RVA = "0x2CB6414", Offset = "0x2CB6414", VA = "0x2CB6414")]
    private void StopShakeCoroutine()
    {
    }

    [Token(Token = "0x6018F83")]
    [Address(RVA = "0x2CB6D80", Offset = "0x2CB6D80", VA = "0x2CB6D80")]
    private IEnumerator WaitShake(float duration) => (IEnumerator) null;

    [Token(Token = "0x6018F84")]
    [Address(RVA = "0x2CB6E78", Offset = "0x2CB6E78", VA = "0x2CB6E78")]
    public void StartCrossDissolve(Adv2Camera source, float durarion, float scale)
    {
    }

    [Token(Token = "0x6018F85")]
    [Address(RVA = "0x2CB6330", Offset = "0x2CB6330", VA = "0x2CB6330")]
    public void StopCrossDissolve()
    {
    }

    [Token(Token = "0x6018F86")]
    [Address(RVA = "0x2CB74F4", Offset = "0x2CB74F4", VA = "0x2CB74F4")]
    private IEnumerator CorssDissloveTimer(CinemachineStoryboard storyboard, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018F87")]
    [Address(RVA = "0x2CB6FD8", Offset = "0x2CB6FD8", VA = "0x2CB6FD8")]
    public RenderTexture CreateCrossDissolveRenderTexture(float scaleX, float scaleY)
    {
      return (RenderTexture) null;
    }

    [Token(Token = "0x6018F88")]
    [Address(RVA = "0x2CB757C", Offset = "0x2CB757C", VA = "0x2CB757C")]
    public void DestroyCrossDissolveRenderTexture()
    {
    }

    [Token(Token = "0x6018F89")]
    [Address(RVA = "0x2CB7668", Offset = "0x2CB7668", VA = "0x2CB7668")]
    public void DisableCrossDissolveRenderCamera()
    {
    }

    [Token(Token = "0x6018F8A")]
    [Address(RVA = "0x2CB76F0", Offset = "0x2CB76F0", VA = "0x2CB76F0")]
    public Adv2Manager.OnProccessSignal LoadCameraAnimation(
      string animationAssetbundleName,
      string animationFileName)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018F8B")]
    [Address(RVA = "0x2CB77F4", Offset = "0x2CB77F4", VA = "0x2CB77F4")]
    public Adv2Manager.OnProccessSignal LoadExclusiveCamera(
      string animationAssetbundleName,
      string animationFileName,
      Adv2Object actor)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018F8C")]
    [Address(RVA = "0x2CB7908", Offset = "0x2CB7908", VA = "0x2CB7908")]
    public void SetLoadedAnimationClip(AnimationClip animationClip)
    {
    }

    [Token(Token = "0x6018F8D")]
    [Address(RVA = "0x2CB7A1C", Offset = "0x2CB7A1C", VA = "0x2CB7A1C")]
    public void SetLoadedAnimationClipExclusiv(AnimationClip animationClip, Adv2Object actor)
    {
    }

    [Token(Token = "0x6018F8E")]
    [Address(RVA = "0x2CB7D6C", Offset = "0x2CB7D6C", VA = "0x2CB7D6C")]
    public bool IsPositionAnimationPlayng() => new bool();

    [Token(Token = "0x6018F8F")]
    [Address(RVA = "0x2CB7CD8", Offset = "0x2CB7CD8", VA = "0x2CB7CD8")]
    private void InitalizeDepthOfField(GameObject focusTarget)
    {
    }

    [Token(Token = "0x6018F90")]
    [Address(RVA = "0x2CB345C", Offset = "0x2CB345C", VA = "0x2CB345C")]
    public void SetOffset()
    {
    }

    [Token(Token = "0x6018F91")]
    [Address(RVA = "0x2CB7E94", Offset = "0x2CB7E94", VA = "0x2CB7E94")]
    public void CopyOffset(Adv2Object srcObject)
    {
    }

    [Token(Token = "0x6018F92")]
    [Address(RVA = "0x2CB38A8", Offset = "0x2CB38A8", VA = "0x2CB38A8")]
    public void DontCameraOffset()
    {
    }

    [Token(Token = "0x6018F93")]
    [Address(RVA = "0x2CB8008", Offset = "0x2CB8008", VA = "0x2CB8008", Slot = "10")]
    public override void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6018F94")]
    [Address(RVA = "0x2CB3770", Offset = "0x2CB3770", VA = "0x2CB3770")]
    public void SetActiveWithAnimation(bool active)
    {
    }

    [Token(Token = "0x6018F95")]
    [Address(RVA = "0x2CB80B0", Offset = "0x2CB80B0", VA = "0x2CB80B0")]
    public void SetLightEffectParameter(
      float? bgParametersHardlightBlend,
      Color? bgParametersHardlightColor,
      LightForCharacters.LightDirectionType? lightForChrarctersDirectionType,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x6018F96")]
    [Address(RVA = "0x2CB8194", Offset = "0x2CB8194", VA = "0x2CB8194")]
    public void SetVignetteEffect(
      Vector2 center,
      Color color,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x6018F97")]
    [Address(RVA = "0x2CB829C", Offset = "0x2CB829C", VA = "0x2CB829C")]
    public void DisableVignetteEffect()
    {
    }

    [Token(Token = "0x6018F98")]
    [Address(RVA = "0x2CB2CD0", Offset = "0x2CB2CD0", VA = "0x2CB2CD0")]
    public void Release()
    {
    }

    [Token(Token = "0x6018F99")]
    [Address(RVA = "0x2CB8334", Offset = "0x2CB8334", VA = "0x2CB8334")]
    private void UpdateFocalLength()
    {
    }

    [Token(Token = "0x6018F9A")]
    [Address(RVA = "0x2CB84F0", Offset = "0x2CB84F0", VA = "0x2CB84F0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6018F9B")]
    [Address(RVA = "0x2CB858C", Offset = "0x2CB858C", VA = "0x2CB858C", Slot = "6")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x6018F9C")]
    [Address(RVA = "0x2CB85A8", Offset = "0x2CB85A8", VA = "0x2CB85A8")]
    public static Adv2Camera Create(string objectName, Transform parent) => (Adv2Camera) null;

    [Token(Token = "0x6018F9D")]
    [Address(RVA = "0x2CB8608", Offset = "0x2CB8608", VA = "0x2CB8608")]
    public Adv2Camera()
    {
    }
  }
}
