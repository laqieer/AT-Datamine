-- このluaスクリプトは、MA_01104_907.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
end

function Play()
	StartPlay()


	--★★ランスロット★★:それではホームルームをはじめよう
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_9070002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
-- ▲直接出力

	--★★ランスロット★★:聞いている者もいるだろうが<br>次の土曜日と日曜日は『五月祭』が開催される
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_9070003")


	--★★ランスロット★★:今回初めて参加する者のために説明しておこう<br>五月祭は、夏の豊穣を願って行われる祭だ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_9070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:市街ではパレード等、さまざまな催しが行われ<br>マーケットには多数の露店が並ぶ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_9070005")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ランスロット★★:はしゃぐなとは言わないが<br>学園の生徒として羽目を外し過ぎないようにな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_9070006")

	change_face(Actor004,"Sad")

	--★★ラグネル★★:祭まであんまり時間ないなあ<br>そろそろ追い込みかけないと…
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_9070007")

	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:ん？ラグネル、お前<br>祭に向けてなんかやるつもりなの？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01104_9070008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:あ、もしかしてアレか？<br>女王…
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01104_9070009")

	change_face(Actor004,"Surprise")

	--★★ラグネル★★:違う違う、違うよガウェイン！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_9070010")

	change_face(Actor004,"Normal")

	--★★ラグネル★★:五月祭の会場で<br>フリーマーケットが開催されるらしくてね
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_9070011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:サークルのみんなで<br>そこになにか出そうって計画してるんだ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_9070012")

	change_face(Actor005,"Laugh")

	--★★ガウェイン★★:サークルってーと、手芸のヤツか<br>へえ～、ちゃんと活動してんだな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01104_9070013")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:五月祭…<br>ついに来てしまうのね…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_9070014")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:選ばれてしまうのね…<br>さらわれてしまうのね、わたし…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_9070015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
