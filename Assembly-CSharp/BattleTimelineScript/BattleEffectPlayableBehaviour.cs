// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleEffectPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021F4")]
  [Serializable]
  public class BattleEffectPlayableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4008F84")]
    [FieldOffset(Offset = "0x10")]
    private GameObject effectPrefab;
    [Token(Token = "0x4008F85")]
    [FieldOffset(Offset = "0x18")]
    private bool autoPlaySE;
    [Token(Token = "0x4008F86")]
    [FieldOffset(Offset = "0x1C")]
    private float SEDelayTime;
    [Token(Token = "0x4008F87")]
    [FieldOffset(Offset = "0x20")]
    private string layerName;
    [Token(Token = "0x4008F88")]
    [FieldOffset(Offset = "0x28")]
    private string attachTargetName;
    [Token(Token = "0x4008F89")]
    [FieldOffset(Offset = "0x30")]
    private List<string> passedObjectNames;
    [Token(Token = "0x4008F8A")]
    [FieldOffset(Offset = "0x38")]
    public BattleEffectPlayableAsset.AttachMethod attachMethod;
    [Token(Token = "0x4008F8B")]
    [FieldOffset(Offset = "0x3C")]
    private BattleEffectPlayableAsset.TransformInheritanceParameter transformInheritanceParameter;
    [Token(Token = "0x4008F8C")]
    [FieldOffset(Offset = "0x40")]
    private float playSpeed;
    [Token(Token = "0x4008F8D")]
    [FieldOffset(Offset = "0x44")]
    private float destroyDelay;
    [Token(Token = "0x4008F8E")]
    [FieldOffset(Offset = "0x48")]
    private Vector3 offsetLocalPosition;
    [Token(Token = "0x4008F8F")]
    [FieldOffset(Offset = "0x54")]
    private Vector3 offsetLocalRotation;
    [Token(Token = "0x4008F90")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 offsetLocalScale;
    [Token(Token = "0x4008F91")]
    [FieldOffset(Offset = "0x70")]
    private GameObject bindingTarget;
    [Token(Token = "0x4008F92")]
    [FieldOffset(Offset = "0x78")]
    private GameObject effectAttachTarget;
    [Token(Token = "0x4008F93")]
    [FieldOffset(Offset = "0x80")]
    private GameObject effectInstance;
    [Token(Token = "0x4008F94")]
    [FieldOffset(Offset = "0x88")]
    private BattleEffectTrackInstanceController effectInstanceController;
    [Token(Token = "0x4008F95")]
    [FieldOffset(Offset = "0x90")]
    private ParticleSystem[] particles;

    [Token(Token = "0x600CED7")]
    [Address(RVA = "0x4B65DEC", Offset = "0x4B65DEC", VA = "0x4B65DEC")]
    public void Initialize(
      BattleEffectPlayableAsset asset,
      PlayableGraph graph,
      GameObject bindingTarget)
    {
    }

    [Token(Token = "0x600CED8")]
    [Address(RVA = "0x4B66000", Offset = "0x4B66000", VA = "0x4B66000")]
    public void SetEffectPrefab(GameObject prefab)
    {
    }

    [Token(Token = "0x600CED9")]
    [Address(RVA = "0x4B66008", Offset = "0x4B66008", VA = "0x4B66008")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x600CEDA")]
    [Address(RVA = "0x4B660F4", Offset = "0x4B660F4", VA = "0x4B660F4")]
    private void CreateEffectInstance()
    {
    }

    [Token(Token = "0x600CEDB")]
    [Address(RVA = "0x4B679CC", Offset = "0x4B679CC", VA = "0x4B679CC")]
    public static GameObject GetAttachTargetByNameDF(GameObject root, string targetName)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600CEDC")]
    [Address(RVA = "0x4B66B1C", Offset = "0x4B66B1C", VA = "0x4B66B1C")]
    public static GameObject GetAttachTargetByNameBF(List<GameObject> roots, string targetName)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600CEDD")]
    [Address(RVA = "0x4B67078", Offset = "0x4B67078", VA = "0x4B67078")]
    public static GameObject GetAttachTargetByPassedObjectNames(
      GameObject root,
      string targetName,
      List<Tuple<string, bool>> passedObjectStatus)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600CEDE")]
    [Address(RVA = "0x4B67D44", Offset = "0x4B67D44", VA = "0x4B67D44")]
    private void PauseEffect()
    {
    }

    [Token(Token = "0x600CEDF")]
    [Address(RVA = "0x4B67E70", Offset = "0x4B67E70", VA = "0x4B67E70")]
    private void DestroyEffectInstance()
    {
    }

    [Token(Token = "0x600CEE0")]
    [Address(RVA = "0x4B67F60", Offset = "0x4B67F60", VA = "0x4B67F60")]
    private void UpdateEffect(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x600CEE1")]
    [Address(RVA = "0x4B676B4", Offset = "0x4B676B4", VA = "0x4B676B4")]
    private void SetLayer(GameObject go, string layerName)
    {
    }

    [Token(Token = "0x600CEE2")]
    [Address(RVA = "0x4B68298", Offset = "0x4B68298", VA = "0x4B68298", Slot = "15")]
    public override void OnPlayableCreate(Playable playable)
    {
    }

    [Token(Token = "0x600CEE3")]
    [Address(RVA = "0x4B682A0", Offset = "0x4B682A0", VA = "0x4B682A0", Slot = "16")]
    public override void OnPlayableDestroy(Playable playable)
    {
    }

    [Token(Token = "0x600CEE4")]
    [Address(RVA = "0x4B682BC", Offset = "0x4B682BC", VA = "0x4B682BC", Slot = "19")]
    public override void PrepareData(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CEE5")]
    [Address(RVA = "0x4B682EC", Offset = "0x4B682EC", VA = "0x4B682EC", Slot = "20")]
    public override void PrepareFrame(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CEE6")]
    [Address(RVA = "0x4B6831C", Offset = "0x4B6831C", VA = "0x4B6831C", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x600CEE7")]
    [Address(RVA = "0x4B68370", Offset = "0x4B68370", VA = "0x4B68370", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x600CEE8")]
    [Address(RVA = "0x4B68378", Offset = "0x4B68378", VA = "0x4B68378", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x600CEE9")]
    [Address(RVA = "0x4B68380", Offset = "0x4B68380", VA = "0x4B68380", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CEEA")]
    [Address(RVA = "0x4B683BC", Offset = "0x4B683BC", VA = "0x4B683BC", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CEEB")]
    [Address(RVA = "0x4B683F8", Offset = "0x4B683F8", VA = "0x4B683F8")]
    public BattleEffectPlayableBehaviour()
    {
    }
  }
}
