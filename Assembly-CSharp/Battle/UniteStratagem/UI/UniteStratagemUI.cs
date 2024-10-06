// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UI.UniteStratagemUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UniteStratagem.UI
{
  [Token(Token = "0x20022B7")]
  public class UniteStratagemUI : MonoBehaviour
  {
    [Token(Token = "0x4009263")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UIAnimationController animationController;
    [Token(Token = "0x4009264")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitImageController[] imageControllers;

    [Token(Token = "0x17002DE5")]
    public bool IsPlayingAnimation
    {
      [Token(Token = "0x600D3C9"), Address(RVA = "0x19DAB4C", Offset = "0x19DAB4C", VA = "0x19DAB4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002DE6")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D3CA"), Address(RVA = "0x19D7784", Offset = "0x19D7784", VA = "0x19D7784")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D3CB")]
    [Address(RVA = "0x19DAB80", Offset = "0x19DAB80", VA = "0x19DAB80")]
    public void Prepare(RenderTexture[] attachTextures)
    {
    }

    [Token(Token = "0x600D3CC")]
    [Address(RVA = "0x19DACCC", Offset = "0x19DACCC", VA = "0x19DACCC")]
    public void PlayAnimation()
    {
    }

    [Token(Token = "0x600D3CD")]
    [Address(RVA = "0x19DACE8", Offset = "0x19DACE8", VA = "0x19DACE8")]
    public void StopAnimation()
    {
    }

    [Token(Token = "0x600D3CE")]
    [Address(RVA = "0x19DAD04", Offset = "0x19DAD04", VA = "0x19DAD04")]
    public void Release()
    {
    }

    [Token(Token = "0x600D3CF")]
    [Address(RVA = "0x19DADC0", Offset = "0x19DADC0", VA = "0x19DADC0")]
    public UniteStratagemUI()
    {
    }
  }
}
