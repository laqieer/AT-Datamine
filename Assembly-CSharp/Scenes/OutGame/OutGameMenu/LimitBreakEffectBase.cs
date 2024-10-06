// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.LimitBreakEffectBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A6A")]
  public class LimitBreakEffectBase : EnhanceEffectBase
  {
    [Token(Token = "0x401000D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] existingGems;
    [Token(Token = "0x401000E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] effectGems;

    [Token(Token = "0x6016F61")]
    [Address(RVA = "0x29C2B94", Offset = "0x29C2B94", VA = "0x29C2B94")]
    protected void SetGems(int current, int enhance)
    {
    }

    [Token(Token = "0x6016F62")]
    [Address(RVA = "0x29C2CE0", Offset = "0x29C2CE0", VA = "0x29C2CE0")]
    protected int GetBeforeLimitBreakCount(int current, int enhance) => new int();

    [Token(Token = "0x6016F63")]
    [Address(RVA = "0x29C2CE8", Offset = "0x29C2CE8", VA = "0x29C2CE8")]
    public LimitBreakEffectBase()
    {
    }
  }
}
