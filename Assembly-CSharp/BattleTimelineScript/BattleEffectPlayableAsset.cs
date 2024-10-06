// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleEffectPlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021F1")]
  public class BattleEffectPlayableAsset : PlayableAsset
  {
    [Token(Token = "0x4008F6C")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public GameObject bindingTarget;
    [Token(Token = "0x4008F6D")]
    [FieldOffset(Offset = "0x20")]
    public ExposedReference<GameObject> effectPrefab;
    [Token(Token = "0x4008F6E")]
    [FieldOffset(Offset = "0x30")]
    public bool autoPlaySE;
    [Token(Token = "0x4008F6F")]
    [FieldOffset(Offset = "0x34")]
    public float SEDelayTime;
    [Token(Token = "0x4008F70")]
    [FieldOffset(Offset = "0x38")]
    public string layerName;
    [Token(Token = "0x4008F71")]
    [FieldOffset(Offset = "0x40")]
    public string attachTargetName;
    [Token(Token = "0x4008F72")]
    [FieldOffset(Offset = "0x48")]
    public List<string> passedObjectNames;
    [Token(Token = "0x4008F73")]
    [FieldOffset(Offset = "0x50")]
    public BattleEffectPlayableAsset.AttachMethod attachMethod;
    [Token(Token = "0x4008F74")]
    [FieldOffset(Offset = "0x54")]
    public BattleEffectPlayableAsset.TransformInheritanceParameter transformInheritanceParameter;
    [Token(Token = "0x4008F75")]
    [FieldOffset(Offset = "0x58")]
    public float playSpeed;
    [Token(Token = "0x4008F76")]
    [FieldOffset(Offset = "0x5C")]
    public float destroyDelay;
    [Token(Token = "0x4008F77")]
    [FieldOffset(Offset = "0x60")]
    public Vector3 offsetLocalPosition;
    [Token(Token = "0x4008F78")]
    [FieldOffset(Offset = "0x6C")]
    public Vector3 offsetLocalRotation;
    [Token(Token = "0x4008F79")]
    [FieldOffset(Offset = "0x78")]
    public Vector3 offsetLocalScale;
    [Token(Token = "0x4008F7A")]
    [FieldOffset(Offset = "0x88")]
    public string comment;

    [Token(Token = "0x600CED4")]
    [Address(RVA = "0x4B65CEC", Offset = "0x4B65CEC", VA = "0x4B65CEC")]
    public void Initialize(GameObject bindingTarget)
    {
    }

    [Token(Token = "0x600CED5")]
    [Address(RVA = "0x4B65CF4", Offset = "0x4B65CF4", VA = "0x4B65CF4", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CED6")]
    [Address(RVA = "0x4B65ED0", Offset = "0x4B65ED0", VA = "0x4B65ED0")]
    public BattleEffectPlayableAsset()
    {
    }

    [Token(Token = "0x20021F2")]
    public enum AttachMethod
    {
      [Token(Token = "0x4008F7C")] Child,
      [Token(Token = "0x4008F7D")] World,
    }

    [Token(Token = "0x20021F3")]
    public enum TransformInheritanceParameter
    {
      [Token(Token = "0x4008F7F")] ApplyPosition,
      [Token(Token = "0x4008F80")] ApplyRotation,
      [Token(Token = "0x4008F81")] ApplyPositionAndRotation,
      [Token(Token = "0x4008F82")] FollowingPosition,
      [Token(Token = "0x4008F83")] FollowingPositionAndRotation,
    }
  }
}
