-- このluaスクリプトは、PT1_01B_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_006)
	InitializeTemplateRandomCamera110191_02()
	InitializeTemplate110191_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "挨拶")
-- ▲直接出力

	--★★真面目な男子生徒★★:僕、ガラハッドさんのこと<br>最初は男性だと思ったんだよね
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_10_0020004")


	--★★真面目な男子生徒★★:全身鎧姿で兜被って<br>顔が見えなかったから
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_10_0020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "否定")
-- ▲直接出力

	--★★気取った男子生徒★★:お前、ホントまだまだだよな～<br>オレは７月に見たときから分かってたぜ
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_10_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★気取った男子生徒★★:守ってあげるべき可憐な女の子だとね！
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_10_0020007")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★真面目な男子生徒★★:そうはいうけど<br>彼女、僕たちより強いんじゃないかな
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_10_0020008")

	PlayAction(Actor002,"to  Std_Surp")

	--★★気取った男子生徒★★:え？
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_10_0020009")

	PlayAction(Actor003,"to  Std_Talk")

	--★★真面目な男子生徒★★:このあいだ響き合う正義のクラスの<br>力自慢の生徒と腕相撲をして
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_10_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★真面目な男子生徒★★:ガラハッドさんは<br>一瞬で勝利したって話だよ
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_10_0020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★気取った男子生徒★★:へ、へえ…なかなかやるじゃないか<br>オレほどでは…ないけどね…ハハ
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_10_0020012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
