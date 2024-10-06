// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.SimpleHpDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002560")]
  public sealed class SimpleHpDamage : BaseSimpleDuelAction
  {
    [Token(Token = "0x400A089")]
    [FieldOffset(Offset = "0x38")]
    private new IDirector mainDirector;
    [Token(Token = "0x400A08A")]
    [FieldOffset(Offset = "0x40")]
    private new DuelData duelData;
    [Token(Token = "0x400A08B")]
    [FieldOffset(Offset = "0x48")]
    private bool showDuelAnime;

    [Token(Token = "0x600E68D")]
    [Address(RVA = "0x4873A5C", Offset = "0x4873A5C", VA = "0x4873A5C")]
    public SimpleHpDamage(IDirector mainDirector, DuelData duelData, bool showDuelAnime)
    {
    }

    [Token(Token = "0x600E68E")]
    [Address(RVA = "0x4873A98", Offset = "0x4873A98", VA = "0x4873A98", Slot = "13")]
    public override void RequestStaging()
    {
    }
  }
}
