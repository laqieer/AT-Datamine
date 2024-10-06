// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2PlayableDirector`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Playables;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E4A")]
  public abstract class Adv2PlayableDirector<T> : Adv2PlayableDirectorBase where T : PlayableDirectorBehaviourBase
  {
    [Token(Token = "0x4011192")]
    [FieldOffset(Offset = "0x0")]
    protected T playableDirector;

    [Token(Token = "0x6019184")]
    public override void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6019185")]
    public override bool IsActive() => new bool();

    [Token(Token = "0x6019186")]
    public override void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x6019187")]
    protected Adv2PlayableDirector()
    {
    }
  }
}
