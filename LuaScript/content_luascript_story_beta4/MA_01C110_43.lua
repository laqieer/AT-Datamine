-- このluaスクリプトは、MA_01C110_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
se_play("SE_ADV_MA_01C110_43_Bell")
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Anger")
change_face(Actor002,"Anger")
change_face(Actor004,"Anger")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001, "to  Std_Surp")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116027)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
wait_time(2.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:街にバルバロイが入り込んでいる…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_430002")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ランスロット★★:もう何回目になるか<br>先月のほうが回数は多かった
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_430003")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そんな…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_430004")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ギネヴィア★★:アーサーがいなくなってからの１ヶ月<br>しょっちゅうよ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01C110_430005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:夜中だろうとお構いなし<br>まったく気が滅入るったらないわ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01C110_430006")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:なんとか追い返せる程度の奴らばかりだがな<br>…だからこそ、アーサーの思惑がわからない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_430007")

	change_face(Actor004,"Sad")

	--★★ランスロット★★:学園を疲弊させるのが狙いなのか<br>弄んでいるつもりなのか、それとも…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_430008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_430009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:今わかってるのは<br>ここを守らなきゃならないってことだけ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01C110_430010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★ギネヴィア★★:あんなふうにみんなが殺されるのはうんざり
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01C110_430011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ディナタン★★:…そうだね、行こう、兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_430012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_430013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116027)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
MobsNo = 0
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
