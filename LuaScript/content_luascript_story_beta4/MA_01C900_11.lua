-- このluaスクリプトは、MA_01C900_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111042_01","111042_01_h")
Include("content_adv_advsmall_111042_01","Template111042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111042_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111042_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_004)
	InitializeTemplateRandomCamera111042_01()
	InitializeTemplate111042_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111042)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera009)
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだこれは…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_110002")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:砦…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_110003")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルドレッド★★:フン…アーサーのヤロウ<br>使えるものは使おうって主義か…面白え
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_110005")


	--★★ノワール★★:どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_110006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:ここに長城があることくらい<br>王家の人間なら皆知ってる
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_110007")


	--★★モルドレッド★★:ローマ皇太子サマ、もだろ？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_110008")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:ここにはかつて我がローマが築き上げた<br>長城があった
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C900_110010")

	change_face(Actor004,"Sad")

	--★★ルーシャス★★:もとはブリテンで発生し始めていたバルバロイを<br>せき止めるための防波堤。だがログレスは――
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C900_110011")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:…いや、やめにしよう<br>いまは過去の話を蒸し返すべきときではない
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C900_110013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ルーシャス★★:なんにせよ我がローマの遺産を<br>我が物顔で使うなど
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C900_110014")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "激怒")
-- ▲直接出力

	--★★ルーシャス★★:見過ごすわけにはいかぬな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C900_111001")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:アーサーはどういうつもりだろうな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_110015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:わざわざ派手な舞台を用意して<br>なにもナシってことはねえだろうしよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_110016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>この先、なにが待ってるかわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_110017")


	--★★ノワール★★:みんな、気を引き締めていこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_110018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111042)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
