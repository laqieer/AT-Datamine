-- このluaスクリプトは、PT4_01A_10_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_004)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_10_0030002")

-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:…ようやくお目覚めかね
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030003")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェインに…ケイ？<br>珍しい組み合わせだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:例の分断作戦の対応について<br>少し話しておきたくてな
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:敵になにか動きがあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0030006")

-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:壁の建造は着実に進めているようだが<br>敵軍自体には動きがない
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030007")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ローマの連中が壁づくりに集中してんならさ<br>そのスキを突いて一網打尽にしちまおーぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_10_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:そこが不気味なのだよ
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030009")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:不気味ぃ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_10_0030010")

	change_face(Actor003,"Normal")

	--★★ケイ★★:我々が壁の建造を妨害してくることは<br>想定済みのはず
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:しかし、ローマ側にはそれを阻む動きは見られず<br>壁の建造速度も一定を保ったままなのだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030012")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:罠を仕掛けて待っているってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0030013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:あるいはこの分断作戦自体が<br>我々の目を欺くためのものかもしれん
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030014")


	--★★ケイ★★:ローマや魔女の狙いがわからぬ状況で<br>逸るべきではないだろう
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:出撃の準備は私のほうで進めておく<br>くれぐれも独断専行などせぬようにな
	Talk(Actor003,"CHRNAME_KAY","speech","L","PT4_01A_10_0030016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ああ<br>わかったぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_10_0030017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
