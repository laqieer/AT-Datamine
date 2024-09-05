// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.GuildBelowScreenHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Guild
{
  [Token(Token = "0x2002B8B")]
  public class GuildBelowScreenHandler : MonoBehaviour
  {
    [Token(Token = "0x400B96A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform contentsTransform;
    [Token(Token = "0x400B96B")]
    [FieldOffset(Offset = "0x20")]
    private GuildBelowScreenBase currentBelowScreen;
    [Token(Token = "0x400B96C")]
    [FieldOffset(Offset = "0x28")]
    private Stack<GuildBelowScreenBase> screenStack;

    [Token(Token = "0x17003ABA")]
    public bool HasStack
    {
      [Token(Token = "0x6011031"), Address(RVA = "0x1C75504", Offset = "0x1C75504", VA = "0x1C75504")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003ABB")]
    public bool IsDirection
    {
      [Token(Token = "0x6011032"), Address(RVA = "0x1C75D1C", Offset = "0x1C75D1C", VA = "0x1C75D1C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011033"), Address(RVA = "0x1C75D24", Offset = "0x1C75D24", VA = "0x1C75D24")] private set
      {
      }
    }

    [Token(Token = "0x6011034")]
    [Address(RVA = "0x1C75D30", Offset = "0x1C75D30", VA = "0x1C75D30")]
    public GuildBelowScreenBase GetCurrentBelowScreen() => (GuildBelowScreenBase) null;

    [Token(Token = "0x6011035")]
    [Address(RVA = "0x1C75998", Offset = "0x1C75998", VA = "0x1C75998")]
    public IEnumerator ChangeBelowScreen(
      GameObject screenAsset,
      GuildAssetBundleParam.GuildScreenType? screenType,
      bool isStack,
      GuildBelowScreenParam param = null,
      bool isCloseAnimationSkip = false,
      bool isBack = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011036")]
    [Address(RVA = "0x1C75554", Offset = "0x1C75554", VA = "0x1C75554")]
    public IEnumerator OnBackScreen() => (IEnumerator) null;

    [Token(Token = "0x6011037")]
    [Address(RVA = "0x1C75334", Offset = "0x1C75334", VA = "0x1C75334")]
    public void ClearStack()
    {
    }

    [Token(Token = "0x6011038")]
    [Address(RVA = "0x1C75D88", Offset = "0x1C75D88", VA = "0x1C75D88")]
    public GuildBelowScreenHandler()
    {
    }
  }
}
