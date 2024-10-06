-- このluaスクリプトは、EA_069_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
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
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130003")


	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to Annoyed")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア_007","0044")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:…あー、駄目！なんにも掴めない！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130005")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0053")
-- ▲直接出力

	--★★ギネヴィア★★:どうなってるのよ！？<br>もう4ヶ月も経ってるのに！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130006")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:バイブス学の先生に習えば<br><ruby=ゲシュタルト・シフト>GS</ruby>のコツとか分かるかと思ったのに…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:殿下、落ち着いてください
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0130009")


	--★★ランスロット★★:GSは絆の力<br>そう簡単に為せるものではありません
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0130010")

-- ▼直接出力
setup_small_camera_end(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0017")
-- ▲直接出力

	--★★ランスロット★★:ましてや<br>ひとりで闇雲に鍛錬をしたところで
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0130011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:そんなのわかってるわ<br>授業で習ったし
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130012")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ギネヴィア","0019")
-- ▲直接出力

	--★★ギネヴィア★★:だからって、じゃあわたしはなにもしないで<br>ただボーっと学園生活を送れって？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130013")


	--★★ギネヴィア★★:がんばってわたしの力を示すの。そうすれば<br>誰かがわたしを見つけてくれるかもしれない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130014")


	--★★ギネヴィア★★:そうしたら、GSだって…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130015")


	--★★ランスロット★★:殿下――
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0130016")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ギネヴィア★★:わたしには、力が必要なの<br>立ち止まってらんない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130017")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0042")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:だから先生――ご指導お願いします
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0130018")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
