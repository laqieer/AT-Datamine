-- このluaスクリプトは、MA_01106_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-77,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101160011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Pointing")
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor002,"Smile")
	on_cutin(2,Actor003,"Anger")

	--★★ギネヴィア★★:行けーっ！お姉ちゃん！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01106_120002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:お姉ちゃんにお任せを
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","N","MA_01106_120003")

-- ▼直接出力
se_play("SE_ADV_MA_01106_12_AppleDrop")
wait_time(4.0)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryDataDuelCommonFormation01_01,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_101)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:す、すごいな、ギネマウアさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_120005")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:殿下のためならば
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01106_120006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:姉妹なら それらしくしたっていいのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_120007")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:いいえ。私がこの立場にいることで 殿下の地位を明確するのです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01106_120008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:意外とガンコなの、この人
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:質実剛健と評してくださいませ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01106_120010")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ね ノワールも一緒にどう？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ そのつもりで来た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_120012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ログレスとキャメリアードは友好国だったからね<br>ここのリンゴもわたしの国に入って来てたんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120014")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:おいしくって 思い出しちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:パパの件 どうもありがとう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120017")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★ノワール★★:こっちこそ お礼を言わせてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_120018")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:父さんを信じてみようって<br>思い直した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_120019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…信じるだけなら、タダだもんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01106_120021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101160011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
