-- このluaスクリプトは、MA_01A110_51.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor001, lookWeight,0.5)
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:…楽しかった？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_490008","MA_01A110_490009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:楽しかったよ<br>色んなことを忘れるくらい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_490011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490012")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:こんなふうに友達と学園をまわるなんて<br>半年前は考えられなかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490013")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_490014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あなたは不穏分子<br>わたしは手に余るワガママ女
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490015")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:触れたらタダじゃ済まなさそうな<br>腫れ物扱い同士で…ふたりとも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でもあなたがわたしを大切に扱ってくれたおかげ<br>みごと腫れは引いたわ。良かったネ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490018")

-- ▼直接出力
lookat_delay_weight(Actor002, {0.9, 0, 0.7, 0} , 0.4)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:もう、触れてもだいじょぶだよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490020")

-- ▼直接出力
setup_small_camera_start()
lookat_delay_weight_reset(Actor002 , 0.6)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:すこし疲れたかも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_490022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…あー、ちょっとわかるかも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490023")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:戦い詰めだったもんね<br>気分転換になればと思ったんだけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490024")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…終わっちゃうね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490026")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:また来年があるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_490027")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力

	--★★ギネヴィア★★:…あるのかな？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_490029")

-- ▼直接出力
setup_small_camera_end()
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookWeight = {0.9, 0, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:一緒にいてよ？<br>来年も、その先も、ずっとだよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490030")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:やくそくだよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_490031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
