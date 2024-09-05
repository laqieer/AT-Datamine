// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.SimpleStatusEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002568")]
  public sealed class SimpleStatusEffect : BaseSimpleDuelAction
  {
    [Token(Token = "0x400A08E")]
    private const float Interval = 1.5f;

    [Token(Token = "0x600E6A6")]
    [Address(RVA = "0x4875820", Offset = "0x4875820", VA = "0x4875820", Slot = "12")]
    public override void Initialize(
      DuelData data,
      ActionData targetActionData,
      IDirector mainDirector)
    {
    }

    [Token(Token = "0x600E6A7")]
    [Address(RVA = "0x487582C", Offset = "0x487582C", VA = "0x487582C", Slot = "13")]
    public override void RequestStaging()
    {
    }

    [Token(Token = "0x600E6A8")]
    [Address(RVA = "0x4875870", Offset = "0x4875870", VA = "0x4875870")]
    private void ShowNextEffect()
    {
    }

    [Token(Token = "0x600E6A9")]
    [Address(RVA = "0x486EC10", Offset = "0x486EC10", VA = "0x486EC10")]
    public SimpleStatusEffect()
    {
    }
  }
}
