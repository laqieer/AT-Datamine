// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenShaderParamByFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200051A")]
  public class TweenShaderParamByFloat : UITweener
  {
    [Token(Token = "0x4001B28")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float from;
    [Token(Token = "0x4001B29")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float to;
    [Token(Token = "0x4001B2A")]
    [FieldOffset(Offset = "0x70")]
    private Material targetMat;
    [Token(Token = "0x4001B2B")]
    [FieldOffset(Offset = "0x78")]
    private float paramValue;
    [Token(Token = "0x4001B2C")]
    [FieldOffset(Offset = "0x80")]
    [HideInInspector]
    [SerializeField]
    private string paramName;

    [Token(Token = "0x170003D9")]
    public float From
    {
      [Token(Token = "0x6001D84"), Address(RVA = "0x29FA2D8", Offset = "0x29FA2D8", VA = "0x29FA2D8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D85"), Address(RVA = "0x29FA2E0", Offset = "0x29FA2E0", VA = "0x29FA2E0")] set
      {
      }
    }

    [Token(Token = "0x170003DA")]
    public float To
    {
      [Token(Token = "0x6001D86"), Address(RVA = "0x29FA2E8", Offset = "0x29FA2E8", VA = "0x29FA2E8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D87"), Address(RVA = "0x29FA2F0", Offset = "0x29FA2F0", VA = "0x29FA2F0")] set
      {
      }
    }

    [Token(Token = "0x170003DB")]
    public float ParamValue
    {
      [Token(Token = "0x6001D88"), Address(RVA = "0x29FA2F8", Offset = "0x29FA2F8", VA = "0x29FA2F8")] get
      {
        return new float();
      }
      [Token(Token = "0x6001D89"), Address(RVA = "0x29FA300", Offset = "0x29FA300", VA = "0x29FA300")] set
      {
      }
    }

    [Token(Token = "0x170003DC")]
    public string ParamName
    {
      [Token(Token = "0x6001D8A"), Address(RVA = "0x29FA538", Offset = "0x29FA538", VA = "0x29FA538")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6001D8B"), Address(RVA = "0x29FA540", Offset = "0x29FA540", VA = "0x29FA540")] set
      {
      }
    }

    [Token(Token = "0x6001D8C")]
    [Address(RVA = "0x29FA358", Offset = "0x29FA358", VA = "0x29FA358")]
    private void GetMaterial()
    {
    }

    [Token(Token = "0x6001D8D")]
    [Address(RVA = "0x29FA548", Offset = "0x29FA548", VA = "0x29FA548", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D8E")]
    [Address(RVA = "0x29FA564", Offset = "0x29FA564", VA = "0x29FA564")]
    public TweenShaderParamByFloat()
    {
    }
  }
}
