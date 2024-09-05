// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.CanvasSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BE6")]
  [CreateAssetMenu(menuName = "Canvas/Create Canvas Settins")]
  public class CanvasSettings : ScriptableObject
  {
    [Token(Token = "0x40035FC")]
    private const string AssetPath = "CanvasSettings";
    [Token(Token = "0x40035FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasSettingItem[] settings;
    [Token(Token = "0x40035FE")]
    [FieldOffset(Offset = "0x0")]
    private static CanvasSettings instance;

    [Token(Token = "0x170009DF")]
    public static CanvasSettingItem[] Settings
    {
      [Token(Token = "0x60043F0"), Address(RVA = "0x3644D40", Offset = "0x3644D40", VA = "0x3644D40")] get
      {
        return (CanvasSettingItem[]) null;
      }
    }

    [Token(Token = "0x170009E0")]
    private static CanvasSettings Instance
    {
      [Token(Token = "0x60043F1"), Address(RVA = "0x3644D5C", Offset = "0x3644D5C", VA = "0x3644D5C")] get
      {
        return (CanvasSettings) null;
      }
    }

    [Token(Token = "0x60043F2")]
    [Address(RVA = "0x3644C00", Offset = "0x3644C00", VA = "0x3644C00")]
    public static int GetPlaneDistance(string name) => new int();

    [Token(Token = "0x60043F3")]
    [Address(RVA = "0x3644E30", Offset = "0x3644E30", VA = "0x3644E30")]
    public CanvasSettings()
    {
    }
  }
}
