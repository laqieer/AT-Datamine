// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UniteStratagemRTSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022B1")]
  [Serializable]
  public sealed class UniteStratagemRTSettings : ScriptableObject
  {
    [Token(Token = "0x4009229")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    [SerializeField]
    private int textureHeight;
    [Token(Token = "0x400922A")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    [SerializeField]
    private int textureWidth;
    [Token(Token = "0x400922B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int depthBuffer;
    [Token(Token = "0x400922C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RenderTextureFormat format;
    [Token(Token = "0x400922D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RenderTextureReadWrite readWrite;
    [Token(Token = "0x400922E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int antiAliasing;
    [Token(Token = "0x400922F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RenderTextureMemoryless memorylessMode;
    [Token(Token = "0x4009230")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private VRTextureUsage vrTextureUsage;
    [Token(Token = "0x4009231")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool useDynamicScale;

    [Token(Token = "0x17002DD6")]
    public int TextureHeight
    {
      [Token(Token = "0x600D38F"), Address(RVA = "0x19D79E8", Offset = "0x19D79E8", VA = "0x19D79E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002DD7")]
    public int TextureWidth
    {
      [Token(Token = "0x600D390"), Address(RVA = "0x19D79F0", Offset = "0x19D79F0", VA = "0x19D79F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002DD8")]
    public int DepthBuffer
    {
      [Token(Token = "0x600D391"), Address(RVA = "0x19D79F8", Offset = "0x19D79F8", VA = "0x19D79F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002DD9")]
    public RenderTextureFormat Format
    {
      [Token(Token = "0x600D392"), Address(RVA = "0x19D7A00", Offset = "0x19D7A00", VA = "0x19D7A00")] get
      {
        return new RenderTextureFormat();
      }
    }

    [Token(Token = "0x17002DDA")]
    public RenderTextureReadWrite ReadWrite
    {
      [Token(Token = "0x600D393"), Address(RVA = "0x19D7A08", Offset = "0x19D7A08", VA = "0x19D7A08")] get
      {
        return new RenderTextureReadWrite();
      }
    }

    [Token(Token = "0x17002DDB")]
    public int AntiAliasing
    {
      [Token(Token = "0x600D394"), Address(RVA = "0x19D7A10", Offset = "0x19D7A10", VA = "0x19D7A10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002DDC")]
    public RenderTextureMemoryless MemorylessMode
    {
      [Token(Token = "0x600D395"), Address(RVA = "0x19D7A18", Offset = "0x19D7A18", VA = "0x19D7A18")] get
      {
        return new RenderTextureMemoryless();
      }
    }

    [Token(Token = "0x17002DDD")]
    public VRTextureUsage VRTextureUsage
    {
      [Token(Token = "0x600D396"), Address(RVA = "0x19D7A20", Offset = "0x19D7A20", VA = "0x19D7A20")] get
      {
        return new VRTextureUsage();
      }
    }

    [Token(Token = "0x17002DDE")]
    public bool UseDynamicScale
    {
      [Token(Token = "0x600D397"), Address(RVA = "0x19D7A28", Offset = "0x19D7A28", VA = "0x19D7A28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D398")]
    [Address(RVA = "0x19D796C", Offset = "0x19D796C", VA = "0x19D796C")]
    public static RenderTexture CreateTexuture(UniteStratagemRTSettings settings)
    {
      return (RenderTexture) null;
    }

    [Token(Token = "0x600D399")]
    [Address(RVA = "0x19D7A30", Offset = "0x19D7A30", VA = "0x19D7A30")]
    public static void ReleaseTexture(RenderTexture texture)
    {
    }

    [Token(Token = "0x600D39A")]
    [Address(RVA = "0x19D7AA8", Offset = "0x19D7AA8", VA = "0x19D7AA8")]
    public UniteStratagemRTSettings()
    {
    }
  }
}
