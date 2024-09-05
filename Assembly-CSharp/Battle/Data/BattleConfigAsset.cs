// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleConfigAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026ED")]
  [CreateAssetMenu(menuName = "staq/Battle/Battle Config Asset")]
  public class BattleConfigAsset : ScriptableObject
  {
    [Token(Token = "0x400A672")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("フィールド上での死亡演出時のSE")]
    [SerializeField]
    private string seOnDyingFieldUnit;
    [Token(Token = "0x400A673")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("デュエル開始時のデフォルトSE")]
    [SerializeField]
    private string seStartDuel;
    [Token(Token = "0x400A674")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("ダブル実行時のデフォルトSE")]
    [SerializeField]
    private string seJoinDouble;
    [Token(Token = "0x400A675")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Tooltip("カメラ設定")]
    private CameraDirector.MapViewCameraSetting[] cameraSettings;
    [Token(Token = "0x400A676")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("影距離")]
    private float shadowDistance;
    [Token(Token = "0x400A677")]
    [FieldOffset(Offset = "0x3C")]
    [Tooltip("ドット絵ユニットの無効時カラー")]
    [SerializeField]
    private Color dotUnitDisabledColor;
    [Token(Token = "0x400A678")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [Tooltip("ドット絵ユニットの有効時カラー")]
    private Color dotUnitEnabledColor;
    [Token(Token = "0x400A679")]
    [FieldOffset(Offset = "0x5C")]
    [Tooltip("ドット絵ユニットの支援可能時カラー")]
    [SerializeField]
    private Color dotUnitSupportbaleColor;
    [Token(Token = "0x400A67A")]
    [FieldOffset(Offset = "0x6C")]
    [Tooltip("ドット絵ユニットのダブル前衛のオフセット座標")]
    [SerializeField]
    private Vector3 doubleFrontUnitPositionOffset;
    [Token(Token = "0x400A67B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [Tooltip("ドット絵ユニットのダブル後衛のオフセット座標")]
    private Vector3 doubleBackUnitPositionOffset;
    [Token(Token = "0x400A67C")]
    [FieldOffset(Offset = "0x84")]
    [Tooltip("ドット絵ユニットを選択した状態を知らせる矢印アイコンのオフセット座標")]
    [SerializeField]
    private Vector3 selectUnitIconPositionOffset;
    [Token(Token = "0x400A67D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    [Tooltip("ユニットステータスUIの設定情報")]
    private UnitStatusPanelConfig unitStatusPanelConfig;
    [Token(Token = "0x400A67E")]
    [FieldOffset(Offset = "0x98")]
    [Tooltip("大型ユニットのサイズ毎の各パネルのターゲットアイコンのオフセット座標")]
    [SerializeField]
    private List<LargeUnitPositionOffsetConfig> largeUnitPositionOffsetList;

    [Token(Token = "0x170032D0")]
    public string SeOnDyingFieldUnit
    {
      [Token(Token = "0x600F0C8"), Address(RVA = "0x41AB920", Offset = "0x41AB920", VA = "0x41AB920")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170032D1")]
    public string SeStartDuel
    {
      [Token(Token = "0x600F0C9"), Address(RVA = "0x41AB928", Offset = "0x41AB928", VA = "0x41AB928")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170032D2")]
    public string SeJoinDouble
    {
      [Token(Token = "0x600F0CA"), Address(RVA = "0x41AB930", Offset = "0x41AB930", VA = "0x41AB930")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170032D3")]
    public CameraDirector.MapViewCameraSetting[] CameraSettings
    {
      [Token(Token = "0x600F0CB"), Address(RVA = "0x41AB938", Offset = "0x41AB938", VA = "0x41AB938")] get
      {
        return (CameraDirector.MapViewCameraSetting[]) null;
      }
    }

    [Token(Token = "0x170032D4")]
    public float ShadowDistance
    {
      [Token(Token = "0x600F0CC"), Address(RVA = "0x41AB940", Offset = "0x41AB940", VA = "0x41AB940")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170032D5")]
    public Color DotUnitDisabledColor
    {
      [Token(Token = "0x600F0CD"), Address(RVA = "0x41AB948", Offset = "0x41AB948", VA = "0x41AB948")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x170032D6")]
    public Color DotUnitEnabledColor
    {
      [Token(Token = "0x600F0CE"), Address(RVA = "0x41AB954", Offset = "0x41AB954", VA = "0x41AB954")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x170032D7")]
    public Color DotUnitSupportbaleColor
    {
      [Token(Token = "0x600F0CF"), Address(RVA = "0x41AB960", Offset = "0x41AB960", VA = "0x41AB960")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x170032D8")]
    public Vector3 DoubleFrontUnitPositionOffset
    {
      [Token(Token = "0x600F0D0"), Address(RVA = "0x41AB96C", Offset = "0x41AB96C", VA = "0x41AB96C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170032D9")]
    public Vector3 DoubleBackUnitPositionOffset
    {
      [Token(Token = "0x600F0D1"), Address(RVA = "0x41AB978", Offset = "0x41AB978", VA = "0x41AB978")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170032DA")]
    public Vector3 SelectUnitIconPositionOffset
    {
      [Token(Token = "0x600F0D2"), Address(RVA = "0x41AB984", Offset = "0x41AB984", VA = "0x41AB984")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170032DB")]
    public UnitStatusPanelConfig UnitStatusPanelConfig
    {
      [Token(Token = "0x600F0D3"), Address(RVA = "0x41AB990", Offset = "0x41AB990", VA = "0x41AB990")] get
      {
        return (UnitStatusPanelConfig) null;
      }
    }

    [Token(Token = "0x170032DC")]
    public List<LargeUnitPositionOffsetConfig> LargeUnitPositionOffsetList
    {
      [Token(Token = "0x600F0D4"), Address(RVA = "0x41AB998", Offset = "0x41AB998", VA = "0x41AB998")] get
      {
        return (List<LargeUnitPositionOffsetConfig>) null;
      }
    }

    [Token(Token = "0x600F0D5")]
    [Address(RVA = "0x41AB9A0", Offset = "0x41AB9A0", VA = "0x41AB9A0")]
    public BattleConfigAsset()
    {
    }
  }
}
