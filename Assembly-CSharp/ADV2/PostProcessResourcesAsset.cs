// Decompiled with JetBrains decompiler
// Type: ADV2.PostProcessResourcesAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E5F")]
  public class PostProcessResourcesAsset : ScriptableObject
  {
    [Token(Token = "0x40111C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PostProcessResources postprocessResources;

    [Token(Token = "0x17005181")]
    public PostProcessResources PostProcessResources
    {
      [Token(Token = "0x60191B3"), Address(RVA = "0x2CF0D60", Offset = "0x2CF0D60", VA = "0x2CF0D60")] get
      {
        return (PostProcessResources) null;
      }
    }

    [Token(Token = "0x60191B4")]
    [Address(RVA = "0x2CF0D68", Offset = "0x2CF0D68", VA = "0x2CF0D68")]
    public PostProcessResourcesAsset()
    {
    }
  }
}
