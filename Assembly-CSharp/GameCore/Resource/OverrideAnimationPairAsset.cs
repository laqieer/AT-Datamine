// Decompiled with JetBrains decompiler
// Type: GameCore.Resource.OverrideAnimationPairAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Resource
{
  [Token(Token = "0x2000CA9")]
  public class OverrideAnimationPairAsset : ScriptableObject
  {
    [Token(Token = "0x400390A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private OverrideAnimationPairAsset.AnimationPair[] animationPairs;
    [Token(Token = "0x400390B")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<KeyValuePair<string, AnimationClip>>> cachedDictionary;

    [Token(Token = "0x6004915")]
    [Address(RVA = "0x3134700", Offset = "0x3134700", VA = "0x3134700")]
    public static void ApplyOverrideAnimations(
      Animator animator,
      OverrideAnimationPairAsset overrideAsset)
    {
    }

    [Token(Token = "0x6004916")]
    [Address(RVA = "0x3134C7C", Offset = "0x3134C7C", VA = "0x3134C7C")]
    private static bool TryGetClipKeyPair(
      string fileName,
      List<KeyValuePair<string, AnimationClip>> pairList,
      out KeyValuePair<string, AnimationClip> output)
    {
      return new bool();
    }

    [Token(Token = "0x6004917")]
    [Address(RVA = "0x31349D8", Offset = "0x31349D8", VA = "0x31349D8")]
    private List<KeyValuePair<string, AnimationClip>> GetPairList()
    {
      return (List<KeyValuePair<string, AnimationClip>>) null;
    }

    [Token(Token = "0x6004918")]
    [Address(RVA = "0x3134F30", Offset = "0x3134F30", VA = "0x3134F30")]
    public OverrideAnimationPairAsset()
    {
    }

    [Token(Token = "0x2000CAA")]
    [Serializable]
    private struct AnimationPair
    {
      [Token(Token = "0x400390C")]
      [FieldOffset(Offset = "0x0")]
      [HideInInspector]
      [SerializeField]
      private int weaponCategory;
      [Token(Token = "0x400390D")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      private string stateName;
      [Token(Token = "0x400390E")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private string keyValue;
      [Token(Token = "0x400390F")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private AnimationClip animationClip;

      [Token(Token = "0x17000AAF")]
      public string KeyValue
      {
        [Token(Token = "0x6004919"), Address(RVA = "0x3134FAC", Offset = "0x3134FAC", VA = "0x3134FAC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000AB0")]
      public AnimationClip AnimationClip
      {
        [Token(Token = "0x600491A"), Address(RVA = "0x3134FB4", Offset = "0x3134FB4", VA = "0x3134FB4")] get
        {
          return (AnimationClip) null;
        }
      }
    }
  }
}
