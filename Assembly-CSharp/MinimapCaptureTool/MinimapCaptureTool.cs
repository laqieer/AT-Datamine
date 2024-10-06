// Decompiled with JetBrains decompiler
// Type: MinimapCaptureTool.MinimapCaptureTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace MinimapCaptureTool
{
  [Token(Token = "0x200035E")]
  public class MinimapCaptureTool : MonoBehaviour
  {
    [Token(Token = "0x40013E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PathSetting pathSetting;
    [Token(Token = "0x40013E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextureSetting textureSetting;

    [Token(Token = "0x170001E2")]
    public PathSetting PathSetting
    {
      [Token(Token = "0x6001360"), Address(RVA = "0x2869438", Offset = "0x2869438", VA = "0x2869438")] get
      {
        return (PathSetting) null;
      }
    }

    [Token(Token = "0x170001E3")]
    public TextureSetting TextureSetting
    {
      [Token(Token = "0x6001361"), Address(RVA = "0x2869440", Offset = "0x2869440", VA = "0x2869440")] get
      {
        return (TextureSetting) null;
      }
    }

    [Token(Token = "0x6001362")]
    [Address(RVA = "0x2869448", Offset = "0x2869448", VA = "0x2869448")]
    public MinimapCaptureTool()
    {
    }
  }
}
