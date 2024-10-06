-- このluaスクリプトは、EA_006_056.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
hideobj01 = get_object("geo_uv03_obj01_foodA")
set_pos(hideobj01, {0,-20, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:１年前にそんなことがあったんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_006_0560003")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:あの頃はみんな一緒で楽しかったな～♪<br>まさかこんなことになるなんて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:来年また、みんな一緒にお花見できるって<br>当たり前のように思ってた
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560005")


	--★★ガレス★★:当たり前なんて、ないのにな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560006")

-- ▼直接出力
voice_play("VO_101009_sp_0020_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_006_0560007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0015")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:…やめやめ！ウジウジしてもしかたないもんな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:今は円卓の騎士として<br>やるべきことを全力でやらなくちゃ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガレス★★:もう余計なことで気を散らしたりしない<br>――そう、約束したから
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560010")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…そう、だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_006_0560011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
voice_play("VO_101032_sp_0001_1")
-- ▲直接出力

	--★★ガレス★★:そうだ！なぁ、ノワール
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560012")


	--★★ガレス★★:全部落ち着いて平和な日々が戻ってきたら…<br>みんなでお花見に行こう～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560013")


	--★★ガレス★★:ノワールとディナタンとは<br>まだ一緒にお花見できてないもんな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力

	--★★ノワール★★:花見か…いいな。楽しそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_006_0560015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:だよな～♪<br>うん、決まりだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("ガレス","0011")
-- ▲直接出力

	--★★ガレス★★:楽しい予定があると、それだけで<br>なんだか気持ちが明るくなってくるな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560017")


	--★★ガレス★★:しっかりご飯を食べて<br>明日からもまた頑張っていこうな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0560018")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
