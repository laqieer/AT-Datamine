// Decompiled with JetBrains decompiler
// Type: ADV2.Playables.PlayableAssetBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Playables;

#nullable disable
namespace ADV2.Playables
{
  [Token(Token = "0x2003E8C")]
  public abstract class PlayableAssetBehaviour<T> : PlayableDirectorBehaviourBase where T : PlayableAsset
  {
    [Token(Token = "0x4011280")]
    [FieldOffset(Offset = "0x0")]
    private T assetEntity;

    [Token(Token = "0x170051B3")]
    protected T asset
    {
      [Token(Token = "0x60192E0")] get => (T) null;
    }

    [Token(Token = "0x60192E1")]
    protected PlayableAssetBehaviour()
    {
    }
  }
}
