-- このluaスクリプトは、MA_01C112_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111015_01","111015_01_h")
Include("content_adv_advsmall_111015_01","Template111015_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111015_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111015_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111015_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111015_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111015_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_001)
	InitializeTemplateRandomCamera111015_01()
	InitializeTemplate111015_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_common_look_at(Actor004,Actor001)
set_common_look_at(Actor005,Actor001)
turn_lookat(Actor004,Actor001, 0)
turn_lookat(Actor005,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111015)
	Actor001 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★ランスロット★★:パーシヴァルを殺し<br>聖杯を破壊など…バカな…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C112_300002")


	--★★アーサー★★:俺の本気が伝わったか？<br>…あんなものがあるから皆が惑う
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300003")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Anger")

	--★★アーサー★★:GSも妖精もただの伝説だ<br>そして穢れた血も継承者も
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★アーサー★★:我々は伝承、妖精、聖杯…<br>現実離れしたものばかりを追ってきた
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300006")


	--★★アーサー★★:それにすがるしか生き残る道がなかったからだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★アーサー★★:そして青春を謳歌する若者たちの可能性に<br>賭けたいと思った
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300008")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★アーサー★★:だがそれは間違っていた<br>間違いに目を瞑り続けていた
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300009")


	--★★アーサー★★:伝承などの力を借りず<br>GSなどせず聖遺物の力も借りず
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:我々自身の力で<br>地上に楽園を築かなければならない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★アーサー★★:ノワールがディナタンを選んだことで<br>俺は気づいたんだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300012")

	change_face(Actor001,"Normal")

	--★★アーサー★★:さて魔女はノワールとディナタンを<br>倒すことができたかどうか…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300013")

	PlayAction(Actor005,"to  Std_No")
	change_face(Actor005,"Anger")

	--★★ギネヴィア★★:…ふたりが魔女に負けるわけないわ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01C112_300014")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★アーサー★★:俺もそう思うよ、ギネヴィア<br>だから俺はお前たちに仲間になって欲しい
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300015")

	change_face(Actor001,"Smile")

	--★★アーサー★★:正しい歴史とは<br>人の力によって切り拓かれるべきだろ？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")

	--★★ランスロット★★:それは…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C112_300017")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Serious")

	--★★アーサー★★:魔女の力など借りぬ<br>継承者の力も借りぬ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300018")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★アーサー★★:どうだ、ふたりとも
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300019")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:そんな世界に興味はないか
	Talk(Actor001,"CHRNAME_ARTHUR","speech","R","MA_01C112_300020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111015)
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111015_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
