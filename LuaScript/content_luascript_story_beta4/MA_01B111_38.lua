-- このluaスクリプトは、MA_01B111_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_01","111061_01_h")
Include("content_adv_advsmall_111061_01","Template111061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_005)
	InitializeTemplateRandomCamera111061_01()
	InitializeTemplate111061_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_pos(Actor002,{-2.97,0,0.367})
Hide(Actor002)
se_play("SE_ADV_MA_01B900_01_Spiral_Water")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","002","101021002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ニニアン★★:これは妖精ニニアンの咎<br>雪げぬ罪を贖う宿命、継承者に刻むのみ
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380002")


	--★★ニニアン★★:その騎士道の歩みの末に<br>奇跡などありえない
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380004")

	change_face(Actor003,"Sad")

	--★★ノワール★★:（………これは、あの夢の続き…？）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","MA_01B111_380005")

-- ▼直接出力
 --setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ニニアン★★:それでも貴方は──
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380006")

	change_face(Actor003,"Normal")

	--★★ノワール★★:（ランスロットから引き継がれた…<br>父さんの遺した記憶の続き）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","MA_01B111_380007")


	--★★ブルーノ★★:聖杯による奇跡を願う
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","MA_01B111_380009")

-- ▼直接出力
 --setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ニニアン★★:聖杯の解放を望む者は…<br>『サラスの都』に足を踏み入れる必要がある
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380010")


	--★★ニニアン★★:サラスの都への門は固く閉ざされている<br>開くために鍵となるもの、それが──
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380011")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,0.218,0,0.362,2.6)
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
--ブルーノ,CHRNAME_BRUNO @名前変更
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブルーノ★★:妖精の命
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B111_380013")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:（…！？父さん…！？）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","MA_01B111_380014")

	change_face(Actor003,"Normal")

	--★★ノワール★★:（それに…「聖杯の力を解放するために<br>鍵となるもの」それが…？）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","MA_01B111_380015")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ニニアン★★:ブルーノ、貴方の剣で<br>この妖精ニニアンの命を天へと捧げ──
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380016")


	--★★ニニアン★★:──サラスの開門と<br>その先にて継承者の任命を
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380017")


	--★★ニニアン★★:その枷、与える者の名は？
	Talk(Actor001,"CHRNAME_NINIAN","speech","L","MA_01B111_380018")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブルーノ★★:ノワール
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B111_380019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","002","101021002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	system.PreLoadRequest(CameraAssetBundleName111061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
