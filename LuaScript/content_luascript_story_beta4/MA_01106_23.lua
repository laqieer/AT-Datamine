-- このluaスクリプトは、MA_01106_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_008)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:だが、ノワールはモルガン救出のため<br>アーサーらと共にカーライル城へ向かう
	Talk(Actor006,"telop","narration","N","MA_01106_231001")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01106_231002")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01106_231003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:おせっかい焼きの姉妹も<br>混ぜてもらえる？
	Talk(Actor006,"telop","narration","N","MA_01106_231004")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:おせっかい焼きの姉妹も<br>混ぜてもらえる？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230002")

	open_select_window_tag(Actor001,"Normal","MA_01106_230004","MA_01106_230005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:頼りにしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_230007")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:モルガン先生がいなくなって<br>悲しまない人は学園にいないわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230008")

	change_face(Actor004,"Normal")

	--★★ギネマウア★★:見逃せませんね<br>王妃としても生徒としても
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","MA_01106_230009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ありがとう、ございます…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_230010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:やめておいたほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_230012")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:いやよ<br>行くったら行くわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230013")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Surprise")

	--★★マルディサント★★:アタシなんかよりずっと心強ぇ…<br>オニーサンの顔の広さには脱帽だな
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01106_230014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:しかもわたしの侍女のサポート付き<br>安心して休んでたっていいわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230015")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:わたしはノワールを自分の家庭事情に巻き込んだ<br>わたしも巻き込まれなきゃ平等じゃないでしょ？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230017")


	--★★ギネヴィア★★:円卓の騎士じゃあないけどね<br>王妃としてその考えはもってるつもり
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230019")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:ありがとう、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_230020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:こちらこそ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01106_230021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
