// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderPlayableValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x2000770")]
  public class ShaderPlayableValue : MonoBehaviour
  {
    [Token(Token = "0x40021FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string _tagName;
    [Token(Token = "0x40021FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ShaderPlayableDictionary targetObjects;
    [Token(Token = "0x4002200")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, ShaderPlayableValue.ShaderPlayableValueData> _targetDatas;
    [Token(Token = "0x4002201")]
    [FieldOffset(Offset = "0x30")]
    private readonly Dictionary<string, ShaderMixerBehaviourData> propertyDatas;

    [Token(Token = "0x1700063D")]
    public Dictionary<string, ShaderPlayableValue.ShaderPlayableValueData> TargetDatas
    {
      [Token(Token = "0x6002987"), Address(RVA = "0x3682178", Offset = "0x3682178", VA = "0x3682178")] get
      {
        return (Dictionary<string, ShaderPlayableValue.ShaderPlayableValueData>) null;
      }
    }

    [Token(Token = "0x1700063E")]
    public Dictionary<string, ShaderMixerBehaviourData> PropertyDatas
    {
      [Token(Token = "0x6002988"), Address(RVA = "0x3682180", Offset = "0x3682180", VA = "0x3682180")] get
      {
        return (Dictionary<string, ShaderMixerBehaviourData>) null;
      }
    }

    [Token(Token = "0x6002989")]
    [Address(RVA = "0x3682188", Offset = "0x3682188", VA = "0x3682188")]
    private void Awake()
    {
    }

    [Token(Token = "0x600298A")]
    [Address(RVA = "0x3682458", Offset = "0x3682458", VA = "0x3682458")]
    private void Start()
    {
    }

    [Token(Token = "0x600298B")]
    [Address(RVA = "0x3682708", Offset = "0x3682708", VA = "0x3682708")]
    private void AddData(
      string name,
      ShaderPlayableValue.ComponentType type,
      Renderer renderer = null,
      Graphic graphic = null)
    {
    }

    [Token(Token = "0x600298C")]
    [Address(RVA = "0x36827BC", Offset = "0x36827BC", VA = "0x36827BC")]
    public ShaderPlayableValue()
    {
    }

    [Token(Token = "0x2000771")]
    public enum ComponentType
    {
      [Token(Token = "0x4002203")] Renderer,
      [Token(Token = "0x4002204")] Graphic,
    }

    [Token(Token = "0x2000772")]
    public class ShaderPlayableValueData
    {
      [Token(Token = "0x4002205")]
      [FieldOffset(Offset = "0x10")]
      public ShaderPlayableValue.ComponentType ComponentType;
      [Token(Token = "0x4002206")]
      [FieldOffset(Offset = "0x18")]
      public Renderer Renderer;
      [Token(Token = "0x4002207")]
      [FieldOffset(Offset = "0x20")]
      public Graphic Graphic;

      [Token(Token = "0x600298D")]
      [Address(RVA = "0x36827B4", Offset = "0x36827B4", VA = "0x36827B4")]
      public ShaderPlayableValueData()
      {
      }
    }
  }
}
