-- このluaスクリプトは、PT2_01C_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:あらためてＧＳの達成おめでと、ノワール
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:よくやったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01C_09_0030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:前から仲のいい兄妹だとは思ってたけど<br>まさかＧＳまでしちゃうなんてねぇ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアだってそうじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0030006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:それはそうだけど、ほら<br>ノワールの場合はちょっと特別じゃない？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:なんといっても継承者なわけだし
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ＧＳを果たすことがゴールじゃない<br>むしろここがスタートラインだともいえる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01C_09_0030009")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:ＧＳにおいては、わたしが先輩ってことになるし<br>困ったことがあったらなんでも聞いてよね？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:ガウェインにも<br>同じようなことを言われたな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0030011")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ん？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01C_09_0030012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:こっちのこと、こっちのこと<br>あらためて今後ともよろしく頼む、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ、こちらこそ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01C_09_0030014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
