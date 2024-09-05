// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.ViewerSettingTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004DB")]
  public class ViewerSettingTable : ScriptableObject
  {
    [Token(Token = "0x4001959")]
    private const string AssetRootPath = "Assets/AssetBundle/UnitDetail/Scriptable/";
    [Token(Token = "0x400195A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("ダブルタップ許容時間")]
    private float doubleTapTime;
    [Token(Token = "0x400195B")]
    [FieldOffset(Offset = "0x20")]
    [Header("2Dビューアー設定")]
    [SerializeField]
    private Viewer2DSetting viewer2D;
    [Token(Token = "0x400195C")]
    [FieldOffset(Offset = "0x28")]
    [Header("3Dビューアー設定")]
    [SerializeField]
    private Viewer3DSetting viewer3D;
    [Token(Token = "0x400195D")]
    [FieldOffset(Offset = "0x30")]
    [Header("Dotビューアー設定")]
    [SerializeField]
    private ViewerDotSetting viewerDot;

    [Token(Token = "0x17000372")]
    public static string AssetPath
    {
      [Token(Token = "0x6001BA0"), Address(RVA = "0x2C2CCA0", Offset = "0x2C2CCA0", VA = "0x2C2CCA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000373")]
    public float DoubleTapTime
    {
      [Token(Token = "0x6001BA1"), Address(RVA = "0x2C2CD60", Offset = "0x2C2CD60", VA = "0x2C2CD60")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000374")]
    public Viewer2DSetting Viewer2D
    {
      [Token(Token = "0x6001BA2"), Address(RVA = "0x2C2CD68", Offset = "0x2C2CD68", VA = "0x2C2CD68")] get
      {
        return (Viewer2DSetting) null;
      }
    }

    [Token(Token = "0x17000375")]
    public Viewer3DSetting Viewer3D
    {
      [Token(Token = "0x6001BA3"), Address(RVA = "0x2C2CD70", Offset = "0x2C2CD70", VA = "0x2C2CD70")] get
      {
        return (Viewer3DSetting) null;
      }
    }

    [Token(Token = "0x17000376")]
    public ViewerDotSetting ViewerDot
    {
      [Token(Token = "0x6001BA4"), Address(RVA = "0x2C2CD78", Offset = "0x2C2CD78", VA = "0x2C2CD78")] get
      {
        return (ViewerDotSetting) null;
      }
    }

    [Token(Token = "0x6001BA5")]
    [Address(RVA = "0x2C2CD80", Offset = "0x2C2CD80", VA = "0x2C2CD80")]
    public ViewerSettingTable()
    {
    }
  }
}
