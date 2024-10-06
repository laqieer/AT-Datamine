// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitSupportPointUpEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002434")]
  public class BattleUnitSupportPointUpEffect : MonoBehaviour
  {
    [Token(Token = "0x4009AEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x4009AEC")]
    private const int offsetX = 20;
    [Token(Token = "0x4009AED")]
    private const int offsetY = 5;

    [Token(Token = "0x600DDD2")]
    [Address(RVA = "0x1E2B85C", Offset = "0x1E2B85C", VA = "0x1E2B85C")]
    public static BattleUnitSupportPointUpEffect Create(Transform parent)
    {
      return (BattleUnitSupportPointUpEffect) null;
    }

    [Token(Token = "0x600DDD3")]
    [Address(RVA = "0x1E2B974", Offset = "0x1E2B974", VA = "0x1E2B974")]
    public void Play(Transform headTransform, CameraDirector camera)
    {
    }

    [Token(Token = "0x600DDD4")]
    [Address(RVA = "0x1E2BA54", Offset = "0x1E2BA54", VA = "0x1E2BA54")]
    public void Stop()
    {
    }

    [Token(Token = "0x600DDD5")]
    [Address(RVA = "0x1E2B998", Offset = "0x1E2B998", VA = "0x1E2B998")]
    private void SetPosition(Transform head, CameraDirector camera)
    {
    }

    [Token(Token = "0x600DDD6")]
    [Address(RVA = "0x1E2BA70", Offset = "0x1E2BA70", VA = "0x1E2BA70")]
    protected Vector3 CalcWorldToUILocalPoint(Vector3 worldPos, CameraDirector cameraDirector)
    {
      return new Vector3();
    }

    [Token(Token = "0x600DDD7")]
    [Address(RVA = "0x1E2BC64", Offset = "0x1E2BC64", VA = "0x1E2BC64")]
    public BattleUnitSupportPointUpEffect()
    {
    }
  }
}
