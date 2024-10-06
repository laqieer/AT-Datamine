-- このluaスクリプトは、MA_01104_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	InitializeTemplateRandomCamera110191_02()
	InitializeTemplate110191_02()
-- ▼直接出力
se_play("SE_ADV_MA_01C111_20_Bell")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.5)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:今日もかわいかったよなぁ<br>俺たちのアイドル！
	Talk(Actor002,"NPCNAME_0151","speech","N","MA_01104_330002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）②★★:療養院の『フェアリー』<br>ディナタンちゃんな！
	Talk(Actor003,"NPCNAME_0153","speech","N","MA_01104_330003")


	--★★キャメロット騎士学術院（男）★★:端麗で、見れば華やぎ、鼓動は高鳴り…<br>すごく身近に感じられるも
	Talk(Actor002,"NPCNAME_0151","speech","N","MA_01104_330004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")

	--★★キャメロット騎士学術院（男）②★★:兄はランスロット先生に喧嘩を売った<br>新人円卓の騎士！
	Talk(Actor003,"NPCNAME_0153","speech","N","MA_01104_330005")

	PlayAction(Actor002,"to  Std_No")

	--★★キャメロット騎士学術院（男）★★:近づくことは許されず決してモノにはならない…
	Talk(Actor002,"NPCNAME_0151","speech","N","MA_01104_330006")

-- ▼直接出力
PlayAction(Actor002,"to  Std_Joy")
PlayAction(Actor003,"to  Std_Joy")
-- ▲直接出力

	--★★男子生徒A＆B★★:これぞアイドル！
	Talk(Actor004,"NPCNAME_0152","speech","N","MA_01104_330007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★マルディサント★★:チッ…なにがフェアリーだよ、バカバカしい
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01104_330009")

	change_face(Actor001,"Normal")

	--★★マルディサント★★:毎日療養院でバタバタ動き回りやがって<br>ロクに昼寝もできやしねえ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01104_330010")

	PlayAction(Actor001,"to  Std_No")

	--★★マルディサント★★:泥臭すぎんだよ<br>フェアリーにしちゃ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01104_330012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
