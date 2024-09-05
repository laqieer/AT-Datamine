// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCharacterClipMotion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.Action;
using FreeMap.Loader;
using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018B7")]
  public class FreeMapCharacterClipMotion : IFreeMapCharacterActionController
  {
    [Token(Token = "0x4006B3A")]
    [FieldOffset(Offset = "0x28")]
    private ResourceCacheHandle clipPackHandle;

    [Token(Token = "0x17001687")]
    private FreeMapCharacterAction Parent
    {
      [Token(Token = "0x6008C5C"), Address(RVA = "0x452C558", Offset = "0x452C558", VA = "0x452C558")] get
      {
        return (FreeMapCharacterAction) null;
      }
    }

    [Token(Token = "0x17001688")]
    private FreeMapClipActionBase ClipAction
    {
      [Token(Token = "0x6008C5D"), Address(RVA = "0x452C560", Offset = "0x452C560", VA = "0x452C560")] set
      {
      }
      [Token(Token = "0x6008C5E"), Address(RVA = "0x452C568", Offset = "0x452C568", VA = "0x452C568")] get
      {
        return (FreeMapClipActionBase) null;
      }
    }

    [Token(Token = "0x17001689")]
    public FreeMapSideInFreeAnimator Controller
    {
      [Token(Token = "0x6008C5F"), Address(RVA = "0x452C570", Offset = "0x452C570", VA = "0x452C570")] set
      {
      }
      [Token(Token = "0x6008C60"), Address(RVA = "0x452C578", Offset = "0x452C578", VA = "0x452C578")] get
      {
        return (FreeMapSideInFreeAnimator) null;
      }
    }

    [Token(Token = "0x1700168A")]
    public FreeMapAnimationClipPack ClipPackage
    {
      [Token(Token = "0x6008C61"), Address(RVA = "0x452C580", Offset = "0x452C580", VA = "0x452C580")] private set
      {
      }
      [Token(Token = "0x6008C62"), Address(RVA = "0x452C588", Offset = "0x452C588", VA = "0x452C588")] get
      {
        return (FreeMapAnimationClipPack) null;
      }
    }

    [Token(Token = "0x6008C63")]
    [Address(RVA = "0x452BC24", Offset = "0x452BC24", VA = "0x452BC24")]
    public FreeMapCharacterClipMotion(FreeMapCharacterAction parent)
    {
    }

    [Token(Token = "0x6008C64")]
    [Address(RVA = "0x452BE40", Offset = "0x452BE40", VA = "0x452BE40")]
    public void Play(FreeMapClipActionBase action)
    {
    }

    [Token(Token = "0x6008C65")]
    [Address(RVA = "0x452BEF8", Offset = "0x452BEF8", VA = "0x452BEF8")]
    public void Initialize(FreeMapSideInFreeAnimator controller)
    {
    }

    [Token(Token = "0x6008C66")]
    [Address(RVA = "0x452C590", Offset = "0x452C590", VA = "0x452C590", Slot = "4")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6008C67")]
    [Address(RVA = "0x452C5E4", Offset = "0x452C5E4", VA = "0x452C5E4", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x6008C68")]
    [Address(RVA = "0x452C660", Offset = "0x452C660", VA = "0x452C660")]
    public void RequestLoad(System.Action<FreeMapAnimationClipPack> callback)
    {
    }

    [Token(Token = "0x6008C69")]
    [Address(RVA = "0x452BF3C", Offset = "0x452BF3C", VA = "0x452BF3C")]
    public void SetClipPackage(ResourceCacheHandle clipHandle)
    {
    }
  }
}
