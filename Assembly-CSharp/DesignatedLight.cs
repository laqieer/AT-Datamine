// Decompiled with JetBrains decompiler
// Type: DesignatedLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000BF")]
public class DesignatedLight : MonoBehaviour, ILightForCharactersReceiver
{
  [Token(Token = "0x4000311")]
  [FieldOffset(Offset = "0x18")]
  public DesignatedLight.Segment segment;
  [Token(Token = "0x4000312")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string LightDirectionPropertyName;
  [Token(Token = "0x4000313")]
  [FieldOffset(Offset = "0x20")]
  public Transform linkedLight;
  [Token(Token = "0x4000314")]
  [FieldOffset(Offset = "0x28")]
  public Renderer[] renderers;
  [Token(Token = "0x4000315")]
  [FieldOffset(Offset = "0x30")]
  private List<Material> _targetMaterials;
  [Token(Token = "0x4000316")]
  [FieldOffset(Offset = "0x38")]
  [NonSerialized]
  public Vector3 roundLitDirLocal;
  [Token(Token = "0x4000317")]
  [FieldOffset(Offset = "0x48")]
  public int[] isSkipDirection20;
  [Token(Token = "0x4000318")]
  [FieldOffset(Offset = "0x50")]
  public int[] isSkipDirection30;
  [Token(Token = "0x4000319")]
  [FieldOffset(Offset = "0x58")]
  public int[] isSkipDirection45;
  [Token(Token = "0x400031A")]
  [FieldOffset(Offset = "0x60")]
  private Dictionary<DesignatedLight.Segment, int[]> isSkipDirectionDic;
  [Token(Token = "0x400031B")]
  [FieldOffset(Offset = "0x8")]
  private static Dictionary<DesignatedLight.Segment, Vector3[][]> directionsDic;

  [Token(Token = "0x60005B5")]
  [Address(RVA = "0x44B5FF4", Offset = "0x44B5FF4", VA = "0x44B5FF4")]
  public static int[] GetSizeBySegment(DesignatedLight.Segment seg) => (int[]) null;

  [Token(Token = "0x60005B6")]
  [Address(RVA = "0x44B614C", Offset = "0x44B614C", VA = "0x44B614C")]
  private static Vector3[][] GetDirsBySegment(DesignatedLight.Segment seg) => (Vector3[][]) null;

  [Token(Token = "0x60005B7")]
  [Address(RVA = "0x44B645C", Offset = "0x44B645C", VA = "0x44B645C")]
  public void UpdateSkipDirection(
    DesignatedLight.Segment segment,
    int column,
    int row,
    bool noSkip)
  {
  }

  [Token(Token = "0x60005B8")]
  [Address(RVA = "0x44B6540", Offset = "0x44B6540", VA = "0x44B6540")]
  static DesignatedLight()
  {
  }

  [Token(Token = "0x60005B9")]
  [Address(RVA = "0x44B6978", Offset = "0x44B6978", VA = "0x44B6978")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60005BA")]
  [Address(RVA = "0x44B6A3C", Offset = "0x44B6A3C", VA = "0x44B6A3C")]
  public void GetMaterials()
  {
  }

  [Token(Token = "0x60005BB")]
  [Address(RVA = "0x44B6B7C", Offset = "0x44B6B7C", VA = "0x44B6B7C")]
  public void DestroyMaterials()
  {
  }

  [Token(Token = "0x60005BC")]
  [Address(RVA = "0x44B6D0C", Offset = "0x44B6D0C", VA = "0x44B6D0C")]
  private void Start()
  {
  }

  [Token(Token = "0x60005BD")]
  [Address(RVA = "0x44B6D34", Offset = "0x44B6D34", VA = "0x44B6D34")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60005BE")]
  [Address(RVA = "0x44B6D5C", Offset = "0x44B6D5C", VA = "0x44B6D5C", Slot = "4")]
  public void UpdateLight(LightForCharacters light)
  {
  }

  [Token(Token = "0x60005BF")]
  [Address(RVA = "0x44B6D90", Offset = "0x44B6D90", VA = "0x44B6D90")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60005C0")]
  [Address(RVA = "0x44B72D4", Offset = "0x44B72D4", VA = "0x44B72D4")]
  public DesignatedLight()
  {
  }

  [Token(Token = "0x20000C0")]
  public enum Segment
  {
    [Token(Token = "0x400031D")] Deg20 = 20, // 0x00000014
    [Token(Token = "0x400031E")] Deg30 = 30, // 0x0000001E
    [Token(Token = "0x400031F")] Deg45 = 45, // 0x0000002D
  }
}
