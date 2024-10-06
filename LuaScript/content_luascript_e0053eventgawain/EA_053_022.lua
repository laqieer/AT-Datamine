-- このluaスクリプトは、EA_053_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★市民（男）★★:本当にありがとう、ガウェイン<br>助かったよ
	Talk(Actor002,"NPCNAME_0177","speech","L","EA_053_0220004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:いいってことよ<br>あいつらのことはケイに話しておくから
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220005")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:あいつらも警備に追われてピリピリしてるんだ<br>五月祭はログレスの外からも人が集まるからな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220006")


	--★★ガウェイン★★:だから、許してやってよ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0008")
-- ▲直接出力

	--★★市民（男）★★:まぁ、ガウェインがそう言うなら…
	Talk(Actor002,"NPCNAME_0177","speech","L","EA_053_0220008")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0036")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:ありがとな！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★市民（男）★★:そういえば角のばあさんがお前のこと探してたぞ<br>頼みたいことがあるとかなんとか
	Talk(Actor002,"NPCNAME_0177","speech","L","EA_053_0220010")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:ええ！？<br>朝も呼ばれたんだけどなあ…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220011")


	--★★ガウェイン★★:…ハッ！もしかして、<br>ばあちゃんになんかあったのか！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220012")

-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0010")
-- ▲直接出力

	--★★市民（男）★★:ヒーロー暇なし、だな
	Talk(Actor002,"NPCNAME_0177","speech","L","EA_053_0220013")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:だな！行ってくるわ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0220014")


	--★★市民（男）★★:おう、いってらっしゃい！
	Talk(Actor002,"NPCNAME_0177","speech","L","EA_053_0220015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
