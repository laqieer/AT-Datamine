// Decompiled with JetBrains decompiler
// Type: Battle.UI.PlayerPhaseEffector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002301")]
  public class PlayerPhaseEffector
  {
    [Token(Token = "0x400941F")]
    [FieldOffset(Offset = "0x10")]
    protected IDirector mainDirector;
    [Token(Token = "0x4009420")]
    [FieldOffset(Offset = "0x18")]
    protected string bgmFileName;

    [Token(Token = "0x600D5F1")]
    [Address(RVA = "0x1D1989C", Offset = "0x1D1989C", VA = "0x1D1989C")]
    private PlayerPhaseEffector()
    {
    }

    [Token(Token = "0x17002E38")]
    public bool SkipWinEffect
    {
      [Token(Token = "0x600D5F2"), Address(RVA = "0x1D198F4", Offset = "0x1D198F4", VA = "0x1D198F4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D5F3"), Address(RVA = "0x1D198FC", Offset = "0x1D198FC", VA = "0x1D198FC")] protected set
      {
      }
    }

    [Token(Token = "0x600D5F4")]
    [Address(RVA = "0x1D19908", Offset = "0x1D19908", VA = "0x1D19908")]
    public PlayerPhaseEffector(IDirector director)
    {
    }

    [Token(Token = "0x600D5F5")]
    [Address(RVA = "0x1D19974", Offset = "0x1D19974", VA = "0x1D19974", Slot = "4")]
    public virtual void OnOwnPhaseBeginStep()
    {
    }

    [Token(Token = "0x600D5F6")]
    [Address(RVA = "0x1D19978", Offset = "0x1D19978", VA = "0x1D19978")]
    public void PlayBGM()
    {
    }

    [Token(Token = "0x600D5F7")]
    [Address(RVA = "0x1D19A14", Offset = "0x1D19A14", VA = "0x1D19A14")]
    protected void PlaySE(AttentionTween.Mode mode)
    {
    }

    [Token(Token = "0x600D5F8")]
    [Address(RVA = "0x1D19BC0", Offset = "0x1D19BC0", VA = "0x1D19BC0", Slot = "5")]
    public virtual string GetDyingEffectName() => (string) null;
  }
}
